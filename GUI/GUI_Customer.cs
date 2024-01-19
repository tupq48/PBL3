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
    public partial class GUI_Customer : Form
    {
        public GUI_Customer()
        {
            InitializeComponent();
            LoadCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_CustomerModule module = new GUI_CustomerModule(this);
            module.ShowDialog();
        }
        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                GUI_CustomerModule module = new GUI_CustomerModule(this);
                module.idKhachHang = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtGmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {

                GUI_CustomerModule module = new GUI_CustomerModule(this);
                module.txtName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtGmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();

                module.txtName.Enabled = false;
                module.txtPhone.Enabled = false;
                module.txtGmail.Enabled = false;
                module.txtAddress.Enabled = false;
                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = false;
                module.btnCancel.Enabled = true;
                module.ShowDialog();

            }
            LoadCustomer();
        }
        
        public void LoadCustomer()
        {
            dgvCustomer.Rows.Clear();
            int i = 0;
            string search = tbSearch.Text;
            SqlDataReader dr = BLL_KhachHang.LoadCustomer(search);
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
        }
    }
}
