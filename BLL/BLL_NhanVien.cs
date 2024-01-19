using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NhanVien
    {
        public static DataTable timkiemNhanvien(String ten)
        {
            return DAL_NhanVien.timkiemNhanvien(ten);
        }
        public static DataTable getAllNhanVien()
        {
            return DAL_NhanVien.getDataNhanVien();
        }

        public static void ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            DAL_NhanVien.ThemTaiKhoan(taiKhoan);
        }

        public static void ThemNhanVien(NhanVien nhanVien)
        {
            DAL_NhanVien.ThemNhanVien(nhanVien);
        }

        public static string AutoIdTaiKhoan()
        {
            return DAL_NhanVien.AutoIdTaiKhoan();
        }
        
        public static string AutoIdNhanVien()
        {
            return DAL_NhanVien.AutoIdNhanVien();
        }

        public static bool KiemTraTenDangNhap(string tenDangNhap)
        {
            return DAL_NhanVien.KiemTraTenDangNhap(tenDangNhap);

        }

        public static string GetTenDangNhap(string idTaiKhoan)
        {
            return DAL_NhanVien.GetTenDangNhap( idTaiKhoan);
        }

        public static string GetMatKhau(string idTaiKhoan)
        {
            return DAL_NhanVien.GetMatKhau( idTaiKhoan);
        }

        public static string GetIdTaiKhoan(string tenDangNhap)
        {
            return DAL_NhanVien.GetIdTaiKhoan(tenDangNhap);
        }

        public static string GetIdNhanVien(string idTaiKhoan)
        {
            return DAL_NhanVien.GetIdNhanVien(idTaiKhoan);
        }

        public static bool KiemTraTaiKhoanNhanVien(TaiKhoan taiKhoan, NhanVien nhanVien)
        {
            return DAL_NhanVien.KiemTraTaiKhoanNhanVien(taiKhoan, nhanVien);
        }

        public static void DeleteTaiKhoanNhanVien(TaiKhoan taiKhoan, NhanVien nhanVien)
        {
            DAL_NhanVien.DeleteTaiKhoanNhanVien(taiKhoan, nhanVien);
        }

        public static bool KiemTraIdTaiKhoan(string idTaiKhoan)
        {
            return DAL_NhanVien.KiemTraIdTaiKhoan(idTaiKhoan);
        }

        public static void UpdateTaiKhoanNhanVien(TaiKhoan taiKhoan, NhanVien nhanVien)
        {
            DAL_NhanVien.UpdateTaiKhoanNhanVien(taiKhoan, nhanVien);
        }
           
        public static string GetTenNhanVien(string idTaiKhoan)
        {
            return DAL_NhanVien.GetTenNhanVien(idTaiKhoan);
        }
    }
}
