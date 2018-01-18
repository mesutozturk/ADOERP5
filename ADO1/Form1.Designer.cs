namespace ADO1
{
    partial class Form1
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
            this.dgUrunler = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUrunler
            // 
            this.dgUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunler.Location = new System.Drawing.Point(13, 127);
            this.dgUrunler.Name = "dgUrunler";
            this.dgUrunler.Size = new System.Drawing.Size(727, 278);
            this.dgUrunler.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(350, 27);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 29);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(118, 29);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(100, 20);
            this.txtKategoriId.TabIndex = 2;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(224, 29);
            this.nFiyat.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(120, 20);
            this.nFiyat.TabIndex = 3;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 101);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(184, 20);
            this.txtAra.TabIndex = 5;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 427);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.txtKategoriId);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUrunler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAra;
    }
}

