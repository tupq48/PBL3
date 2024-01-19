using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class GUI_Employee : Form
    {
        GUI_EmployeeModule module = null;
        BLL_NhanVien Bll_emp = new BLL_NhanVien();


        public GUI_Employee()
        {
            InitializeComponent();
            module = new GUI_EmployeeModule(this);
        }

        void Danhstt()
        {
            if (dgvNhanVien.RowCount > 1)
            {
                for (int i = 1; i <= dgvNhanVien.RowCount; i++)
                {
                    //Nếu cột đầu tiên (checkbok) tồn tại
                    if (dgvNhanVien.Rows[i-1].Cells[1].Value != null)
                    {
                        dgvNhanVien.Rows[i-1].Cells[0].Value=i;
                    }
                }
            }
        }
        private void dgvThuCung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvNhanVien.Columns[e.ColumnIndex].Name;
            module = new GUI_EmployeeModule(this);
            //   int row = e.RowIndex;
            if (colName == "Edit")
            {
                try
                {
                    module =new GUI_EmployeeModule(this);
                    try
                    {
                        int index = e.RowIndex;
                        DataGridViewRow selectedRow = dgvNhanVien.Rows[index];
                        module.txtHoTen.Text = selectedRow.Cells["HoTen"].Value.ToString();
                        module.dtNgaySinh.Value = (DateTime)selectedRow.Cells["NgaySinh"].Value;
                        module.cbGioiTinh.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                        module.txtSDT.Text = selectedRow.Cells["Sdt"].Value.ToString();
                        module.txtGmail.Text = selectedRow.Cells["Gmail"].Value.ToString();
                        module.txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                        module.txtLuong.Text = selectedRow.Cells["Luong"].Value.ToString();
                        string idTaiKhoan = selectedRow.Cells["IdTaiKhoan"].Value.ToString();
                        module.cbChucVu.Text= "Nhân viên";
                        module.txtTaiKhoan.Text = BLL_NhanVien.GetTenDangNhap(idTaiKhoan);
                        module.txtMatKhau.Text = BLL_NhanVien.GetMatKhau(idTaiKhoan);
                        //module.cbKhoaTaiKhoan.Text = DAL_TaiKhoan.TaiKhoanBiKhoa(idTaiKhoan) ? "True" : "False";
                        module.cbKhoaTaiKhoan.Text = BLL_TaiKhoan.Instance.TaiKhoanBiKhoa(idTaiKhoan) ? "True" : "False";

                    }
                    catch (Exception ex)
                    {
                    }

                    module.btnSave.Enabled = false;
                    module.btnUpdate.Enabled = true;
                    module.butReset.Enabled = true;
                    module.ShowDialog();
                    Danhstt();

                }
                catch (Exception)
                {
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            module = new GUI_EmployeeModule(this);
            module.txtHoTen.Text = "";
            module.dtNgaySinh.Value = DateTime.Now;
            module.cbGioiTinh.Text = "";
            module.txtSDT.Text = "";
            module.txtGmail.Text = "";
            module.txtDiaChi.Text = "";
            module.txtLuong.Text = "";
            string idTaiKhoan = "";
            module.txtTaiKhoan.Text = "";
            module.txtMatKhau.Text = "";
            module.cbKhoaTaiKhoan.Text = "";
            module.btnSave.Enabled = true;
            module.btnUpdate.Enabled = false;
            //    module.btnDelete.Enabled = false;
            module.butReset.Enabled = true;
            module.ShowDialog();
            Danhstt();

        }

        private void GUI_Employee_Load(object sender, EventArgs e)
        {

            dgvNhanVien.DataSource= BLL_NhanVien.getAllNhanVien();
            // so thu tu
            Danhstt();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String ten = txtSearch.Text;
            dgvNhanVien.DataSource = BLL_NhanVien.timkiemNhanvien(ten);
            Danhstt();
        }
    }
}
