using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDSach
    {
        private string maHD;
        private string maSach;
        private int soLuong;
        private float donGia;
        private float tongTien;

        public ChiTietHDSach()
        {
        }

        public ChiTietHDSach(string maHD, string maSach, int soLuong, float donGia, float tongTien)
        {
            this.maHD = maHD;
            this.maSach = maSach;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.tongTien = tongTien;
        }

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set
            {
                donGia = value; }
        }

        public float TongTien
        {
            get { return tongTien; }
            set
            {
                tongTien = value;
            }
        }
    }
}
