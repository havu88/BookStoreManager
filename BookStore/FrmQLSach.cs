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
            if (txtMaSach.Text != "" &&  txtTenSach.Text != "" && txtDonGia.Text != "" && txtTonKho.Text != "" && txtMaNhomSach.Text != "" && txtTenNhomSach.Text != "")
            {
                try
                {
                    int DonGia = Convert.ToInt32(txtDonGia.Text);
                    try
                    {
                        int TonKho = Convert.ToInt32(txtTonKho.Text);
                        dtgvDSSach.Rows.Add(txtMaSach.Text, txtTenSach.Text, txtDonGia.Text, txtTonKho.Text, txtMaNhomSach.Text, txtTenNhomSach.Text);
                        refreshGD();
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
            int maSach = dtgvDSSach.CurrentCell.RowIndex;
            dtgvDSSach[0, maSach].Value = txtMaSach.Text;
            dtgvDSSach[1, maSach].Value = txtTenSach.Text;
            dtgvDSSach[2, maSach].Value = txtDonGia.Text;
            dtgvDSSach[3, maSach].Value = txtTonKho.Text;
            dtgvDSSach[4, maSach].Value = txtMaNhomSach.Text;
            dtgvDSSach[5, maSach].Value = txtTenNhomSach.Text;
            refreshGD();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            int maSach = dtgvDSSach.CurrentCell.RowIndex;
            if (MessageBox.Show("Bạn có muốn xóa thông tin này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtgvDSSach.Rows.RemoveAt(maSach);
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
    }
}
