using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Login
    {
        private static DAL_Login instance;
        public static DAL_Login Instance
        {
            get
            {
                if (instance == null) instance = new DAL_Login();
                return instance;
            }
        }

        //biến tài khoản dùng để lưu lại thông tin tài khoản đã đăng nhập vào
        public static TaiKhoan tk = new TaiKhoan();
        

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        CSDL dbcon = new CSDL();
        SqlDataReader dr;
        public static SqlCommand Login(TaiKhoan taikhoan, SqlCommand cm, SqlConnection conn)
        {
          // SqlConnection conn = DbConnectionData.HamKetNoi();
            conn.Open();
            cm = new SqlCommand("SELECT TenDangNhap, MatKhau FROM TAIKHOAN WHERE TenDangNhap=@name and MatKhau=@password", conn);
            cm.Parameters.AddWithValue("@name", taikhoan.TenDangNhap);
            cm.Parameters.AddWithValue("@password",taikhoan.MatKhau);
            cm.ExecuteNonQuery();
            conn.Close();
            tk = taikhoan;
            //lưu tài khoản đã đăng nhập vào
            return cm;
        }
    }
}
