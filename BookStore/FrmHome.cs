﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            List<Sach> danhSachSach = SachBUS.Instance.hienThiSach();
            
            DataTable dataTableSach = new DataTable();

            dataTableSach.Columns.Add("MaSach", typeof(string));
            dataTableSach.Columns.Add("MaNhomSach", typeof(string));
            dataTableSach.Columns.Add("TenSach", typeof(string));
            dataTableSach.Columns.Add("DonGia", typeof(int));
            dataTableSach.Columns.Add("TonKho", typeof(int));
            foreach (Sach sach in danhSachSach)
            {
                dataTableSach.Rows.Add(sach.MaSach, sach.MaNhomSach, sach.TenSach, sach.DonGia, sach.TonKho);
            }

            dtgvSach.DataSource = dataTableSach;

            List<SanPhamKhac> danhSachSanPhamKhac = SanPhamKhacBUS.Instance.hienThiSanPhamKhac();

            DataTable dataTableSPK = new DataTable();

            dataTableSPK.Columns.Add("MaSPK", typeof(string));
            dataTableSPK.Columns.Add("TenSPK", typeof(string));
            dataTableSPK.Columns.Add("DonGia", typeof(int));
            dataTableSPK.Columns.Add("TonKho", typeof(int));
            foreach (SanPhamKhac sanPhamKhac in danhSachSanPhamKhac)
            {
                dataTableSPK.Rows.Add(sanPhamKhac.MaSPK, sanPhamKhac.TenSP, sanPhamKhac.DonGia, sanPhamKhac.TonKho);
            }


            
            dtgvSPK.DataSource = dataTableSPK;

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string sdt = txtSDT.Text;   

            int result = KhachHangBUS.Instance.themKhachHang(maKH, tenKH, sdt);
            if (result == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiemTL.Text = "0";
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string sdt = txtTimKH.Text;

            KhachHang result = KhachHangBUS.Instance.timKhachHang(sdt);
            if (result != null)
            {
                txtMaKH.Text = result.MaKH.ToString();
                txtTenKH.Text = result.TenKH.ToString();
                txtSDT.Text = result.SDT.ToString();
                txtDiemTL.Text = result.DiemTL.ToString();
            }
            else
            {
                MessageBox.Show("Khách hàng không tồn tại");
            }
        }

        
    }
}
