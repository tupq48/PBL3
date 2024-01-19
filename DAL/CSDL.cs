using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CSDL
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;


        public string connection()
        {
            //hiệu
            //con = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
            //tú
            con = @"Data Source=DESKTOP-SLK41LB\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";
            //tiến
            //con = 
            return con;
        }

        public void executeQuery(string sql)
        {
            try
            {
                cn.ConnectionString = connection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
            }

        }
    }
}
