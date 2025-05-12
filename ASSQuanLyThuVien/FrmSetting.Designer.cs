namespace ASSQuanLyThuVien
{
    partial class FrmSetting
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.swInNghieng = new Sunny.UI.UISwitch();
            this.swGachChan = new Sunny.UI.UISwitch();
            this.swInDam = new Sunny.UI.UISwitch();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.swInNghieng);
            this.uiGroupBox1.Controls.Add(this.swGachChan);
            this.uiGroupBox1.Controls.Add(this.swInDam);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(17, 17);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 39, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1399, 234);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Font";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(26, 137);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(94, 23);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "In nghiêng";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(26, 87);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(94, 23);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "Gạch chân";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(26, 41);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(65, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "In đậm";
            // 
            // swInNghieng
            // 
            this.swInNghieng.ActiveText = "Bật";
            this.swInNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.swInNghieng.InActiveText = "Tắt";
            this.swInNghieng.Location = new System.Drawing.Point(125, 131);
            this.swInNghieng.MinimumSize = new System.Drawing.Size(1, 1);
            this.swInNghieng.Name = "swInNghieng";
            this.swInNghieng.Size = new System.Drawing.Size(75, 29);
            this.swInNghieng.TabIndex = 2;
            this.swInNghieng.Text = "uiSwitch3";
            this.swInNghieng.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.swInNghieng_ValueChanged);
            // 
            // swGachChan
            // 
            this.swGachChan.ActiveText = "Bật";
            this.swGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.swGachChan.InActiveText = "Tắt";
            this.swGachChan.Location = new System.Drawing.Point(125, 81);
            this.swGachChan.MinimumSize = new System.Drawing.Size(1, 1);
            this.swGachChan.Name = "swGachChan";
            this.swGachChan.Size = new System.Drawing.Size(75, 29);
            this.swGachChan.TabIndex = 1;
            this.swGachChan.Text = "uiSwitch2";
            this.swGachChan.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.swGachChan_ValueChanged);
            // 
            // swInDam
            // 
            this.swInDam.ActiveText = "Bật";
            this.swInDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.swInDam.InActiveText = "Tắt";
            this.swInDam.Location = new System.Drawing.Point(125, 35);
            this.swInDam.MinimumSize = new System.Drawing.Size(1, 1);
            this.swInDam.Name = "swInDam";
            this.swInDam.Size = new System.Drawing.Size(75, 29);
            this.swInDam.TabIndex = 0;
            this.swInDam.Text = "uiSwitch1";
            this.swInDam.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.swInDam_ValueChanged);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 935);
            this.Controls.Add(this.uiGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmSetting";
            this.Text = "FrmSetting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISwitch swInNghieng;
        private Sunny.UI.UISwitch swGachChan;
        private Sunny.UI.UISwitch swInDam;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
    }
}