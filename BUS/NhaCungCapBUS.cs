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
    public class NhaCungCapBUS
    {
        NhaCungCapDAO nccDAO = new NhaCungCapDAO();
        public void ThemNhaCungCap(NhaCungCap ncc)
        {
            nccDAO.Them(ncc);
        }
        public DataTable LayDanhSachNhaCungCap()
        {
            return nccDAO.LayDanhSachNhaCungCap();
        }
        public void CapNhatNhaCungCap(NhaCungCap ncc)
        {
            nccDAO.Sua(ncc);
        }
        public void XoaNhaCungCap(NhaCungCap ncc)
        {
            nccDAO.Xoa(ncc);
        }
        public DataTable Search(string timKiem, string value)
        {
            return nccDAO.Search(timKiem, value);
        }
    }
}
