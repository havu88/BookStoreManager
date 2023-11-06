using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamKhacDAO
    {
        private static SanPhamKhacDAO instance;
        public static SanPhamKhacDAO Instance
        {
            get { if (instance == null) instance = new SanPhamKhacDAO(); return SanPhamKhacDAO.instance; }
            private set { SanPhamKhacDAO.instance = value; }
        }

        public List<SanPhamKhac> hienThiSanPhamKhac()
        {
            try
            {
                List<SanPhamKhac> danhSachSanPhamKhac = new List<SanPhamKhac>();
                //string query = @"proc_DanhSachSanPhamKhac";
                string query = "SELECT * FROM dbo.SanPhamKhac";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in table.Rows)
                {
                    SanPhamKhac sanPhamKhac = new SanPhamKhac(row);
                    danhSachSanPhamKhac.Add(sanPhamKhac);
                }
                return danhSachSanPhamKhac;
            }
            catch 
            {
                return null;
            }

        }
        public bool ThemSPK(string maSPK, string tenSP, float donGia, int tonKho)
        {
            string query = string.Format("EXEC [dbo].[proc_themSPKMoi] @MaSPK = {0}, @TenSPK = N'{1}',@DonGia = {2},@TonKho = {3}", maSPK, tenSP, donGia, tonKho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaSPK(string maSPK, string tenSP, float donGia, int tonKho)
        {
            string query = string.Format("EXEC [dbo].[proc_suaSPK] @MaSPK = {0}, @TenSPK = N'{1}',@DonGia = {2},@TonKho = {3}", maSPK, tenSP, donGia, tonKho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaSPK(string maSPK)
        {

            string query = string.Format("EXEC [dbo].[proc_xoaSPK] @MaSPK = {0}", maSPK);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
