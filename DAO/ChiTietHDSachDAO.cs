using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHDSachDAO
    {
        private static ChiTietHDSachDAO instance;
        public static ChiTietHDSachDAO Instance
        {
            get { if (instance == null) instance = new ChiTietHDSachDAO(); return ChiTietHDSachDAO.instance; }
            private set { ChiTietHDSachDAO.instance = value; }
        }

        public int themChiTietHDSach(string maHD, string maSach, int soLuong, float donGia)
        {
            int result = -1;
            string query = @"proc_ThemChiTietHDSach @MaHD , @MaSach  , @SoLuong , @DonGia ";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, maSach, soLuong , donGia });

            return result;
        }
    }
}
