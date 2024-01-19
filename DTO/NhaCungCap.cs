using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string idNhaCungCap;
        private string tenNhaCungCap;

        public NhaCungCap()
        {
        }

        public NhaCungCap(string idNhaCungCap, string tenNhaCungCap)
        {
            IdNhaCungCap=idNhaCungCap;
            TenNhaCungCap=tenNhaCungCap;
        }

        public string IdNhaCungCap
        {
            get { return idNhaCungCap; }
            set { idNhaCungCap = value; }
        }
        public string TenNhaCungCap
        {
            set { tenNhaCungCap = value; }
            get { return tenNhaCungCap; }
        }
    }
}
