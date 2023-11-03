using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaLamViec
    {
        private string maCa;
        private DateTime ngayLam;
        private TimeSpan gioBatDau;
        private TimeSpan gioKetThuc;

        public CaLamViec()
        {
        }

        public CaLamViec(string maCa, DateTime ngayLam, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            this.maCa = maCa;
            this.ngayLam = ngayLam;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
        }

        public string MaCa
        {
            get { return maCa; }
            set { maCa = value; }
        }

        public DateTime NgayLam
        {
            get { return ngayLam; }
            set { ngayLam = value; }
        }

        public TimeSpan GioBatDau
        {
            get { return gioBatDau; }
            set { gioBatDau = value; }
        }

        public TimeSpan GioKetThuc
        {
            get { return gioKetThuc; }
            set { gioKetThuc = value; }
        }
    }
}
