using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Cash
    {
        private static BLL_Cash instance;
        public static BLL_Cash Instance
        {
            get
            {
                if (instance == null) instance = new BLL_Cash();
                return instance;
            }
        }

        public int GetSoLuongThuCungConLai(string idThuCung)
        {
            return DAL_ThuCung.GetSoLuongThuCungConLai(idThuCung);
        }

        public string AutoIdHoaDon()
        {
            return DAL_HoaDon.AutoIdHoaDon();
        }

        public string GetIdTaiKhoan(string tenDangNhap)
        {
            return DAL_NhanVien.GetIdTaiKhoan(tenDangNhap);
        }

        public void ThemHoaDon(string idHoaDon,string idKhachHang,string idTaiKhoan,DateTime datetime,int tongTien)
        {
            HoaDon hoaDon = new HoaDon(idHoaDon,idKhachHang,idTaiKhoan,datetime,tongTien);
            DAL_HoaDon.ThemHoaDon(hoaDon);
        }

        public void ThemHoaDonChiTiet(string idHoaDon,string idThuCung,int soLuongThuCung,int thanhTien)
        {
            HoaDonChiTiet hdct = new HoaDonChiTiet(idHoaDon, idThuCung, soLuongThuCung, thanhTien);
            DAL_HoaDon.ThemHoaDonChiTiet(hdct);
            DAL_ThuCung.UpdateSoLuongThuCung(idThuCung, soLuongThuCung);
        }

        public string GetTenDangNhapHienTai()
        {
            return DAL_Login.tk.TenDangNhap;
        }
    }
}
