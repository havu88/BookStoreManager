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
            dtgvSach.Refresh(); 

            List<SanPhamKhac> danhSachSanPhamKhac = SanPhamKhacBUS.Instance.hienThiSanPhamKhac();
            dtgvSPK.DataSource = danhSachSanPhamKhac;

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string sdt = txtSDT.Text;   

            int result = KhachHangBUS.Instance.themKhachHang(maKH, tenKH, sdt);
            if (result != 0)
            {
                MessageBox.Show("Thành Công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
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
