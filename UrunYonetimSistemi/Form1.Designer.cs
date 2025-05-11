namespace UrunEnvanterApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.brnListeleAvl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtYeniFiyat = new System.Windows.Forms.TextBox();
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ara";
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.SystemColors.Window;
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(76, 33);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(166, 27);
            this.txtAra.TabIndex = 6;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(24, 82);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(61, 32);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(354, 75);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 8;
            // 
            // brnListeleAvl
            // 
            this.brnListeleAvl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.brnListeleAvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnListeleAvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brnListeleAvl.Location = new System.Drawing.Point(453, 487);
            this.brnListeleAvl.Name = "brnListeleAvl";
            this.brnListeleAvl.Size = new System.Drawing.Size(182, 31);
            this.brnListeleAvl.TabIndex = 9;
            this.brnListeleAvl.Text = "Sıralı Listele";
            this.brnListeleAvl.UseVisualStyleBackColor = false;
            this.brnListeleAvl.Click += new System.EventHandler(this.brnListeleAvl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtAra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 178);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Arama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(453, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 469);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtYeniFiyat
            // 
            this.txtYeniFiyat.BackColor = System.Drawing.SystemColors.Window;
            this.txtYeniFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniFiyat.Location = new System.Drawing.Point(150, 236);
            this.txtYeniFiyat.Name = "txtYeniFiyat";
            this.txtYeniFiyat.Size = new System.Drawing.Size(166, 27);
            this.txtYeniFiyat.TabIndex = 16;
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(322, 235);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(96, 27);
            this.btnFiyatGuncelle.TabIndex = 17;
            this.btnFiyatGuncelle.Text = "Güncelle";
            this.btnFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fiyat Güncelle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiyatGuncelle);
            this.Controls.Add(this.txtYeniFiyat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.brnListeleAvl);
            this.Controls.Add(this.lblSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button brnListeleAvl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtYeniFiyat;
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.Label label1;
    }
}

