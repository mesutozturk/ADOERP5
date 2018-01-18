namespace EFCFFundamentals
{
    partial class FormSiparis
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
            this.lstOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTedarikci = new System.Windows.Forms.ListBox();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstOrders.FullRowSelect = true;
            this.lstOrders.GridLines = true;
            this.lstOrders.HoverSelection = true;
            this.lstOrders.Location = new System.Drawing.Point(295, 16);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOrders.MultiSelect = false;
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(546, 361);
            this.lstOrders.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstOrders.TabIndex = 15;
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
            this.columnHeader2.Width = 93;
            // 
            // lstTedarikci
            // 
            this.lstTedarikci.FormattingEnabled = true;
            this.lstTedarikci.ItemHeight = 17;
            this.lstTedarikci.Location = new System.Drawing.Point(16, 16);
            this.lstTedarikci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTedarikci.Name = "lstTedarikci";
            this.lstTedarikci.Size = new System.Drawing.Size(268, 361);
            this.lstTedarikci.TabIndex = 14;
            this.lstTedarikci.SelectedIndexChanged += new System.EventHandler(this.lstTedarikci_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Teslim Tarihi";
            this.columnHeader8.Width = 91;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Kargo Fiyatı";
            this.columnHeader9.Width = 98;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Toplam Sipariş Tutarı";
            this.columnHeader10.Width = 157;
            // 
            // FormSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 386);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.lstTedarikci);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSiparis";
            this.Text = "FormSiparis";
            this.Load += new System.EventHandler(this.FormSiparis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListBox lstTedarikci;
    }
}