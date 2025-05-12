using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ASSQuanLyThuVien
{
    public partial class FrmSetting : Form
    {
        private FrmMain _mainForm;

        public FrmSetting(FrmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void SetFontForAllControls(Control parent, FontStyle style)
        {
            foreach (Control control in parent.Controls)
            {
                // Xử lý các control là button, label, group box
                if (control is Sunny.UI.UIButton uiButton)
                {
                    uiButton.Font = new Font(uiButton.Font, style);
                }
                else if (control is Button normalButton)
                {
                    normalButton.Font = new Font(normalButton.Font, style);
                }
                else if (control is Label label)
                {
                    label.Font = new Font(label.Font, style);
                }
                else if (control is Sunny.UI.UIGroupBox uiGroupBox)
                {
                    uiGroupBox.Font = new Font(uiGroupBox.Font, style);
                    // Duyệt qua các control con trong GroupBox
                    SetFontForAllControls(uiGroupBox, style);
                }
                // Nếu control là container khác, tiếp tục duyệt
                else if (control.HasChildren)
                {
                    SetFontForAllControls(control, style);
                }
            }
        }
        private void SetUnderlineForButtons(Control parent, bool underline)
        {
            foreach (Control control in parent.Controls)
            {
                // Chỉ xử lý các nút (button)
                if (control is Sunny.UI.UIButton uiButton)
                {
                    Font currentFont = uiButton.Font;
                    FontStyle newStyle = underline ? (currentFont.Style | FontStyle.Underline) : (currentFont.Style & ~FontStyle.Underline);
                    uiButton.Font = new Font(currentFont, newStyle);
                }
                else if (control is Button normalButton)
                {
                    Font currentFont = normalButton.Font;
                    FontStyle newStyle = underline ? (currentFont.Style | FontStyle.Underline) : (currentFont.Style & ~FontStyle.Underline);
                    normalButton.Font = new Font(currentFont, newStyle);
                }
                // Nếu control là container, tiếp tục duyệt
                else if (control.HasChildren)
                {
                    SetUnderlineForButtons(control, underline);
                }
            }
        }
        private void SetInNghienForButtons(Control parent, bool inNghien)
        {
            foreach(Control control in parent.Controls)
            {
                if(control is Sunny.UI.UIButton uiButton)
                {
                    Font currentFont = uiButton.Font;
                    FontStyle nemStyle = inNghien ? (currentFont.Style | FontStyle.Italic) : (currentFont.Style & ~FontStyle.Italic);
                    uiButton.Font = new Font (currentFont, nemStyle);
                }else if(control is Button normalButton)
                {
                    Font currentFont = normalButton.Font;
                    FontStyle nemStyle = inNghien ? (currentFont.Style | FontStyle.Italic) : (currentFont.Style & ~FontStyle.Italic);
                    normalButton.Font = new Font(currentFont, nemStyle);
                }else if (control.HasChildren)
                {
                    SetInNghienForButtons(control, inNghien);
                }
            }
        }

        private void swInDam_ValueChanged(object sender, bool value)
        {
            if (_mainForm != null) // Sử dụng _mainForm thay vì Program.MainForm
            {
                if (value) // In đậm
                {
                    SetFontForAllControls(_mainForm, FontStyle.Bold);
                }
                else // Trở về bình thường
                {
                    SetFontForAllControls(_mainForm, FontStyle.Regular);
                }
            }
            else
            {
                MessageBox.Show("Form chính chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void swGachChan_ValueChanged(object sender, bool value)
        {
            if (_mainForm != null) // Đảm bảo FrmMain tồn tại
            {
                if (value) // Gạch chân
                {
                    SetUnderlineForButtons(_mainForm, true);
                }
                else // Bỏ gạch chân
                {
                    SetUnderlineForButtons(_mainForm, false);
                }
            }
            else
            {
                MessageBox.Show("Form chính chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void swInNghieng_ValueChanged(object sender, bool value)
        {
            if(_mainForm != null)
            {
                if (value)
                {
                    SetInNghienForButtons(_mainForm, true);
                }
                else
                {
                    SetInNghienForButtons (_mainForm, false);
                }
            }
            else
            {
                MessageBox.Show("Form chính chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }
    }
}