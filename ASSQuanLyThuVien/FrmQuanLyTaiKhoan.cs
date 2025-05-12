using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSQuanLyThuVien
{
    public partial class FrmQuanLyTaiKhoan : Form
    {
        public string connectionString = @"Data Source=NGUYENNTTD01427\SQLEXPRESS01;Initial Catalog=QuanLyThuVien3;Integrated Security=True;TrustServerCertificate=True";
        public FrmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridView1.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            DataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            DataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            DataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            DataGridView1.Columns["VaiTro"].HeaderText = "Vai Trò";
            DataGridView1.Columns["TaiKhoan"].HeaderText = "Tài Khoản";
            DataGridView1.Columns["MatKhau"].HeaderText = "Mật Khẩu";
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from TaiKhoan";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ClearBang()
        {
            txtMaNhanVien.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
            txtTaiKhoan.Text = "";
            txtTimKiem.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cboVaiTro.SelectedIndex = -1;
        }
        private void SearchData(string keyword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM TaiKhoan WHERE MaNhanVien LIKE @Keyword Or HoTen LIKE @Keyword Or NgaySinh LIKE @Keyword Or" +
                        " SoDienThoai LIKE @Keyword Or VaiTro LIKE @Keyword Or TaiKhoan LIKE @Keyword Or MatKhau LIKE @Keyword";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword.Trim() + "%"); // % để tìm kiếm gần đúng
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtHoTen.Text)||
                string.IsNullOrWhiteSpace(txtMaNhanVien.Text)||
                string.IsNullOrWhiteSpace(txtMatKhau.Text)||
                string.IsNullOrWhiteSpace(txtSDT.Text)||
                string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show(
                    "Vui lòng điền đầy đủ thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Lấy MaSach từ txtMaSach.Text thay vì từ DataGridView
                    int maNhanVien = Convert.ToInt32(txtMaNhanVien.Text.Trim());

                    string query = "INSERT INTO TaiKhoan (MaNhanVien, HoTen, NgaySinh, SoDienThoai, VaiTro, TaiKhoan, MatKhau) " +
                                  "VALUES (@MaNhanVien,@HoTen, @NgaySinh, @SoDienThoai, @VaiTro, @TaiKhoan, @MatKhau)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@HoTen",txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh",dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@VaiTro",cboVaiTro.Text);
                    cmd.Parameters.AddWithValue("@TaiKhoan",txtTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("MatKhau", txtMatKhau.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Thêm thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearBang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtMaNhanVien.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn 1 bảng để sửa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int maNhanVien = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["MaNhanVien"].Value);
                    string query = "UPDATE TaiKhoan SET HoTen = @HoTen, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai" +
                        ", VaiTro = @VaiTro, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau WHERE MaNhanVien = @MaNhanVien";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai",txtSDT.Text);
                    cmd.Parameters.AddWithValue("@VaiTro",cboVaiTro.Text);
                    cmd.Parameters.AddWithValue("@TaiKhoan",txtTaiKhoan.Text);
                    cmd.Parameters.AddWithValue("@MatKhau",txtMatKhau.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Thay đổi Dữ liệu thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearBang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int MaNhanVien = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["MaNhanVien"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from TaiKhoan where MaNhanVien = @MaNhanVien", conn);
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Xóa Thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearBang();
                }
            }
            else if (DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                "Vui lòng chọn 1 dòng",
                "Cảnh báo",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Xóa thất bại",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show(
                    "Vui lòng nhập từ khóa tìm kiếm!", 
                    "Cảnh báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            else
            {
                SearchData(keyword);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                cboVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
                txtTaiKhoan.Text = row.Cells["TaiKhoan"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();

            }
        }
    }
}
