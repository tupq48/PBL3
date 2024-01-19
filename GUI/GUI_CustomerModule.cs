using BLL;
using DAL;
using DTO;
using GUI;
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

namespace GUI
{
    public partial class GUI_CustomerModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        CSDL dbcon = new CSDL();
        string title = "Pet Shop Management System";
        public string idKhachHang;
        bool check = false;
        GUI_Customer customer;
        GUI_CashCustomer cashcustomer;
        int piv = 0;
        public GUI_CustomerModule(GUI_Customer form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            customer = form;
        }
        public GUI_CustomerModule(GUI_CashCustomer form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            cashcustomer = form;
            piv = 1;
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn đăng ký khách hàng này không? ", " Đăng ký khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        KhachHang khachhang;
                        idKhachHang = DAL_KhachHang.AutoIdKhachHang();
                        khachhang = new KhachHang(idKhachHang, txtName.Text, txtPhone.Text, txtGmail.Text, txtAddress.Text);
                        BLL_KhachHang.ThemKhachhang(khachhang);
                        MessageBox.Show("Khách hàng đã được đăng ký thành công!", "Đăng ký khách hàng");
                        Clear();
                        if (piv == 0)
                        {
                            customer.LoadCustomer();
                            this.Dispose();
                        }
                        else
                        {
                            cashcustomer.LoadCustomer();
                            this.Dispose();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn Chỉnh sửa bản ghi này không? ", "Chỉnh sửa hồ sơ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        KhachHang khachhang;
                        khachhang = new KhachHang(idKhachHang, txtName.Text, txtPhone.Text, txtGmail.Text, txtAddress.Text);
                        BLL_KhachHang.UpdateInfo(khachhang);

                        MessageBox.Show("Khách hàng đã được đăng ký thành công!", "Chỉnh sửa hồ sơ");
                        Clear();
                        customer.LoadCustomer();
                        this.Dispose();
                    }

                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region method
        public void CheckField()
        {
            if (txtName.Text == "" | txtGmail.Text == "" | txtAddress.Text == "" | txtPhone.Text == "")
            {
                MessageBox.Show("Trường dữ liệu bắt buộc! ", "Cảnh báo");
                return;
            }

            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!!!",
                    "Lỗi");
                return;
            }
            else
            {
                try
                {
                    int.Parse(txtPhone.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập đúng SĐT!!!",
                        "Lỗi");
                    return;
                }
            }

            check = true;
        }

        public void Clear()
        {
           // txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtGmail.Clear();

            //btnSave.Enabled = true;
            //btnUpdate.Enabled = false;
        }

        #endregion method

        private void GUI_CustomerModule_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hồ sơ khách hàng này không? ", " Xóa hồ sơ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KhachHang khachhang;
                string idkhachhang = DAL_KhachHang.AutoIdKhachhang();
                khachhang = new KhachHang(idkhachhang, txtName.Text, txtPhone.Text, txtGmail.Text, txtAddress.Text);
                BLL_KhachHang.XoaKhachhang(khachhang);
                MessageBox.Show("Khách hàng đã được xóa thành công", "Xóa hồ sơ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Clear();
               
                customer.LoadCustomer();
                this.Dispose();

            }

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
