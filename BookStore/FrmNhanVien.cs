using BUS;
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
    public partial class FrmNhanVien : Form
    {
        NhanVienBus nvBus = new NhanVienBus();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            this.dgv_DSNV.DataSource = nvBus.LayDanhSachNhanVien();
        }
        private void btb_Them_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txt_MaNV.Text, txt_TenTk.Text, txt_HoNV.Text, txt_TenNV.Text, dtp_NgaySinh.Value, txt_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, int.Parse(txt_SoCa.Text), txt_MaCV.Text);
            nvBus.ThemNhanVien(nv);
            LoadDanhSach();
        }

        private void dgv_DSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txt_MaNV.Text, txt_TenTk.Text, txt_HoNV.Text, txt_TenNV.Text, dtp_NgaySinh.Value, txt_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, int.Parse(txt_SoCa.Text), txt_MaCV.Text);
            nvBus.CapNhatNhanVien(nv);
            LoadDanhSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txt_MaNV.Text, txt_TenTk.Text, txt_HoNV.Text, txt_TenNV.Text, dtp_NgaySinh.Value, txt_GioiTinh.Text, txt_SDT.Text, txt_DiaChi.Text, int.Parse(txt_SoCa.Text), txt_MaCV.Text);
            nvBus.XoaNhanVien(nv);
            LoadDanhSach();
        }

        private void btn_Luong_Click(object sender, EventArgs e)
        {
            FrmBangLuong luong = new FrmBangLuong();
            luong.Width = 700;
            luong.Height = 350;
            luong.Show();
        }

        private void lbl_QLSanPham_Click(object sender, EventArgs e)
        {

        }
    }
}
