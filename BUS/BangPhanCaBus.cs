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
    public class BangPhanCaBus
    {
        BangPhanCaDAO pcDao= new BangPhanCaDAO();
        public void ThemPhanCa(BangPhanCa pc)
        {
            pcDao.Them(pc);
        }
        public void XoaPhanCa(BangPhanCa pc)
        {
            pcDao.Xoa(pc);
        }
        public DataTable LayDanhSachPhanCa()
        {
            return pcDao.LayDanhSachNBangPhanCa();
        }
        public DataTable Search(string key, string value)
        {
            return pcDao.Search(key,value);
        }
    }
}
