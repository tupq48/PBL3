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
    public class BLL_Login
    {
        private static BLL_Login instance;
        public static BLL_Login Instance 
        {
            get
            {
                if (instance == null) instance = new BLL_Login() ;
                return instance ;
            }
        }

        public TaiKhoan GetTaiKhoanDangNhap()
        {
            return DAL_Login.tk;
        }
        public void LuuThongTinDangNhap(string tenDangNhap, string matKhau)
        {
            TaiKhoan taiKhoan = new TaiKhoan(tenDangNhap, matKhau);
            DAL_Login.tk = taiKhoan;
            DAL_Login.tk.QuyenTruyCap = DAL_TaiKhoan.GetQuyenTruyCap(DAL_Login.tk);
            DAL_Login.tk.IdTaiKhoan = DAL_NhanVien.GetIdTaiKhoan(tenDangNhap);
        }

        public bool TaiKhoanTonTai(string tk, string mk)
        {
            SqlConnection cn = DbConnectionData.HamKetNoi();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT TenDangNhap, MatKhau FROM TAIKHOAN WHERE TenDangNhap=@tk and MatKhau=@mk", cn);
            cm.Parameters.AddWithValue("@tk", tk);
            cm.Parameters.AddWithValue("@mk", mk);
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
                return true;
            return false;
        }

        public string GetQuyenTruyCap()
        {
            string quyenTruyCap = "";
            try
            {
                quyenTruyCap = DAL_Login.tk.QuyenTruyCap;
            }
            catch (Exception e)
            {
            }
            return quyenTruyCap;
        }

        public string GetIdTaiKhoanDangNhap()
        {
            string id = "";
            try
            {
                id = DAL_Login.tk.IdTaiKhoan;
            }
            catch (Exception e)
            {
            }
            return id;
        }

        public string GetTenDangNhapTaiKhoanLogin()
        {
            return DAL_Login.tk.TenDangNhap;
        }
        
        public string GetMatKhau()
        {
            return DAL_Login.tk.MatKhau;
        }
    }
}
