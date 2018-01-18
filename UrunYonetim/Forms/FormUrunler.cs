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

namespace UrunYonetim.Forms
{
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
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

                cmbTedarikci.DataSource = db.Suppliers.ToList();
                cmbTedarikci.DisplayMember = "CompanyName";
                cmbTedarikci.ValueMember = "SupplierID";

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
            nFiyat.Value = seciliUrun.UnitPrice ?? 0;
            cbSatistanKaldir.Checked = seciliUrun.Discontinued;
            cmbTedarikci.SelectedValue = seciliUrun.SupplierID ?? 0;
            nStok.Value = seciliUrun.UnitsInStock ?? 0;
            cmbKategori.SelectedValue = seciliUrun.CategoryID ?? 0;
        }
    }
}
