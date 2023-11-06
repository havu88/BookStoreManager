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
    public partial class FrmQLSach : Form
    {
        public FrmQLSach()
        {
            InitializeComponent();
        }

        private void FrmQLSach_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        BindingSource dsSach = new BindingSource();

        void LoadData()
        {
            dtgvDSSach.DataSource = dsSach;
            LoadDSSach();
        }
        void LoadDSSach()
        {
            dsSach.DataSource = SachDAO.Instance.hienThiSach();
        }

        private void refreshGD()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtDonGia.Text = "";
            txtTonKho.Text = "";
            txtMaNhomSach.Text = "";
            txtTenNhomSach.Text = "";
        }
       
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            float donGia = Convert.ToSingle(txtDonGia.Text);
            int tonKho = Convert.ToInt32(txtTonKho.Text);
            string maNhomSach = txtMaNhomSach.Text;
            string tenNhomSach = txtTenNhomSach.Text;
            if (txtMaSach.Text != "" &&  txtTenSach.Text != "" && txtDonGia.Text != "" && txtTonKho.Text != "" && txtMaNhomSach.Text != "" && txtTenNhomSach.Text != "")
            {
                try
                {
                    try
                    {
                        int TonKho = Convert.ToInt32(txtTonKho.Text);
                        if (SachDAO.Instance.ThemSach(maSach, tenSach, donGia, tonKho, maNhomSach, tenNhomSach))
                        {
                            MessageBox.Show("Thêm sách thành công");
                            LoadDSSach(); 
                            refreshGD();
                            if (themsach != null)
                                themsach(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm sách mới");
                        }
                       
                    }
                    catch (FormatException) 
                    {

                        MessageBox.Show("Nhập sai kiểu dữ liệu tồn kho!");
                            
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai kiểu dữ liệu đơn giá!");
                }

            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!");
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            string tenSach = txtTenSach.Text;
            float donGia = Convert.ToSingle(txtDonGia);
            int tonKho = Convert.ToInt32(txtTonKho.Text);
            string maNhomSach = txtMaNhomSach.Text;

            if (SachDAO.Instance.SuaSach(maSach, tenSach, donGia, tonKho, maNhomSach))
            {
                MessageBox.Show("Sửa thông tin sách thành công");
                LoadDSSach() ;
                refreshGD();
                if (suasach != null)
                    suasach(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa sách");
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            if (MessageBox.Show("Bạn có muốn xóa thông tin này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                if (SachDAO.Instance.XoaSach(maSach))
                {
                    MessageBox.Show("Xóa sách thành công");
                    LoadDSSach();
                    refreshGD();
                    if (xoasach != null)
                        xoasach(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa sách");
                }
            }    
        }

        private void dtgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDSSach.SelectedCells.Count > 0) 
            {
                DataGridViewRow row = dtgvDSSach.Rows[dtgvDSSach.CurrentCell.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtMaSach.Text = row.Cells[1].Value.ToString();
                txtMaSach.Text = row.Cells[2].Value.ToString();
                txtMaSach.Text = row.Cells[3].Value.ToString();
                txtMaSach.Text = row.Cells[4].Value.ToString();
                txtMaSach.Text = row.Cells[5].Value.ToString();
                refreshGD();
            }
        }
        private event EventHandler themsach;
        public event EventHandler Themsach
        {
            add { themsach += value; }
            remove { themsach -= value; }
        }

        private event EventHandler xoasach;
        public event EventHandler Xoasach
        {
            add { xoasach += value; }
            remove { xoasach -= value; }
        }

        private event EventHandler suasach;
        public event EventHandler Suasach
        {
            add { suasach += value; }
            remove { suasach -= value; }
        }

        private void menuItemSPK_Click(object sender, EventArgs e)
        {
            FrmQuanLySPK  frmspk = new FrmQuanLySPK();
            frmspk.ShowDialog();
        }

        private void menuItemHome_Click(object sender, EventArgs e)
        {

        }
    }
}
