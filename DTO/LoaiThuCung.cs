using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiThuCung
    {
        private string idLoai;
        private string tenLoai;

        public LoaiThuCung()
        {
        }

        public LoaiThuCung(string idLoai, string tenLoai)
        {
            IdLoai=idLoai;
            TenLoai=tenLoai;
        }

        public string IdLoai
        {
            get { return idLoai; }
            set { idLoai = value; }
        }
        public string TenLoai
        {
            set { tenLoai = value; }
            get { return tenLoai; }
        }
    }
}
