using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonChiTiet
    {
        private string idHoaDon;
        private string idThuCung;
        private int soLuongThuCung;
        private int thanhTien;

        public HoaDonChiTiet()
        {
        }
        public HoaDonChiTiet(string idHoaDon, string idThuCung, int soLuongThuCung, int thanhTien)
        {
            IdHoaDon=idHoaDon;
            IdThuCung=idThuCung;
            SoLuongThuCung=soLuongThuCung;
            ThanhTien=thanhTien;
        }
        public string IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }
        public string IdThuCung
        {
            get { return idThuCung; }
            set { idThuCung = value; }
        }
        public int SoLuongThuCung
        {
            get { return soLuongThuCung; }
            set { soLuongThuCung = value; }
        }
        public int ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
