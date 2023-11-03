using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }
        public TaiKhoan xuLyDangNhap(string taiKhoan, string matKhau)
        {
            string query = @"proc_DangNhap @userName , @pass ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { taiKhoan, matKhau });
            if (table.Rows.Count > 0)
            {
                TaiKhoan taikhoan = new TaiKhoan(table.Rows[0]);
                return taikhoan;
            }
            return null;
        }

        public List<TaiKhoan> hienThiTaiKhoan()
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();
            string query = @"proc_DanhSachTaiKhoan";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                TaiKhoan taikhoan = new TaiKhoan(row);
                danhSachTaiKhoan.Add(taikhoan);
            }
            return danhSachTaiKhoan;

        }
    }
}
