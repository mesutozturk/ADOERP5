namespace EFCFFundamentals
{
    partial class FormTedarikci
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTedarikci = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(150, 20);
            this.txtAra.TabIndex = 25;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(256, 12);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(195, 20);
            this.txtFirmaAdi.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Telefon";
            // 
            // lstTedarikci
            // 
            this.lstTedarikci.ContextMenuStrip = this.contextMenuStrip1;
            this.lstTedarikci.FormattingEnabled = true;
            this.lstTedarikci.Location = new System.Drawing.Point(13, 38);
            this.lstTedarikci.Name = "lstTedarikci";
            this.lstTedarikci.Size = new System.Drawing.Size(150, 264);
            this.lstTedarikci.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişOluşturToolStripMenuItem,
            this.siparişleriGörüntüleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // siparişOluşturToolStripMenuItem
            // 
            this.siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            this.siparişOluşturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişOluşturToolStripMenuItem.Click += new System.EventHandler(this.siparişOluşturToolStripMenuItem_Click);
            // 
            // siparişleriGörüntüleToolStripMenuItem
            // 
            this.siparişleriGörüntüleToolStripMenuItem.Name = "siparişleriGörüntüleToolStripMenuItem";
            this.siparişleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişleriGörüntüleToolStripMenuItem.Text = "Siparişleri Görüntüle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(362, 256);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 46);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(267, 256);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 46);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(172, 256);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 46);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Firma Adı";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(256, 59);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(195, 20);
            this.txtTelefon.TabIndex = 27;
            // 
            // FormTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 325);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTedarikci);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "FormTedarikci";
            this.Text = "FormTedarikci";
            this.Load += new System.EventHandler(this.FormTedarikci_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTedarikci;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişleriGörüntüleToolStripMenuItem;
    }
}