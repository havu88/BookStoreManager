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
        DBConnection dbConn = new DBConnection();
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

        public DataTable LayDanhSachHoaDon()
        {
            string sqlStr = string.Format("select * from HoaDon");
            return dbConn.LayDanhSach(sqlStr);
        }

        public float TinhDoanhThuTheoNgay(string NgayXuatHD)
        {
            string query = @"SELECT dbo.F_TinhDoanhThuNgay '@NgayXuatHD';";
            float result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { NgayXuatHD });
            return result;
        }

    }
}
