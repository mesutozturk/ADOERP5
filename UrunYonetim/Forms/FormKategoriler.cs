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
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
        void VerileriGetir()
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();

                lstKategori.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
                lstKategori.DisplayMember = "CategoryName";
                lstKategori.ValueMember = "CategoryID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;

            var seciliKategori = lstKategori.SelectedItem as Category;
            txtKategoriAdi.Text = seciliKategori.CategoryName;
            txtAciklama.Text = seciliKategori.Description;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                Category cat = new Category
                {
                    CategoryName = txtKategoriAdi.Text,
                    Description = txtAciklama.Text
                };
                db.Categories.Add(cat);
                db.SaveChanges();
                VerileriGetir();
                lstKategori.SelectedValue = cat.CategoryID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
