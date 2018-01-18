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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ProductViewModel> productList = new List<ProductViewModel>();

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            //mesut.ozturk@wissenakademie.com
            int a = 5;
            short b = 5;
            long c = 555555555555L;

            double d = 3.14d;
            float f = 3.14f;
            decimal ee = 3.14m;

            long adres = 0xca4f5d;
            int binary = 0b1010101110100101;

            //MessageBox.Show("binary" + (10 / 3));

        }

        private void UrunleriGetir(string sorgu = "")
        {
            productList = new List<ProductViewModel>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "";
            if (string.IsNullOrEmpty(sorgu))
                query = "SELECT	ProductID,ProductName,CategoryName,UnitPrice,UnitsInStock,Discontinued FROM dbo.Products p JOIN dbo.Categories c ON c.CategoryID=p.CategoryID";
            else
                query = sorgu;

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    productList.Add(new ProductViewModel()
                    {
                        CategoryName = dataReader.GetString(2),
                        ProductID = (int)dataReader[0],
                        ProductName = dataReader["ProductName"].ToString(),
                        UnitPrice = (decimal)dataReader["UnitPrice"],
                        UnitsInStock = (short)dataReader["UnitsInStock"],
                        Discontinued = (bool)dataReader["Discontinued"],
                    });
                }
                this.Text = $"Toplam {productList.Count} adet ürün okundu";
                dgUrunler.DataSource = productList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;
            int kategoriId = int.Parse(txtKategoriId.Text);
            decimal fiyat = nFiyat.Value;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"insert into Products(ProductName,CategoryId,UnitPrice,UnitsInStock) values(@urunadi,@kategoriid,@fiyat,0)";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@urunadi", urunAdi);
            cmd.Parameters.AddWithValue("@kategoriid", kategoriId);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                int satir = cmd.ExecuteNonQuery();
                MessageBox.Show($"Toplam {satir} adet kayıt girildi");
                UrunleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string arama = txtAra.Text;
            //string query = "SELECT	ProductID,ProductName,CategoryName,UnitPrice,UnitsInStock,Discontinued FROM dbo.Products p JOIN dbo.Categories c ON c.CategoryID=p.CategoryID  where Productname LIKE  '%" + arama + "%'";
            SqlCommand query = new SqlCommand("SELECT	ProductID,ProductName,CategoryName,UnitPrice,UnitsInStock,Discontinued FROM dbo.Products p JOIN dbo.Categories c ON c.CategoryID=p.CategoryID  where Productname LIKE  '%'+@arama+'%'");
            query.Parameters.AddWithValue("@arama", arama);

            //UrunleriGetir(query);
        }
    }
}

//a'; update products set unitprice=0.01;--  