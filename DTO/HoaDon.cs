using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string idHoaDon;
        private string idKhachHang;
        private string idTaiKhoan;
        private DateTime ngayDatHang;
        private int tongTien;

        public HoaDon()
        {
        }
        public HoaDon(string idHoaDon, string idKhachHang, string idTaiKhoan, DateTime ngayDatHang, int tongTien)
        {
            IdHoaDon=idHoaDon;
            IdKhachHang=idKhachHang;
            IdTaiKhoan =idTaiKhoan;
            NgayDatHang=ngayDatHang;
            TongTien=tongTien;
        }

        public string IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }
        public string IdKhachHang
        {
            get { return idKhachHang; }
            set { idKhachHang = value; }
        }
        public string IdTaiKhoan
        {
            get { return idTaiKhoan; }
            set { idTaiKhoan = value; }
        }
        public DateTime NgayDatHang
        {
            get { return ngayDatHang; }
            set { ngayDatHang = value; }
        }
        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
