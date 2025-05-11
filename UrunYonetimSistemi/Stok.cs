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

namespace UrunEnvanterApp
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                txtUpdateID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtUpdateID.Text);
                int newStock = int.Parse(txtNewStock.Text);

                bool updated = GlobalData.linkedList.UpdateStock(id, newStock);

                if (updated)
                {
                    MessageBox.Show("Stok başarıyla güncellendi.");
                    btnStokSirala.PerformClick(); // Listeyi tekrar göster
                }
                else
                    MessageBox.Show("Ürün bulunamadı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnStokSirala_Click(object sender, EventArgs e)
        {
            var sorted = GlobalData.linkedList.SortByStock();
            dataGridView1.Rows.Clear();
            foreach (var p in sorted)
            {
                dataGridView1.Rows.Add(p.ID, p.Name, p.Stock, p.Category);
            }
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Ad");
            dataGridView1.Columns.Add("Stock", "Stok");
            dataGridView1.Columns.Add("Category", "Kategori");
        }
    }
}
