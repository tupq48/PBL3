using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string idNhanVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sdt;
        private string gmail;
        private string diaChi;
        private int luong;
        private string idTaiKhoan;

        public NhanVien()
        {
        }
        public NhanVien(string idNhanVien, string hoTen, DateTime ngaySinh, string gioiTinh, string sdt, string gmail, string diaChi, int luong, string idTaiKhoan)
        {
            IdNhanVien=idNhanVien;
            HoTen=hoTen;
            NgaySinh=ngaySinh;
            GioiTinh=gioiTinh;
            Sdt=sdt;
            Gmail=gmail;
            DiaChi=diaChi;
            Luong=luong;
            IdTaiKhoan=idTaiKhoan;
        }

        public string IdNhanVien
        {
            get { return idNhanVien; }
            set { idNhanVien = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public int Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        public string IdTaiKhoan
        {
            get { return idTaiKhoan; }
            set { idTaiKhoan = value; }
        }
    }
}
