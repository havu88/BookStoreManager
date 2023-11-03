using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return KhachHangBUS.instance; }
            private set { KhachHangBUS.instance = value; }
        }

        public int themKhachHang(string maKH, string tenKH, string sdt)
        {
            return (KhachHangDAO.Instance.themKhachHang(maKH, tenKH, sdt));
        }

        public KhachHang timKhachHang(string sdt)
        {
            return (KhachHangDAO.Instance.timKhachHang(sdt));
        }
    }
}
