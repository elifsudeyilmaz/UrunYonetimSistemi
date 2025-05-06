using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HashTable productTable = new HashTable();
        private void button1_Click(object sender, EventArgs e)
        {
            Products p = new Products
            {
                ID = int.Parse(textBox1.Text),
                Name = textBox2.Text,
                Category = textBox3.Text,
                Price = double.Parse(textBox4.Text),
                Stock = int.Parse(textBox5.Text)
            };
            productTable.Add(p);
            MessageBox.Show("İstediğiniz Ürün eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            bool result = productTable.Delete(id);
            MessageBox.Show(result ? "Silindi" : "Bulunamadı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            Products p = productTable.Search(id);
            if (p != null)
                MessageBox.Show($"Aradığınız Ürün Bulundu.Ürünün Özellikleri: {p.Name} - {p.Category} - {p.Price}£ - {p.Stock}");
            else
                MessageBox.Show("Aradığınız Ürün Bulunamadı.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var list = productTable.GetAllProducts();
            dataGridView1.DataSource = list;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productTable.PerformBigDataTest(productTable, 10000); // 10000 ürün verdim örnek olarak
        }

        private void button7_Click(object sender, EventArgs e)
        {
            productTable.PerformSearchTest(productTable, 1000, 10000); // burada 0 ile 10000 arası rasgele id de 1000 tanesini aradık
        }

        private void button6_Click(object sender, EventArgs e) 
        {
            productTable.PerformDeleteTest(1000, 10000);
        }
    }
}
