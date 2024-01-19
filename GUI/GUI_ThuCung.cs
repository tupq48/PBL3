using System.Collections.Generic;
using BLL;
using DTO;
namespace GUI
{
    public partial class GUI_ThuCung : Form
    {
        BLL_ThuCung Bll_tc = new BLL_ThuCung();
        public GUI_ThuCung()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvThuCung.DataSource=Bll_tc.getThuCung();
            cboNhaCungCap.DataSource= Bll_tc.LayNhaCungCap();
            cboLoaiThuCung.DataSource=Bll_tc.LayLoaiThuCung();
            cboLoaiThuCung.Text="";
            cboNhaCungCap.Text="";
            txtTimKiem.Text="Tìm kiếm";
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            if (txtIdThuCung.Text != "" && cboLoaiThuCung.Text != "" && txtTenGiong.Text != "" &&
                txtSoLuongConLai.Text != "" && txtGiaBan.Text != "" && txtMota.Text !="" && cboNhaCungCap.Text != "")
            {
                ThuCung tc = new ThuCung(txtIdThuCung.Text, Bll_tc.LayIdLoaiThuCung(cboLoaiThuCung.Text), txtTenGiong.Text,
                Convert.ToInt32(txtSoLuongConLai.Text), Convert.ToInt32(txtGiaBan.Text), txtMota.Text, Bll_tc.LayIdNhaCungCap(cboNhaCungCap.Text));
                //MessageBox.Show(Convert.ToString(Bll_tc.themThuCung(tc)));
                // Them
                DialogResult dg = MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {

                    if (Bll_tc.themThuCung(tc))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvThuCung.DataSource = Bll_tc.getThuCung(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
              }
              else
              {
                  MessageBox.Show("Xin hãy nhập đầy đủ");
              }
        }
        private void but_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {
            if (txtIdThuCung.Text != "" && cboLoaiThuCung.Text != "" && txtTenGiong.Text != "" &&
            txtSoLuongConLai.Text != "" && txtGiaBan.Text != "" && txtMota.Text !="" && cboNhaCungCap.Text != "")
            {
                // Lấy row hiện tại
                //DataGridViewRow row = dgvThuCung.SelectedRows[0];
                //int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                ThuCung tc = new ThuCung(txtIdThuCung.Text, Bll_tc.LayIdLoaiThuCung(cboLoaiThuCung.Text), txtTenGiong.Text,
                    Convert.ToInt32(txtSoLuongConLai.Text), Convert.ToInt32(txtGiaBan.Text),txtMota.Text, Bll_tc.LayIdNhaCungCap(cboNhaCungCap.Text));
                DialogResult dg = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {

                    if (Bll_tc.suaThuCung(tc))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvThuCung.DataSource = Bll_tc.getThuCung(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
            
        }

        private void but_Xoa_Click(object sender, EventArgs e)
        {
            // Lấy row hiện tại
            // DataGridViewRow row = dgvThuCung.SelectedRows[0];
            // String ID = row.Cells[0].Value.ToString();

            String ID = txtIdThuCung.Text;
            DialogResult dg = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {

                if (Bll_tc.xoaThuCung(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvThuCung.DataSource = Bll_tc.getThuCung(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        
        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int row = e.RowIndex;

                // Chuyển giá trị lên form
                txtIdThuCung.Text = dgvThuCung.Rows[row].Cells[0].Value.ToString();
                String tg1 = dgvThuCung.Rows[row].Cells[1].Value.ToString();
                cboLoaiThuCung.Text=Bll_tc.LayTenLoaiThuCung(tg1);
                txtTenGiong.Text = dgvThuCung.Rows[row].Cells[2].Value.ToString();
                txtSoLuongConLai.Text = dgvThuCung.Rows[row].Cells[3].Value.ToString();
                txtGiaBan.Text = dgvThuCung.Rows[row].Cells[4].Value.ToString();
                txtMota.Text = dgvThuCung.Rows[row].Cells[5].ToString();
                String tg2 = dgvThuCung.Rows[row].Cells[6].Value.ToString();
                cboNhaCungCap.Text= Bll_tc.LayTenNhaCungCap(tg2);
            }
            catch (Exception)
            {

                
            }
            
        }
        // tim kiem dung combobox trong datagridview
        private void butTimKiem_Click(object sender, EventArgs e)
        {
            String ten = txtTimKiem.Text;
            dgvThuCung.DataSource = Bll_tc.timkiemThuCung(ten);
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            txtIdThuCung.Text="";
            cboLoaiThuCung.Text="";
            txtTenGiong.Text="";
            txtGiaBan.Text="";
            txtSoLuongConLai.Text="";
            txtMota.Text="";
            cboNhaCungCap.Text="";
        }
    }
}