using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }

        public int themHoaDon(string maHD, string maKH, string maNV)
        {
            string query = @"proc_ThemHoaDon @MaHD , @MaKH  , @MaNV ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maHD, maKH, maNV });

            return result;
        }

        public DataTable thanhToanHD(string maHD)
        {
            string query = @"proc_ThanhToanHD @maHD ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { maHD });
            if (table.Rows.Count > 0)
            {
                
                return table;
            }
            return null;
        }

    }
}
