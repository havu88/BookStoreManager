using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomSach
    {
        private string maNhomSach;
        private string tenNhomSach;

        public NhomSach()
        {
        }

        public NhomSach(string maNhomSach, string tenNhomSach)
        {
            this.maNhomSach = maNhomSach;
            this.tenNhomSach = tenNhomSach;
        }

        public string MaNhomSach
        {
            get { return maNhomSach; }
            set { maNhomSach = value; }
        }

        public string TenNhomSach
        {
            get { return tenNhomSach; }
            set { tenNhomSach = value; }
        }
    }
}
