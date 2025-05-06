using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using AVLTreeInventory;
using DenemeUrunYonetim;
using System.Collections;
using static UrunEnvanterApp.Program;

namespace UrunEnvanterApp
{
    public partial class HızlıEkleme : Form
    {
        

        public HızlıEkleme()
        {
            InitializeComponent();
        }

        private void HızlıEkleme_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Ad");
            dataGridView1.Columns.Add("Price", "Fiyat");
            dataGridView1.Columns.Add("Stock", "Stok");
            dataGridView1.Columns.Add("Category", "Kategori");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan ürün bilgilerini al
                int id = Convert.ToInt32(txtID.Text);
                string name = txtName.Text;
                string category = txtCategory.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int stock = Convert.ToInt32(txtStock.Text);

                // Yeni bir ürün oluştur
                Product newProduct = new Product(id, name, category, price, stock);

                // HashTable'a ekle
                GlobalData.productTable.Add(newProduct);

                // AVL Tree'ye ekle
                GlobalData.avlTree.Insert(newProduct);

                // LinkedList'e ekle
                GlobalData.linkedList.AddProduct(newProduct);

                // Başarı mesajı
                MessageBox.Show("Ürün başarıyla eklendi!");
                txtID.Clear();
                txtName.Clear();
                txtCategory.Clear();
                txtPrice.Clear();
                txtStock.Clear();
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'i temizliyoruz
                dataGridView1.Rows.Clear();

               
                List<Product> allProducts = GlobalData.productTable.GetAllProducts();

                
                foreach (var product in allProducts)
                {
                    dataGridView1.Rows.Add(product.ID, product.Name, product.Price, product.Stock, product.Category);
                }

                MessageBox.Show("Tüm ürünler listeye eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(txtAraID.Text);  // Arama ID'sini alıyoruz

                // Ürünü arıyoruz
                Product foundProduct = GlobalData.productTable.Search(productId);

                // Eğer ürün bulunduysa, DataGridView'e ekleyelim
                if (foundProduct != null)
                {
                    // DataGridView'i temizliyoruz
                    dataGridView1.Rows.Clear();

                    // Bulunan ürünü ekliyoruz
                    dataGridView1.Rows.Add(foundProduct.ID, foundProduct.Name, foundProduct.Category, foundProduct.Price, foundProduct.Stock);
                    txtAraID.Clear();
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan silinecek ürünün ID'sini al
                int urunID = Convert.ToInt32(txtDelete.Text);

                // HashTable'dan sil
                bool isDeletedFromHash = GlobalData.productTable.Delete(urunID);

                // AVL Tree'den sil
                bool isDeletedFromAVL = GlobalData.avlTree.Delete(urunID);

                // LinkedList'ten sil
                bool isDeletedFromList = GlobalData.linkedList.Delete(urunID);

                // Silme işlemi başarılıysa
                if (isDeletedFromHash && isDeletedFromAVL && isDeletedFromList)
                {
                    MessageBox.Show("Ürün başarıyla silindi!");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız. Ürün ID'sini kontrol edin.");
                }
                txtDelete.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalData.productTable.PerformBigDataTest(GlobalData.productTable, 10000); // 10000 ürün verdim örnek olarak
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalData.productTable.PerformSearchTest(GlobalData.productTable, 1000, 10000); // burada 0 ile 10000 arası rasgele id de 1000 tanesini aradık
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalData.productTable.PerformDeleteTest(1000, 10000);
        }
    }
        
}
