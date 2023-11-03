using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CungCapSach
    {
        private string maNCC;
        private string maSach;
        private int soLuongCC;

        public CungCapSach()
        {
        }

        public CungCapSach(string maNCC, string maSach, int soLuongCC)
        {
            this.maNCC = maNCC;
            this.maSach = maSach;
            this.soLuongCC = soLuongCC;
        }

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public int SoLuongCC
        {
            get { return soLuongCC; }
            set { soLuongCC = value; }
        }
    }
}
