using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSQuanLyThuVien
{
    public partial class FrmQuanLySach : Form
    {
        public string connectionString = @"Data Source=NGUYENNTTD01427\SQLEXPRESS01;Initial Catalog=QuanLyThuVien3;Integrated Security=True;TrustServerCertificate=True";
        public FrmQuanLySach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TheLoai();
            LoadData();
            DataGridView1.Columns["MaSach"].HeaderText = "Mã sách";
            DataGridView1.Columns["TenSach"].HeaderText = "Tên sách";
            DataGridView1.Columns["TacGia"].HeaderText = "Tác giả";
            DataGridView1.Columns["MaTheLoai"].HeaderText = "Mã thể loại";
            DataGridView1.Columns["NXB"].HeaderText = "Nhà xuất bản";
            DataGridView1.Columns["NamXuatBan"].HeaderText = "Năm xuất bản";
        }
        
        private void LoadData()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from Sach";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridView1.DataSource = dt;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ClearB()
        {
            txtMaSach.Text = "";
            txtNXB.Text = "";
            txtTacGia.Text = "";
            txtNamXuatBan.Text = "";
            txtTenSach.Text = "";
            cboTheLoai.SelectedIndex = -1;
        }
        private void TheLoai()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MaTheLoai FROM TheLoai", conn); 
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboTheLoai.DataSource = dt;
                    cboTheLoai.DisplayMember = "MaTheLoai";
                    cboTheLoai.ValueMember = "MaTheLoai"; // Đặt ValueMember để SelectedValue trả về đúng giá trị
                    cboTheLoai.SelectedIndex = -1; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách thể loại: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SearchData(string keyword)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from Sach where MaSach Like @Keyword or TenSach Like @Keyword or TacGia Like @Keyword or MaTheLoai Like @KeyWord or NXB like @Keyword or NamXuatBan Like @Keyword";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword.Trim() + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text) || string.IsNullOrWhiteSpace(txtNamXuatBan.Text) ||
                string.IsNullOrWhiteSpace(txtNXB.Text) || string.IsNullOrWhiteSpace(txtTacGia.Text) ||
                string.IsNullOrWhiteSpace(txtTenSach.Text) || cboTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại những thông tin chưa điền",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Lấy MaSach từ txtMaSach.Text thay vì từ DataGridView
                    int maSach = Convert.ToInt32(txtMaSach.Text.Trim());

                    string query = "INSERT INTO Sach (MaSach, TenSach, TacGia, MaTheLoai, NXB, NamXuatBan) " +
                                  "VALUES (@maSach, @tenSach, @tacGia, @maTheLoai, @nxb, @namXuatBan)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@tenSach", txtTenSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@tacGia", txtTacGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@maTheLoai", cboTheLoai.SelectedValue.ToString()); // Đảm bảo giá trị hợp lệ
                    cmd.Parameters.AddWithValue("@nxb", txtNXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@namXuatBan", txtNamXuatBan.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Thêm thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearB();
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
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập mã sách để cập nhật!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy mã sách từ ô nhập liệu
                    int maSach;
                    if (!int.TryParse(txtMaSach.Text, out maSach))
                    {
                        MessageBox.Show("Mã sách phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra xem mã thể loại đã được chọn chưa
                    if (cboTheLoai.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn mã thể loại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "UPDATE Sach SET TenSach = @Ten, TacGia = @TacGia, MaTheLoai = @MaTheLoai, " +
                                   "NXB = @NXB, NamXuatBan = @NamXuatBan WHERE MaSach = @Ma";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", maSach);
                    cmd.Parameters.AddWithValue("@Ten", txtTenSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaTheLoai", cboTheLoai.SelectedValue.ToString()); // Sửa lỗi ở đây
                    cmd.Parameters.AddWithValue("@NXB", txtNXB.Text.Trim());
                    cmd.Parameters.AddWithValue("@NamXuatBan", txtNamXuatBan.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Cập nhật dữ liệu thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LoadData();
                        ClearB();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã sách cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(
                    "Lỗi SQL: " + sqlEx.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
            if(DataGridView1.SelectedRows.Count > 0)
            {
                int ma = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["MaSach"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Sach where MaSach = @Ma",conn);
                    cmd.Parameters.AddWithValue("@Ma",ma);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show(
                        "Xóa Thành Công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                }
            }else if(DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn dòng để xóa",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                
                MessageBox.Show(
                    "Xóa Thất bại" ,
                    "LỖI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                txtNamXuatBan.Text = row.Cells["NamXuatBan"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtNXB.Text = row.Cells["NXB"].Value.ToString();
                cboTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData(); // Nếu không nhập từ khóa, hiển thị toàn bộ dữ liệu
            }
            else
            {
                SearchData(keyword); // Gọi hàm tìm kiếm với từ khóa
            }
        }
    }
}
