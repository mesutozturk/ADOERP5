using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void Form2_Load(object sender, EventArgs e)
        {
            Verigetir1();
        }
        List<OverSalesViewModel> model = new List<OverSalesViewModel>();
        void Verigetir1()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from oversalesavarage";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                model = new List<OverSalesViewModel>();
                while (dataReader.Read())
                {
                    model.Add(new OverSalesViewModel
                    {
                        OrderID = (int)dataReader["OrderID"],
                        Total = (decimal)(double)dataReader["Total"]
                    });
                }
                dgv.DataSource = model;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class OverSalesViewModel
    {
        public int OrderID { get; set; }
        public decimal Total { get; set; }
    }
}
