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
    public class BangPhanCaDAO
    {
        DBConnection dbConn = new DBConnection();
        public BangPhanCaDAO()
        {

        }
        public DataTable LayDanhSachNBangPhanCa()
        {
            string sqlStr = string.Format("select * from BangPhanCa");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(BangPhanCa pc)
        {
            string sqlStr = string.Format("proc_PhanCa N'{0}', N'{1}', N'{2}'", pc.MaCa, pc.MaNV, pc.NgayLam);
            dbConn.Execute(sqlStr);
        }
        public void Xoa(BangPhanCa pc)
        {
            string sqlStr = string.Format("proc_XoaPhanCa N'{0}', N'{1}'", pc.MaCa, pc.MaNV);
            dbConn.Execute(sqlStr);
        }
        public DataTable Search(string timKiem, string value)
        {
            string sqlStr = string.Format("select * from BangPhanCa where " + timKiem + " like N'%" + value + "%'");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Sua(string MaCaSua, string MaNVSua, BangPhanCa pc)
        {
            string sqlStr = string.Format("proc_SuaPhanCa N'{0}', N'{1}', N'{2}', N'{3}', N'{4}'", MaCaSua, MaNVSua, pc.MaCa, pc.MaNV, pc.NgayLam);
            dbConn.Execute(sqlStr);
        }
    }
}
