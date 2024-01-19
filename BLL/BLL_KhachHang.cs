using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_KhachHang
    {
        public static void ThemKhachhang(KhachHang khachhang)
        {
            DAL_KhachHang.ThemKhachhang(khachhang);
        }
        public static void UpdateInfo(KhachHang khachhang)
        {
            DAL_KhachHang.UpdateInfo(khachhang);

        }
        public static void XoaKhachhang(KhachHang khachhang)
        {
            DAL_KhachHang.XoaKhachhang(khachhang);
        }
        public static SqlCommand getDataCustomer(string search, SqlConnection cn)
        {
            return DAL_KhachHang.getDataKhachHang(search, cn);
        }
        
        public static SqlDataReader LoadCustomer(string search)
        {
            SqlConnection cn = DbConnectionData.HamKetNoi();
            cn.Open();
            SqlCommand cm = BLL_KhachHang.getDataCustomer(search, cn);
            SqlDataReader dr = cm.ExecuteReader();
            return dr;
        }    

        public static string GetTenKhachHang(string idKhachHang)
        {
            return DAL_KhachHang.GetTenKhachHang(idKhachHang);
        }
    }
}
