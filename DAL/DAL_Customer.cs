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
    public class DAL_Customer
    {
        public static string AutoIdKhachHang()
        {
            string id;
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AutoIdKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                object obj = cmd.ExecuteScalar();
                id = obj.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở autoidtiakhoan trong dalnhanvien");
                throw;
            }

            return id;
        }


        public static SqlCommand getDataKhachHang(string search, SqlConnection cn)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM KHACHHANG WHERE CONCAT(IdKhachHang,HoTen,Sdt,DiaChi) LIKE N'%" + search + "%'", cn);
            return sqlCommand;
           
        }
        public static void ThemKhachhang(KhachHang khachhang)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                string SQL = string.Format("insert into KHACHHANG(IdKhachHang,HoTen,Sdt,Gmail,DiaChi) VALUES (@IdKH,@Ten,@sdt,@gmail, @dc)");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdKH", SqlDbType.Char).Value = khachhang.IdKhachHang;
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = khachhang.HoTen;
                cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = khachhang.Sdt;
                cmd.Parameters.Add("@gmail", SqlDbType.NVarChar).Value = khachhang.Gmail;
                cmd.Parameters.Add("@dc", SqlDbType.NVarChar).Value = khachhang.DiaChi;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở dal nhan vien hàm themtaikhoan");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void UpdateInfo(KhachHang khachhang)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE KHACHHANG SET HoTen=@name, Sdt=@phone,Gmail = @gmail, DiaChi=@dc WHERE IdKhachHang=@id");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = khachhang.IdKhachHang;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = khachhang.HoTen;
                cmd.Parameters.Add("@phone", SqlDbType.Char).Value = khachhang.Sdt;
                cmd.Parameters.Add("@gmail", SqlDbType.NVarChar).Value = khachhang.Gmail;
                cmd.Parameters.Add("@dc", SqlDbType.NVarChar).Value = khachhang.DiaChi;
                cmd.ExecuteNonQuery();
                conn.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở dal nhan vien hàm themtaikhoan");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void XoaKhachhang(KhachHang khachhang)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL1 = string.Format("DELETE FROM KHACHHANG WHERE IdKhachHang = '" + khachhang.IdKhachHang + "'");
            SqlCommand cmd1 = new SqlCommand(SQL1, conn);
            try
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception )
            {

                throw;
            }
        }
        public static string GetTenKhachHang(string idTaiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT * FROM KHACHHANG");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["IdTaiKhoan"].ToString() == idTaiKhoan)
                    return row["HoTen"].ToString();
            }
            conn.Close();
            return "Admin";
        }

    }
}
