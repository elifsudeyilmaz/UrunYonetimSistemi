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
using static UrunEnvanterApp.Program;
using System.Diagnostics;

namespace UrunEnvanterApp
{
    public partial class Form1 : Form
    {
        //AVL ağacı ile Sıralı olarak sıralama ve isim ile arama
      
        

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
                var result = GlobalData.avlTree.SearchByName(productName);
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
            var products = GlobalData.avlTree.InOrderToList();

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
        }

        private string seciliUrunAdi = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["Name"].Value != null)
            {
                seciliUrunAdi = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seciliUrunAdi))
            {
                MessageBox.Show("Lütfen önce bir ürün seçin.");
                return;
            }

            if (double.TryParse(txtYeniFiyat.Text, out double yeniFiyat))
            {
                bool sonuc = GlobalData.avlTree.UpdatePriceByName(seciliUrunAdi, yeniFiyat);
                if (sonuc)
                {
                    MessageBox.Show("Fiyat başarıyla güncellendi.");
                    // Güncellenmiş ürünü yeniden göster
                    var updated = GlobalData.avlTree.SearchByName(seciliUrunAdi);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(updated.ID, updated.Name, updated.Price);
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
            }
        }
    }
}
