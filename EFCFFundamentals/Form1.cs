using EFCFFundamentals.DAL;
using EFCFFundamentals.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCFFundamentals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
        void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();
                lstKategori.DataSource = db.Kategoriler.ToList();
                lstKategori.DisplayMember = "KategoriAdi";
                lstKategori.ValueMember = "KategoriID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklama = txtAciklama.Text
                };
                MyContext db = new MyContext();
                db.Kategoriler.Add(kategori);
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            var seciliKategori = lstKategori.SelectedItem as Kategori;
            txtKategoriAdi.Text = seciliKategori.KategoriAdi;
            txtAciklama.Text = seciliKategori.Aciklama;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            var seciliKategori = lstKategori.SelectedItem as Kategori;
            var cevap = MessageBox.Show($"{seciliKategori.KategoriAdi} isimli kategoriyi silmek istiyor musunuz?", "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;
            try
            {
                MyContext db = new MyContext();
                seciliKategori = db.Kategoriler.Find(seciliKategori.KategoriId);
                if (seciliKategori == null)
                {
                    MessageBox.Show("Kategori Bulunamadı");
                    VerileriGetir();
                    return;
                }
                if (seciliKategori.Urunler.Any())
                {
                    MessageBox.Show($"Bu kategorinin {seciliKategori.Urunler.Count} adet ürünü bulunduğundan silemezsiniz!");
                    return;
                }
                db.Kategoriler.Remove(seciliKategori);
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            var seciliKategori = lstKategori.SelectedItem as Kategori;
            try
            {
                MyContext db = new MyContext();
                seciliKategori = db.Kategoriler.Find(seciliKategori.KategoriId);
                if (seciliKategori == null)
                {
                    MessageBox.Show("Kategori Bulunamadı");
                    VerileriGetir();
                    return;
                }
                seciliKategori.KategoriAdi = txtKategoriAdi.Text;
                seciliKategori.Aciklama = txtAciklama.Text;
                db.SaveChanges();
                VerileriGetir();
                lstKategori.SelectedValue = seciliKategori.KategoriId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            try
            {
                MyContext db = new MyContext();
                lstKategori.DataSource = db.Kategoriler
                    .Where(x => x.KategoriAdi.ToLower().Contains(ara) || x.Aciklama.ToLower().Contains(ara))
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FormUrunler urunlerForm = new FormUrunler
            {
                Text = "Ürünler"
            };
            urunlerForm.ShowDialog();
        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            FormTedarikci tedarikciForm = new FormTedarikci()
            {
                Text = "Tedarikçiler"
            };
            tedarikciForm.ShowDialog();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            FormSiparis siparisForm = new FormSiparis()
            {
                Text = "Siparişler"
            };
            siparisForm.ShowDialog();
        }
    }
}
