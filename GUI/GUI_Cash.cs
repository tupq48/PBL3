
using BLL;
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
    public partial class GUI_Cash : Form
    {
        //SqlConnection cn = new SqlConnection();
        //SqlCommand cm;
        //CSDL dbcon = new CSDL();
        //SqlDataReader dr;

        string title = "Pet Shop Management System";
        GUI_Main main;
        public GUI_Cash(GUI_Main form)
        {
            InitializeComponent();
            //cn = DbConnectionData.HamKetNoi();
            main = form;
        }

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCash.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                try
                {
                    dgvCash.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "dgvCash_CellContentClick");
                }
            }
            else if (colName == "Increase")
            {
                int row = e.RowIndex;
                int column = 4;
                int soLuong = int.Parse(dgvCash.Rows[row].Cells[column].Value.ToString());
                string idThuCung = dgvCash.Rows[row].Cells[2].Value.ToString();

                if (soLuong >= BLL_Cash.Instance.GetSoLuongThuCungConLai(idThuCung)) 
                {                 
                    MessageBox.Show("Số lượng thú cưng trong kho đã đạt tối đa!", "Lỗi");
                }
                else
                {
                    dgvCash.Rows[row].Cells[column].Value = soLuong + 1;
                    dgvCash.Rows[row].Cells[6].Value = (soLuong + 1)* int.Parse( dgvCash.Rows[row].Cells[5].Value.ToString());
                }        
            }
            else if (colName == "Decrease")
            {
                int row = e.RowIndex;
                int column = 4;
                int soLuong = int.Parse(dgvCash.Rows[row].Cells[column].Value.ToString());
                string idThuCung = dgvCash.Rows[row].Cells[2].Value.ToString();
                if (soLuong <= 1)
                {
                }
                else
                {
                    dgvCash.Rows[row].Cells[column].Value = soLuong - 1;
                    dgvCash.Rows[row].Cells[6].Value = (soLuong - 1) * int.Parse(dgvCash.Rows[row].Cells[5].Value.ToString());
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_CashProduct product = new GUI_CashProduct(this);
            product.ShowDialog();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (dgvCash.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có dữ liệu để tạo, vui lòng thêm ít nhất 1 thú cưng vào hóa đơn", "Lỗi");
                return;
            }    

            GUI_CashCustomer gui_customer = new GUI_CashCustomer(this);
            gui_customer.ShowDialog();
            if (dgvCash.Rows[0].Cells["IdKhachHang"].Value.ToString() == "")
            {
                return;
            }    

            //add data vào database từ dgvCash
            DialogResult dialogResult = MessageBox.Show("Xác nhận hóa đơn?", "Xác nhận!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            string idHoaDon = BLL_Cash.Instance.AutoIdHoaDon();
            string idKhachHang = "";
            string tenDangNhapHienTai = BLL_Cash.Instance.GetTenDangNhapHienTai();
            string idTaiKhoan = BLL_Cash.Instance.GetIdTaiKhoan(tenDangNhapHienTai);
            DateTime datetime = DateTime.Today;
            int tongTien = 0;
            foreach (DataGridViewRow dgvr in dgvCash.Rows)
            {
                try
                {
                    idKhachHang = dgvr.Cells[7].Value.ToString();
                    tongTien += int.Parse(dgvr.Cells[6].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "btnCash_Click");
                }
            }
            try
            {
                BLL_Cash.Instance.ThemHoaDon(idHoaDon, idKhachHang, idTaiKhoan, datetime, tongTien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi trong gui_cash");
            }

            try
            {
                string idThuCung;
                int soLuongThuCung;
                int thanhTien;
                foreach (DataGridViewRow dgvr in dgvCash.Rows)
                {
                    idThuCung = dgvr.Cells[2].Value.ToString();
                    soLuongThuCung = int.Parse(dgvr.Cells[4].Value.ToString());
                    thanhTien = int.Parse(dgvr.Cells[6].Value.ToString());

                    BLL_Cash.Instance.ThemHoaDonChiTiet(idHoaDon, idThuCung, soLuongThuCung, thanhTien);
                }
            }
            catch (Exception)
            {
                
            }


            MessageBox.Show("Đã thêm hóa đơn thành công!", "Thành công!");
            dgvCash.Rows.Clear();

        }

        private void GUI_Cash_Load(object sender, EventArgs e)
        {

        }

        private void dgvCash_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dgvCash_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblTotal.Text = TinhTongTien().ToString();
        }

        private void dgvCash_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotal.Text = TinhTongTien().ToString();
        }

        private void dgvCash_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotal.Text = TinhTongTien().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private int TinhTongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow item in dgvCash.Rows)
            {
                tongTien = tongTien + int.Parse(item.Cells["TongTien"].Value.ToString());
            }
            return tongTien;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }

}
