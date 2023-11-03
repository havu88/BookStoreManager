using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangPhanCa
    {
        private string maCa;
        private string maNV;
        private DateTime ngayLam;

        public BangPhanCa()
        {
        }

        public BangPhanCa(string maCa, string maNV, DateTime ngayLam)
        {
            this.maCa = maCa;
            this.maNV = maNV;
            this.ngayLam = ngayLam;
        }

        public string MaCa
        {
            get { return maCa; }
            set { maCa = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public DateTime NgayLam
        {
            get { return ngayLam; }
            set { ngayLam = value; }
        }
    }
}
