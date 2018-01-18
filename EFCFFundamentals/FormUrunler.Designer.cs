namespace EFCFFundamentals
{
    partial class FormUrunler
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.nStok = new System.Windows.Forms.NumericUpDown();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(204, 114);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 56);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(108, 114);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(72, 56);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(66, 61);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(188, 21);
            this.cmbKategori.TabIndex = 30;
            // 
            // nStok
            // 
            this.nStok.Location = new System.Drawing.Point(66, 88);
            this.nStok.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nStok.Name = "nStok";
            this.nStok.Size = new System.Drawing.Size(187, 20);
            this.nStok.TabIndex = 32;
            this.nStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(66, 35);
            this.nFiyat.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(187, 20);
            this.nFiyat.TabIndex = 29;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(295, 9);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(188, 20);
            this.txtAra.TabIndex = 34;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(66, 9);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(187, 20);
            this.txtUrunAdi.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ürün Adı";
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(295, 35);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(188, 316);
            this.lstUrun.TabIndex = 35;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 114);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(72, 56);
            this.btnKaydet.TabIndex = 36;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 363);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.nStok);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.btnKaydet);
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown nStok;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.Button btnKaydet;
    }
}