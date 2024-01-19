using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_DoiMatKhau : Form
    {
        public GUI_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtXacNhanMK.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text.Equals("") ||
                txtMatKhauMoi.Text.Equals("") ||
                txtXacNhanMK.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi!");
                clear();
                return;
            }    

            if (!BLL_Login.Instance.GetMatKhau().Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show("mật khẩu cũ không chính xác!", "Lỗi!");
                clear();
                return;
            }

            if (!txtMatKhauMoi.Text.Equals(txtXacNhanMK.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng với mật khẩu mới!", "Lỗi!");
                clear();
                return;
            }
            try
            {
                BLL_TaiKhoan.Instance.DoiMatKhau(BLL_Login.Instance.GetTaiKhoanDangNhap(), txtMatKhauMoi.Text);
                MessageBox.Show("Đổi thành công", "Thành công!");
                clear();
                this.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
