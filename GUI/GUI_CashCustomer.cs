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
    public partial class GUI_CashCustomer : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        CSDL dbcon = new CSDL();
        SqlDataReader dr;
        string title = "Pet Shop Management System";
        GUI_Cash cash;
        public GUI_CashCustomer(GUI_Cash form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            cash = form;
            LoadCustomer();
        }

        private void dgvCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Choice")
            {
                SqlConnection conn = new SqlConnection();
                conn = DbConnectionData.HamKetNoi();
                string idKH = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                conn.Open();
                int index = 0;
                foreach (DataGridViewRow dr in cash.dgvCash.Rows)
                {
                    dr.Cells[7].Value = idKH;   
                }   
                this.Dispose();
                conn.Close();
            }
        }
        public void LoadCustomer()
        {

            try
            {
                int i = 0;
                dgvCustomer.Rows.Clear();
                cm = new SqlCommand("SELECT IdKhachHang,HoTen,Sdt FROM KHACHHANG WHERE HoTen LIKE '%" + txtSearch.Text + "%'", cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_CustomerModule module = new GUI_CustomerModule(this);
            module.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}
