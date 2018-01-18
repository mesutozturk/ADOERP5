namespace UrunYonetim.Forms
{
    partial class FormMusteriSiparisler
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
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.lstOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSiparisDetay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSiparisDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(12, 12);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(242, 355);
            this.lstCustomer.TabIndex = 12;
            this.lstCustomer.SelectedIndexChanged += new System.EventHandler(this.lstCustomer_SelectedIndexChanged);
            // 
            // lstOrders
            // 
            this.lstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lstOrders.ContextMenuStrip = this.cmsSiparisDetay;
            this.lstOrders.FullRowSelect = true;
            this.lstOrders.GridLines = true;
            this.lstOrders.HoverSelection = true;
            this.lstOrders.Location = new System.Drawing.Point(261, 13);
            this.lstOrders.MultiSelect = false;
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(629, 354);
            this.lstOrders.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstOrders.TabIndex = 13;
            this.lstOrders.UseCompatibleStateImageBehavior = false;
            this.lstOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş No";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sipariş Tarihi";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İstenen Tarih";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ülke";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kargo Tutarı";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam Sipariş Tutarı";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kargo Firması";
            this.columnHeader7.Width = 97;
            // 
            // cmsSiparisDetay
            // 
            this.cmsSiparisDetay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.toolStripSeparator1,
            this.detayToolStripMenuItem,
            this.gönderToolStripMenuItem});
            this.cmsSiparisDetay.Name = "cmsSiparisDetay";
            this.cmsSiparisDetay.Size = new System.Drawing.Size(153, 120);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detayToolStripMenuItem.Text = "Detay";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
            // 
            // gönderToolStripMenuItem
            // 
            this.gönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muhasebeToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.kargoToolStripMenuItem});
            this.gönderToolStripMenuItem.Name = "gönderToolStripMenuItem";
            this.gönderToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.gönderToolStripMenuItem.Text = "Gönder";
            // 
            // muhasebeToolStripMenuItem
            // 
            this.muhasebeToolStripMenuItem.Name = "muhasebeToolStripMenuItem";
            this.muhasebeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.muhasebeToolStripMenuItem.Text = "Muhasebe";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // kargoToolStripMenuItem
            // 
            this.kargoToolStripMenuItem.Name = "kargoToolStripMenuItem";
            this.kargoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kargoToolStripMenuItem.Text = "Kargo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // FormMusteriSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 386);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.lstCustomer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FormMusteriSiparisler";
            this.Text = "FormMusteriSiparisler";
            this.Load += new System.EventHandler(this.FormMusteriSiparisler_Load);
            this.cmsSiparisDetay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.ListView lstOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip cmsSiparisDetay;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kargoToolStripMenuItem;
    }
}