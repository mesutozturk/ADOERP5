using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetim.Dialogs;
using UrunYonetim.Models;
using UrunYonetim.ViewModels;

namespace UrunYonetim.Forms
{
    public partial class FormSiparisOlustur : Form
    {
        public FormSiparisOlustur()
        {
            InitializeComponent();
            arttırToolStripMenuItem.Click += SepetYonetimi;
            azaltToolStripMenuItem.Click += SepetYonetimi;
            çıkartToolStripMenuItem.Click += SepetYonetimi;
            adetiGüncelleToolStripMenuItem.Click += SepetYonetimi;
        }

        private void SepetYonetimi(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;
            var seciliUrun = lstSepet.SelectedItem as SepetViewModel;

            var menuItem = sender as ToolStripMenuItem;
            if (menuItem.Name == "azaltToolStripMenuItem")
            {
                if (seciliUrun.Quantity >= 2)
                    seciliUrun.Quantity--;
                else if (seciliUrun.Quantity == 1)
                    sepetList.Remove(seciliUrun);
            }
            else if (menuItem.Name == "arttırToolStripMenuItem")
            {
                var urun = urunList.Where(x => x.ProductID == seciliUrun.ProductID).FirstOrDefault();
                if (!StokKontrol(urun))
                {
                    MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                    return;
                }
                seciliUrun.Quantity++;
            }

            else if (menuItem.Name == "çıkartToolStripMenuItem")
                sepetList.Remove(seciliUrun);
            else if (menuItem.Name == "adetiGüncelleToolStripMenuItem")
            {
                DialogAdetGuncelle dialogAdetGuncelle = new DialogAdetGuncelle();
                dialogAdetGuncelle.nDeger.Value = seciliUrun.Quantity;
                dialogAdetGuncelle.StartPosition = FormStartPosition.CenterParent;
                dialogAdetGuncelle.ShowDialog();
                short deger = Convert.ToInt16(dialogAdetGuncelle.nDeger.Value);
                if (deger > 0)
                {
                    var urun = urunList.Where(x => x.ProductID == seciliUrun.ProductID).FirstOrDefault();
                    if (!StokKontrol(urun, deger))
                    {
                        MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                        return;
                    }
                    seciliUrun.Quantity = deger;
                }
                else
                    sepetList.Remove(seciliUrun);
            }
            SepetGuncelle();
        }

        List<UrunViewModel> urunList = new List<UrunViewModel>();
        List<SepetViewModel> sepetList = new List<SepetViewModel>();
        private void FormSiparisOlustur_Load(object sender, EventArgs e)
        {
            VerileriGetir();
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                cmbCalisan.DataSource = db.Employees.Select(x => new EmployeeViewModel()
                {
                    EmployeeID = x.EmployeeID,
                    FullName = x.FirstName + " " + x.LastName,
                    Title = x.Title
                }).ToList();

                cmbKargo.DataSource = db.Shippers.ToList();
                cmbKargo.DisplayMember = "CompanyName";
                cmbKargo.ValueMember = "ShipperID";

                cmbMusteri.DataSource = db.Customers.ToList();
                cmbMusteri.DisplayMember = "CompanyName";
                cmbMusteri.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message);
            }
        }
        void VerileriGetir(string arama = "")
        {
            try
            {
                var ara = arama.ToLower();
                NorthwindEntities db = new NorthwindEntities();
                var sonuc = from prod in db.Products
                                //join cat in db.Categories on prod.CategoryID equals cat.CategoryID
                            where prod.Discontinued == false && (prod.ProductName.ToLower().Contains(ara) || prod.Category.CategoryName.Contains(ara))
                            orderby prod.ProductName ascending
                            select new UrunViewModel
                            {
                                ProductID = prod.ProductID,
                                ProductName = prod.ProductName,
                                UnitPrice = prod.UnitPrice,
                                UnitsInStock = prod.UnitsInStock,
                                CategoryName = prod.Category.CategoryName
                            };
                lstUrun.DataSource = sonuc.ToList();
                urunList = sonuc.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            VerileriGetir(txtAra.Text);
        }

        bool StokKontrol(UrunViewModel seciliUrun, short adet = 1)
        {
            bool varmi = false, cevap = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == seciliUrun.ProductID)
                {
                    varmi = true;
                    if (adet == 1)
                    {
                        if (seciliUrun.UnitsInStock > x.Quantity)
                            cevap = true;
                        else
                            cevap = false;
                    }
                    else if (adet > 1)
                    {
                        if (seciliUrun.UnitsInStock >= adet)
                            cevap = true;
                        else
                            cevap = false;
                    }

                }
            });

            if (!varmi)
            {
                if (seciliUrun.UnitsInStock > 0)
                    cevap = true;
                else
                    cevap = false;
            }
            return cevap;
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as UrunViewModel;
            bool kontrol = StokKontrol(seciliUrun);
            if (!kontrol)
            {
                MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                return;
            }
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == seciliUrun.ProductID)
                {
                    varmi = true;
                    x.Quantity++;
                }
            });
            if (!varmi)
            {
                var model = new SepetViewModel()
                {
                    ProductID = seciliUrun.ProductID,
                    Discount = float.Parse(nIndirim.Value.ToString()),
                    ProductName = seciliUrun.ProductName,
                    UnitPrice = seciliUrun.UnitPrice ?? 0
                };
                sepetList.Add(model);
            }
            SepetGuncelle();
        }
        void SepetGuncelle()
        {
            lstSepet.Items.Clear();
            sepetList.ForEach(x => lstSepet.Items.Add(x));
            SepetHesapla();
        }
        void SepetHesapla()
        {
            decimal toplam = 0, kdv = 0;
            toplam = sepetList.Sum(x => x.Total);
            kdv = toplam * 0.18m;
            nToplam.Value = toplam;
            nKdv.Value = kdv;
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (sepetList.Count == 0)
            {
                MessageBox.Show("Önce Sepete Ürün Eklemelisiniz");
                return;
            }
            var musteri = cmbMusteri.SelectedItem as Customer;
            var kargo = cmbKargo.SelectedItem as Shipper;
            var calisan = cmbCalisan.SelectedItem as EmployeeViewModel;

            string mesaj = $"{ nToplam.Value + nKargoFiyat.Value:c2} tutarındaki siparişi onaylıyor musunuz?\nMüşteri: {musteri.CompanyName}, Kargo: {kargo.CompanyName}";

            var cevap = MessageBox.Show(mesaj, "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            NorthwindEntities db = new NorthwindEntities();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniSiparis = new Order()
                    {
                        EmployeeID = calisan.EmployeeID,
                        CustomerID = musteri.CustomerID,
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(7),
                        Freight = nKargoFiyat.Value,
                        ShipVia = kargo.ShipperID,
                    };
                    db.Orders.Add(yeniSiparis);
                    db.SaveChanges();

                    foreach (var item in sepetList)
                    {
                        var siparisDetay = new Order_Detail()
                        {
                            OrderID = yeniSiparis.OrderID,
                            ProductID = item.ProductID,
                            UnitPrice = item.UnitPrice,
                            Quantity = item.Quantity,
                            Discount = item.Discount
                        };
                        if (item.ProductID == 2) // bilerek hata verdirmek istiyoruz rollbacki görmek için
                            throw new Exception("Manuel hata");
                        db.Order_Details.Add(siparisDetay);

                        var urun = db.Products.Find(item.ProductID);
                        urun.UnitsInStock -= item.Quantity;
                    }
                    db.SaveChanges();

                    tran.Commit();
                    MessageBox.Show($"{yeniSiparis.OrderID}'nolu siparişiniz tarafımıza ulaşmıştır");
                    Temizle();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Sipariş Oluşturma işleminde hata oluştu.\n" + ex.Message);
                }
            }
        }
        void Temizle()
        {
            sepetList = new List<SepetViewModel>();
            lstSepet.Items.Clear();
            VerileriGetir();
        }
    }
}
