using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetim.Models;
using UrunYonetim.ViewModels;

namespace UrunYonetim.Forms
{
    public partial class FormMusteriSiparisler : Form
    {
        public FormMusteriSiparisler()
        {
            InitializeComponent();
        }

        private void FormMusteriSiparisler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
        void VerileriGetir()
        {
            NorthwindEntities db = new NorthwindEntities();
            lstCustomer.DataSource = db.Customers.OrderBy(x => x.CompanyName).ToList();
            lstCustomer.DisplayMember = "CompanyName";
            lstCustomer.ValueMember = "CustomerID";
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedItem == null) return;

            var seciliMusteri = lstCustomer.SelectedItem as Customer;
            try
            {
                NorthwindEntities db = new NorthwindEntities();

                var sonuc = db.Orders
                    .Where(x => x.CustomerID == seciliMusteri.CustomerID)
                    .OrderByDescending(x => x.OrderDate)
                    .Select(x => new SiparisViewModel()
                    {
                        IstenenTarih = x.RequiredDate,
                        KargoFirmasi = x.Shipper.CompanyName,
                        KargoTutari = x.Freight ?? 0,
                        SiparisNo = x.OrderID,
                        SiparisTarihi = x.OrderDate,
                        Ulke = x.ShipCountry,
                        ToplamSiparisTutari = 0
                    })
                    .ToList();
                lstOrders.Items.Clear();
                sonuc.ForEach(x =>
                {
                    x.ToplamSiparisTutari = db.Order_Details
                    .Where(y => y.OrderID == x.SiparisNo)
                    .Sum(y => y.UnitPrice * y.Quantity);
                    ListViewItem viewItem = new ListViewItem(x.SiparisNo.ToString());
                    viewItem.SubItems.Add($"{x.SiparisTarihi:dd MMMM yyyy}");
                    viewItem.SubItems.Add($"{x.IstenenTarih:dd MMMM yyyy}");
                    viewItem.SubItems.Add(x.Ulke);
                    viewItem.SubItems.Add($"{x.KargoTutari:c2}");
                    viewItem.SubItems.Add($"{x.ToplamSiparisTutari:c2}");
                    viewItem.SubItems.Add(x.KargoFirmasi);
                    lstOrders.Items.Add(viewItem);
                }
                );
                lstOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş bulunamadı");
                MessageBox.Show(ex.Message);
            }
        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItems == null || lstOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bir şey seçmediniz");
                return;
            }
            try
            {
                var siparisId = int.Parse(lstOrders.SelectedItems[0].Text);
                NorthwindEntities db = new NorthwindEntities();
                var sonuc = db.Order_Details.Where(x => x.OrderID == siparisId).ToList();
                List<ListViewItem> viewItemList = new List<ListViewItem>();
                sonuc.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.Product.ProductName);
                    viewItem.SubItems.Add($"{x.UnitPrice:c2}");
                    viewItem.SubItems.Add($"{x.Quantity}");
                    viewItem.SubItems.Add($"% {x.Discount * 100}");
                    viewItemList.Add(viewItem);
                });

                FormMusteriSiparisDetay musteriSiparisDetay = new FormMusteriSiparisDetay(viewItemList);
                musteriSiparisDetay.Text = $"{siparisId} nolu siparişin detayı";
                musteriSiparisDetay.StartPosition = FormStartPosition.CenterParent;
                musteriSiparisDetay.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
