namespace ASSQuanLyThuVien
{
    partial class FrmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyTaiKhoan));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.dtpNgaySinh = new Sunny.UI.UIDatetimePicker();
            this.txtMatKhau = new Sunny.UI.UITextBox();
            this.cboVaiTro = new Sunny.UI.UIComboBox();
            this.txtHoTen = new Sunny.UI.UITextBox();
            this.txtTaiKhoan = new Sunny.UI.UITextBox();
            this.txtSDT = new Sunny.UI.UITextBox();
            this.txtMaNhanVien = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.DataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.btnLamMoi = new Sunny.UI.UIButton();
            this.btnXoa = new Sunny.UI.UIButton();
            this.btnCapNhat = new Sunny.UI.UIButton();
            this.btnThem = new Sunny.UI.UIButton();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.btnTimKiem = new Sunny.UI.UIButton();
            this.txtTimKiem = new Sunny.UI.UITextBox();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(432, 33);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(210, 36);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Quản lý tài khoản";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dtpNgaySinh);
            this.uiGroupBox1.Controls.Add(this.txtMatKhau);
            this.uiGroupBox1.Controls.Add(this.cboVaiTro);
            this.uiGroupBox1.Controls.Add(this.txtHoTen);
            this.uiGroupBox1.Controls.Add(this.txtTaiKhoan);
            this.uiGroupBox1.Controls.Add(this.txtSDT);
            this.uiGroupBox1.Controls.Add(this.txtMaNhanVien);
            this.uiGroupBox1.Controls.Add(this.uiLabel8);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 83);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1049, 192);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Thông tin tài khoản";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.DateFormat = "dd-MM-yyyy";
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpNgaySinh.Location = new System.Drawing.Point(493, 83);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaySinh.MaxLength = 10;
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpNgaySinh.Size = new System.Drawing.Size(211, 29);
            this.dtpNgaySinh.SymbolDropDown = 61555;
            this.dtpNgaySinh.SymbolNormal = 61555;
            this.dtpNgaySinh.SymbolSize = 24;
            this.dtpNgaySinh.TabIndex = 10;
            this.dtpNgaySinh.Text = "31-03-2025";
            this.dtpNgaySinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 3, 31, 14, 27, 31, 825);
            this.dtpNgaySinh.Watermark = "";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatKhau.Location = new System.Drawing.Point(840, 83);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.ShowText = false;
            this.txtMatKhau.Size = new System.Drawing.Size(189, 29);
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMatKhau.Watermark = "";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DataSource = null;
            this.cboVaiTro.FillColor = System.Drawing.Color.White;
            this.cboVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboVaiTro.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboVaiTro.Items.AddRange(new object[] {
            "Admin",
            "ThuThu"});
            this.cboVaiTro.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboVaiTro.Location = new System.Drawing.Point(125, 83);
            this.cboVaiTro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboVaiTro.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboVaiTro.Size = new System.Drawing.Size(237, 29);
            this.cboVaiTro.SymbolSize = 24;
            this.cboVaiTro.TabIndex = 9;
            this.cboVaiTro.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboVaiTro.Watermark = "";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(493, 34);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(5);
            this.txtHoTen.ShowText = false;
            this.txtHoTen.Size = new System.Drawing.Size(211, 29);
            this.txtHoTen.TabIndex = 8;
            this.txtHoTen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtHoTen.Watermark = "";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTaiKhoan.Location = new System.Drawing.Point(840, 35);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiKhoan.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Padding = new System.Windows.Forms.Padding(5);
            this.txtTaiKhoan.ShowText = false;
            this.txtTaiKhoan.Size = new System.Drawing.Size(189, 29);
            this.txtTaiKhoan.TabIndex = 8;
            this.txtTaiKhoan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTaiKhoan.Watermark = "";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSDT.Location = new System.Drawing.Point(125, 133);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(5);
            this.txtSDT.ShowText = false;
            this.txtSDT.Size = new System.Drawing.Size(579, 29);
            this.txtSDT.TabIndex = 8;
            this.txtSDT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSDT.Watermark = "";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaNhanVien.Location = new System.Drawing.Point(125, 33);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNhanVien.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaNhanVien.ShowText = false;
            this.txtMaNhanVien.Size = new System.Drawing.Size(237, 29);
            this.txtMaNhanVien.TabIndex = 7;
            this.txtMaNhanVien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaNhanVien.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(733, 86);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 23);
            this.uiLabel8.TabIndex = 6;
            this.uiLabel8.Text = "Mật khẩu";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(10, 136);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(108, 23);
            this.uiLabel7.TabIndex = 5;
            this.uiLabel7.Text = "SĐT";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(386, 86);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 4;
            this.uiLabel6.Text = "Ngày sinh";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(386, 36);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 3;
            this.uiLabel5.Text = "Họ tên";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(733, 36);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 2;
            this.uiLabel4.Text = "Tài khoản";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(10, 86);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(108, 23);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "Vai trò";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(10, 36);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(108, 23);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "Mã nhân viên";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.DataGridView1);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(13, 285);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(1049, 288);
            this.uiGroupBox2.TabIndex = 3;
            this.uiGroupBox2.Text = "Danh sách tài khoản";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.SelectedIndex = -1;
            this.DataGridView1.Size = new System.Drawing.Size(1049, 256);
            this.DataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.btnLamMoi);
            this.uiGroupBox3.Controls.Add(this.btnXoa);
            this.uiGroupBox3.Controls.Add(this.btnCapNhat);
            this.uiGroupBox3.Controls.Add(this.btnThem);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(13, 581);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(729, 106);
            this.uiGroupBox3.TabIndex = 4;
            this.uiGroupBox3.Text = "Công cụ";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(558, 47);
            this.btnLamMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(394, 47);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCapNhat.Location = new System.Drawing.Point(235, 47);
            this.btnCapNhat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(70, 47);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.btnTimKiem);
            this.uiGroupBox4.Controls.Add(this.txtTimKiem);
            this.uiGroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(750, 581);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(312, 106);
            this.uiGroupBox4.TabIndex = 5;
            this.uiGroupBox4.Text = "Tìm kiếm";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(9, 68);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(295, 35);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(9, 32);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.ShowText = false;
            this.txtTimKiem.Size = new System.Drawing.Size(295, 29);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Watermark = "";
            // 
            // FrmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 701);
            this.Controls.Add(this.uiGroupBox4);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyTaiKhoan_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UITextBox txtHoTen;
        private Sunny.UI.UITextBox txtTaiKhoan;
        private Sunny.UI.UITextBox txtSDT;
        private Sunny.UI.UITextBox txtMaNhanVien;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtMatKhau;
        private Sunny.UI.UIComboBox cboVaiTro;
        private Sunny.UI.UIDataGridView DataGridView1;
        private Sunny.UI.UIButton btnLamMoi;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIButton btnCapNhat;
        private Sunny.UI.UIButton btnThem;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIButton btnTimKiem;
        private Sunny.UI.UITextBox txtTimKiem;
        private Sunny.UI.UIDatetimePicker dtpNgaySinh;
    }
}