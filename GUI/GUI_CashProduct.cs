using DAL;
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
    public partial class GUI_CashProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        CSDL dbcon = new CSDL();
        SqlDataReader dr;
        string title = "Pet Shop Management System";
        public string uname;
        GUI_Cash cash;
        public GUI_CashProduct(GUI_Cash form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            cash = form;
            LoadProduct();
        }

        private void btnCashh_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow dr in dgvProduct.Rows)
            {
                
                bool chkbox = Convert.ToBoolean(dr.Cells["Select"].Value);
                if (chkbox)
                {
                    try
                    {

                        //kiem tra đã tồn tại thú cưng đã chọn hay chưa
                        bool check = false;
                        foreach (DataGridViewRow item in cash.dgvCash.Rows)
                        {
                            if (item.Cells["IdThuCung"].Value.ToString() == dr.Cells["IdThuCung"].Value.ToString())
                            {
                                check = true;
                                break;
                            }
                        }

                        if (check)
                            continue;
                        i++;
                        //lấy tên nhân viên
                        string idThuNgan = DAL_NhanVien.GetIdTaiKhoan(DAL_Login.tk.TenDangNhap);
                        

                        //add data vào dgvCash -- dgvCash thong qua cash.dgvCash
                        cash.dgvCash.Rows.Add(i, i.ToString(),
                                            dr.Cells[1].Value.ToString(),
                                            dr.Cells[3].Value.ToString(),
                                            1,
                                            Convert.ToDecimal(dr.Cells[4].Value.ToString()),
                                            Convert.ToDecimal(dr.Cells[4].Value.ToString()), 
                                            "",
                                            idThuNgan); 
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, title);
                    }
                }
            }

            //cash.loadCash();
            this.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        #region Method

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT IdThuCung, IdLoai, TenGiong, GiaBan, MoTa FROM THUCUNG WHERE CONCAT(IdThuCung,IdLoai,TenGiong) LIKE '%" + txtSearch.Text + "%' AND SoLuongConLai > " + 0 + "", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }
        #endregion Method

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
