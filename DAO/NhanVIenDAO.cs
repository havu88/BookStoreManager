using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace DAO
{
    public class NhanVienDAO
    {
        DBConnection dbConn = new DBConnection();
        public NhanVienDAO()
        {

        }
        public DataTable LayDanhSachNhanVien()
        {
            string sqlStr = string.Format("select * from NhanVien");
            return dbConn.LayDanhSach(sqlStr);
        }
        public void Them(NhanVien nv)
        {
            string sqlStr = string.Format("proc_ThemNhanVien N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', {8}, null, N'{9}'", nv.MaNV, nv.TenTK, nv.HoNV, nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.SDT, nv.DiaChi, nv.SoCa, nv.MaCV);
            dbConn.Execute(sqlStr);
        }
        public void Sua(NhanVien nv)
        {
            string sqlStr = string.Format("update_NhanVien N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', {7}, null, N'{8}'", nv.MaNV, nv.HoNV, nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.SDT, nv.DiaChi, nv.SoCa, nv.MaCV);
            dbConn.Execute(sqlStr);
        }
        public void Xoa(NhanVien nv)
        {
            string sqlStr = string.Format("proc_XoaNhanVien N'{0}'", nv.MaNV);
            dbConn.Execute(sqlStr);
        }
        public DataTable XemLuong()
        {
            string sqlSrt = string.Format("SELECT * FROM func_tinhLuongNV()");
            return dbConn.LayDanhSach(sqlSrt);
        }
    }
}
