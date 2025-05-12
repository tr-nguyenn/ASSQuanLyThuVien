using Sunny.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASSQuanLyThuVien
{
    public partial class Login : Form
    {
        public string connectString = @"Data Source=NGUYENNTTD01427\SQLEXPRESS01;Initial Catalog=QuanLyThuVien3;Integrated Security=True;TrustServerCertificate=True";

        public Login()
        {
            InitializeComponent();
        }

        
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            
            string tenDangNhap = txtUser.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
               
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();

                    // Sử dụng tham số hóa truy vấn để tránh SQL Injection
                    string query = "SELECT * FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", tenDangNhap);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        using (SqlDataReader data = cmd.ExecuteReader())
                        {
                            if (data.Read())
                            {
                                string role = data["VaiTro"].ToString();
                                DialogResult result = MessageBox.Show(
                                    "Bạn đã đăng nhập thành công với tư cách là " + role,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                if (result == DialogResult.OK)
                                {
                                    this.Hide();
                                    if(role == "Admin")
                                    {
                                        FrmMain main = new FrmMain();
                                        main.Show();
                                        main.lbNamUser.Text = role;
                                    }
                                    else if(role == "ThuThu"){
                                        FrmMain main=new FrmMain();
                                        main.Show();
                                        // Ẩn chức năng quản lý người dùng
                                        main.mnsQuanLyNguoiDung.Enabled = false;
                                        main.quảnLýNgườiDùngToolStripMenuItem1.Enabled = false;
                                        main.lbNamUser.Text = role;
                                        main.btnQuanLyNguoiDung.Enabled=false;
                                    }
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        } 
                    } 
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            FrmOpttion frmOpttion = new FrmOpttion();
            frmOpttion.ShowDialog();
        }

        private void grbDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}