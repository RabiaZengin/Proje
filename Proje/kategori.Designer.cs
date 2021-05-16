namespace Proje
{
    partial class kategori
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
            this.btnekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(202, 111);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori";
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(117, 45);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(160, 20);
            this.txtkategori.TabIndex = 3;
            // 
            // kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(308, 232);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkategori);
            this.Name = "kategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kategori";
            this.Load += new System.EventHandler(this.kategori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkategori;
    }
}