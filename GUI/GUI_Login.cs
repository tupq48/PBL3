using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace GUI
{
    public partial class GUI_Login : Form
    {
        public GUI_Login()
        {
            InitializeComponent();
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {

        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                //lưu tài khoản đăng nhập vào dal_login để còn biết tài khoản nào đã đăng nhập
                BLL_Login.Instance.LuuThongTinDangNhap(txttk.Text, txtmk.Text);

                string _name = "";                          //tên người đăng nhập
                string _role = BLL_Login.Instance.GetQuyenTruyCap();   

                if (BLL_Login.Instance.TaiKhoanTonTai(txttk.Text, txtmk.Text))
                {
                    string idTaiKhoanDangNhap = BLL_Login.Instance.GetIdTaiKhoanDangNhap();
                    if (BLL_TaiKhoan.Instance.TaiKhoanBiKhoa(idTaiKhoanDangNhap))
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khóa, vui lòng liên hệ với Admin để có thể mở khóa.", "Tài khoản bị khóa");
                        txttk.Focus();
                        return;
                    }
                    if (_role == "Nhân viên")
                    {
                        _name = BLL_NhanVien.GetTenNhanVien(idTaiKhoanDangNhap);
                    }
                    
                    GUI_Main main = new GUI_Main();
                    main.lblUserName.Text = _name; 
                    main.lblRole.Text = _role;

                    if (_role == "Nhân viên")
                    {
                        main.btnUser.Enabled = false;
                        main.btnThongke.Enabled = false;
                    }

                    this.Hide();
                    this.Close();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txttk.Text = "";
                    txtmk.Text = "";
                    txttk.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtmk_TextChanged(object sender, EventArgs e)
        {
        }


        private void txtmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnlogin_Click(sender, e);
        }

        private void txttk_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
