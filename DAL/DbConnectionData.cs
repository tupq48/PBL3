using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbConnectionData
    {
        //tú
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SLK41LB\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True");
        //hiệu   
        //protected SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True");
        //tiến
        // protected  SqlConnection conn = new SqlConnection();
        public static SqlConnection HamKetNoi()
        {
            //hiệu
            //string connectionSTR = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
            //tú
            string connectionSTR = @"Data Source=DESKTOP-SLK41LB\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
            //tiến
            /// SqlConnection conn = new SqlConnection();
            SqlConnection conn = new SqlConnection(connectionSTR);
            return conn;
        }
    }
}
