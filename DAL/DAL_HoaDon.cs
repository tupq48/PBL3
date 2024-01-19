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
    public class DAL_HoaDon
    {

        public static string AutoIdHoaDon()
        {
            string id = "";
            SqlConnection conn = DbConnectionData.HamKetNoi();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("AutoIdHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                object obj = cmd.ExecuteScalar();
                id = obj.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở autoidhoadon trong dalhoadon");
                //throw;
            }

            return id;

        }

        public static void ThemHoaDon(HoaDon hoaDon)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            conn.Open();
            try
            {
                string SQL = string.Format("insert into HoaDon(IdHoaDon,IdKhachHang,IdTaiKhoan,NgayDatHang, TongTien) "
                    + "VALUES (@IdHoaDon,@IdKhachHang,@IdTaiKhoan,@NgayDatHang, @TongTien)");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdHoaDon", SqlDbType.Char).Value = hoaDon.IdHoaDon;
                cmd.Parameters.Add("@IdKhachHang", SqlDbType.Char).Value = hoaDon.IdKhachHang;
                cmd.Parameters.Add("@IdTaiKhoan", SqlDbType.Char).Value = hoaDon.IdTaiKhoan;
                cmd.Parameters.Add("@NgayDatHang", SqlDbType.DateTime).Value = hoaDon.NgayDatHang;
                cmd.Parameters.Add("@TongTien", SqlDbType.Int).Value = hoaDon.TongTien;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở dal nhan vien hàm themhoadon trong dalhoadon");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void ThemHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            SqlConnection conn = DbConnectionData.HamKetNoi();
            conn.Open();
            try
            {
                string SQL = string.Format("insert into HoaDonChiTiet(IdHoaDon,IdThuCung,SoLuongThuCung,ThanhTien) "
                    + "VALUES (@IdHoaDon,@IdThuCung,@SoLuongThuCung,@ThanhTien)");
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.Add("@IdHoaDon", SqlDbType.Char).Value = hdct.IdHoaDon;
                cmd.Parameters.Add("@IdThuCung", SqlDbType.Char).Value = hdct.IdThuCung;
                cmd.Parameters.Add("@SoLuongThuCung", SqlDbType.Int).Value = hdct.SoLuongThuCung;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = hdct.ThanhTien;

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("lỗi ở dal nhan vien hàm themhoadonchitiet trong dalhoadon");
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
