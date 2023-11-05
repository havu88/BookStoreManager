using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string maNV;
        private string tenTK;
        private string hoNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string sdt;
        private string diaChi;
        private int soCa;
        private string maCV;

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string tenTK, string hoNV, string tenNV, DateTime ngaySinh, string gioiTinh, string sdt, string diaChi, int soCa, string maCV)
        {
            this.maNV = maNV;
            this.tenTK = tenTK;
            this.hoNV = hoNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.soCa = soCa;
            this.maCV = maCV;
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }

        public string HoNV
        {
            get { return hoNV; }
            set { hoNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public int SoCa
        {
            get { return soCa; }
            set { soCa = value; }
        }

        public string MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }
    }
}
