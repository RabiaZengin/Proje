namespace Proje
{
    partial class Ürünlistele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmkgüncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmarka = new System.Windows.Forms.ComboBox();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbarkodara = new System.Windows.Forms.TextBox();
            this.btnsilme = new System.Windows.Forms.Button();
            this.btgüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsatış = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txtalış = new System.Windows.Forms.TextBox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtürün = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmkgüncelle
            // 
            this.btnmkgüncelle.Location = new System.Drawing.Point(467, 378);
            this.btnmkgüncelle.Name = "btnmkgüncelle";
            this.btnmkgüncelle.Size = new System.Drawing.Size(71, 39);
            this.btnmkgüncelle.TabIndex = 90;
            this.btnmkgüncelle.Text = "Marka Güncelle";
            this.btnmkgüncelle.UseVisualStyleBackColor = true;
            this.btnmkgüncelle.Click += new System.EventHandler(this.btnmkgüncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Kategori";
            // 
            // cmbmarka
            // 
            this.cmbmarka.FormattingEnabled = true;
            this.cmbmarka.Location = new System.Drawing.Point(308, 396);
            this.cmbmarka.Name = "cmbmarka";
            this.cmbmarka.Size = new System.Drawing.Size(121, 21);
            this.cmbmarka.TabIndex = 87;
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(308, 350);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(121, 21);
            this.cmbkategori.TabIndex = 86;
            this.cmbkategori.SelectedIndexChanged += new System.EventHandler(this.cmbkategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "BarkodNo";
            // 
            // txtbarkodara
            // 
            this.txtbarkodara.Location = new System.Drawing.Point(467, 9);
            this.txtbarkodara.MaxLength = 8;
            this.txtbarkodara.Name = "txtbarkodara";
            this.txtbarkodara.Size = new System.Drawing.Size(156, 20);
            this.txtbarkodara.TabIndex = 84;
            this.txtbarkodara.TextChanged += new System.EventHandler(this.txtbarkodara_TextChanged);
            // 
            // btnsilme
            // 
            this.btnsilme.Location = new System.Drawing.Point(677, 51);
            this.btnsilme.Name = "btnsilme";
            this.btnsilme.Size = new System.Drawing.Size(75, 23);
            this.btnsilme.TabIndex = 83;
            this.btnsilme.Text = "Sil";
            this.btnsilme.UseVisualStyleBackColor = true;
            this.btnsilme.Click += new System.EventHandler(this.btnsilme_Click);
            // 
            // btgüncelle
            // 
            this.btgüncelle.Location = new System.Drawing.Point(131, 307);
            this.btgüncelle.Name = "btgüncelle";
            this.btgüncelle.Size = new System.Drawing.Size(75, 23);
            this.btgüncelle.TabIndex = 82;
            this.btgüncelle.Text = "Güncelle";
            this.btgüncelle.UseVisualStyleBackColor = true;
            this.btgüncelle.Click += new System.EventHandler(this.btgüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "ÜrünAdı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "Kategori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "BarkodNo";
            // 
            // txtsatış
            // 
            this.txtsatış.Location = new System.Drawing.Point(107, 278);
            this.txtsatış.Name = "txtsatış";
            this.txtsatış.Size = new System.Drawing.Size(99, 20);
            this.txtsatış.TabIndex = 74;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(107, 44);
            this.txtbarkod.MaxLength = 8;
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(99, 20);
            this.txtbarkod.TabIndex = 68;
            // 
            // txtalış
            // 
            this.txtalış.Location = new System.Drawing.Point(107, 239);
            this.txtalış.Name = "txtalış";
            this.txtalış.Size = new System.Drawing.Size(99, 20);
            this.txtalış.TabIndex = 73;
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(107, 83);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.ReadOnly = true;
            this.txtkategori.Size = new System.Drawing.Size(99, 20);
            this.txtkategori.TabIndex = 69;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(107, 200);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(99, 20);
            this.txtmiktar.TabIndex = 72;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(107, 122);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.ReadOnly = true;
            this.txtmarka.Size = new System.Drawing.Size(99, 20);
            this.txtmarka.TabIndex = 70;
            // 
            // txtürün
            // 
            this.txtürün.Location = new System.Drawing.Point(107, 161);
            this.txtürün.Name = "txtürün";
            this.txtürün.Size = new System.Drawing.Size(99, 20);
            this.txtürün.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(225, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 286);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Ürünlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 448);
            this.Controls.Add(this.btnmkgüncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbmarka);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbarkodara);
            this.Controls.Add(this.btnsilme);
            this.Controls.Add(this.btgüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtsatış);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.txtalış);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtürün);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ürünlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünlistele";
            this.Load += new System.EventHandler(this.Ürünlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmkgüncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmarka;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbarkodara;
        private System.Windows.Forms.Button btnsilme;
        private System.Windows.Forms.Button btgüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtsatış;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.TextBox txtalış;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtürün;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}