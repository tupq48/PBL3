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
    public partial class GUI_Main : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        CSDL dbcon = new CSDL();

        int timeToChangePicture = 10; //second
        int numberOfPicture = 10; //so luong anh co trong thu muc
        //tạo dữ liệu ảnh trong panel8

        PictureBox[] pictureBox;
        int soLuongAnh = 0;
        public GUI_Main()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            btnDashboard.PerformClick();
        }

       private void resetButton()
        {
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.FillColor = Color.FromName("GradientActiveCaption");
            btnCustomer.ForeColor = Color.Black;
            btnCustomer.FillColor = Color.FromName("GradientActiveCaption");
            btnUser.ForeColor = Color.Black;
            btnUser.FillColor = Color.FromName("GradientActiveCaption");
            btnProduct.ForeColor = Color.Black;
            btnProduct.FillColor = Color.FromName("GradientActiveCaption");
            btnCash.ForeColor = Color.Black;
            btnCash.FillColor = Color.FromName("GradientActiveCaption");
            btnThongke.ForeColor = Color.Black;
            btnThongke.FillColor = Color.FromName("GradientActiveCaption");
            btnLogout.ForeColor = Color.Black;
            btnLogout.FillColor = Color.FromName("GradientActiveCaption");


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            resetButton();
            btnDashboard.ForeColor = Color.White;
            btnDashboard.FillColor = Color.DodgerBlue;

            openChildForm(new GUI_Dasboad());
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            panel5.Controls.Clear();
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            resetButton();
            btnCustomer.ForeColor = Color.White;
            btnCustomer.FillColor = Color.DodgerBlue;
            openChildForm(new GUI_Customer());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            resetButton();
            btnUser.ForeColor = Color.White;
            btnUser.FillColor = Color.DodgerBlue;
            openChildForm(new GUI_Employee());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            resetButton();
            btnProduct.ForeColor = Color.White;
            btnProduct.FillColor = Color.DodgerBlue;
            openChildForm(new GUI_Pet());
           
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            resetButton();
            btnCash.ForeColor = Color.White;
            btnCash.FillColor = Color.DodgerBlue;
            openChildForm(new GUI_Cash(this));

        }

        private void GUI_Main_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            { 
                progress.Invoke((MethodInvoker)delegate
                {
                    progress.Text = DateTime.Now.ToString("hh:mm:ss");
                    progress.Value = Convert.ToInt32(DateTime.Now.Second);
                });
            }
            catch (Exception)
            {

            }
            
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            //resetButton();
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.FillColor = Color.DodgerBlue;
            GUI_DoiMatKhau gui_doimatkhau =  new GUI_DoiMatKhau();
            gui_doimatkhau.ShowDialog();

            btnDoiMatKhau.ForeColor = Color.Black;
            btnDoiMatKhau.FillColor = Color.FromName("GradientActiveCaption");
            //resetButton();  
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            resetButton();
            btnThongke.ForeColor = Color.White;
            btnThongke.FillColor = Color.DodgerBlue;
            openChildForm(new GUI_ThongKe());

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progress_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Second % timeToChangePicture == 0)
            {
                int chieuDai = panel8.Size.Width - progress.Width;
                if (soLuongAnh != 0)
                {
                    for (int i = 0; i < soLuongAnh; i++)
                    {
                        panel8.Controls.Remove(pictureBox[i]);
                    }
                }
                soLuongAnh = chieuDai / 300;
                pictureBox = new PictureBox[soLuongAnh];

                for (int i = 0; i < soLuongAnh; i++)
                {
                    pictureBox[i] = new PictureBox();
                    pictureBox[i].Width = 300;
                    pictureBox[i].Dock = System.Windows.Forms.DockStyle.Left;
                    panel8.Controls.Add(pictureBox[i]);

                    int number = 0;
                    while (number == 0)
                    {
                        Random r = new Random();
                        number = r.Next(numberOfPicture);
                    }
                    string url = Application.StartupPath + @"\\Picture\AllPetPicture\" + number.ToString() + ".png";
                    pictureBox[i].Image = new Bitmap(url);
                    pictureBox[i].Show();
                }
            }
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            resetButton();
            btnLogout.ForeColor = Color.White;
            btnLogout.FillColor = Color.DodgerBlue;
            DialogResult dialogResult = MessageBox.Show("Bạn xác nhận đăng xuất?", "Đăng xuất tài khoản", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                GUI_Login gui_Login = new GUI_Login();
                gui_Login.ShowDialog();
            }
        }

        private void GUI_Main_Resize(object sender, EventArgs e)
        {
            int chieuDai = panel8.Size.Width - progress.Width;
            if (soLuongAnh != 0)
            {
                for (int i = 0; i < soLuongAnh; i++)
                {
                    panel8.Controls.Remove(pictureBox[i]);
                }
            }    
            soLuongAnh = chieuDai/300;
            pictureBox = new PictureBox[soLuongAnh];
            for (int i = 0; i < soLuongAnh; i++)
            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Width = 300;
                 
                pictureBox[i].Dock = System.Windows.Forms.DockStyle.Left;
                panel8.Controls.Add(pictureBox[i]);
                
                int number = 0;
                while(number == 0)
                {
                    Random r = new Random();
                    number = r.Next(numberOfPicture);
                }    
                string url = Application.StartupPath + @"\\Picture\AllPetPicture\" + number.ToString() + ".png";
                pictureBox[i].Image = new Bitmap(url);
                pictureBox[i].Show();
                
            }
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
