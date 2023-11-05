using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBus
    {
        NhanVienDAO nvDao = new NhanVienDAO();
        public void ThemNhanVien(NhanVien nv)
        {
            nvDao.Them(nv);
        }
        public DataTable LayDanhSachNhanVien()
        {
            return nvDao.LayDanhSachNhanVien();
        }
        public void CapNhatNhanVien(NhanVien nv)
        {
            nvDao.Sua(nv);
        }
        public void XoaNhanVien(NhanVien nv)
        {
            nvDao.Xoa(nv);
        }
        public DataTable XemLuong()
        {
            return nvDao.XemLuong();
        }
    }
}
