using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHDSPKBUS
    {
        private static ChiTietHDSPKBUS instance;
        public static ChiTietHDSPKBUS Instance
        {
            get { if (instance == null) instance = new ChiTietHDSPKBUS(); return ChiTietHDSPKBUS.instance; }
            private set { ChiTietHDSPKBUS.instance = value; }
        }

        public int themChiTietHDSPK(string maHD, string maSPK, int soLuong, float donGia)
        {
            return (ChiTietHDSPKDAO.Instance.themChiTietHDSPK(maHD, maSPK, soLuong, donGia));
        }
    }
}
