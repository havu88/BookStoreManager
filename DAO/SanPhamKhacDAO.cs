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
            List<SanPhamKhac> danhSachSanPhamKhac= new List<SanPhamKhac>();
            string query = @"proc_DanhSachSanPhamKhac";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                SanPhamKhac sanPhamKhac = new SanPhamKhac();
                danhSachSanPhamKhac.Add(sanPhamKhac);
            }
            return danhSachSanPhamKhac;

        }
    }
}
