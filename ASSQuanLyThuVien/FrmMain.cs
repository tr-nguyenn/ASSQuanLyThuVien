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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void quảnLýSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmQuanLySach frm = new FrmQuanLySach();
            frm.MdiParent =this;
            frm.Show();
        }

        private void quảnLýLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiSach frm = new FrmQuanLyLoaiSach();
            frm.MdiParent =this;
            frm.Show();
        }

        private void quảnLýNượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhieuMuon frm = new FrmPhieuMuon();
            frm.MdiParent =this;
            frm.Show();
        }

        public void quảnLýNgườiDùngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan frm = new FrmQuanLyTaiKhoan();
            frm.MdiParent =this;
            frm.Show();
        }

        private void quảnLýĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyDocGia frm = new FrmQuanLyDocGia();
            frm.MdiParent =this;
            frm.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.MdiParent =this;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void mnsQuanLyNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyLoaiSach_Click(object sender, EventArgs e)
        {
            FrmQuanLyLoaiSach frm = new FrmQuanLyLoaiSach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            FrmQuanLySach frm = new FrmQuanLySach();
            frm.MdiParent = this;
            frm.Show();
        }

        private void QuanLyMuonSach_Click(object sender, EventArgs e)
        {
            FrmPhieuMuon frm = new FrmPhieuMuon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan frm = new FrmQuanLyTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            FrmQuanLyDocGia frm = new FrmQuanLyDocGia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn thoát",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc chắn muốn Đăng xuất",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void swDen_ValueChanged(object sender, bool value)
        {
            if (value) 
            {
                pnHeader.FillColor = Color.Black;  
                pnLeft.FillColor = Color.Black;
                pnRight.FillColor = Color.Black;
                pictureBox1.BackColor = Color.Black;
                lbNamUser.BackColor = Color.Black;
                uiGroupBox1.BackColor = Color.Black;
                uiGroupBox2.BackColor = Color.Black;
                uiGroupBox3.BackColor = Color.Black;
                uiGroupBox4.BackColor = Color.Black;
               
                
            }
            else
            {
                pnHeader.FillColor = Color.White;  
                pnLeft.FillColor = Color.White;
                pnRight.FillColor = Color.White;
                pictureBox1.BackColor = Color.White;
                lbNamUser.BackColor = Color.White;
                uiGroupBox1.BackColor = Color.White;
                uiGroupBox2.BackColor = Color.White;
                uiGroupBox3.BackColor = Color.White;
                uiGroupBox4.BackColor = Color.White;
            
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSetting frmSetting = new FrmSetting(this);
            frmSetting.MdiParent= this;
            frmSetting.Show();
        }

        private void pnRight_Click(object sender, EventArgs e)
        {

        }
    }
}
