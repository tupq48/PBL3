using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_ThuCung
    {
        DAL_ThuCung dalThuCung = new DAL_ThuCung();
        public DataTable getThuCung()
        {
            return dalThuCung.getDataThuCung();
        }

        public bool themThuCung(ThuCung tc)
        {
            return dalThuCung.themThuCung(tc);
        }

        public bool suaThuCung(ThuCung tc)
        {
            return dalThuCung.suaThuCung(tc);
        }

        public bool xoaThuCung(String IDtc )
        {
            return dalThuCung.xoaThuCung(IDtc);
        }
        public DataTable timkiemThuCung(string ten)
        {
            return dalThuCung.timkiemThuCung(ten);
        }
        public List<String> LayNhaCungCap()
        {
            List<String> ncc = new List<String>();
            foreach(DataRow dr in dalThuCung.LayNhaCungCap().Rows)
            {
                ncc.Add(dr["TenNhaCungCap"].ToString());
            }
            return ncc;
        }
        public String LayTenNhaCungCap(String str)
        {
            String txt="";
            foreach (DataRow dr in dalThuCung.LayNhaCungCap().Rows)
            {
                if (str == dr["IdNhaCungCap"].ToString())
                {
                    txt=dr["TenNhaCungCap"].ToString();
                }
            }
            return txt;
        }
        public String LayIdNhaCungCap(String str)
        {
            String txt = "";
            foreach (DataRow dr in dalThuCung.LayNhaCungCap().Rows)
            {
                if (str == dr["TenNhaCungCap"].ToString())
                {
                    txt=dr["IdNhaCungCap"].ToString();
                }
            }
            return txt;
        }
        //-----------
        public List<String> LayLoaiThuCung()
        {
            List<String> ltc = new List<String>();
            foreach (DataRow dr in dalThuCung.LayLoaiThuCung().Rows)
            {
                ltc.Add(dr["TenLoai"].ToString());
            }
            return ltc;
        }
        public String LayTenLoaiThuCung(String str)
        {
            String txt = "";
            foreach (DataRow dr in dalThuCung.LayLoaiThuCung().Rows)
            {
                if (str == dr["IdLoai"].ToString())
                {
                    return txt=dr["TenLoai"].ToString();
                }
            }
            return txt;
        }
        public String LayIdLoaiThuCung(String str)
        {
            String txt = "";
            foreach (DataRow dr in dalThuCung.LayLoaiThuCung().Rows)
            {
                if (str == dr["TenLoai"].ToString())
                {
                    txt=dr["IdLoai"].ToString();
                }
            }
            return txt;
        }
        public string AutoIdThuCung()
        {
            return dalThuCung.AutoIdThuCung();
        }

        public static string GetTenThuCung(string idThuCung)
        {
            return DAL_ThuCung.GetTenThuCung(idThuCung);
        }
    }
}
