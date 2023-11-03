using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDSPK
    {
        private string maHD;
        private string maSPK;
        private int soLuong;
        private float donGia;
        private float tongTien;

        public ChiTietHDSPK()
        {
        }

        public ChiTietHDSPK(string maHD, string maSPK, int soLuong, float donGia, float tongTien)
        {
            this.maHD = maHD;
            this.maSPK = maSPK;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.tongTien = tongTien;
        }

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaSPK
        {
            get { return maSPK; }
            set { maSPK = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

    }
}
