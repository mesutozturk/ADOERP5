namespace UrunYonetim.Forms
{
    partial class FormSiparisOlustur
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
            this.components = new System.ComponentModel.Container();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.nKdv = new System.Windows.Forms.NumericUpDown();
            this.nToplam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbCalisan = new System.Windows.Forms.ComboBox();
            this.cmbKargo = new System.Windows.Forms.ComboBox();
            this.nKargoFiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsSepetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adetiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).BeginInit();
            this.cmsSepetMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.cmsSepetMenu;
            this.lstSepet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(330, 38);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(311, 228);
            this.lstSepet.TabIndex = 26;
            // 
            // nIndirim
            // 
            this.nIndirim.DecimalPlaces = 3;
            this.nIndirim.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nIndirim.Location = new System.Drawing.Point(208, 328);
            this.nIndirim.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(116, 20);
            this.nIndirim.TabIndex = 25;
            this.nIndirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(208, 270);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(116, 52);
            this.btnSepeteEkle.TabIndex = 24;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(181, 20);
            this.txtAra.TabIndex = 22;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(12, 38);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(312, 225);
            this.lstUrun.TabIndex = 23;
            // 
            // nKdv
            // 
            this.nKdv.DecimalPlaces = 2;
            this.nKdv.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nKdv.Location = new System.Drawing.Point(473, 315);
            this.nKdv.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKdv.Name = "nKdv";
            this.nKdv.ReadOnly = true;
            this.nKdv.Size = new System.Drawing.Size(168, 40);
            this.nKdv.TabIndex = 30;
            this.nKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nToplam
            // 
            this.nToplam.DecimalPlaces = 2;
            this.nToplam.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nToplam.Location = new System.Drawing.Point(473, 272);
            this.nToplam.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nToplam.Name = "nToplam";
            this.nToplam.ReadOnly = true;
            this.nToplam.Size = new System.Drawing.Size(168, 40);
            this.nToplam.TabIndex = 29;
            this.nToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(373, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(373, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Toplam";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(12, 301);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(181, 21);
            this.cmbMusteri.TabIndex = 31;
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(12, 270);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(181, 21);
            this.cmbCalisan.TabIndex = 32;
            // 
            // cmbKargo
            // 
            this.cmbKargo.FormattingEnabled = true;
            this.cmbKargo.Location = new System.Drawing.Point(13, 328);
            this.cmbKargo.Name = "cmbKargo";
            this.cmbKargo.Size = new System.Drawing.Size(181, 21);
            this.cmbKargo.TabIndex = 33;
            // 
            // nKargoFiyat
            // 
            this.nKargoFiyat.DecimalPlaces = 3;
            this.nKargoFiyat.Location = new System.Drawing.Point(78, 355);
            this.nKargoFiyat.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKargoFiyat.Name = "nKargoFiyat";
            this.nKargoFiyat.Size = new System.Drawing.Size(116, 20);
            this.nKargoFiyat.TabIndex = 34;
            this.nKargoFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nKargoFiyat.Value = new decimal(new int[] {
            105,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kargo Fiyatı";
            // 
            // cmsSepetMenu
            // 
            this.cmsSepetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arttırToolStripMenuItem,
            this.azaltToolStripMenuItem,
            this.çıkartToolStripMenuItem,
            this.adetiGüncelleToolStripMenuItem});
            this.cmsSepetMenu.Name = "cmsSepetMenu";
            this.cmsSepetMenu.Size = new System.Drawing.Size(152, 92);
            // 
            // arttırToolStripMenuItem
            // 
            this.arttırToolStripMenuItem.Name = "arttırToolStripMenuItem";
            this.arttırToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.arttırToolStripMenuItem.Text = "Arttır";
            // 
            // azaltToolStripMenuItem
            // 
            this.azaltToolStripMenuItem.Name = "azaltToolStripMenuItem";
            this.azaltToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.azaltToolStripMenuItem.Text = "Azalt";
            // 
            // çıkartToolStripMenuItem
            // 
            this.çıkartToolStripMenuItem.Name = "çıkartToolStripMenuItem";
            this.çıkartToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.çıkartToolStripMenuItem.Text = "Çıkart";
            // 
            // adetiGüncelleToolStripMenuItem
            // 
            this.adetiGüncelleToolStripMenuItem.Name = "adetiGüncelleToolStripMenuItem";
            this.adetiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.adetiGüncelleToolStripMenuItem.Text = "Adeti Güncelle";
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.ForeColor = System.Drawing.Color.Crimson;
            this.btnSiparisOlustur.Location = new System.Drawing.Point(378, 367);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(263, 57);
            this.btnSiparisOlustur.TabIndex = 37;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // FormSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 477);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nKargoFiyat);
            this.Controls.Add(this.cmbKargo);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.cmbCalisan);
            this.Controls.Add(this.nKdv);
            this.Controls.Add(this.nToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrun);
            this.Name = "FormSiparisOlustur";
            this.Text = "FormSiparisOlustur";
            this.Load += new System.EventHandler(this.FormSiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).EndInit();
            this.cmsSepetMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.NumericUpDown nKdv;
        private System.Windows.Forms.NumericUpDown nToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.ComboBox cmbKargo;
        private System.Windows.Forms.NumericUpDown nKargoFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsSepetMenu;
        private System.Windows.Forms.ToolStripMenuItem arttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adetiGüncelleToolStripMenuItem;
        private System.Windows.Forms.Button btnSiparisOlustur;
    }
}