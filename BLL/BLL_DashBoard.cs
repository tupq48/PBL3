using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DashBoard
    {
        private static BLL_DashBoard instance;
        public static BLL_DashBoard Instance
        {
            get
            {
                if (instance == null) instance = new BLL_DashBoard();
                return instance;
            }
        }

        public int ExtractData(string str)
        {
            return DAL_DashBoard.Instance.ExtractData(str);
        }
    }
}
