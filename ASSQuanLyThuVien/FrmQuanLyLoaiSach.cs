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
    public partial class FrmQuanLyLoaiSach : Form
    {
        private string connectionString = @"Data Source=NGUYENNTTD01427\SQLEXPRESS01;Initial Catalog=QuanLyThuVien3;Integrated Security=True;TrustServerCertificate=True";
        public FrmQuanLyLoaiSach()
        {
            InitializeComponent();
        }
        private void FrmQuanLyLoaiSach_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridView1.Columns["MaTheLoai"].HeaderText = "Mã thể loại";
            DataGridView1.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from TheLoai";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridView1.DataSource = dt;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: "+ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ClearB()
        {
            txtMaLoai.Text = "";
            txtTenTheLoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaLoai.Text) || string.IsNullOrWhiteSpace(txtTenTheLoai.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "Insert into TheLoai (MaTheLoai, TenTheLoai)" + "values (@Ma,@Ten)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", txtMaLoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtTenTheLoai.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm Dữ liệu thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearB();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SearchData(string keyword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM TheLoai WHERE MaTheLoai LIKE @Keyword OR TenTheLoai LIKE @Keyword";
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
                txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaLoai.Text) || string.IsNullOrWhiteSpace(txtTenTheLoai.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn 1 dòng để sửa",
                    "thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "update TheLoai set TenTheLoai = @Ten " +
                        "Where MaTheLoai = @Ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", txtMaLoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtTenTheLoai.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Cập nhật thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearB();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: "+ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int maTheLoai = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["MaTheLoai"].Value);
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from TheLoai where MaTheLoai = @Ma", conn);
                    cmd.Parameters.AddWithValue("@Ma", maTheLoai);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Xóa Thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show(
                        "Xóa Thất bại",
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
