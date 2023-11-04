using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHDSPKDAO
    {
        private static ChiTietHDSPKDAO instance;
        public static ChiTietHDSPKDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHDSPKDAO(); return ChiTietHDSPKDAO.instance; }
            private set { ChiTietHDSPKDAO.instance = value; }
        }

        public int themChiTietHDSPK(string maHD, string maSPK, int soLuong, float donGia)
        {
            int result = -1;
            string query = @"proc_ThemChiTietHDSPK @MaHD , @MaSPK  , @SoLuong , @DonGia ";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, maSPK, soLuong, donGia });

            return result;
        }
    }
}
