using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamSoc
    {
        private string maNV;
        private string maKH;
        private string phanHoiKH;
        private float diemTL;

        public ChamSoc()
        {
        }

        public ChamSoc(string maNV, string maKH, string phanHoiKH, float diemTL)
        {
            this.maNV = maNV;
            this.maKH = maKH;
            this.phanHoiKH = phanHoiKH;
            this.diemTL = diemTL;
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string PhanHoiKH
        {
            get { return phanHoiKH; }
            set { phanHoiKH = value; }
        }

        public float DiemTL
        {
            get { return diemTL; }
            set { diemTL = value; }
        }
    }
}
