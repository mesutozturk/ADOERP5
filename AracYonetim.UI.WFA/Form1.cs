using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracYonetim.BLL.Repository;
using AracYonetim.Entities.Enums;
using AracYonetim.Entities.Models;

namespace AracYonetim.UI.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVitesTipi.DataSource = Enum.GetNames(typeof(VitesTipleri));
            cmbYakitTipi.DataSource = Enum.GetNames(typeof(YakitTipleri));
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            try
            {
                lstMarkalar.DataSource = new MarkaRepo().GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] resimDosyasi;
        private void pbMarkaLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog
            {
                Title = "Bir resim dosyası seçiniz",
                Multiselect = false,
                Filter = "JPG Formatı (*.jpg) | *.jpg; *.jpeg; | PNG Formatı | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memoryStream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(buffer, 0, 64) != 0)
                {
                    memoryStream.Write(buffer, 0, 64);
                }
                resimDosyasi = memoryStream.ToArray();
                pbMarkaLogo.Image = new Bitmap(memoryStream);
            }
        }

        private void btnMarkaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniMarka = new Marka()
                {
                    MarkaAdi = txtMarkaAdi.Text,
                    Kurucusu = txtKurucu.Text,
                    Ulke = txtUlke.Text,
                    KurulusYili = int.Parse(txtKurulusYili.Text),
                    Logo = resimDosyasi
                };
                new MarkaRepo().Insert(yeniMarka);
                resimDosyasi = null;
                pbMarkaLogo.Image = null;
                VerileriGetir();
                MessageBox.Show($"{yeniMarka.MarkaAdi} markası başarıyla eklenmiştir");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarkalar.SelectedItem is Marka seciliMarka)
            {
                txtMarkaAdi.Text = seciliMarka.MarkaAdi;
                txtKurucu.Text = seciliMarka.Kurucusu;
                txtKurulusYili.Text = seciliMarka.KurulusYili.ToString();
                txtUlke.Text = seciliMarka.Ulke;
                if (seciliMarka.Logo != null)
                {
                    try
                    {
                        pbMarkaLogo.Image = new Bitmap(new MemoryStream(seciliMarka.Logo));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    pbMarkaLogo.Image = null;

                lstAraclar.DataSource = new MarkaRepo().GetById(seciliMarka.Id)?.Araclar;
            }
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            if (lstMarkalar.SelectedItem is Marka seciliMarka)
            {
                try
                {
                    var yeniArac = new Arac()
                    {
                        MarkaId = seciliMarka.Id,
                        Model = txtModel.Text,
                        UretimYili = int.Parse(txtUretimYili.Text),
                        VitesTipi = (VitesTipleri)Enum.Parse(typeof(VitesTipleri), cmbVitesTipi.SelectedItem.ToString()),
                        YakitTipi = (YakitTipleri)Enum.Parse(typeof(YakitTipleri), cmbYakitTipi.SelectedItem.ToString()),
                        Fotograf = resimDosyasi
                    };
                    new AracRepo().Insert(yeniArac);
                    VerileriGetir();
                    pbAracResim.Image = null;
                    resimDosyasi = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pbAracResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog
            {
                Title = "Bir resim dosyası seçiniz",
                Multiselect = false,
                Filter = "JPG Formatı (*.jpg) | *.jpg; *.jpeg; | PNG Formatı | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memoryStream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(buffer, 0, 64) != 0)
                {
                    memoryStream.Write(buffer, 0, 64);
                }
                resimDosyasi = memoryStream.ToArray();
                pbAracResim.Image = new Bitmap(memoryStream);
            }
        }

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem is Arac seciliArac)
            {
                txtModel.Text = seciliArac.Model;
                txtUretimYili.Text = seciliArac.UretimYili.ToString();
                cmbVitesTipi.SelectedIndex = (short) seciliArac.VitesTipi;
                cmbYakitTipi.SelectedIndex = (short)seciliArac.YakitTipi;
                if (seciliArac.Fotograf != null)
                {
                    try
                    {
                        pbAracResim.Image = new Bitmap(new MemoryStream(seciliArac.Fotograf));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    pbAracResim.Image = null;
            }
        }
    }
}
