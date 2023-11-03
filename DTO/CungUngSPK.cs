using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CungUngSPK
    {
        private string maNCC;
        private string maSPK;
        private int soLuongCC;

        public CungUngSPK()
        {
        }

        public CungUngSPK(string maNCC, string maSPK, int soLuongCC)
        {
            this.maNCC = maNCC;
            this.maSPK = maSPK;
            this.soLuongCC = soLuongCC;
        }

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        public string MaSPK
        {
            get { return maSPK; }
            set { maSPK = value; }
        }

        public int SoLuongCC
        {
            get { return soLuongCC; }
            set { soLuongCC = value; }
        }
    }
}
