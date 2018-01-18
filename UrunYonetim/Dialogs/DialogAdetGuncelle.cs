using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetim.Dialogs
{
    public partial class DialogAdetGuncelle : Form
    {
        public DialogAdetGuncelle()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
