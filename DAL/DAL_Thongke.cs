using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Thongke
    {
        public static DataTable getDataHD()
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("SELECT ISNULL(SUM(SoLuongThuCung),0) AS SoLuongThuCung,  ISNULL(SUM(TongTien),0) AS TongTien FROM HOADON inner join HOADONCHITIET ON HOADON.IdHoaDon = HOADONCHITIET.IdHoaDon WHERE IdTaiKhoan = 'TK0001'", conn);
           // sqlCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable ThongKeTatCa(DateTime beginDate, DateTime endDate)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("ThongKeTatCa", conn);
            sqlCommand.Parameters.Add(new SqlParameter("@beginDate", beginDate));
            sqlCommand.Parameters.Add(new SqlParameter("@endDate", endDate));


            sqlCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable ThongKeTheoTaiKhoan( string idNhanVien , DateTime beginDate, DateTime endDate)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("ThongKeTheoTaiKhoan", conn);
            sqlCommand.Parameters.Add(new SqlParameter("@idTaiKhoan", DAL_NhanVien.GetIdTaiKhoanNhanVien(idNhanVien)));
            sqlCommand.Parameters.Add(new SqlParameter("@beginDate", beginDate));
            sqlCommand.Parameters.Add(new SqlParameter("@endDate", endDate));

            sqlCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable ThongKeTheoThuCung(string idThuCung, DateTime beginDate, DateTime endDate)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("ThongKeTheoThuCung", conn);
            sqlCommand.Parameters.Add(new SqlParameter("@idThuCung", idThuCung));
            sqlCommand.Parameters.Add(new SqlParameter("@beginDate", beginDate));
            sqlCommand.Parameters.Add(new SqlParameter("@endDate", endDate));

            sqlCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable ThongKeTheoTaiKhoanVaThuCung(string idNhanVien, string idThuCung, DateTime beginDate, DateTime endDate)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("ThongKeTheoTaiKhoanVaThuCung", conn);
            sqlCommand.Parameters.Add(new SqlParameter("@idTaiKhoan", DAL_NhanVien.GetIdTaiKhoanNhanVien(idNhanVien)));
            sqlCommand.Parameters.Add(new SqlParameter("@idThuCung", idThuCung));
            sqlCommand.Parameters.Add(new SqlParameter("@beginDate", beginDate));
            sqlCommand.Parameters.Add(new SqlParameter("@endDate", endDate));

            sqlCommand.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable GetDataNhanVien()
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("select * from NhanVien", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable GetDataThuCung()
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            SqlCommand sqlCommand = new SqlCommand("select * from ThuCung", conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
    

}
