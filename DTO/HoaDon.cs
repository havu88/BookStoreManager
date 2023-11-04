using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string maHD;
        private DateTime ngayXuatHD;
        private string maKH;
        private string maNV;
        private int soLuong;
        private float triGiaHD;
        private string trangThai;

        public HoaDon()
        {
        }

        
        public HoaDon(string maHD, DateTime ngayXuatHD, string maKH, string maNV, int soLuong, float triGiaHD, string trangThai)
        {
            this.maHD = maHD;
            this.ngayXuatHD = ngayXuatHD;
            this.maKH = maKH;
            this.maNV = maNV;
            this.soLuong = soLuong;
            this.triGiaHD = triGiaHD;
            this.trangThai = trangThai;
        }

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public DateTime NgayXuatHD
        {
            get { return ngayXuatHD; }
            set { ngayXuatHD = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public float TriGiaHD
        {
            get { return triGiaHD; }
            set { triGiaHD = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}
