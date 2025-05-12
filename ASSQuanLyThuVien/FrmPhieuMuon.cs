using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSQuanLyThuVien
{
    public partial class FrmPhieuMuon : Form
    {
        public string connectString = @"Data Source=NGUYENNTTD01427\SQLEXPRESS01;Initial Catalog=QuanLyThuVien3;Integrated Security=True;TrustServerCertificate=True";
        public FrmPhieuMuon()
        {
            InitializeComponent();
        }

        private void FrmPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadData();

            // Kiểm tra và đặt tiêu đề cho DataGridView1
            if (DataGridView1.Columns.Count > 0)
            {
                DataGridView1.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
                DataGridView1.Columns["MaNhanVien"].HeaderText = "Mã Nhân viên";
                DataGridView1.Columns["MaDocGia"].HeaderText = "Mã đọc gải";
                DataGridView1.Columns["NgayMuon"].HeaderText = "Ngày mượn";
                DataGridView1.Columns["NgayHetHan"].HeaderText = "Ngày hết hạn";
                DataGridView1.Columns["TrangThaiTra"].HeaderText = "Trạng thái trả";
                DataGridView1.Columns["NgayTra"].HeaderText = "Ngày trả";
                DataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
            }
            else
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu cho DataGridView1.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Kiểm tra và đặt tiêu đề cho DataGridView2
            if (DataGridView2.Columns.Count > 0)
            {
                DataGridView2.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
                DataGridView2.Columns["MaSach"].HeaderText = "Mã sách";
                DataGridView2.Columns["SoLuong"].HeaderText = "Số Lượng";
            }
            else
            {
                MessageBox.Show(
                    "Không thể tải dữ liệu cho DataGridView2.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string query = "SELECT * FROM PhieuMuon; SELECT * FROM ChiTietPhieuMuon";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // Sử dụng DataSet để chứa kết quả của cả hai truy vấn
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Gán dữ liệu cho DataGridView1 (bảng PhieuMuon)
                    if (ds.Tables.Count > 0)
                    {
                        DataGridView1.DataSource = ds.Tables[0]; // Bảng đầu tiên: PhieuMuon
                    }

                    // Gán dữ liệu cho DataGridView2 (bảng ChiTietPhieuMuon)
                    if (ds.Tables.Count > 1)
                    {
                        DataGridView2.DataSource = ds.Tables[1]; // Bảng thứ hai: ChiTietPhieuMuon
                    }
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
            // Xóa TextBox
            txtMaPhieu.Text = "";
            txtGhiChu.Text = "";
            txtSoLuong.Text = ""; // Nếu control này tồn tại

            // Xóa lựa chọn trong ComboBox
            cboNhanVien.SelectedIndex = -1;
            cboDocGia.SelectedIndex = -1;
            cboTrangThaiTra.SelectedIndex = -1;

            // Đặt lại DateTimePicker về ngày hiện tại
            dptNgayMuon.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
        }
        private void SearchData(string keyword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string query = "SELECT * FROM PhieuMuon WHERE MaPhieu LIKE @Keyword OR MaNhanVien LIKE @Keyword" +
                        " OR MaDocGia LIKE @Keyword OR NgayMuon LIKE @Keyword OR TrangThaiTra LIKE @Keyword OR NgayTra LIKE @Keyword OR GhiChu LIKE @Keyword";
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
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text)||string.IsNullOrWhiteSpace(cboDocGia.Text)
                ||string.IsNullOrWhiteSpace(cboNhanVien.Text) || string.IsNullOrWhiteSpace(cboTrangThaiTra.Text))
            {
                MessageBox.Show(
                    "Vui lòng điền đầy đủ thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            try
            {
                using(SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string query = "Insert into PhieuMuon (MaPhieu, MaNhanVien, MaDocGia, NgayMuon, NgayHetHan, TrangThaiTra, NgayTra, GhiChu)" +
                        "values( @MaPhieu, @MaNhanVien, @MaDocGia, @NgayMuon, @NgayHetHan, @TrangThaiTra, @NgayTra, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhieu", txtMaPhieu.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cboNhanVien.Text);
                    cmd.Parameters.AddWithValue("@MaDocGia", cboDocGia.Text);
                    cmd.Parameters.AddWithValue("@NgayMuon", dptNgayMuon.Value);
                    cmd.Parameters.AddWithValue("@NgayHetHan", dtpNgayHetHan.Value);
                    cmd.Parameters.AddWithValue("@TrangThaiTra", cboTrangThaiTra.Text);
                    cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Value);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Thêm Dữ liệu thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearBang();
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGhiChu.Text) ||
                string.IsNullOrWhiteSpace(txtMaPhieu.Text))
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
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string query = "update PhieuMuon set MaNhanVien = @MaNhanVien, MaDocGia = @MaDocGia, NgayMuon = @NgayMuon, NgayHetHan = @NgayHetHan" +
                        ", TrangThaiTra = @TrangThaiTra, NgayTra = @NgayTra, GhiChu = @GhiChu where MaPhieu = @MaPhieu";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhieu", txtMaPhieu.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cboNhanVien.Text);
                    cmd.Parameters.AddWithValue("@MaDocGia", cboDocGia.Text);
                    cmd.Parameters.AddWithValue("@NgayMuon", dptNgayMuon.Text);
                    cmd.Parameters.AddWithValue("@NgayHetHan", dtpNgayHetHan.Text);
                    cmd.Parameters.AddWithValue("@TrangThaiTra", cboTrangThaiTra.Text);
                    cmd.Parameters.AddWithValue("@NgayTra", dtpNgayTra.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Thay đổi Dữ liệu thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearBang();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                int MaPhieu = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["MaPhieu"].Value);
                using(SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from PhieuMuon where MaPhieu = @MaPhieu", conn);
                    cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Xóa Thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadData();
                    ClearBang();
                }
            }else if(DataGridView1.SelectedRows.Count == 0)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSach.Text) || string.IsNullOrWhiteSpace(cboSach.Text)
                || string.IsNullOrWhiteSpace(txtSoLuong.Text) )
            {
                MessageBox.Show(
                    "Vui lòng điền đầy đủ thông tin",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    string query = "Insert into ChiTietPhieuMuon(MaPhieu,MaSach,SoLuong)"+
                        " Values(@MaPhieu,@MaSach,@SoLuong)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhieu", cboLoaiSach.Text);
                    cmd.Parameters.AddWithValue("@MaSach", cboSach.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                        "Thêm Dữ liệu thành công",
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

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (DataGridView2.SelectedRows.Count > 0)
            {
                int MaPhieu = Convert.ToInt32(DataGridView2.SelectedRows[0].Cells["MaPhieu"].Value);
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from ChiTietPhieuMuon where MaPhieu = @MaPhieu", conn);
                    cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
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

        private void uiButton7_Click(object sender, EventArgs e)
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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                cboDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
                cboNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                cboTrangThaiTra.Text = row.Cells["TrangThaiTra"].Value.ToString();
                dtpNgayHetHan.Text = row.Cells["NgayHetHan"].Value.ToString();
                dtpNgayTra.Text = row.Cells["NgayTra"].Value.ToString();
                dptNgayMuon.Text = row.Cells["NgayMuon"].Value.ToString();

                DataGridViewRow rows = DataGridView2.Rows[e.RowIndex];
                cboLoaiSach.Text = rows.Cells["MaPhieu"].Value.ToString();
                cboSach.Text = rows.Cells["MaSach"].Value.ToString();
                txtSoLuong.Text = rows.Cells["SoLuong"].Value.ToString();
            }
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
