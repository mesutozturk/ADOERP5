using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFGiris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "EF CRUD";
            VerileriGetir();
        }
        void VerileriGetir()
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                cmbKategori.DataSource = db.Categories.ToList();
                cmbKategori.DisplayMember = "CategoryName";
                cmbKategori.ValueMember = "CategoryID";

                lstUrun.DataSource = db.Products.OrderBy(x => x.ProductName).ToList();
                lstUrun.DisplayMember = "ProductName";
                lstUrun.ValueMember = "ProductID";

                this.Text += $" Toplam Ürün Sayısı: {db.Products.Count()} Toplam Ürün Maliyeti: {db.Products.Sum(x => x.UnitPrice * x.UnitsInStock):c2} - {DateTime.Now:dd MMMM yy dddd}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;

            var seciliUrun = lstUrun.SelectedItem as Product;
            txtUrunAdi.Text = seciliUrun.ProductName;
            //nFiyat.Value = seciliUrun.UnitPrice.HasValue ? seciliUrun.UnitPrice.Value : 0;
            nFiyat.Value = seciliUrun.UnitPrice ?? 0;
            cbSatistanKaldir.Checked = seciliUrun.Discontinued;

            cmbKategori.SelectedValue = seciliUrun.CategoryID;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                NorthwindEntities context = new NorthwindEntities();
                var seciliKategori = cmbKategori.SelectedItem as Category;
                Product yeni = new Product()
                {
                    ProductName = txtUrunAdi.Text,
                    UnitPrice = nFiyat.Value,
                    Discontinued = cbSatistanKaldir.Checked,
                    CategoryID = seciliKategori?.CategoryID
                };
                context.Products.Add(yeni);
                context.SaveChanges();
                VerileriGetir();
                lstUrun.SelectedValue = yeni.ProductID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Product;

            DialogResult cevap = MessageBox.Show($"{seciliUrun.ProductName} isimli ürünü silmek istiyor musunuz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    NorthwindEntities db = new NorthwindEntities();
                    seciliUrun = db.Products.Find(seciliUrun.ProductID);
                    if (seciliUrun == null)
                    {
                        MessageBox.Show("Silinecek ürün bulunamadı!");
                        VerileriGetir();
                        return;
                    }
                    db.Products.Remove(seciliUrun);
                    db.SaveChanges();
                    VerileriGetir();
                    MessageBox.Show($"{seciliUrun.ProductName} isimli ürün silinmiştir");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{seciliUrun.ProductName} adlı ürün silinememiştir\n " + ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Product;

            try
            {
                NorthwindEntities db = new NorthwindEntities();
                seciliUrun = db.Products.Find(seciliUrun.ProductID);
                if (seciliUrun == null)
                {
                    MessageBox.Show("Güncellenecek ürün bulunamadı!");
                    VerileriGetir();
                    return;
                }
                seciliUrun.ProductName = txtUrunAdi.Text;
                seciliUrun.UnitPrice = nFiyat.Value;
                seciliUrun.CategoryID = Convert.ToInt32(cmbKategori.SelectedValue);
                seciliUrun.Discontinued = cbSatistanKaldir.Checked;
                db.SaveChanges();
                VerileriGetir();
                lstUrun.SelectedValue = seciliUrun.ProductID;
                MessageBox.Show("Ürün güncelleme işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string arama = txtAra.Text.ToLower();

            try
            {
                NorthwindEntities db = new NorthwindEntities();
                var sonuc = db.Products
                    .Where(x => x.ProductName.ToLower().Contains(arama) || x.Category.CategoryName.ToLower().StartsWith(arama))
                    .OrderBy(x => x.ProductName)
                    .ToList();
                lstUrun.DataSource = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
