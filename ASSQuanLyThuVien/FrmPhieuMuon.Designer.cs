namespace ASSQuanLyThuVien
{
    partial class FrmPhieuMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhieuMuon));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cboDocGia = new Sunny.UI.UIComboBox();
            this.cboNhanVien = new Sunny.UI.UIComboBox();
            this.cboTrangThaiTra = new Sunny.UI.UIComboBox();
            this.dtpNgayHetHan = new Sunny.UI.UIDatetimePicker();
            this.dptNgayMuon = new Sunny.UI.UIDatetimePicker();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.NgayMuon = new Sunny.UI.UILabel();
            this.dtpNgayTra = new Sunny.UI.UIDatetimePicker();
            this.txtGhiChu = new Sunny.UI.UITextBox();
            this.txtMaPhieu = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.ChiTietPhieuMuo = new Sunny.UI.UIGroupBox();
            this.btnXoaSach = new Sunny.UI.UIButton();
            this.btnThemSach = new Sunny.UI.UIButton();
            this.Sách = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.txtSoLuong = new Sunny.UI.UITextBox();
            this.cboSach = new Sunny.UI.UIComboBox();
            this.cboLoaiSach = new Sunny.UI.UIComboBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.btnThoat = new Sunny.UI.UIButton();
            this.btnLamMoi = new Sunny.UI.UIButton();
            this.btnXoa = new Sunny.UI.UIButton();
            this.btnCapNhat = new Sunny.UI.UIButton();
            this.btnThem = new Sunny.UI.UIButton();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.DataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiGroupBox5 = new Sunny.UI.UIGroupBox();
            this.btnTimKiem = new Sunny.UI.UIButton();
            this.txtTimKiem = new Sunny.UI.UITextBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.DataGridView2 = new Sunny.UI.UIDataGridView();
            this.uiGroupBox1.SuspendLayout();
            this.ChiTietPhieuMuo.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(390, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(295, 36);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Quản lý phiếu mượn";
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cboDocGia);
            this.uiGroupBox1.Controls.Add(this.cboNhanVien);
            this.uiGroupBox1.Controls.Add(this.cboTrangThaiTra);
            this.uiGroupBox1.Controls.Add(this.dtpNgayHetHan);
            this.uiGroupBox1.Controls.Add(this.dptNgayMuon);
            this.uiGroupBox1.Controls.Add(this.uiLabel9);
            this.uiGroupBox1.Controls.Add(this.uiLabel8);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.NgayMuon);
            this.uiGroupBox1.Controls.Add(this.dtpNgayTra);
            this.uiGroupBox1.Controls.Add(this.txtGhiChu);
            this.uiGroupBox1.Controls.Add(this.txtMaPhieu);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 72);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(896, 246);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Mã phiếu";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDocGia
            // 
            this.cboDocGia.DataSource = null;
            this.cboDocGia.FillColor = System.Drawing.Color.White;
            this.cboDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboDocGia.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboDocGia.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboDocGia.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboDocGia.Location = new System.Drawing.Point(141, 135);
            this.cboDocGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDocGia.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboDocGia.Size = new System.Drawing.Size(261, 29);
            this.cboDocGia.SymbolSize = 24;
            this.cboDocGia.TabIndex = 13;
            this.cboDocGia.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboDocGia.Watermark = "";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DataSource = null;
            this.cboNhanVien.FillColor = System.Drawing.Color.White;
            this.cboNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNhanVien.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboNhanVien.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboNhanVien.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboNhanVien.Location = new System.Drawing.Point(142, 83);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNhanVien.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboNhanVien.Size = new System.Drawing.Size(261, 29);
            this.cboNhanVien.SymbolSize = 24;
            this.cboNhanVien.TabIndex = 13;
            this.cboNhanVien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboNhanVien.Watermark = "";
            // 
            // cboTrangThaiTra
            // 
            this.cboTrangThaiTra.DataSource = null;
            this.cboTrangThaiTra.FillColor = System.Drawing.Color.White;
            this.cboTrangThaiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTrangThaiTra.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboTrangThaiTra.Items.AddRange(new object[] {
            "Chưa trả",
            "Trả rồi"});
            this.cboTrangThaiTra.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboTrangThaiTra.Location = new System.Drawing.Point(568, 133);
            this.cboTrangThaiTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTrangThaiTra.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboTrangThaiTra.Name = "cboTrangThaiTra";
            this.cboTrangThaiTra.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboTrangThaiTra.Size = new System.Drawing.Size(294, 29);
            this.cboTrangThaiTra.SymbolSize = 24;
            this.cboTrangThaiTra.TabIndex = 12;
            this.cboTrangThaiTra.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboTrangThaiTra.Watermark = "";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.DateFormat = "dd-MM-yyyy";
            this.dtpNgayHetHan.FillColor = System.Drawing.Color.White;
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpNgayHetHan.Location = new System.Drawing.Point(568, 83);
            this.dtpNgayHetHan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayHetHan.MaxLength = 10;
            this.dtpNgayHetHan.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpNgayHetHan.Size = new System.Drawing.Size(294, 29);
            this.dtpNgayHetHan.SymbolDropDown = 61555;
            this.dtpNgayHetHan.SymbolNormal = 61555;
            this.dtpNgayHetHan.SymbolSize = 24;
            this.dtpNgayHetHan.TabIndex = 8;
            this.dtpNgayHetHan.Text = "31-03-2025";
            this.dtpNgayHetHan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpNgayHetHan.Value = new System.DateTime(2025, 3, 31, 8, 51, 12, 248);
            this.dtpNgayHetHan.Watermark = "";
            // 
            // dptNgayMuon
            // 
            this.dptNgayMuon.DateFormat = "dd-MM-yyyy";
            this.dptNgayMuon.FillColor = System.Drawing.Color.White;
            this.dptNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dptNgayMuon.Location = new System.Drawing.Point(568, 33);
            this.dptNgayMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dptNgayMuon.MaxLength = 10;
            this.dptNgayMuon.MinimumSize = new System.Drawing.Size(63, 0);
            this.dptNgayMuon.Name = "dptNgayMuon";
            this.dptNgayMuon.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dptNgayMuon.Size = new System.Drawing.Size(294, 29);
            this.dptNgayMuon.SymbolDropDown = 61555;
            this.dptNgayMuon.SymbolNormal = 61555;
            this.dptNgayMuon.SymbolSize = 24;
            this.dptNgayMuon.TabIndex = 8;
            this.dptNgayMuon.Text = "31-03-2025";
            this.dptNgayMuon.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dptNgayMuon.Value = new System.DateTime(2025, 3, 31, 8, 51, 12, 248);
            this.dptNgayMuon.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(428, 186);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(100, 23);
            this.uiLabel9.TabIndex = 11;
            this.uiLabel9.Text = "Ghi chú";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(428, 136);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(133, 23);
            this.uiLabel8.TabIndex = 10;
            this.uiLabel8.Text = "Trạng thái trả";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(428, 86);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(133, 23);
            this.uiLabel7.TabIndex = 9;
            this.uiLabel7.Text = "Ngày hết hạn";
            // 
            // NgayMuon
            // 
            this.NgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NgayMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NgayMuon.Location = new System.Drawing.Point(428, 36);
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Size = new System.Drawing.Size(115, 23);
            this.NgayMuon.TabIndex = 8;
            this.NgayMuon.Text = "Ngày mượn";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.DateFormat = "dd-MM-yyyy";
            this.dtpNgayTra.FillColor = System.Drawing.Color.White;
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpNgayTra.Location = new System.Drawing.Point(141, 183);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayTra.MaxLength = 10;
            this.dtpNgayTra.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpNgayTra.Size = new System.Drawing.Size(261, 29);
            this.dtpNgayTra.SymbolDropDown = 61555;
            this.dtpNgayTra.SymbolNormal = 61555;
            this.dtpNgayTra.SymbolSize = 24;
            this.dtpNgayTra.TabIndex = 7;
            this.dtpNgayTra.Text = "31-03-2025";
            this.dtpNgayTra.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpNgayTra.Value = new System.DateTime(2025, 3, 31, 8, 51, 12, 0);
            this.dtpNgayTra.Watermark = "";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGhiChu.Location = new System.Drawing.Point(550, 183);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Padding = new System.Windows.Forms.Padding(5);
            this.txtGhiChu.ShowText = false;
            this.txtGhiChu.Size = new System.Drawing.Size(312, 29);
            this.txtGhiChu.TabIndex = 6;
            this.txtGhiChu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtGhiChu.Watermark = "";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaPhieu.Location = new System.Drawing.Point(141, 33);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPhieu.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaPhieu.ShowText = false;
            this.txtMaPhieu.Size = new System.Drawing.Size(261, 29);
            this.txtMaPhieu.TabIndex = 4;
            this.txtMaPhieu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaPhieu.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(16, 186);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 3;
            this.uiLabel5.Text = "Ngày trả";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(16, 136);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 2;
            this.uiLabel4.Text = "Đọc giả";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(16, 86);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(104, 23);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "Nhân Viên";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(16, 36);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "Mã phiếu";
            // 
            // ChiTietPhieuMuo
            // 
            this.ChiTietPhieuMuo.Controls.Add(this.btnXoaSach);
            this.ChiTietPhieuMuo.Controls.Add(this.btnThemSach);
            this.ChiTietPhieuMuo.Controls.Add(this.Sách);
            this.ChiTietPhieuMuo.Controls.Add(this.uiLabel11);
            this.ChiTietPhieuMuo.Controls.Add(this.uiLabel10);
            this.ChiTietPhieuMuo.Controls.Add(this.txtSoLuong);
            this.ChiTietPhieuMuo.Controls.Add(this.cboSach);
            this.ChiTietPhieuMuo.Controls.Add(this.cboLoaiSach);
            this.ChiTietPhieuMuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChiTietPhieuMuo.Location = new System.Drawing.Point(13, 328);
            this.ChiTietPhieuMuo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChiTietPhieuMuo.MinimumSize = new System.Drawing.Size(1, 1);
            this.ChiTietPhieuMuo.Name = "ChiTietPhieuMuo";
            this.ChiTietPhieuMuo.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.ChiTietPhieuMuo.Size = new System.Drawing.Size(625, 126);
            this.ChiTietPhieuMuo.TabIndex = 3;
            this.ChiTietPhieuMuo.Text = "Chi tiết phiếu mượn";
            this.ChiTietPhieuMuo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoaSach.Location = new System.Drawing.Point(505, 64);
            this.btnXoaSach.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(100, 35);
            this.btnXoaSach.TabIndex = 17;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThemSach.Location = new System.Drawing.Point(367, 64);
            this.btnThemSach.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(100, 35);
            this.btnThemSach.TabIndex = 14;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // Sách
            // 
            this.Sách.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Sách.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Sách.Location = new System.Drawing.Point(363, 32);
            this.Sách.Name = "Sách";
            this.Sách.Size = new System.Drawing.Size(73, 23);
            this.Sách.TabIndex = 16;
            this.Sách.Text = "Sách";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.Location = new System.Drawing.Point(16, 76);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(100, 23);
            this.uiLabel11.TabIndex = 15;
            this.uiLabel11.Text = "Số lượng";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(16, 37);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 23);
            this.uiLabel10.TabIndex = 13;
            this.uiLabel10.Text = "Loại sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Location = new System.Drawing.Point(123, 70);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(5);
            this.txtSoLuong.ShowText = false;
            this.txtSoLuong.Size = new System.Drawing.Size(206, 29);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSoLuong.Watermark = "";
            // 
            // cboSach
            // 
            this.cboSach.DataSource = null;
            this.cboSach.FillColor = System.Drawing.Color.White;
            this.cboSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSach.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboSach.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSach.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboSach.Location = new System.Drawing.Point(443, 28);
            this.cboSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSach.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboSach.Name = "cboSach";
            this.cboSach.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboSach.Size = new System.Drawing.Size(162, 29);
            this.cboSach.SymbolSize = 24;
            this.cboSach.TabIndex = 14;
            this.cboSach.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboSach.Watermark = "";
            // 
            // cboLoaiSach
            // 
            this.cboLoaiSach.DataSource = null;
            this.cboLoaiSach.FillColor = System.Drawing.Color.White;
            this.cboLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboLoaiSach.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboLoaiSach.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboLoaiSach.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboLoaiSach.Location = new System.Drawing.Point(123, 31);
            this.cboLoaiSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLoaiSach.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboLoaiSach.Name = "cboLoaiSach";
            this.cboLoaiSach.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboLoaiSach.Size = new System.Drawing.Size(206, 29);
            this.cboLoaiSach.SymbolSize = 24;
            this.cboLoaiSach.TabIndex = 13;
            this.cboLoaiSach.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboLoaiSach.Watermark = "";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.btnThoat);
            this.uiGroupBox3.Controls.Add(this.btnLamMoi);
            this.uiGroupBox3.Controls.Add(this.btnXoa);
            this.uiGroupBox3.Controls.Add(this.btnCapNhat);
            this.uiGroupBox3.Controls.Add(this.btnThem);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(917, 72);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(156, 382);
            this.uiGroupBox3.TabIndex = 4;
            this.uiGroupBox3.Text = "Công cụ";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThoat.Location = new System.Drawing.Point(28, 323);
            this.btnThoat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(28, 253);
            this.btnLamMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(28, 183);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCapNhat.Location = new System.Drawing.Point(28, 113);
            this.btnCapNhat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(28, 43);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.DataGridView1);
            this.uiGroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(13, 462);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(1060, 180);
            this.uiGroupBox4.TabIndex = 4;
            this.uiGroupBox4.Text = "Dách sách mượn";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(0, 32);
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectedIndex = -1;
            this.DataGridView1.Size = new System.Drawing.Size(1060, 148);
            this.DataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Controls.Add(this.btnTimKiem);
            this.uiGroupBox5.Controls.Add(this.txtTimKiem);
            this.uiGroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox5.Location = new System.Drawing.Point(646, 328);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox5.Size = new System.Drawing.Size(263, 126);
            this.uiGroupBox5.TabIndex = 5;
            this.uiGroupBox5.Text = "Tìm kiếm";
            this.uiGroupBox5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(19, 76);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(227, 35);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTimKiem.Click += new System.EventHandler(this.uiButton7_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(19, 37);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.ShowText = false;
            this.txtTimKiem.Size = new System.Drawing.Size(227, 30);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Watermark = "";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.DataGridView2);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(13, 650);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(1060, 180);
            this.uiGroupBox2.TabIndex = 5;
            this.uiGroupBox2.Text = "Chi tiết Danh sách mượn";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridView2
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView2.EnableHeadersVisualStyles = false;
            this.DataGridView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DataGridView2.Location = new System.Drawing.Point(0, 32);
            this.DataGridView2.Name = "DataGridView2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView2.RowTemplate.Height = 24;
            this.DataGridView2.SelectedIndex = -1;
            this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size = new System.Drawing.Size(1060, 148);
            this.DataGridView2.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DataGridView2.TabIndex = 0;
            // 
            // FrmPhieuMuon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1083, 749);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox5);
            this.Controls.Add(this.uiGroupBox4);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.ChiTietPhieuMuo);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhieuMuon_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.ChiTietPhieuMuo.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox ChiTietPhieuMuo;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboBox cboTrangThaiTra;
        private Sunny.UI.UIDatetimePicker dtpNgayHetHan;
        private Sunny.UI.UIDatetimePicker dptNgayMuon;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel NgayMuon;
        private Sunny.UI.UIDatetimePicker dtpNgayTra;
        private Sunny.UI.UITextBox txtGhiChu;
        private Sunny.UI.UITextBox txtMaPhieu;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtSoLuong;
        private Sunny.UI.UIComboBox cboSach;
        private Sunny.UI.UIComboBox cboLoaiSach;
        private Sunny.UI.UIButton btnThem;
        private Sunny.UI.UIButton btnXoaSach;
        private Sunny.UI.UIButton btnThemSach;
        private Sunny.UI.UILabel Sách;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIButton btnLamMoi;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIButton btnCapNhat;
        private Sunny.UI.UIDataGridView DataGridView1;
        private Sunny.UI.UIGroupBox uiGroupBox5;
        private Sunny.UI.UIButton btnTimKiem;
        private Sunny.UI.UITextBox txtTimKiem;
        private Sunny.UI.UIButton btnThoat;
        private Sunny.UI.UIComboBox cboDocGia;
        private Sunny.UI.UIComboBox cboNhanVien;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDataGridView DataGridView2;
    }
}