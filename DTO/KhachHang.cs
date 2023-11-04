using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string maKH;
        private string tenKH;
        private string sdt;
        private float diemTL;

        public KhachHang()
        {
        }

        public KhachHang(string maKH, string tenKH, string sdt, float diemTL)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.diemTL = diemTL;
        }

        public KhachHang(DataRow row)
        {
            MaKH = row["MaKH"].ToString();
            TenKH = row["TenKH"].ToString();
            SDT = row["SDT"].ToString();
            DiemTL = (float)Convert.ToDouble(row["DiemTL"]);
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public float DiemTL
        {
            get { return diemTL; }
            set { diemTL = value; }
        }
    }
}
