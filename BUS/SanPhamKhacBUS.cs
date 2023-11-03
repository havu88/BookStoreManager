using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamKhacBUS
    {
        private static SanPhamKhacBUS instance;
        public static SanPhamKhacBUS Instance
        {
            get { if (instance == null) instance = new SanPhamKhacBUS(); return SanPhamKhacBUS.instance; }
            private set { SanPhamKhacBUS.instance = value; }
        }

        public List<SanPhamKhac> hienThiSanPhamKhac()
        {
            return (SanPhamKhacDAO.Instance.hienThiSanPhamKhac());

        }
    }
}
