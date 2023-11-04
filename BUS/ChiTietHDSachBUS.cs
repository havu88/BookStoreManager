using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHDSachBUS
    {
        private static ChiTietHDSachBUS instance;
        public static ChiTietHDSachBUS Instance
        {
            get { if (instance == null) instance = new ChiTietHDSachBUS(); return ChiTietHDSachBUS.instance; }
            private set { ChiTietHDSachBUS.instance = value; }
        }

        public int themChiTietHDSach(string maHD, string maSach, int soLuong, float donGia)
        {
            return (ChiTietHDSachDAO.Instance.themChiTietHDSach(maHD, maSach, soLuong, donGia));
        }
    }
}
