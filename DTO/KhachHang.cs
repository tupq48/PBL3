using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string idKhachHang;
        private string hoTen;
        private string sdt;
        private string gmail;
        private string diaChi;

        public KhachHang()
        {
        }
        public KhachHang(string idKhachHang, string hoTen, string sdt, string gmail, string diaChi)
        {
            IdKhachHang=idKhachHang;
            HoTen=hoTen;
            Sdt=sdt;
            Gmail=gmail;
            DiaChi=diaChi;
        }

        public string IdKhachHang
        {
            get { return idKhachHang; }
            set { idKhachHang = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
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
    }
}
