using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        public static string GetQuyenTruyCap(TaiKhoan taiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();


            string SQL = string.Format("SELECT * FROM TAIKHOAN");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["TenDangNhap"].ToString() == taiKhoan.TenDangNhap)
                    return row["QuyenTruyCap"].ToString();
            }
            conn.Close();
            return "Error!!!";
        }

        public static void DoiMatKhau(TaiKhoan taiKhoan, string matKhau)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update TAIKHOAN set MatKhau =@MatKhau "
                    + "where IdTaiKhoan=@IdTaiKhoan", conn);
                cmd2.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = matKhau;
                cmd2.Parameters.Add("@IdTaiKhoan", SqlDbType.Char).Value = taiKhoan.IdTaiKhoan;
                cmd2.ExecuteNonQuery();

                DAL_Login.tk.MatKhau = matKhau;
                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool TaiKhoanBiKhoa(string idTaiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            bool ktra = true;

            string SQL = string.Format("SELECT * FROM TAIKHOAN");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["IdTaiKhoan"].ToString() == idTaiKhoan)
                    return  bool.Parse(row["TaiKhoanBiKhoa"].ToString());
            }
            conn.Close();
            return ktra;
        }

        public static void KhoaTaiKhoan(TaiKhoan taiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update TAIKHOAN set TaiKhoanBiKhoa =@tkbk "
                    + "where IdTaiKhoan=@IdTaiKhoan", conn);
                cmd2.Parameters.Add("@tkbk", SqlDbType.NVarChar).Value = true;
                cmd2.Parameters.Add("@IdTaiKhoan", SqlDbType.Char).Value = taiKhoan.IdTaiKhoan;
                cmd2.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
