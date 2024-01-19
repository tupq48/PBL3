
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
    public partial class GUI_ThongKe : Form
    {
        public GUI_ThongKe()
        {
            InitializeComponent();
            Load();
        }

        private void dgvThongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void Load()
        {
            cbThuCung.Items.Add("--All--");
            cbNhanVien.Items.Add("--All--");

            DataTable dt = new DataTable();
            dt = BLL_ThongKe.Instance.GetDataNhanVien();
            foreach (DataRow item in dt.Rows)
                cbNhanVien.Items.Add(item["IdNhanVien"].ToString());
            dt = BLL_ThongKe.Instance.GetDataThuCung();
            foreach (DataRow item in dt.Rows)
                cbThuCung.Items.Add(item["IdThuCung"].ToString());

            cbNhanVien.SelectedIndex = 0;
            cbNhanVien.Text = cbNhanVien.Items[0].ToString();
            cbThuCung.SelectedIndex = 0;
            cbThuCung.Text = cbThuCung.Items[0].ToString();

            dtBeginDate.Value = DateTime.Parse("1/1/2022");
        }

        private void cbThuCung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThuCung.SelectedIndex != 0)
                if (rbtAll.Checked == true) rbtAll.Checked = false;
            if (cbNhanVien.SelectedIndex == 0 && cbThuCung.SelectedIndex == 0)
                rbtAll.Checked = true;

        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhanVien.SelectedIndex != 0)
                if (rbtAll.Checked == true) rbtAll.Checked = false;
            if (cbNhanVien.SelectedIndex == 0 && cbThuCung.SelectedIndex == 0)
                rbtAll.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAll.Checked == true)
            {
                cbNhanVien.SelectedIndex = 0;
                cbNhanVien.Text = cbNhanVien.Items[0].ToString();
                cbThuCung.SelectedIndex = 0;
                cbThuCung.Text = cbThuCung.Items[0].ToString();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvThongke.Rows.Clear();
            DateTime beginDate = dtBeginDate.Value;
            DateTime endDate = dtEndDate.Value;
            string idThuCung = "";
            string idNhanVien = "";
            string idHoaDon;
            string nguoiBan;
            string khachHang;
            DateTime ngayMua;
            string thuCung;
            int soLuongMua;
            int tongTien;

            DataTable dt;

            if (cbNhanVien.SelectedIndex != 0) idNhanVien = cbNhanVien.SelectedItem.ToString();
            if (cbThuCung.SelectedIndex != 0) idThuCung = cbThuCung.SelectedItem.ToString();

            if (rbtAll.Checked == true)
                dt = BLL_ThongKe.Instance.ThongKeTatCa(beginDate, endDate);
            else
            {
                if(cbNhanVien.SelectedIndex == 0)
                {
                    dt = BLL_ThongKe.Instance.ThongKeTheoThuCung(idThuCung, beginDate, endDate);
                }    
                else 
                if (cbThuCung.SelectedIndex == 0)
                {
                    dt = BLL_ThongKe.Instance.ThongKeTheoTaiKhoan(idNhanVien, beginDate, endDate);
                }   
                else
                {
                    dt = BLL_ThongKe.Instance.ThongKeTheoTaiKhoanVaThuCung(idNhanVien, idThuCung, beginDate, endDate);
                }    
            }    

            int index = 0;
            string idHoaDonTemp = "";
            foreach (DataRow item in dt.Rows)
            { 
                idHoaDon = item[0].ToString(); 
                nguoiBan = BLL_NhanVien.GetTenNhanVien(item[1].ToString());
                khachHang = BLL_KhachHang.GetTenKhachHang(item[2].ToString());
                ngayMua = DateTime.Parse(item[3].ToString());
                thuCung = BLL_ThuCung.GetTenThuCung(item[4].ToString());
                soLuongMua =  int.Parse(item[5].ToString());
                tongTien = int.Parse(item[6].ToString());

                if (idHoaDonTemp != idHoaDon)
                {
                    index++;
                    dgvThongke.Rows.Add(index, idHoaDon, nguoiBan, khachHang, ngayMua, thuCung, soLuongMua, tongTien);
                    idHoaDonTemp = idHoaDon;
                }
                else
                {
                    dgvThongke.Rows.Add("", idHoaDon, nguoiBan, khachHang, ngayMua, thuCung, soLuongMua, tongTien);
                } 
            }
        }
    }
}
