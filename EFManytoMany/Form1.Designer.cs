namespace EFManytoMany
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
            this.btnDersOnayla = new System.Windows.Forms.Button();
            this.lblToplamKredi = new System.Windows.Forms.Label();
            this.clstOgrenciDersleri = new System.Windows.Forms.CheckedListBox();
            this.nKredi = new System.Windows.Forms.NumericUpDown();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.lstOgrenci = new System.Windows.Forms.ListBox();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nKredi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDersOnayla
            // 
            this.btnDersOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersOnayla.ForeColor = System.Drawing.Color.Crimson;
            this.btnDersOnayla.Location = new System.Drawing.Point(274, 385);
            this.btnDersOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.btnDersOnayla.Name = "btnDersOnayla";
            this.btnDersOnayla.Size = new System.Drawing.Size(200, 43);
            this.btnDersOnayla.TabIndex = 31;
            this.btnDersOnayla.Text = "Ders Seçimini Onayla";
            this.btnDersOnayla.UseVisualStyleBackColor = true;
            this.btnDersOnayla.Click += new System.EventHandler(this.btnDersOnayla_Click);
            // 
            // lblToplamKredi
            // 
            this.lblToplamKredi.AutoSize = true;
            this.lblToplamKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKredi.Location = new System.Drawing.Point(270, 357);
            this.lblToplamKredi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamKredi.Name = "lblToplamKredi";
            this.lblToplamKredi.Size = new System.Drawing.Size(177, 26);
            this.lblToplamKredi.TabIndex = 30;
            this.lblToplamKredi.Text = "Toplam Kredi: 14";
            // 
            // clstOgrenciDersleri
            // 
            this.clstOgrenciDersleri.FormattingEnabled = true;
            this.clstOgrenciDersleri.Location = new System.Drawing.Point(7, 340);
            this.clstOgrenciDersleri.Margin = new System.Windows.Forms.Padding(2);
            this.clstOgrenciDersleri.Name = "clstOgrenciDersleri";
            this.clstOgrenciDersleri.Size = new System.Drawing.Size(232, 184);
            this.clstOgrenciDersleri.TabIndex = 29;
            this.clstOgrenciDersleri.Click += new System.EventHandler(this.clstOgrenciDersleri_SelectedIndexChanged);
            this.clstOgrenciDersleri.SelectedIndexChanged += new System.EventHandler(this.clstOgrenciDersleri_SelectedIndexChanged);
            // 
            // nKredi
            // 
            this.nKredi.Location = new System.Drawing.Point(323, 77);
            this.nKredi.Margin = new System.Windows.Forms.Padding(2);
            this.nKredi.Name = "nKredi";
            this.nKredi.Size = new System.Drawing.Size(152, 20);
            this.nKredi.TabIndex = 26;
            this.nKredi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(87, 78);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(152, 21);
            this.cmbCinsiyet.TabIndex = 22;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(87, 54);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(152, 20);
            this.dtpDogumTarihi.TabIndex = 21;
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.Location = new System.Drawing.Point(274, 150);
            this.lstDersler.Margin = new System.Windows.Forms.Padding(2);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(202, 186);
            this.lstDersler.TabIndex = 28;
            this.lstDersler.SelectedIndexChanged += new System.EventHandler(this.lstDersler_SelectedIndexChanged);
            // 
            // lstOgrenci
            // 
            this.lstOgrenci.FormattingEnabled = true;
            this.lstOgrenci.Location = new System.Drawing.Point(7, 150);
            this.lstOgrenci.Margin = new System.Windows.Forms.Padding(2);
            this.lstOgrenci.Name = "lstOgrenci";
            this.lstOgrenci.Size = new System.Drawing.Size(232, 186);
            this.lstOgrenci.TabIndex = 24;
            this.lstOgrenci.SelectedIndexChanged += new System.EventHandler(this.lstOgrenci_SelectedIndexChanged);
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Location = new System.Drawing.Point(274, 102);
            this.btnDersKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(201, 43);
            this.btnDersKaydet.TabIndex = 27;
            this.btnDersKaydet.Text = "Ders Kaydet";
            this.btnDersKaydet.UseVisualStyleBackColor = true;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(7, 102);
            this.btnOgrenciKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(231, 43);
            this.btnOgrenciKaydet.TabIndex = 23;
            this.btnOgrenciKaydet.Text = "Öğrenci Kaydet";
            this.btnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Doğum Tarihi";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(87, 29);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(152, 20);
            this.txtSoyad.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(323, 54);
            this.txtDersAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(152, 20);
            this.txtDersAdi.TabIndex = 25;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(87, 6);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(152, 20);
            this.txtAd.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kredi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ders Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 538);
            this.Controls.Add(this.btnDersOnayla);
            this.Controls.Add(this.lblToplamKredi);
            this.Controls.Add(this.clstOgrenciDersleri);
            this.Controls.Add(this.nKredi);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.lstDersler);
            this.Controls.Add(this.lstOgrenci);
            this.Controls.Add(this.btnDersKaydet);
            this.Controls.Add(this.btnOgrenciKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKredi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDersOnayla;
        private System.Windows.Forms.Label lblToplamKredi;
        private System.Windows.Forms.CheckedListBox clstOgrenciDersleri;
        private System.Windows.Forms.NumericUpDown nKredi;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ListBox lstDersler;
        private System.Windows.Forms.ListBox lstOgrenci;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.Button btnOgrenciKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

