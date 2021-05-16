namespace Proje
{
    partial class müsterilisteleme
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "TCAra";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(476, 53);
            this.txtara.MaxLength = 11;
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(151, 20);
            this.txtara.TabIndex = 37;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(686, 94);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 36;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(165, 315);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(62, 23);
            this.btnguncelle.TabIndex = 35;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(96, 266);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(131, 20);
            this.txtmail.TabIndex = 34;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(96, 225);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(131, 20);
            this.txtadres.TabIndex = 33;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(96, 184);
            this.txttelefon.MaxLength = 11;
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(131, 20);
            this.txttelefon.TabIndex = 32;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(96, 143);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(131, 20);
            this.txtadsoyad.TabIndex = 31;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(96, 107);
            this.txttc.MaxLength = 11;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(131, 20);
            this.txttc.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ad Soyad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 279);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "TC";
            // 
            // müsterilisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "müsterilisteleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "müsterilisteleme";
            this.Load += new System.EventHandler(this.müsterilisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}