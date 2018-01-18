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
using EFCFFundamentals.ViewModels;

namespace EFCFFundamentals
{
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
        }

        private void FormSiparis_Load(object sender, EventArgs e)
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

        private void lstTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTedarikci.SelectedItem == null) return;

            var seciliTedarikci = lstTedarikci.SelectedItem as Tedarikci;

            try
            {
                MyContext db = new MyContext();
                var siparisler = db.Siparisler
                    .Where(x => x.TedarikciId == seciliTedarikci.TedarikciId)
                    .OrderByDescending(x => x.SiparisTarihi)
                    .Select(x => new SiparisViewModel()
                    {
                        SiparisNo = x.SiparisId,
                        SiparisTarihi = x.SiparisTarihi,
                        KargoTutari = x.KargoFiyati,
                        TeslimTarihi = x.TeslimTarihi,
                        ToplamSiparisTutari = 0
                    })
                    .ToList();
                lstOrders.Items.Clear();
                foreach (var item in siparisler)
                {
                    item.ToplamSiparisTutari = db.SiparisDetaylar
                        .Where(x => x.SiparisId == item.SiparisNo)
                        .Sum(x => x.Adet * x.Fiyat * (1 - x.Indirim));
                    ListViewItem viewItem = new ListViewItem(item.SiparisNo.ToString("0000"));
                    viewItem.SubItems.Add($"{item.SiparisTarihi:dd MMMM yyyy}");
                    viewItem.SubItems.Add(item.TeslimTarihi != null ? $"{item.TeslimTarihi:dd MMMM yyyy}" : "Daha teslim edilmedi");
                    viewItem.SubItems.Add($"{item.KargoTutari:c2}");
                    viewItem.SubItems.Add($"{item.ToplamSiparisTutari:c2}");
                    lstOrders.Items.Add(viewItem);
                }
                lstOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş bulunamadı!\n" + ex.Message);
            }
        }
    }
}
