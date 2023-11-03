using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongViec
    {
        private string maCV;
        private string tenCV;
        private float luong;

        public CongViec()
        {
        }

        public CongViec(string maCV, string tenCV, float luong)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
            this.luong = luong;
        }

        public string MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }

        public string TenCV
        {
            get { return tenCV; }
            set { tenCV = value; }
        }

        public float Luong
        {
            get { return luong; }
            set { luong = value; }
        }
    }
}
