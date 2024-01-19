using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string idTaiKhoan;
        private string tenDangNhap;
        private string matKhau;
        private string quyenTruyCap;
        private bool taiKhoanBiKhoa; 
        public TaiKhoan()
        {
        }
        public TaiKhoan(string tenDangNhap, string matKhau)
        {
            TenDangNhap=tenDangNhap;
            MatKhau=matKhau;
        }
        public TaiKhoan(string idTaiKhoan, string tenDangNhap, string matKhau, string quyenTruyCap, bool taiKhoanBiKhoa)
        {
            IdTaiKhoan=idTaiKhoan;
            TenDangNhap=tenDangNhap;
            MatKhau=matKhau;
            QuyenTruyCap=quyenTruyCap;
            TaiKhoanBiKhoa = taiKhoanBiKhoa;
        }

        public string IdTaiKhoan
        {
            get { return idTaiKhoan; }
            set { idTaiKhoan = value; }
        }

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string QuyenTruyCap
        {
            get { return quyenTruyCap; }
            set { quyenTruyCap = value; }
        }
        public bool TaiKhoanBiKhoa
        {
            get { return taiKhoanBiKhoa; }
            set { taiKhoanBiKhoa = value; }
        }
    }
}
