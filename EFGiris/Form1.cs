using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //NorthwindEntities db = new NorthwindEntities();
            //List<Product> urunler = db.Products
            //    .Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50)
            //    .OrderByDescending(x => x.UnitPrice)
            //    .ThenBy(x => x.ProductName)
            //    .ToList();
            //dgvUrunler.DataSource = urunler;
            //this.Text = $"Toplam Ürün Fiyatı: {db.Products.Sum(x=>x.UnitPrice):c2}";
            KategorileriDoldur();
        }

        void KategorileriDoldur()
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                List<Category> kategoriList = db.Categories.OrderBy(x => x.CategoryName).ToList();
                lstKategori.DataSource = kategoriList;
                lstKategori.DisplayMember = "CategoryName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;

            Category seciliKategori = lstKategori.SelectedItem as Category;
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                //List<Product> urunler = db.Products.Where(x => x.CategoryID == seciliKategori.CategoryID).ToList();
                var urunler = db.Categories
                    .Find(seciliKategori.CategoryID)?
                    .Products
                    .Select(x => new ProductViewModel()
                    {
                        ProductID = x.ProductID,
                        Discontinued = x.Discontinued,
                        ProductName = x.ProductName,
                        ReorderLevel = x.ReorderLevel,
                        UnitPrice = x.UnitPrice,
                        UnitsInStock = x.UnitsInStock,
                        UnitsOnOrder = x.UnitsOnOrder,
                        CategoryName = x.Category.CategoryName
                    })
                    .ToList(); // find p.k ile arama yapar

                var urunler2 = from cat in db.Categories
                               join prod in db.Products on cat.CategoryID equals prod.CategoryID
                               where prod.CategoryID == seciliKategori.CategoryID
                               orderby prod.ProductName ascending
                               select new ProductViewModel
                               {
                                   ProductID = prod.ProductID,
                                   Discontinued = prod.Discontinued,
                                   ProductName = prod.ProductName,
                                   ReorderLevel = prod.ReorderLevel,
                                   UnitPrice = prod.UnitPrice,
                                   UnitsInStock = prod.UnitsInStock,
                                   UnitsOnOrder = prod.UnitsOnOrder,
                                   CategoryName = cat.CategoryName
                               };
                
                if (urunler != null && urunler.Count > 0)
                    dgvUrunler.DataSource = urunler2.ToList();
                else
                    MessageBox.Show($"{seciliKategori.CategoryName}'in ürünü yok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Product pro = null;
            //pro.ProductName = "kamil";
        }
    }
}
