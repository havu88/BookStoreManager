using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private float donGia;
        private int tonKho;
        private string maNhomSach;
        private string tenNhomSach;

        public Sach()
        {
        }

        public Sach(DataRow row)
        {
            MaSach = row["MaSach"].ToString();
            TenSach = row["TenSach"].ToString();
            DonGia = (float)Convert.ToSingle(row["DonGia"]);
            TonKho = (int)Convert.ToInt32(row["TonKho"]);
            MaNhomSach = row["MaNhomSach"].ToString();
            TenNhomSach = row["TenNhomSach"].ToString();
        }

        public Sach(string maSach, string tenSach, float donGia, int tonKho,  string maNhomSach, string tenNhomSach)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.donGia = donGia;
            this.tonKho = tonKho;
            this.maNhomSach = maNhomSach;
            this.tenNhomSach = tenNhomSach;

        }

        public string MaSach
        {
            get => maSach;
            set => maSach = value; 
        }

        public string TenSach
        {
            get => tenSach;
            set => tenSach = value;
        }

        public float DonGia
        {
            get => donGia;
            set => donGia = value; 
        }

        public int TonKho
        {
            get => tonKho;
            set => tonKho = value;
        }
        public string TenNhomSach
        {
            get => tenNhomSach;
            set => tenNhomSach = value;
        } 
        public string MaNhomSach
        {
            get => maNhomSach;
            set => maNhomSach = value; 
        }
    }
}
