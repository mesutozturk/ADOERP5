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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }

        private void FormMusteriler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
        void VerileriGetir()
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();

                lstCustomer.DataSource = db.Customers.OrderBy(x => x.CustomerID).ToList();
                lstCustomer.DisplayMember = "CompanyName";
                lstCustomer.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedItem == null) return;

            var seciliMusteri = lstCustomer.SelectedItem as Customer;
            txtCity.Text = seciliMusteri.City;
            txtCompanyName.Text = seciliMusteri.CompanyName;
            txtContactName.Text = seciliMusteri.ContactName;
            txtContactTitle.Text = seciliMusteri.ContactTitle;
            txtAddress.Text = seciliMusteri.Address;
            txtRegion.Text = seciliMusteri.Region;
            txtPostalCode.Text = seciliMusteri.PostalCode;
            txtCountry.Text = seciliMusteri.Country;
            txtPhone.Text = seciliMusteri.Phone;
            txtFax.Text = seciliMusteri.Fax;
            txtCustomerID.Text = seciliMusteri.CustomerID;
        }
    }
}
