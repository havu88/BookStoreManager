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
        private string maNhomSach;
        private string tenSach;
        private float donGia;
        private int tonKho;

        public Sach()
        {
        }

        public Sach(DataRow row)
        {
            MaSach = row["MaSach"].ToString();
            MaNhomSach = row["MaNhomSach"].ToString();
            TenSach = row["TenSach"].ToString();
            DonGia = (float)Convert.ToDouble(row["DonGia"]);
            TonKho = (int)row["TonKho"];
        }

        public Sach(string maSach, string maNhomSach, string tenSach, float donGia, int tonKho)
        {
            this.maSach = maSach;
            this.maNhomSach = maNhomSach;
            this.tenSach = tenSach;
            this.donGia = donGia;
            this.tonKho = tonKho;
        }

        public string MaSach
        {
            get => maSach;
            set => maSach = value; 
        }

        public string MaNhomSach
        {
            get => maNhomSach;
            set => maNhomSach = value; 
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
    }
}
