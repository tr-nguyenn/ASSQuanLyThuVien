namespace ASSQuanLyThuVien
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cboThongKe = new Sunny.UI.UIComboBox();
            this.dtpDenNgay = new Sunny.UI.UIDatetimePicker();
            this.dtpThoiGianTu = new Sunny.UI.UIDatetimePicker();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.DataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.btnThoat = new Sunny.UI.UIButton();
            this.btnLamMoi = new Sunny.UI.UIButton();
            this.btnXuatThongKe = new Sunny.UI.UIButton();
            this.btnThongKe = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(555, 41);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(323, 44);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "Thống kê và báo cáo";
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cboThongKe);
            this.uiGroupBox1.Controls.Add(this.dtpDenNgay);
            this.uiGroupBox1.Controls.Add(this.dtpThoiGianTu);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(17, 126);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1009, 305);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboThongKe
            // 
            this.cboThongKe.DataSource = null;
            this.cboThongKe.FillColor = System.Drawing.Color.White;
            this.cboThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboThongKe.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboThongKe.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboThongKe.Location = new System.Drawing.Point(236, 56);
            this.cboThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboThongKe.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboThongKe.Name = "cboThongKe";
            this.cboThongKe.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboThongKe.Size = new System.Drawing.Size(345, 29);
            this.cboThongKe.SymbolSize = 24;
            this.cboThongKe.TabIndex = 12;
            this.cboThongKe.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboThongKe.Watermark = "";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.DateFormat = "dd-MM-yyyy";
            this.dtpDenNgay.FillColor = System.Drawing.Color.White;
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDenNgay.Location = new System.Drawing.Point(236, 166);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDenNgay.MaxLength = 10;
            this.dtpDenNgay.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpDenNgay.Size = new System.Drawing.Size(345, 29);
            this.dtpDenNgay.SymbolDropDown = 61555;
            this.dtpDenNgay.SymbolNormal = 61555;
            this.dtpDenNgay.SymbolSize = 24;
            this.dtpDenNgay.TabIndex = 11;
            this.dtpDenNgay.Text = "31-03-2025";
            this.dtpDenNgay.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpDenNgay.Value = new System.DateTime(2025, 3, 31, 15, 16, 42, 346);
            this.dtpDenNgay.Watermark = "";
            // 
            // dtpThoiGianTu
            // 
            this.dtpThoiGianTu.DateFormat = "dd-MM-yyyy";
            this.dtpThoiGianTu.FillColor = System.Drawing.Color.White;
            this.dtpThoiGianTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpThoiGianTu.Location = new System.Drawing.Point(236, 112);
            this.dtpThoiGianTu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpThoiGianTu.MaxLength = 10;
            this.dtpThoiGianTu.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpThoiGianTu.Name = "dtpThoiGianTu";
            this.dtpThoiGianTu.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpThoiGianTu.Size = new System.Drawing.Size(345, 29);
            this.dtpThoiGianTu.SymbolDropDown = 61555;
            this.dtpThoiGianTu.SymbolNormal = 61555;
            this.dtpThoiGianTu.SymbolSize = 24;
            this.dtpThoiGianTu.TabIndex = 10;
            this.dtpThoiGianTu.Text = "31-03-2025";
            this.dtpThoiGianTu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpThoiGianTu.Value = new System.DateTime(2025, 3, 31, 15, 16, 42, 346);
            this.dtpThoiGianTu.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(65, 169);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(146, 23);
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.TagString = "";
            this.uiLabel4.Text = "Đến ngày";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(65, 115);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(146, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "Thời gian từ ";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(65, 56);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(146, 23);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "Thống kê theo";
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.DataGridView1);
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiCheckBoxGroup1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(17, 443);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(1224, 402);
            this.uiCheckBoxGroup1.TabIndex = 5;
            this.uiCheckBoxGroup1.Text = "Kết quả thống kê";
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.DataGridView1.Location = new System.Drawing.Point(0, 39);
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
            this.DataGridView1.SelectedIndex = -1;
            this.DataGridView1.Size = new System.Drawing.Size(1224, 363);
            this.DataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btnThoat);
            this.uiGroupBox2.Controls.Add(this.btnLamMoi);
            this.uiGroupBox2.Controls.Add(this.btnXuatThongKe);
            this.uiGroupBox2.Controls.Add(this.btnThongKe);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(1037, 126);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(204, 305);
            this.uiGroupBox2.TabIndex = 5;
            this.uiGroupBox2.Text = "Công cụ";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThoat.Location = new System.Drawing.Point(3, 185);
            this.btnThoat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(3, 135);
            this.btnLamMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(147, 35);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatThongKe
            // 
            this.btnXuatThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXuatThongKe.Location = new System.Drawing.Point(3, 85);
            this.btnXuatThongKe.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXuatThongKe.Name = "btnXuatThongKe";
            this.btnXuatThongKe.Size = new System.Drawing.Size(147, 35);
            this.btnXuatThongKe.TabIndex = 1;
            this.btnXuatThongKe.Text = "Xuất Thống kê";
            this.btnXuatThongKe.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXuatThongKe.Click += new System.EventHandler(this.btnXuatThongKe_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThongKe.Location = new System.Drawing.Point(3, 35);
            this.btnThongKe.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(147, 35);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 863);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThongKe_Load_2);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDatetimePicker dtpDenNgay;
        private Sunny.UI.UIDatetimePicker dtpThoiGianTu;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDataGridView DataGridView1;
        private Sunny.UI.UIButton btnThoat;
        private Sunny.UI.UIButton btnLamMoi;
        private Sunny.UI.UIButton btnXuatThongKe;
        private Sunny.UI.UIButton btnThongKe;
        private Sunny.UI.UIComboBox cboThongKe;
    }
}