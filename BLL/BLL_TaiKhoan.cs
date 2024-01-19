using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan instance;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new BLL_TaiKhoan();
                return instance;
            }
        }

        public bool TaiKhoanBiKhoa(string idTaiKhoan)
        {
            return DAL_TaiKhoan.TaiKhoanBiKhoa(idTaiKhoan);
        }

        public void DoiMatKhau(TaiKhoan taiKhoan, string matKhau)
        {
            DAL_TaiKhoan.DoiMatKhau(taiKhoan, matKhau);
        }
    }
}
