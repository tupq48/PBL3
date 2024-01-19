using BLL;
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
    public partial class GUI_Dasboad : Form
    {
        string title = "Pet Shop Management System";
        public GUI_Dasboad()
        {
            InitializeComponent();
        }
        public int extractData(string str)
        {
            int data = 0;
            try
            {
                data = BLL_DashBoard.Instance.ExtractData(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
            return data;
        }


        private void GUI_Dasboad_Load(object sender, EventArgs e)
        {
            lblDog.Text = extractData("LTC001").ToString();
            lblCat.Text = extractData("LTC002").ToString();
            lblbird.Text = extractData("LTC003").ToString();
            lblFish.Text = extractData("LTC005").ToString();
            lblMouse.Text = extractData("LTC004").ToString();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
