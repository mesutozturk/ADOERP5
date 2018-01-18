namespace EFCFFundamentals
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
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nKargoFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.nKdv = new System.Windows.Forms.NumericUpDown();
            this.nToplam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.cmsSepetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adetiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstUrun = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).BeginInit();
            this.cmsSepetMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.ForeColor = System.Drawing.Color.Crimson;
            this.btnSiparisOlustur.Location = new System.Drawing.Point(388, 337);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(263, 57);
            this.btnSiparisOlustur.TabIndex = 51;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Kargo Fiyatı";
            // 
            // nKargoFiyat
            // 
            this.nKargoFiyat.DecimalPlaces = 3;
            this.nKargoFiyat.Location = new System.Drawing.Point(87, 272);
            this.nKargoFiyat.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKargoFiyat.Name = "nKargoFiyat";
            this.nKargoFiyat.Size = new System.Drawing.Size(116, 20);
            this.nKargoFiyat.TabIndex = 49;
            this.nKargoFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nKargoFiyat.Value = new decimal(new int[] {
            105,
            0,
            0,
            65536});
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(22, 240);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(181, 21);
            this.cmbTedarikci.TabIndex = 47;
            // 
            // nKdv
            // 
            this.nKdv.DecimalPlaces = 2;
            this.nKdv.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nKdv.Location = new System.Drawing.Point(483, 285);
            this.nKdv.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKdv.Name = "nKdv";
            this.nKdv.ReadOnly = true;
            this.nKdv.Size = new System.Drawing.Size(168, 40);
            this.nKdv.TabIndex = 45;
            this.nKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nToplam
            // 
            this.nToplam.DecimalPlaces = 2;
            this.nToplam.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nToplam.Location = new System.Drawing.Point(483, 242);
            this.nToplam.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nToplam.Name = "nToplam";
            this.nToplam.ReadOnly = true;
            this.nToplam.Size = new System.Drawing.Size(168, 40);
            this.nToplam.TabIndex = 44;
            this.nToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(383, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(383, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Toplam";
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.cmsSepetMenu;
            this.lstSepet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(340, 8);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(311, 228);
            this.lstSepet.TabIndex = 41;
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
            // nIndirim
            // 
            this.nIndirim.DecimalPlaces = 3;
            this.nIndirim.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nIndirim.Location = new System.Drawing.Point(218, 298);
            this.nIndirim.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(116, 20);
            this.nIndirim.TabIndex = 40;
            this.nIndirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(218, 240);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(116, 52);
            this.btnSepeteEkle.TabIndex = 39;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(22, 8);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(312, 225);
            this.lstUrun.TabIndex = 38;
            // 
            // FormSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 402);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nKargoFiyat);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.nKdv);
            this.Controls.Add(this.nToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lstUrun);
            this.Name = "FormSiparisOlustur";
            this.Text = "FormSiparisOlustur";
            this.Load += new System.EventHandler(this.FormSiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).EndInit();
            this.cmsSepetMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nKargoFiyat;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.NumericUpDown nKdv;
        private System.Windows.Forms.NumericUpDown nToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ContextMenuStrip cmsSepetMenu;
        private System.Windows.Forms.ToolStripMenuItem arttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adetiGüncelleToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstUrun;
    }
}