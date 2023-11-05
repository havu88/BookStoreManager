using BUS;
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
            this.ControlBox = false; // Vô hiệu hóa ControlBox
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // Đặt FormBorderStyle thành FixedToolWindow
        }

        private void loadData()
        {
            List<Sach> danhSachSach = SachBUS.Instance.hienThiSach();

            DataTable dataTableSach = new DataTable();

            dataTableSach.Columns.Add("Mã Sách", typeof(string));
            dataTableSach.Columns.Add("Mã Nhóm Sách", typeof(string));
            dataTableSach.Columns.Add("Tên Sách", typeof(string));
            dataTableSach.Columns.Add("Đơn Giá", typeof(int));
            dataTableSach.Columns.Add("Tồn Kho", typeof(int));
            foreach (Sach sach in danhSachSach)
            {
                dataTableSach.Rows.Add(sach.MaSach, sach.MaNhomSach, sach.TenSach, sach.DonGia, sach.TonKho);
            }

            dtgvSach.DataSource = dataTableSach;

            List<SanPhamKhac> danhSachSanPhamKhac = SanPhamKhacBUS.Instance.hienThiSanPhamKhac();

            DataTable dataTableSPK = new DataTable();

            dataTableSPK.Columns.Add("Mã SP", typeof(string));
            dataTableSPK.Columns.Add("Tên SP", typeof(string));
            dataTableSPK.Columns.Add("Đơn Giá", typeof(int));
            dataTableSPK.Columns.Add("Tồn Kho", typeof(int));
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
            if (result != -1)
            {
                MessageBox.Show("Thành công");
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

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra người dùng đã nhấp vào một dòng hợp lệ hay không
            {
                DataGridViewRow row = dtgvSach.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong dòng được chọn
                string maSach = row.Cells["Mã Sách"].Value.ToString();
                int donGia = Convert.ToInt32(row.Cells["Đơn Giá"].Value);

                txtMaSach.Text = maSach;
                txtDonGiaSach.Text = donGia.ToString();

            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string maKH = txtMaKHinHD.Text; 
            string maNV = txtMaNV.Text;

            int result = HoaDonBUS.Instance.themHoaDon(maHD, maKH, maNV);
            if (result != -1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }

        private void btnThemSachinHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string maSach = txtMaSach.Text;
            float donGia = (float)Convert.ToDouble(txtDonGiaSach.Text);
            int soLuong = Convert.ToInt32(txtSoLuongSach.Text);

            int result = ChiTietHDSachBUS.Instance.themChiTietHDSach(maHD, maSach, soLuong, donGia);
            if (result != -1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            loadData();
        }

        private void dtgvSPK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra người dùng đã nhấp vào một dòng hợp lệ hay không
            {
                DataGridViewRow row = dtgvSPK.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong dòng được chọn
                string maSP = row.Cells["Mã SP"].Value.ToString();
                int donGia = Convert.ToInt32(row.Cells["Đơn Giá"].Value);

                txtMaSP.Text = maSP;
                txtDonGiaSP.Text = donGia.ToString();

            }
        }

        private void btnThemSPinHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string maSP = txtMaSP.Text;
            float donGia = (float)Convert.ToDouble(txtDonGiaSP.Text);
            int soLuong = Convert.ToInt32(txtSoLuongSP.Text);

            int result = ChiTietHDSPKBUS.Instance.themChiTietHDSPK(maHD, maSP, soLuong, donGia);
            if (result != -1)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            loadData();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;

            DataTable table = HoaDonBUS.Instance.thanhToanHD(maHD); 

            if (table != null)
            {
                this.Hide();

                FrmHoaDon frmHoaDon = new FrmHoaDon(table);  
                frmHoaDon.ShowDialog();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.ShowDialog();
        }

        private void dtgvSach_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void dtgvSPK_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel=true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.Show();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLy frmQuanLy = new FrmQuanLy();  
            frmQuanLy.ShowDialog();
        }

       
    }
}
