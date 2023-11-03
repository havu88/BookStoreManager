using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBUS
    {
        private static SachBUS instance;
        public static SachBUS Instance
        {
            get { if (instance == null) instance = new SachBUS(); return SachBUS.instance; }
            private set { SachBUS.instance = value; }
        }

        public List<Sach> hienThiSach()
        {
            return (SachDAO.Instance.hienThiSach());

        }
    }
}
