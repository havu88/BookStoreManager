using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string sdt;

        public NhaCungCap()
        {
        }

        public NhaCungCap(string maNCC, string tenNCC, string diaChi, string sdt)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
