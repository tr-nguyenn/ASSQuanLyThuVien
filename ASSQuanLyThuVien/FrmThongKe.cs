using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSQuanLyThuVien
{
    public partial class FrmThongKe : Form
    {
        private string connectionString = @"Data Source=NGUYENNTTD01427\SQLEXPRESS01;Initial Catalog=QuanLyThuVien3;Integrated Security=True;TrustServerCertificate=True";

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            // Ban đầu không hiển thị gì trên DataGridView
            DataGridView1.DataSource = null;
        }

        // Cập nhật tiêu đề cột cho thống kê
        private void UpdateThongKeColumnHeaders()
        {
            if (DataGridView1.Columns.Contains("LoaiThongKe"))
            {
                DataGridView1.Columns["LoaiThongKe"].HeaderText = "Loại Thống Kê";
            }
            else if (DataGridView1.Columns.Contains("TheLoaiSach"))
            {
                DataGridView1.Columns["TheLoaiSach"].HeaderText = "Thể Loại Sách";
            }
            DataGridView1.Columns["SoLuong"].HeaderText = "Số Lượng";
        }

        // Nút Thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "";
                    if (cboThongKe.SelectedItem.ToString() == "Số lượng sách theo thể loại")
                    {
                        query = @" SELECT TheLoai.TenTheLoai, COUNT(Sach.MaSach) As SoLuong FROM TheLoai
                               INNER JOIN Sach ON TheLoai.MaTheLoai = Sach.MaTheLoai
                               GROUP BY TheLoai.TenTheLoai";
                    }
                    else if (cboThongKe.SelectedItem.ToString() == "Sách đã mượn trả")
                    {
                        query = @"SELECT TrangThaiTra, COUNT(*) AS SoLuong FROM PhieuMuon GROUP BY TrangThaiTra";
                    }
                    else if (cboThongKe.SelectedItem.ToString() == "Sách mượn nhiều nhất")
                    {
                        query = @"
                        SELECT TOP 10 s.TenSach, COUNT(ctpm.MaSach) AS SoLanMuon
                        FROM ChiTietPhieuMuon ctpm
                        JOIN Sach s ON ctpm.MaSach = s.MaSach
                        JOIN PhieuMuon pm ON ctpm.MaPhieu = pm.MaPhieu
                        WHERE pm.NgayMuon BETWEEN @from AND @to
                        GROUP BY s.TenSach
                        ORDER BY SoLanMuon DESC";
                    }
                    else if (cboThongKe.SelectedItem.ToString() == "Độc giả mượn nhiều nhất")
                    {
                        query = @"
                        SELECT TOP 10 dg.TenDocGia, COUNT(pm.MaDocGia) AS SoLanMuon
                        FROM PhieuMuon pm
                        JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia
                        WHERE pm.NgayMuon BETWEEN @from AND @to
                        GROUP BY dg.TenDocGia
                        ORDER BY SoLanMuon DESC";
                    }
                    else if (cboThongKe.SelectedItem.ToString() == "Số lượng sách mượn theo ngày")
                    {
                        query = @"
                        SELECT pm.NgayMuon, COUNT(ctpm.MaSach) AS SoLuongSachMuon
                        FROM PhieuMuon pm
                        JOIN ChiTietPhieuMuon ctpm ON pm.MaPhieu = ctpm.MaPhieu
                        WHERE pm.NgayMuon BETWEEN @from AND @to
                        GROUP BY pm.NgayMuon
                        ORDER BY pm.NgayMuon";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@from", dtpThoiGianTu.Value);
                    cmd.Parameters.AddWithValue("@to", dtpDenNgay.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    DataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Loi: " + ex.Message,
                    "Loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        // Nút Xuất thống kê ra file .txt
        private void btnXuatThongKe_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FileName = "DanhSachNhanVien.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Ghi tiêu đề cột
                        for (int i = 0; i < DataGridView1.Columns.Count; i++)
                        {
                            sw.Write(DataGridView1.Columns[i].HeaderText);
                            if (i < DataGridView1.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Ghi dữ liệu từ DataGridView
                        foreach (DataGridViewRow row in DataGridView1.Rows)
                        {
                            if (!row.IsNewRow) // Bỏ qua dòng trống cuối cùng
                            {
                                for (int i = 0; i < DataGridView1.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < DataGridView1.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                    MessageBox.Show("Xuất danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Reset DataGridView về trạng thái ban đầu (không hiển thị gì)
            DataGridView1.DataSource = null;

            // Reset các trường nhập liệu
            cboThongKe.Text = "";
            dtpThoiGianTu.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bỏ sự kiện CellContentClick vì không cần nữa
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không làm gì
        }
        //Load thống kê
        private void LoadThongKe()
        {
            cboThongKe.Items.Add("Số lượng sách theo thể loại");
            cboThongKe.Items.Add("Sách đã mượn trả");
            cboThongKe.Items.Add("Sách mượn nhiều nhất");
            cboThongKe.Items.Add("Độc giả mượn nhiều nhất");
            cboThongKe.Items.Add("Số lượng sách mượn theo ngày");
            cboThongKe.SelectedItem = 0;
        }
        private void FrmThongKe_Load_1(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmThongKe_Load_2(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}