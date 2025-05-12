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
using System.Windows.Input;

namespace ASSQuanLyThuVien
{
    public partial class FrmQuanLyDocGia : Form
    {
        public string connetionString = @"Data Source=NGUYENNTTD01427\SQLEXPRESS01;Initial Catalog=QuanLyThuVien3;Integrated Security=True;TrustServerCertificate=True";
        public FrmQuanLyDocGia()
        {
            InitializeComponent();
        }
        private void FrmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridView1.Columns["MaDocGia"].HeaderText = "Mã Đọc Giả";
            DataGridView1.Columns["TenDocGia"].HeaderText = "Tên Đọc Giả";
            DataGridView1.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    conn.Open();
                    string query = "select * from DocGia";
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
            txtMaDocGia.Text = "";
            txtSDT.Text = "";
            txtTenDocGia.Text = "";
            txtTimKiem.Text = "";
        }
        private void SearchData(string keyword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM DocGia WHERE MaDocGia LIKE @Keyword OR SoDienThoai LIKE @Keyword OR TenDocGia LIKE @Keyword";
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
            if (string.IsNullOrWhiteSpace(txtTenDocGia.Text) || 
                string.IsNullOrWhiteSpace(txtMaDocGia.Text) || 
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    conn.Open();
                    string query = "Insert into DocGia (MaDocGia, TenDocGia, SoDienThoai)" + "values (@Ma,@Ten,@Sdt)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", txtMaDocGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtTenDocGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sdt", txtSDT.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm Dữ liệu thành công",
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
                    "lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDocGia.Text) || 
                string.IsNullOrWhiteSpace(txtTenDocGia.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn 1 dòng để sửa",
                    "thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    conn.Open();
                    string query = "update DocGia set TenDocGia = @Ten , SoDienThoai = @Sdt " +
                        "Where MaDocGia = @Ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", txtMaDocGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", txtTenDocGia.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sdt", txtSDT.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Cập nhật thành công",
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
                int MaDocGia = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["MaDocGia"].Value);
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from DocGia where MaDocGia = @Ma", conn);
                    cmd.Parameters.AddWithValue("@Ma", MaDocGia);
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
                LoadData();
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
                txtMaDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
                txtTenDocGia.Text = row.Cells["TenDocGia"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            }
        }
    }
}
