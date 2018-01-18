using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetim.Forms;
using UrunYonetim.Models;

namespace UrunYonetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ürün Yönetimi";
        }
        FormUrunler urunlerForm;
        FormKategoriler kategorilerForm;
        FormMusteriler musterilerForm;
        FormMusteriSiparisler musteriSiparislerForm;
        FormSiparisOlustur siparisOlusturForm;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunlerForm == null || urunlerForm.IsDisposed)
            {
                urunlerForm = new FormUrunler();
                urunlerForm.MdiParent = this;
                urunlerForm.WindowState = FormWindowState.Maximized;
                urunlerForm.Text = "Ürünler";
                urunlerForm.Show();
            }
        }
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kategorilerForm == null || kategorilerForm.IsDisposed)
            {
                kategorilerForm = new FormKategoriler();
                kategorilerForm.MdiParent = this;
                kategorilerForm.WindowState = FormWindowState.Maximized;
                kategorilerForm.Text = "Kategoriler";
                kategorilerForm.Show();
            }
        }
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musterilerForm == null || musterilerForm.IsDisposed)
            {
                musterilerForm = new FormMusteriler();
                musterilerForm.MdiParent = this;
                musterilerForm.WindowState = FormWindowState.Maximized;
                musterilerForm.Text = "Müşteriler";
                musterilerForm.Show();
            }
        }

        private void müşteriSiparişleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musteriSiparislerForm == null || musteriSiparislerForm.IsDisposed)
            {
                musteriSiparislerForm = new FormMusteriSiparisler();
                musteriSiparislerForm.MdiParent = this;
                musteriSiparislerForm.WindowState = FormWindowState.Maximized;
                musteriSiparislerForm.Text = "Müşteri Siparişler";
                musteriSiparislerForm.Show();
            }
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siparisOlusturForm == null || siparisOlusturForm.IsDisposed)
            {
                siparisOlusturForm = new FormSiparisOlustur();
                siparisOlusturForm.MdiParent = this;
                siparisOlusturForm.WindowState = FormWindowState.Maximized;
                siparisOlusturForm.Text = "Sipariş Oluştur";
                siparisOlusturForm.Show();
            }
        }
    }
}
