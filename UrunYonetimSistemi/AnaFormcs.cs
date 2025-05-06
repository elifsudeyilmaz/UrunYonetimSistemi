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
using static UrunEnvanterApp.Program;
using WindowsFormsApp1;
using DenemeUrunYonetim;
using UrunEnvanterApp;

namespace UrunEnvanterApp
{
    public partial class AnaFormcs : Form
    {
        public AnaFormcs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HızlıEkleme form=new HızlıEkleme();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stok form= new Stok();
            form.ShowDialog();
        }

        private void AnaFormcs_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>
        {
            new Product(1, "Kalem", "Kırtasiye", 10.0, 100),
            new Product(2, "Defter", "Kırtasiye", 25.0, 80),
            new Product(3, "Silgi", "Kırtasiye", 5.0, 150),
            new Product(4, "Cetvel", "Kırtasiye", 8.0, 70),
            new Product(5, "Makas", "Kırtasiye", 15.0, 60),
            new Product(6, "Yapıştırıcı", "Kırtasiye", 12.5, 90),
            new Product(7, "Kitap", "Eğitim", 45.0, 50),
            new Product(8, "Kalemlik", "Aksesuar", 20.0, 40),
            new Product(9, "Dosya", "Ofis", 18.0, 100),
            new Product(10, "Zımba", "Ofis", 22.0, 55)
        };

            foreach (var product in products)
            {
                GlobalData.productTable.Add(product);
                GlobalData.avlTree.Insert(product);
                GlobalData.linkedList.AddProduct(product);
            }
        }
        
    }
}
