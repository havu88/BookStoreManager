﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamKhac
    {
        private string maSPK;
        private string tenSP;
        private float donGia;
        private int tonKho;

        public SanPhamKhac()
        {
        }

        public SanPhamKhac(string maSPK, string tenSP, float donGia, int tonKho)
        {
            this.maSPK = maSPK;
            this.tenSP = tenSP;
            this.donGia = donGia;
            this.tonKho = tonKho;
        }

        public string MaSPK
        {
            get { return maSPK; }
            set { maSPK = value; }
        }

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int TonKho
        {
            get { return tonKho; }
            set { tonKho = value; }
        }
    }
}
