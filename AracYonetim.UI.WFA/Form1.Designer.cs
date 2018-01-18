namespace AracYonetim.UI.WFA
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.txtKurulusYili = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtKurucu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbMarkaLogo = new System.Windows.Forms.PictureBox();
            this.lstMarkalar = new System.Windows.Forms.ListBox();
            this.btnMarkaKaydet = new System.Windows.Forms.Button();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbAracResim = new System.Windows.Forms.PictureBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtUretimYili = new System.Windows.Forms.TextBox();
            this.cmbYakitTipi = new System.Windows.Forms.ComboBox();
            this.cmbVitesTipi = new System.Windows.Forms.ComboBox();
            this.btnAracKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarkaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAracResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(79, 12);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(118, 20);
            this.txtMarkaAdi.TabIndex = 0;
            // 
            // txtKurulusYili
            // 
            this.txtKurulusYili.Location = new System.Drawing.Point(79, 39);
            this.txtKurulusYili.Name = "txtKurulusYili";
            this.txtKurulusYili.Size = new System.Drawing.Size(118, 20);
            this.txtKurulusYili.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kuruluş Yılı";
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(79, 66);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(118, 20);
            this.txtUlke.TabIndex = 2;
            // 
            // txtKurucu
            // 
            this.txtKurucu.Location = new System.Drawing.Point(79, 92);
            this.txtKurucu.Name = "txtKurucu";
            this.txtKurucu.Size = new System.Drawing.Size(118, 20);
            this.txtKurucu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ülke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kurucusu";
            // 
            // pbMarkaLogo
            // 
            this.pbMarkaLogo.Location = new System.Drawing.Point(18, 118);
            this.pbMarkaLogo.Name = "pbMarkaLogo";
            this.pbMarkaLogo.Size = new System.Drawing.Size(179, 138);
            this.pbMarkaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMarkaLogo.TabIndex = 5;
            this.pbMarkaLogo.TabStop = false;
            this.pbMarkaLogo.Click += new System.EventHandler(this.pbMarkaLogo_Click);
            // 
            // lstMarkalar
            // 
            this.lstMarkalar.FormattingEnabled = true;
            this.lstMarkalar.Location = new System.Drawing.Point(204, 13);
            this.lstMarkalar.Name = "lstMarkalar";
            this.lstMarkalar.Size = new System.Drawing.Size(181, 303);
            this.lstMarkalar.TabIndex = 5;
            this.lstMarkalar.SelectedIndexChanged += new System.EventHandler(this.lstMarkalar_SelectedIndexChanged);
            // 
            // btnMarkaKaydet
            // 
            this.btnMarkaKaydet.Location = new System.Drawing.Point(79, 273);
            this.btnMarkaKaydet.Name = "btnMarkaKaydet";
            this.btnMarkaKaydet.Size = new System.Drawing.Size(118, 43);
            this.btnMarkaKaydet.TabIndex = 4;
            this.btnMarkaKaydet.Text = "Marka Kaydet";
            this.btnMarkaKaydet.UseVisualStyleBackColor = true;
            this.btnMarkaKaydet.Click += new System.EventHandler(this.btnMarkaKaydet_Click);
            // 
            // lstAraclar
            // 
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.Location = new System.Drawing.Point(391, 12);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(194, 303);
            this.lstAraclar.TabIndex = 6;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Üretim Yılı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yakıt Tipi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vites Tipi";
            // 
            // pbAracResim
            // 
            this.pbAracResim.Location = new System.Drawing.Point(595, 118);
            this.pbAracResim.Name = "pbAracResim";
            this.pbAracResim.Size = new System.Drawing.Size(179, 138);
            this.pbAracResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAracResim.TabIndex = 10;
            this.pbAracResim.TabStop = false;
            this.pbAracResim.Click += new System.EventHandler(this.pbAracResim_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(651, 13);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(122, 20);
            this.txtModel.TabIndex = 7;
            // 
            // txtUretimYili
            // 
            this.txtUretimYili.Location = new System.Drawing.Point(651, 36);
            this.txtUretimYili.Name = "txtUretimYili";
            this.txtUretimYili.Size = new System.Drawing.Size(122, 20);
            this.txtUretimYili.TabIndex = 8;
            // 
            // cmbYakitTipi
            // 
            this.cmbYakitTipi.FormattingEnabled = true;
            this.cmbYakitTipi.Location = new System.Drawing.Point(652, 60);
            this.cmbYakitTipi.Name = "cmbYakitTipi";
            this.cmbYakitTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbYakitTipi.TabIndex = 9;
            // 
            // cmbVitesTipi
            // 
            this.cmbVitesTipi.FormattingEnabled = true;
            this.cmbVitesTipi.Location = new System.Drawing.Point(652, 87);
            this.cmbVitesTipi.Name = "cmbVitesTipi";
            this.cmbVitesTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbVitesTipi.TabIndex = 10;
            // 
            // btnAracKaydet
            // 
            this.btnAracKaydet.Location = new System.Drawing.Point(595, 273);
            this.btnAracKaydet.Name = "btnAracKaydet";
            this.btnAracKaydet.Size = new System.Drawing.Size(118, 43);
            this.btnAracKaydet.TabIndex = 11;
            this.btnAracKaydet.Text = "Araç Kaydet";
            this.btnAracKaydet.UseVisualStyleBackColor = true;
            this.btnAracKaydet.Click += new System.EventHandler(this.btnAracKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 335);
            this.Controls.Add(this.btnAracKaydet);
            this.Controls.Add(this.cmbVitesTipi);
            this.Controls.Add(this.cmbYakitTipi);
            this.Controls.Add(this.txtUretimYili);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.pbAracResim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstAraclar);
            this.Controls.Add(this.btnMarkaKaydet);
            this.Controls.Add(this.lstMarkalar);
            this.Controls.Add(this.pbMarkaLogo);
            this.Controls.Add(this.txtKurucu);
            this.Controls.Add(this.txtUlke);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKurulusYili);
            this.Controls.Add(this.txtMarkaAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMarkaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAracResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.TextBox txtKurulusYili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtKurucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbMarkaLogo;
        private System.Windows.Forms.ListBox lstMarkalar;
        private System.Windows.Forms.Button btnMarkaKaydet;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbAracResim;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtUretimYili;
        private System.Windows.Forms.ComboBox cmbYakitTipi;
        private System.Windows.Forms.ComboBox cmbVitesTipi;
        private System.Windows.Forms.Button btnAracKaydet;
    }
}

