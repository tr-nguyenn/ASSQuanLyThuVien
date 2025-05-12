using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSQuanLyThuVien
{
    public partial class FrmOpttion : MaterialForm
    {
        public FrmOpttion()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FrmOption_Font frm = new FrmOption_Font();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
