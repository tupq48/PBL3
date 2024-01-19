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
    public partial class GUI_Pet : Form
    {
        GUI_PetModule module = null;

        BLL_ThuCung Bll_tc = new BLL_ThuCung();
        public GUI_Pet()
        {
            InitializeComponent();
            module = new GUI_PetModule(this);
            if (BLL_Login.Instance.GetQuyenTruyCap() == "Nhân viên")
            {
                btnAdd.Visible = false;
                Edit.Visible = false;
            }
        }
        void Danhstt()
        {
            if (dgvThuCung.RowCount > 1)
            {
                for (int i = 1; i <= dgvThuCung.RowCount; i++)
                {
                    //Nếu cột đầu tiên (checkbok) tồn tại
                    if (dgvThuCung.Rows[i-1].Cells[1].Value != null)
                    {
                        dgvThuCung.Rows[i-1].Cells[0].Value=i;
                    }
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            module = new GUI_PetModule(this);
            module.cboNhaCungCap.DataSource = Bll_tc.LayNhaCungCap();
            module.cboLoaiThuCung.DataSource = Bll_tc.LayLoaiThuCung();
            module.txtIdThuCung.Text="";
            module.cboLoaiThuCung.Text="";
            module.txtTenGiong.Text="";
            module.txtGiaBan.Text="";
            module.txtSoLuongConLai.Text="";
            module.txtMota.Text="";
            module.cboNhaCungCap.Text="";
            module.btnSave.Enabled = true;
            module.btnUpdate.Enabled = false;
            module.butReset.Enabled = true;
            module.ShowDialog();
            Danhstt();

        }
        private void GUI_Pet_Load(object sender, EventArgs e)
        {
            dgvThuCung.DataSource= Bll_tc.getThuCung();
            Danhstt();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            String ten = txtSearch.Text;
            dgvThuCung.DataSource = Bll_tc.timkiemThuCung(ten);
            Danhstt();
        }

        private void dgvThuCung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvThuCung.Columns[e.ColumnIndex].Name;
            module = new GUI_PetModule(this);
            if (colName == "Edit")
            {
                try
                {
                    module =new GUI_PetModule(this);
                    module.cboLoaiThuCung.ResetText();
                    module.cboNhaCungCap.ResetText();
                    module.cboNhaCungCap.DataSource = Bll_tc.LayNhaCungCap();
                    module.cboLoaiThuCung.DataSource = Bll_tc.LayLoaiThuCung();

                    // Chuyển giá trị lên form
                    module.txtIdThuCung.Text = dgvThuCung.Rows[e.RowIndex].Cells["IdThuCung"].Value.ToString();
                    String tg1 = dgvThuCung.Rows[e.RowIndex].Cells["IdLoai"].Value.ToString();
                    module.cboLoaiThuCung.ResetText();
                    module.cboLoaiThuCung.Text = Bll_tc.LayTenLoaiThuCung(tg1);
                    module.txtTenGiong.Text = dgvThuCung.Rows[e.RowIndex].Cells["TenGiong"].Value.ToString();
                    module.txtSoLuongConLai.Text = dgvThuCung.Rows[e.RowIndex].Cells["SoLuongConLai"].Value.ToString();
                    module.txtGiaBan.Text = dgvThuCung.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString();
                    module.txtMota.Text = dgvThuCung.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
                    String tg2 = dgvThuCung.Rows[e.RowIndex].Cells["IdNhaCungCap"].Value.ToString();
                    module.cboNhaCungCap.Text= Bll_tc.LayTenNhaCungCap(tg2);
                    module.btnSave.Enabled = false;
                    module.btnUpdate.Enabled = true;
                    module.butReset.Enabled = true;
                    module.ShowDialog();
                    Danhstt();

                }
                catch (Exception)
                {
                    throw;
                }
                
            }
        }

        
    }
}
