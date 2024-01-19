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
using DTO;
using DAL;

namespace GUI
{
    public partial class GUI_NhanVien : Form
    {
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = BLL_NhanVien.getAllNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "ID";
            dgvNhanVien.Columns[1].HeaderText = "Họ Tên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns[3].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[4].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns[5].HeaderText = "Gmail";
            dgvNhanVien.Columns[6].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns[7].HeaderText = "Lương";
            dgvNhanVien.Columns[8].Visible = false;
            cbChucVu.Text = "Nhân viên";
            cbGioiTinh.Text = "Nữ";
           
           
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Equals("") ||
                txtHoTen.Text.Equals("") ||
                txtLuong.Text.Equals("") ||
                txtMatKhau.Text.Equals("") ||
                txtSDT.Text.Equals("") ||
                txtGmail.Text.Equals("") ||
                txtTaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin",
                    "Lỗi");
                return;
            }
            if (KiemTraDuLieuNhapVao() == false)
                return;

            if (KiemTraTenDangNhap(txtTaiKhoan.Text.ToString()) == false)
                return;



            DialogResult dialogResult = MessageBox.Show("Xác nhận thêm?", "Xác nhận!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            //đoạn này nên thêm 1 cái messeger box yesno để xác nhận có thêm hay không   

            TaiKhoan taiKhoan;
            String idTaiKhoan = BLL_NhanVien.AutoIdTaiKhoan();
            taiKhoan = new TaiKhoan(idTaiKhoan,txtTaiKhoan.Text, txtMatKhau.Text, cbChucVu.Text,false);
            BLL_NhanVien.ThemTaiKhoan(taiKhoan);

            string idNhanVien = BLL_NhanVien.AutoIdNhanVien();
            NhanVien nhanVien = new NhanVien(idNhanVien,
                                             txtHoTen.Text,
                                             dtNgaySinh.Value,
                                             cbGioiTinh.Text,
                                             txtSDT.Text,
                                             txtGmail.Text,
                                             txtDiaChi.Text,
                                             int.Parse(txtLuong.Text),
                                             idTaiKhoan);
            BLL_NhanVien.ThemNhanVien(nhanVien);
            dgvNhanVien.DataSource = BLL_NhanVien.getAllNhanVien();

            MessageBox.Show("Đã thêm dữ liệu thành công",
                    "Thành công!");
            Reset();

        }    
        



        private bool KiemTraDuLieuNhapVao()
        {
            bool bo = true;
            try
            {
                int.Parse(txtLuong.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đúng dữ liệu cho lương!!!",
                    "Lỗi");
                bo = false;
            }

            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!!!",
                    "Lỗi");
                bo = false;
            }
            else
            {
                try
                {
                    int.Parse(txtSDT.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập đúng SĐT!!!",
                        "Lỗi");
                    bo = false;
                }
            }    
            //cần kiểm tra thêm nhiều cái nữa
            return bo;
        }

        private bool KiemTraTenDangNhap(string tenDangNhap)
        {
            bool bo = true;
            try
            {
                bo = BLL_NhanVien.KiemTraTenDangNhap(tenDangNhap);
                if (bo == false)
                    MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập lại!", "Tài khoản đã tồn tại");
            }
            catch (Exception e)
            {
                MessageBox.Show("lỗi ở GUINhanVienCs hàm KiemTraTenDangNhap", "lỗi");
            }

            return bo;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvNhanVien.Rows[index];
                txtHoTen.Text = selectedRow.Cells[1].Value.ToString();
                dtNgaySinh.Value = (DateTime)selectedRow.Cells[2].Value;
                cbGioiTinh.Text = selectedRow.Cells[3].Value.ToString();
                txtSDT.Text = selectedRow.Cells[4].Value.ToString();
                txtGmail.Text = selectedRow.Cells[5].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells[6].Value.ToString();
                txtLuong.Text = selectedRow.Cells[7].Value.ToString();
                string idTaiKhoan = selectedRow.Cells[8].Value.ToString();
                txtTaiKhoan.Text = BLL_NhanVien.GetTenDangNhap(idTaiKhoan);
                txtMatKhau.Text = BLL_NhanVien.GetMatKhau(idTaiKhoan);
                cbKhoaTaiKhoan.Text = DAL_TaiKhoan.TaiKhoanBiKhoa(idTaiKhoan) ? "True" : "False";
                
            }
            catch (Exception ex)
            {
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
            txtGmail.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbChucVu.Text = "Nhân viên";
            cbGioiTinh.Text = "Nữ";
            dtNgaySinh.Value = DateTime.Today;
        }

        private void btnLockAccount_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan;
            string idTaiKhoan, idNhanVien;
            NhanVien nhanVien;
            bool taiKhoanBiKhoa = cbKhoaTaiKhoan.Text == "True" ? true : false;
            //try catch để ngăn trường hợp input bị null
            try
            {
                idTaiKhoan = BLL_NhanVien.GetIdTaiKhoan(txtTaiKhoan.Text);
                taiKhoan = new TaiKhoan(idTaiKhoan,
                                        txtTaiKhoan.Text,
                                        txtMatKhau.Text,
                                        cbChucVu.Text,
                                        taiKhoanBiKhoa);
                idNhanVien = BLL_NhanVien.GetIdNhanVien(idTaiKhoan);
                nhanVien = new NhanVien(idNhanVien,
                                                 txtHoTen.Text,
                                                 dtNgaySinh.Value,
                                                 cbGioiTinh.Text,
                                                 txtSDT.Text,
                                                 txtGmail.Text,
                                                 txtDiaChi.Text,
                                                 int.Parse(txtLuong.Text),
                                                 idTaiKhoan);

                //kiểm tra so khớp tài khoản và nhân viên
                if (BLL_NhanVien.KiemTraTaiKhoanNhanVien(taiKhoan, nhanVien) == false)
                {
                    MessageBox.Show("Không tìm thấy thông tin tài khoản!!!", "Lỗi");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận khóa tài khoản?", "Xác nhận!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //tiến hành khóa
                    //BLL_NhanVien.DeleteTaiKhoanNhanVien(taiKhoan,nhanVien); // cái này lúc kia là xóa
                    DAL_TaiKhoan.KhoaTaiKhoan(taiKhoan);
                    //cập nhập lại dữ liệu cho dgvNhanVien
                    dgvNhanVien.DataSource = BLL_NhanVien.getAllNhanVien();

                    //thông báo xóa thành công
                    MessageBox.Show("Đã khóa tài khoản!!!", "Thành công");
                    Reset();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!! ", "Lỗi"); 
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan;
            string idTaiKhoan, idNhanVien;
            NhanVien nhanVien;
            //try catch để ngăn trường hợp input bị null
            try
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[dgvNhanVien.CurrentCell.RowIndex];
                idTaiKhoan = selectedRow.Cells[8].Value.ToString();
                bool taiKhoanBiKhoa = cbKhoaTaiKhoan.Text == "True" ? true : false;
                taiKhoan = new TaiKhoan(idTaiKhoan,
                                        txtTaiKhoan.Text,
                                        txtMatKhau.Text,
                                        cbChucVu.Text,
                                        taiKhoanBiKhoa);
                idNhanVien = BLL_NhanVien.GetIdNhanVien(idTaiKhoan);
                nhanVien = new NhanVien(idNhanVien,
                                        txtHoTen.Text,
                                        dtNgaySinh.Value,
                                        cbGioiTinh.Text,
                                        txtSDT.Text,
                                        txtGmail.Text,
                                        txtDiaChi.Text,
                                        int.Parse(txtLuong.Text),
                                        idTaiKhoan);
                string tk = BLL_NhanVien.GetTenDangNhap(idTaiKhoan);
                if (taiKhoan.TenDangNhap != tk) //kiểm tra xem cái tên đăng nhập có thay đổi hay ko
                if (BLL_NhanVien.KiemTraTenDangNhap(taiKhoan.TenDangNhap) == false) // = false có nghĩa là đã tồn tại tên đăng nhập trong database, chỗ này hơi ngu đần xí nên phải note
                {
                    MessageBox.Show("Tài khoản đã tồn tài, vui lòng lựa chọn 1 tài khoản khác!!!", "Lỗi");
                    return;
                }
                if (BLL_NhanVien.KiemTraIdTaiKhoan(idTaiKhoan) == false)
                {
                    MessageBox.Show("Không tìm thấy thông tin tài khoản để cập nhật!!!", "Lỗi");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận sửa?", "Xác nhận!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //tiến hành cập nhập
                    BLL_NhanVien.UpdateTaiKhoanNhanVien(taiKhoan, nhanVien);

                    //cập nhập lại dữ liệu cho dgvNhanVien
                    dgvNhanVien.DataSource = BLL_NhanVien.getAllNhanVien();

                    //thông báo xóa thành công
                    MessageBox.Show("Đã cập nhật tài khoản!!!", "Thành công");
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                return;
            }
        }
    }

}
