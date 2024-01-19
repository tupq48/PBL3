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
using DTO;
namespace GUI
{
    public partial class GUI_PetModule : Form
    {
        BLL_ThuCung Bll_tc = new BLL_ThuCung();
        GUI_Pet pet;

        public GUI_PetModule()
        {
            InitializeComponent();
          
        }

        public GUI_PetModule(GUI_Pet _pet)
        {
            InitializeComponent();
            pet=_pet;
        }
        
        private void GUI_PetModule_Load(object sender, EventArgs e)
        {
            //dgvThuCung.DataSource=Bll_tc.getThuCung();
            //cboNhaCungCap.Text="";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( cboLoaiThuCung.Text != "" && txtTenGiong.Text != "" &&
            txtSoLuongConLai.Text != "" && txtGiaBan.Text != "" &&  cboNhaCungCap.Text != "" )
            {
                try
                {
                    string idThuCung = Bll_tc.LayIdLoaiThuCung(cboLoaiThuCung.Text.ToString());
                    string tenGiong = txtTenGiong.Text.ToString();
                    int slcl = Convert.ToInt32(txtSoLuongConLai.Text.ToString());
                    string idNCC = Bll_tc.LayIdNhaCungCap(cboNhaCungCap.Text.ToString());
                    ThuCung tc = new ThuCung(txtIdThuCung.Text.ToString(),
                                             idThuCung, 
                                             tenGiong,
                                             slcl, 
                                             Convert.ToInt32(txtGiaBan.Text.ToString()), 
                                             txtMota.Text.ToString(), 
                                             idNCC);
                    DialogResult dg = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dg == DialogResult.OK)
                    {

                        if (Bll_tc.suaThuCung(tc))
                        {
                            MessageBox.Show("Sửa thành công");
                            pet.dgvThuCung.DataSource = Bll_tc.getThuCung(); // refresh datagridview
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công");

                        }
                    }
                } 
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }

        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    String ID = txtIdThuCung.Text;
        //    DialogResult dg = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //    if (dg == DialogResult.OK)
        //    {

        //        if (Bll_tc.xoaThuCung(ID))
        //        {
        //            MessageBox.Show("Xóa thành công");
        //            pet.dgvThuCung.DataSource = Bll_tc.getThuCung(); // refresh datagridview
        //            this.Dispose();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Xóa không thành công");
        //            this.Dispose();
        //        }
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( cboLoaiThuCung.Text != "" && txtTenGiong.Text != "" &&
                txtSoLuongConLai.Text != "" && txtGiaBan.Text != ""  && cboNhaCungCap.Text != "" )
            {
                try
                {
                    string idthucung = Bll_tc.AutoIdThuCung();
                   // MessageBox.Show(idthucung);
                    ThuCung tc = new ThuCung(idthucung, Bll_tc.LayIdLoaiThuCung(cboLoaiThuCung.Text), txtTenGiong.Text,
                    Convert.ToInt32(txtSoLuongConLai.Text), Convert.ToInt32(txtGiaBan.Text), txtMota.Text, Bll_tc.LayIdNhaCungCap(cboNhaCungCap.Text));
                    //MessageBox.Show(Convert.ToString(Bll_tc.themThuCung(tc)));
                    // Them
                    DialogResult dg = MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dg == DialogResult.OK)
                    {

                        if (Bll_tc.themThuCung(tc))
                        {
                            MessageBox.Show("Thêm thành công");
                            pet.dgvThuCung.DataSource = Bll_tc.getThuCung(); // refresh datagridview
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công");

                        }
                    }
                } catch (Exception pp) { throw; }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //txtIdThuCung.Text="";
            cboLoaiThuCung.Text="";
            txtTenGiong.Text="";
            txtGiaBan.Text="";
            txtSoLuongConLai.Text="";
            txtMota.Text="";
            cboNhaCungCap.Text="";
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
