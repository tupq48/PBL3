using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        public static DataTable timkiemNhanvien(String ten)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            //conn.Open();
            string sql = "Select * from NHANVIEN where HoTen LIKE N'%" + ten + "%'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable getDataNhanVien()
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("sp_GetDataNhanVien", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static string AutoIdTaiKhoan()
        {
            string id;
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AutoIdTaiKhoan", conn);
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


        public static string AutoIdNhanVien()
        {
            string id;
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AutoIdNhanVien", conn);
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
        public static void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                string SQL = string.Format("insert into TAIKHOAN(IdTaiKhoan,TenDangNhap,MatKhau,QuyenTruyCap,TaiKhoanBiKhoa) VALUES (@IdTaiKhoan,@TenDangNhap,@MatKhau,@QuyenTruyCap,@TaiKhoanBiKhoa)");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdTaiKhoan",SqlDbType.Char).Value = taiKhoan.IdTaiKhoan;
                cmd.Parameters.Add("@TenDangNhap",SqlDbType.Char).Value = taiKhoan.TenDangNhap;
                cmd.Parameters.Add("@MatKhau",SqlDbType.Char).Value = taiKhoan.MatKhau;
                cmd.Parameters.Add("@QuyenTruyCap",SqlDbType.NVarChar).Value = taiKhoan.QuyenTruyCap;
                cmd.Parameters.Add("@TaiKhoanBiKhoa",SqlDbType.Bit).Value = taiKhoan.TaiKhoanBiKhoa;

                cmd.ExecuteNonQuery();
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

        public static void ThemNhanVien(NhanVien nhanVien)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                string SQL = string.Format("insert into NHANVIEN(IdNhanVien,HoTen,NgaySinh,GioiTinh,Sdt,Gmail,DiaChi,Luong,IdTaiKhoan) VALUES (@IdNhanVien,@HoTen,@NgaySinh,@GioiTinh,@Sdt,@Gmail,@DiaChi,@Luong,@IdTaiKhoan)");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdNhanVien", SqlDbType.Char).Value = nhanVien.IdNhanVien;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanVien.HoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nhanVien.NgaySinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.GioiTinh;
                cmd.Parameters.Add("@Sdt", SqlDbType.Char).Value = nhanVien.Sdt;
                cmd.Parameters.Add("@Gmail", SqlDbType.NVarChar).Value = nhanVien.Gmail;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.DiaChi;
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = nhanVien.Luong;
                cmd.Parameters.Add("@IdTaiKhoan", SqlDbType.Char).Value = nhanVien.IdTaiKhoan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở dal nhan vien hàm themnhanvien");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool KiemTraTenDangNhap(string tenDangNhap)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT TenDangNhap FROM TAIKHOAN");
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL,conn);
                SqlDataReader dtReader = cmd.ExecuteReader();
                while (dtReader.Read())
                {
                    Console.WriteLine(tenDangNhap + " " + dtReader.GetString(0));
                    if (tenDangNhap.Equals(dtReader.GetString(0)))
                        return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }    

        public static string GetTenDangNhap(string idTaiKhoan)
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
                if (row["idTaiKhoan"].ToString() == idTaiKhoan)
                    return row["TenDangNhap"].ToString();
            }
            conn.Close();
            return "Error!!!";
        }

        public static string GetIdTaiKhoanNhanVien(string idNhanVien)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();


            string SQL = string.Format("SELECT * FROM NhanVien");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["IdNhanVien"].ToString() == idNhanVien)
                    return row["IdTaiKhoan"].ToString();
            }
            conn.Close();
            return "Admin";
        }

        public static string GetMatKhau(string idTaiKhoan)
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
                if (row["idTaiKhoan"].ToString() == idTaiKhoan)
                    return row["MatKhau"].ToString();
            }
            conn.Close();
            return "Error!!!";
        }

        public static string GetIdTaiKhoan(string tenDangNhap)
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
                if (row["TenDangNhap"].ToString() == tenDangNhap)
                    return row["IdTaiKhoan"].ToString();
            }
            conn.Close();
            return "Error!!!";
        }

        public static string GetIdNhanVien(string idTaiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT * FROM NhanVien");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row["IdTaiKhoan"].ToString() == idTaiKhoan)
                    return row["IdNhanVien"].ToString();
            }
            conn.Close();
            return DAL_Login.tk.IdTaiKhoan;
            // trả về admin nếu ko tìm thấy trong bảng nhân viên
        }

        public static bool KiemTraTaiKhoanNhanVien(TaiKhoan taiKhoan, NhanVien nhanVien)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT * FROM NHANVIEN");
            conn.Open();
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bool existTaiKhoan = false;
            bool existNhanVien = false;
            foreach (DataRow row in dt.Rows)
            {
                if (row["IdTaiKhoan"].ToString() == nhanVien.IdTaiKhoan)
                {
                    DateTime dateTime = Convert.ToDateTime(row["NgaySinh"].ToString());
                    if (row["IdNhanVien"].ToString() == nhanVien.IdNhanVien &&
                        row["HoTen"].ToString() == nhanVien.HoTen &&
                        dateTime == nhanVien.NgaySinh &&
                        row["GioiTinh"].ToString() == nhanVien.GioiTinh &&
                        row["Sdt"].ToString() == nhanVien.Sdt &&
                        row["Gmail"].ToString() == nhanVien.Gmail &&
                        row["DiaChi"].ToString() == nhanVien.DiaChi &&
                        int.Parse(row["Luong"].ToString()) == nhanVien.Luong &&
                        row["IdTaiKhoan"].ToString() == nhanVien.IdTaiKhoan)
                    {
                        existNhanVien = true;
                        break;
                    }
                }
            }
            
            string SQL1 = string.Format("SELECT * FROM TAIKHOAN");
            SqlCommand cmd1 = new SqlCommand(SQL1, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                if (row["IdTaiKhoan"].ToString() == taiKhoan.IdTaiKhoan)
                {
                    if (row["TenDangNhap"].ToString() == taiKhoan.TenDangNhap &&
                        row["MatKhau"].ToString() == taiKhoan.MatKhau)
                    {
                        existTaiKhoan = true;
                        break;
                    }
                }
            }
            
            return (existTaiKhoan && existNhanVien);


        }

        public static void DeleteTaiKhoanNhanVien(TaiKhoan taiKhoan, NhanVien nhanVien)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL1 = string.Format("DELETE FROM NHANVIEN WHERE IdTaiKhoan = '" + nhanVien.IdTaiKhoan+"'");
            SqlCommand cmd1 = new SqlCommand(SQL1, conn);
            try
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
            string SQL2 = string.Format("DELETE FROM TAIKHOAN WHERE IdTaiKhoan = '" + taiKhoan.IdTaiKhoan + "'");
            SqlCommand cmd2 = new SqlCommand(SQL2, conn);
            try
            {
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public static bool KiemTraIdTaiKhoan(string idTaiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT IdTaiKhoan FROM TAIKHOAN");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                SqlDataReader dtReader = cmd.ExecuteReader();
                while (dtReader.Read())
                {
                    if (idTaiKhoan.Equals(dtReader.GetString(0)))
                        return true;
                }
            }
            catch (Exception ex)
            { 
                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public static void UpdateTaiKhoanNhanVien(TaiKhoan taiKhoan, NhanVien nhanVien)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
             try
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update NHANVIEN set HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, Sdt=@Sdt, Gmail=@Gmail, DiaChi=@DiaChi, Luong=@Luong " 
                    + "where IdTaiKhoan=@IdTaiKhoan", conn);
                cmd2.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanVien.HoTen;
                cmd2.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nhanVien.NgaySinh;
                cmd2.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.GioiTinh;
                cmd2.Parameters.Add("@Sdt", SqlDbType.Char).Value = nhanVien.Sdt;
                cmd2.Parameters.Add("@Gmail", SqlDbType.NVarChar).Value = nhanVien.Gmail;
                cmd2.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.DiaChi;
                cmd2.Parameters.Add("@Luong", SqlDbType.Int).Value = nhanVien.Luong;
                cmd2.Parameters.Add("@IdTaiKhoan", SqlDbType.Char).Value = nhanVien.IdTaiKhoan;
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
            string SQL1 = string.Format("UPDATE TAIKHOAN SET TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, TaiKhoanBiKhoa = @tkbk WHERE IdTaiKhoan = @IdTaiKhoan");
            SqlCommand cmd1 = new SqlCommand(SQL1, conn);
            try
            {
                conn.Open();
                cmd1.Parameters.Add("@IdTaiKhoan", SqlDbType.Char).Value = taiKhoan.IdTaiKhoan;
                cmd1.Parameters.Add("@TenDangNhap", SqlDbType.Char).Value = taiKhoan.TenDangNhap;
                cmd1.Parameters.Add("@MatKhau", SqlDbType.Char).Value = taiKhoan.MatKhau;
                cmd1.Parameters.Add("@tkbk", SqlDbType.Bit).Value = taiKhoan.TaiKhoanBiKhoa;
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public static string GetTenNhanVien(string idTaiKhoan)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            string SQL = string.Format("SELECT * FROM NhanVien");
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
