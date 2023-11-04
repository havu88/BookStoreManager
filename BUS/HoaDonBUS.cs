using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get { if (instance == null) instance = new HoaDonBUS(); return HoaDonBUS.instance; }
            private set { HoaDonBUS.instance = value; }
        }

        public int themHoaDon(string maHD, string maKH, string maNV)
        {
            return (HoaDonDAO.Instance.themHoaDon(maHD, maKH, maNV));
        }

        public DataTable thanhToanHD(string maHD)
        {
            return (HoaDonDAO.Instance.thanhToanHD(maHD));  
        }
    }
}
