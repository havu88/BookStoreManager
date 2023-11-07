using BookStore;
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
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void LoadDanhSach()
        {
            this.dgv_DSNCC.DataSource = nccBUS.LayDanhSachNhaCungCap();

            /*this.dgv_DSNCC.Columns["MaNCC"].Width = 100;
            this.dgv_DSNCC.Columns["TenNCC"].Width = 200;
            this.dgv_DSNCC.Columns["DiaChi"].Width = 200;
            this.dgv_DSNCC.Columns["SDT"].Width = 100;*/
        }

        private void btb_Them_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap(txt_MaNCC.Text, txt_TenNCC.Text, txt_DiaChi.Text, txt_SDT.Text);
            nccBUS.ThemNhaCungCap(ncc);
            LoadDanhSach();
        }
        private void dgv_DSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_DSNCC.CurrentRow.Index;

            txt_MaNCC.Text = dgv_DSNCC.Rows[i].Cells[0].Value.ToString();
            txt_TenNCC.Text = dgv_DSNCC.Rows[i].Cells[1].Value.ToString();
            txt_DiaChi.Text = dgv_DSNCC.Rows[i].Cells[2].Value.ToString();
            txt_SDT.Text = dgv_DSNCC.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap(txt_MaNCC.Text, txt_TenNCC.Text, txt_DiaChi.Text, txt_SDT.Text);
            nccBUS.CapNhatNhaCungCap(ncc);
            LoadDanhSach();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap(txt_MaNCC.Text, txt_TenNCC.Text, txt_DiaChi.Text, txt_SDT.Text);
            nccBUS.XoaNhaCungCap(ncc);
            LoadDanhSach();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text == "")
                {
                    dgv_DSNCC.DataSource = nccBUS.LayDanhSachNhaCungCap();
                    return;
                }
            string timkiem = "";
            if (cbo_Loai.Text == "Tên NCC") timkiem = "TenNCC";
            else if (cbo_Loai.Text == "Mã NCC") timkiem = "MaNCC";
            else if (cbo_Loai.Text == "Địa Chỉ") timkiem = "DiaChi";
            else if (cbo_Loai.Text == "SĐT") timkiem = "SDT";
            dgv_DSNCC.DataSource = nccBUS.Search(timkiem, txt_TimKiem.Text);
        }
    }
}
