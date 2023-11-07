using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class SachDAO
    {
        private static SachDAO instance;
        public static SachDAO Instance
        {
            get { if (instance == null) instance = new SachDAO(); return SachDAO.instance; }
            private set { SachDAO.instance = value; }
        }

       public List<Sach> hienThiSach()
        {
            try
            { 
                List<Sach> danhSachSach = new List<Sach>();
                //string query = @"proc_DanhSachSach";
                string query = "SELECT * FROM dbo.Sach";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in table.Rows)
                {
                    Sach sach = new Sach(row);
                    danhSachSach.Add(sach);
                }
                
                return danhSachSach;
            }
            catch
            {
                return null;
            }

            
        }

        public bool ThemSach(string maSach, string tenSach, float donGia, int tonKho, string maNhomSach, string tenNhomSach)
        {
            string query = string.Format("EXEC [dbo].[proc_themSachMoi] @MaSach = {0}, @TenSach = N'{1}',@DonGia = {2},@TonKho = {3},@MaNhomSach = {4},@TenNhomSach = N'{5}'", maSach, tenSach, donGia, tonKho, maNhomSach, tenNhomSach);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaSach(string maSach, string tenSach, float donGia, int tonKho, string maNhomSach)
        {
            string query = string.Format("EXEC [dbo].[proc_suaSach] @MaSach = {0}, @TenSach = N'{1}',@DonGia = {2},@TonKho = {3}, @MaNhomSach = {4}", maSach, tenSach, donGia, tonKho, maNhomSach);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaSach(string maSach)
        {
           
            string query = string.Format("EXEC [dbo].[proc_xoaSach] @MaSach = {0}", maSach);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
