namespace ASSQuanLyThuVien
{
    partial class FrmOpttion
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
            this.pnLeft = new Sunny.UI.UIPanel();
            this.btnFont = new Sunny.UI.UIButton();
            this.btnColor = new Sunny.UI.UIButton();
            this.btnPassword = new Sunny.UI.UIButton();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.pnLeft.Controls.Add(this.btnPassword);
            this.pnLeft.Controls.Add(this.btnColor);
            this.pnLeft.Controls.Add(this.btnFont);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnLeft.Location = new System.Drawing.Point(3, 64);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(136, 335);
            this.pnLeft.TabIndex = 1;
            this.pnLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFont
            // 
            this.btnFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFont.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFont.ForeColor = System.Drawing.Color.Black;
            this.btnFont.Location = new System.Drawing.Point(3, 17);
            this.btnFont.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFont.Name = "btnFont";
            this.btnFont.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnFont.Size = new System.Drawing.Size(130, 35);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Font";
            this.btnFont.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(3, 65);
            this.btnColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnColor.Name = "btnColor";
            this.btnColor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnColor.Size = new System.Drawing.Size(130, 35);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnPassword
            // 
            this.btnPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPassword.ForeColor = System.Drawing.Color.Black;
            this.btnPassword.Location = new System.Drawing.Point(3, 117);
            this.btnPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnPassword.Size = new System.Drawing.Size(130, 35);
            this.btnPassword.TabIndex = 2;
            this.btnPassword.Text = "Password";
            this.btnPassword.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // FrmOpttion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 402);
            this.Controls.Add(this.pnLeft);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmOpttion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opttion";
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnLeft;
        private Sunny.UI.UIButton btnPassword;
        private Sunny.UI.UIButton btnColor;
        private Sunny.UI.UIButton btnFont;
    }
}