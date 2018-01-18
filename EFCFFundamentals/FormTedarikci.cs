using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCFFundamentals.DAL;
using EFCFFundamentals.Entities;

namespace EFCFFundamentals
{
    public partial class FormTedarikci : Form
    {
        public FormTedarikci()
        {
            InitializeComponent();
        }

        private void FormTedarikci_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();
                lstTedarikci.DataSource = db.Tedarikciler.ToList();
                lstTedarikci.DisplayMember = "FirmaAdi";
                lstTedarikci.ValueMember = "TedarikciId";
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
                Tedarikci tedarikci = new Tedarikci()
                {
                    FirmaAdi = txtFirmaAdi.Text,
                    Telefon = txtTelefon.Text
                };
                MyContext db = new MyContext();
                db.Tedarikciler.Add(tedarikci);
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSiparisOlustur siparisForm = new FormSiparisOlustur { Text = "Sipariş Oluştur" };
            siparisForm.ShowDialog();
        }
    }
}
