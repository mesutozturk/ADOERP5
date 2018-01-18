namespace EFCFFundamentals
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
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstKategori = new System.Windows.Forms.ListBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnTedarikci = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(256, 59);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(195, 117);
            this.txtAciklama.TabIndex = 21;
            this.txtAciklama.Text = "";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(150, 20);
            this.txtAra.TabIndex = 16;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(256, 12);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(195, 20);
            this.txtKategoriAdi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kategori Adı";
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.Location = new System.Drawing.Point(13, 38);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(150, 264);
            this.lstKategori.TabIndex = 17;
            this.lstKategori.SelectedIndexChanged += new System.EventHandler(this.lstKategori_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(362, 181);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 46);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(264, 182);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 46);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(169, 181);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 46);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(169, 233);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(89, 46);
            this.btnUrunler.TabIndex = 25;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnTedarikci
            // 
            this.btnTedarikci.Location = new System.Drawing.Point(264, 233);
            this.btnTedarikci.Name = "btnTedarikci";
            this.btnTedarikci.Size = new System.Drawing.Size(89, 46);
            this.btnTedarikci.TabIndex = 25;
            this.btnTedarikci.Text = "Tedarikciler";
            this.btnTedarikci.UseVisualStyleBackColor = true;
            this.btnTedarikci.Click += new System.EventHandler(this.btnTedarikci_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(362, 233);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(89, 46);
            this.btnSiparis.TabIndex = 26;
            this.btnSiparis.Text = "Siparişler";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 309);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnTedarikci);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKategori);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstKategori;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnTedarikci;
        private System.Windows.Forms.Button btnSiparis;
    }
}

