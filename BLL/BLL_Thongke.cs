using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ThongKe
    {
        private static BLL_ThongKe instance;
        public static BLL_ThongKe Instance
        {
            get
            {
                if (instance == null) instance = new BLL_ThongKe();
                return instance;
            }
        }
        public static DataTable getallhoadon()
        {
            return DAL_Thongke.getDataHD();
        }

        public DataTable GetDataNhanVien()
        {
            return DAL_Thongke.GetDataNhanVien();
        }
        public DataTable GetDataThuCung()
        {
            return DAL_Thongke.GetDataThuCung();
        }
        public DataTable ThongKeTatCa(DateTime beginDate, DateTime endDate)
        {
            return DAL_Thongke.ThongKeTatCa(beginDate, endDate);
        }
        public DataTable ThongKeTheoThuCung(string idThuCung, DateTime beginDate, DateTime endDate)
        {
            return DAL_Thongke.ThongKeTheoThuCung(idThuCung, beginDate, endDate);
        }
        public DataTable ThongKeTheoTaiKhoan(string idNhanVien, DateTime beginDate, DateTime endDate)
        {
            return DAL_Thongke.ThongKeTheoTaiKhoan(idNhanVien, beginDate, endDate);
        } 
            public DataTable ThongKeTheoTaiKhoanVaThuCung(string idNhanVien, string idThuCung, DateTime beginDate, DateTime endDate)
        {
            return DAL_Thongke.ThongKeTheoTaiKhoanVaThuCung(idNhanVien, idThuCung, beginDate, endDate);
        }

    }
}
