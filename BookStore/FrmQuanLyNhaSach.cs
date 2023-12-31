﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FrmQuanLyNhaSach : Form
    {
        NhanVienBus nvBus = new NhanVienBus();
        BangPhanCaBus pcBus= new BangPhanCaBus();
        public FrmQuanLyNhaSach()
        {
            InitializeComponent();
        }
        private void LoadDanhSach()
        {
            this.dgv_DSNV.DataSource = nvBus.LayDanhSachNhanVien();
        }
        private void LoadDanhSachPhanCa()
        {
            this.dgv_DSPC.DataSource = pcBus.LayDanhSachPhanCa();
        }

        private void dgv_DSNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DSNV.CurrentRow.Index;

            txt_MaNV.Text = dgv_DSNV.Rows[i].Cells[0].Value.ToString();
            txt_TenTk.Text = dgv_DSNV.Rows[i].Cells[1].Value.ToString();
            txt_HoNV.Text = dgv_DSNV.Rows[i].Cells[2].Value.ToString();
            txt_TenNV.Text = dgv_DSNV.Rows[i].Cells[3].Value.ToString();
            dtp_NgaySinh.Text = dgv_DSNV.Rows[i].Cells[4].Value.ToString();
            txt_GioiTinh.Text = dgv_DSNV.Rows[i].Cells[5].Value.ToString();
            txt_SDT.Text = dgv_DSNV.Rows[i].Cells[6].Value.ToString();
            txt_DiaChi.Text = dgv_DSNV.Rows[i].Cells[7].Value.ToString();
            txt_SoCa.Text = dgv_DSNV.Rows[i].Cells[8].Value.ToString();
            txt_MaCV.Text = dgv_DSNV.Rows[i].Cells[9].Value.ToString();
        }

        private void btb_Them_Click_1(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txt_MaNV.Text, txt_TenTk.Text, txt_HoNV.Text, txt_TenNV.Text, dtp_NgaySinh.Value, txt_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, int.Parse(txt_SoCa.Text), txt_MaCV.Text);
            nvBus.ThemNhanVien(nv);
            LoadDanhSach();
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txt_MaNV.Text, txt_TenTk.Text, txt_HoNV.Text, txt_TenNV.Text, dtp_NgaySinh.Value, txt_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, int.Parse(txt_SoCa.Text), txt_MaCV.Text);
            nvBus.CapNhatNhanVien(nv);
            LoadDanhSach();
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txt_MaNV.Text, txt_TenTk.Text, txt_HoNV.Text, txt_TenNV.Text, dtp_NgaySinh.Value, txt_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, int.Parse(txt_SoCa.Text), txt_MaCV.Text);
            nvBus.XoaNhanVien(nv);
            LoadDanhSach();
        }

        private void btn_Luong_Click_1(object sender, EventArgs e)
        {
            FrmBangLuong luong = new FrmBangLuong();
            luong.Width = 700;
            luong.Height = 350;
            luong.Show();
        }

        private void tp_QLNV_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
            LoadDanhSachPhanCa();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
            {
                dgv_DSNV.DataSource = nvBus.LayDanhSachNhanVien();
                return;
            }
            string timkiem = "";
            if (cbo_Loai.Text == "Tên") timkiem = "TenNV";
            if (cbo_Loai.Text == "Mã NV") timkiem = "MaNV";
            if (cbo_Loai.Text == "SDT") timkiem = "SDT";
            dgv_DSNV.DataSource = nvBus.Search(timkiem, txt_TimKiem.Text);
        }

        private void btb_ThemCa_Click(object sender, EventArgs e)
        {
            BangPhanCa pc= new BangPhanCa(txt_MaCa.Text,txt_MaNV_PC.Text,dtp_NgayLam.Value);
            pcBus.ThemPhanCa(pc);
            LoadDanhSachPhanCa();
        }

        private void btn_XoaCa_Click(object sender, EventArgs e)
        {
            BangPhanCa pc = new BangPhanCa(txt_MaCa.Text, txt_MaNV_PC.Text, dtp_NgayLam.Value);
            pcBus.XoaPhanCa(pc);
            LoadDanhSachPhanCa();
        }

        private void dgv_DSPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DSPC.CurrentRow.Index;

            txt_MaCa.Text = dgv_DSPC.Rows[i].Cells[0].Value.ToString();
            txt_MaNV_PC.Text = dgv_DSPC.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_TimKiemPhanCa_Click(object sender, EventArgs e)
        {
            if (txt_TimKiemPhanCa.Text == "")
            {
                dgv_DSPC.DataSource = pcBus.LayDanhSachPhanCa();
                return;
            }
            string timkiem = "";
            if (cbo_LoaiTimKiem.Text == "Mã Ca") timkiem = "MaCa";
            if (cbo_LoaiTimKiem.Text == "Mã NV") timkiem = "MaNV";
            dgv_DSPC.DataSource = pcBus.Search(timkiem, txt_TimKiemPhanCa.Text);
        }

        private void btn_ThoatCa_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhaSach frmQL= new FrmQuanLyNhaSach();
            frmQL.Close();
        }

        private void btn_SuaPhanCa_Click(object sender, EventArgs e)
        {
            int i = dgv_DSPC.CurrentRow.Index;
            string MaCa_current = dgv_DSPC.Rows[i].Cells[0].Value.ToString();
            string MaNV_current = dgv_DSPC.Rows[i].Cells[1].Value.ToString();        
            BangPhanCa pc = new BangPhanCa(txt_MaCa.Text, txt_MaNV_PC.Text, dtp_NgayLam.Value);
            pcBus.SuaPhanCa(MaCa_current, MaNV_current, pc);
            LoadDanhSachPhanCa();
            /*            MessageBox.Show(MaCa_current);
                        MessageBox.Show(MaNV_current);
                        MessageBox.Show(pc.MaCa);
                        MessageBox.Show(pc.MaNV);
                        MessageBox.Show(pc.NgayLam.ToString());*/

        }
    }
}
