using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }

        public int themKhachHang(string maKH, string tenKH, string sdt)
        {
            string query = @"proc_TaoKhachHang @MaKH , @TenKH , @SDT";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {maKH, tenKH, sdt});
            
            return result;
        }

        public KhachHang timKhachHang(string sdt)
        {
            string query = "select * from dbo.func_TimKiemKHBangSDT( @SDT )";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { sdt });
            if (table.Rows.Count > 0)
            {
                KhachHang khachhang = new KhachHang(table.Rows[0]);
                return khachhang;
            }
            return null;
        }
    }
}
