namespace ASSQuanLyThuVien
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.grbDangNhap = new Sunny.UI.UIGroupBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnDangNhap = new FontAwesome.Sharp.IconButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.txtUser = new Sunny.UI.UITextBox();
            this.grbDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Controls.Add(this.iconPictureBox1);
            this.grbDangNhap.Controls.Add(this.pictureBox1);
            this.grbDangNhap.Controls.Add(this.btnThoat);
            this.grbDangNhap.Controls.Add(this.btnDangNhap);
            this.grbDangNhap.Controls.Add(this.uiLine1);
            this.grbDangNhap.Controls.Add(this.txtPassword);
            this.grbDangNhap.Controls.Add(this.txtUser);
            this.grbDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDangNhap.FillColor = System.Drawing.Color.White;
            this.grbDangNhap.FillColor2 = System.Drawing.Color.White;
            this.grbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbDangNhap.Location = new System.Drawing.Point(0, 0);
            this.grbDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDangNhap.MinimumSize = new System.Drawing.Size(1, 1);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grbDangNhap.Size = new System.Drawing.Size(402, 420);
            this.grbDangNhap.TabIndex = 0;
            this.grbDangNhap.Text = "Đăng nhập";
            this.grbDangNhap.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.grbDangNhap.Click += new System.EventHandler(this.grbDangNhap_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(358, 22);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ASSQuanLyThuVien.Properties.Resources._9187604;
            this.pictureBox1.Location = new System.Drawing.Point(133, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 25;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(215, 324);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 47);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnDangNhap.IconColor = System.Drawing.Color.White;
            this.btnDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangNhap.IconSize = 25;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(55, 324);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(126, 47);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Login";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.Location = new System.Drawing.Point(55, 171);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(286, 29);
            this.uiLine1.TabIndex = 7;
            this.uiLine1.Text = "Quản lý thư viện";
            // 
            // txtPassword
            // 
            this.txtPassword.ButtonFillColor = System.Drawing.Color.Red;
            this.txtPassword.ButtonStyleInherited = false;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Icon = global::ASSQuanLyThuVien.Properties.Resources.padlock;
            this.txtPassword.Location = new System.Drawing.Point(55, 275);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '◦';
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(286, 41);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUser.ButtonStyleInherited = false;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.Icon = global::ASSQuanLyThuVien.Properties.Resources.user;
            this.txtUser.Location = new System.Drawing.Point(55, 224);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(5);
            this.txtUser.ShowText = false;
            this.txtUser.Size = new System.Drawing.Size(286, 41);
            this.txtUser.TabIndex = 3;
            this.txtUser.TagString = "";
            this.txtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUser.Watermark = "Tên Tài khoản";
            // 
            // Login
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(402, 420);
            this.Controls.Add(this.grbDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grbDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox grbDangNhap;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtUser;
        private Sunny.UI.UILine uiLine1;
        private FontAwesome.Sharp.IconButton btnDangNhap;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}