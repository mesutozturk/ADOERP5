using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFManytoMany.DAL;
using EFManytoMany.Entities;

namespace EFManytoMany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = Enum.GetNames(typeof(Cinsiyetler));
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();
                lstOgrenci.DataSource = db.Ogrenciler.ToList();
                lstDersler.DataSource = db.Dersler.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                db.Ogrenciler.Add(new Ogrenci
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString())
                });
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOgrenci.SelectedItem == null) return;

            var seciliOgrenci = lstOgrenci.SelectedItem as Ogrenci;
            txtAd.Text = seciliOgrenci.Ad;
            txtSoyad.Text = seciliOgrenci.Soyad;
            dtpDogumTarihi.Value = seciliOgrenci.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (byte)seciliOgrenci.Cinsiyet;
            OgrenciDersleriDoldur(seciliOgrenci.Id);
        }

        private void OgrenciDersleriDoldur(int ogrenciId)
        {
            try
            {
                MyContext db = new MyContext();
                clstOgrenciDersleri.Items.Clear();
                db.Dersler.ToList().ForEach(x => clstOgrenciDersleri.Items.Add(x));
                var ogrenci = db.Ogrenciler.Find(ogrenciId);
                lblToplamKredi.Text = $"Toplam kredi: {ogrenci.Dersler.Sum(x => x.Kredi)}";
                if (!ogrenci.Dersler.Any()) return;

                foreach (var ogrDers in ogrenci.Dersler)
                {
                    for (int i = 0; i < clstOgrenciDersleri.Items.Count; i++)
                    {
                        var ders = clstOgrenciDersleri.Items[i] as Ders;
                        if (ders?.Id == ogrDers.Id)
                            clstOgrenciDersleri.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                db.Dersler.Add(new Ders()
                {
                    DersAdi = txtDersAdi.Text,
                    Kredi = Convert.ToInt32(nKredi.Value)
                });
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDersler.SelectedItem == null) return;
            var seciliDers = lstDersler.SelectedItem as Ders;
            txtDersAdi.Text = seciliDers.DersAdi;
            nKredi.Value = seciliDers.Kredi;
        }

        private void clstOgrenciDersleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Ders item in clstOgrenciDersleri.CheckedItems)
            {
                total += item.Kredi;
            }
            lblToplamKredi.Text = $"Toplam kredi: {total}";
        }

        private void btnDersOnayla_Click(object sender, EventArgs e)
        {
            if (lstOgrenci.SelectedItem == null)
            {
                MessageBox.Show("Önce öğrenciyi seçiniz");
                return;
            }
            var ogrenciId = ((Ogrenci)lstOgrenci.SelectedItem).Id;

            if (clstOgrenciDersleri.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bu işlemi yapabilmek için öncelikle ders seçmelisiniz");
                return;
            }
            try
            {
                var db = new MyContext();
                var secilenDersler = new List<Ders>();
                var ogrenci = db.Ogrenciler.Find(ogrenciId);
                var mevcutDersler = ogrenci?.Dersler ?? new List<Ders>();
                foreach (Ders item in clstOgrenciDersleri.CheckedItems)
                {
                    secilenDersler.Add(item);
                }

                foreach (Ders secilenDers in secilenDersler)
                {
                    if (mevcutDersler.All(x => x.Id != secilenDers.Id))
                    {
                        //ekleme
                        var eklenecek = db.Dersler.Find(secilenDers.Id);
                        mevcutDersler.Add(eklenecek);
                    }
                }
                var silinecekDersler = new List<Ders>();
                foreach (Ders mevcutDers in mevcutDersler)
                {
                    if (secilenDersler.All(x => x.Id != mevcutDers.Id))
                    {
                        //delete
                        var silinecek = db.Dersler.Find(mevcutDers.Id);
                        silinecekDersler.Add(silinecek);
                    }
                }
                silinecekDersler.ForEach(x => mevcutDersler.Remove(x));
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
