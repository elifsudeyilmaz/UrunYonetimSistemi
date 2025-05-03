using AVLTreeInventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVLTreeInventory;
using System.Collections;
using System.Xml.Linq;

namespace UrunEnvanterApp
{
    public partial class Form1 : Form
    {
        //AVL ağacı ile Sıralı olarak sıralama ve isim ile arama
        AVLTree avlTree = new AVLTree(); 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string productName = txtAra.Text.Trim();
            if (!string.IsNullOrEmpty(productName))
            {
                var result = avlTree.SearchByName(productName);
                if (result != null)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(result.ID, result.Name, result.Price);
                    
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir ürün adı giriniz.");
            }
        }

        private void brnListeleAvl_Click(object sender, EventArgs e)
        {
            var products = avlTree.InOrderToList();

            dataGridView1.Rows.Clear();

            foreach (var p in products)
            {
                dataGridView1.Rows.Add(p.ID, p.Name, p.Price);
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Ürün Adı");
            dataGridView1.Columns.Add("Price", "Fiyat");

            avlTree.Insert(new Product { ID = 1001, Name = "Laptop", Price = 5000, Stock = 20, Category = "Elektronik" });
            avlTree.Insert(new Product { ID = 1002, Name = "Telefon", Price = 3000, Stock = 30, Category = "Elektronik" });
            avlTree.Insert(new Product { ID = 1003, Name = "Bardak", Price = 15, Stock = 100, Category = "Ev Eşyası" });
            avlTree.Insert(new Product { ID = 1004, Name = "Çikolata", Price = 25, Stock = 50, Category = "Gıda" });
        }
    }
}
