using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DashBoard
    {
        private static DAL_DashBoard instance;
        public static DAL_DashBoard Instance
        {
            get
            {
                if (instance == null) instance = new DAL_DashBoard();
                return instance;
            }
        }

        public int ExtractData(string str)
        {
            SqlConnection cn = DbConnectionData.HamKetNoi();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT ISNULL(SUM(SoLuongConLai),0) AS qty FROM THUCUNG WHERE IdLoai='" + str + "'", cn);
            int data = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return data;    
        }
    }

}
