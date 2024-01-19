using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO
{
    public class ThuCung
    {
		private string idThuCung;
		private string idLoai;
		private string tenGiong;
		private int soLuongConLai;
		private int giaBan;
		//	public Image Anh;
		private string moTa;
		private string idNhaCungCap;

        public ThuCung()
        {
        }
        public ThuCung(string idThuCung, string idLoai, string tenGiong, int soLuongConLai, int giaBan,string moTa, string idNhaCungCap)
        {
            IdThuCung=idThuCung;
            IdLoai=idLoai;
            TenGiong=tenGiong;
            SoLuongConLai=soLuongConLai;
            GiaBan=giaBan;
            MoTa=moTa;
            IdNhaCungCap=idNhaCungCap;
        }

        public string IdThuCung
        {
			get { return idThuCung; }
			set { idThuCung = value; }	
        }
        public string IdLoai
        {
            get { return idLoai; }
            set { idLoai = value; }
        }
        public string TenGiong
        {
            get { return tenGiong; }
            set { tenGiong = value; }
        }
        public int SoLuongConLai
        {
            get { return soLuongConLai; }
            set { soLuongConLai = value; }
        }
        public int GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public string IdNhaCungCap
        {
            get { return idNhaCungCap; }
            set { idNhaCungCap = value; }
        }
    }
}
