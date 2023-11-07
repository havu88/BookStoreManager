using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        DBConnection dbConn = new DBConnection();
        public NhaCungCapDAO()
        {

        }
        public DataTable LayDanhSachNhaCungCap()
        {
            string sqlStr = string.Format("select * from NhaCungCap");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(NhaCungCap ncc)
        {
            string sqlStr = string.Format("proc_ThemNCC N'{0}', N'{1}', N'{2}', N'{3}'", ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT);
            dbConn.Execute(sqlStr);
        }
        public void Sua(NhaCungCap ncc)
        {
            string sqlStr = string.Format("proc_SuaNCC N'{0}', N'{1}', N'{2}', N'{3}'", ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT);
            dbConn.Execute(sqlStr);
        }
        public void Xoa(NhaCungCap ncc)
        {
            string sqlStr = string.Format("proc_XoaNCC N'{0}'", ncc.MaNCC);
            dbConn.Execute(sqlStr);
        }

        public DataTable Search(string timKiem, string value)
        {
            string sqlStr = "";
            if (timKiem == "MaNCC")
            {
                sqlStr = string.Format("SELECT * FROM dbo.SearchNCCByMaNCC('{0}');", value);
            }
            else if (timKiem == "TenNCC")
            {
                sqlStr = string.Format("SELECT * FROM dbo.SearchNCCByTenNCC(N'{0}');", value);
            }
            else if (timKiem == "DiaChi")
            {
                sqlStr = string.Format("SELECT * FROM dbo.SearchNCCByDiaChi(N'{0}');", value);
            }
            else if (timKiem == "SDT")
            {
                sqlStr = string.Format("SELECT * FROM dbo.SearchNCCBySDT('{0}');", value);
            }
                return dbConn.LayDanhSach(sqlStr);
        }
    }
}
