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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            this.ControlBox = false; // Vô hiệu hóa ControlBox
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // Đặt FormBorderStyle thành FixedToolWindow
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
           
            TaiKhoan taikhoan = TaiKhoanBUS.Instance.xuLyDangNhap(taiKhoan, matKhau);
            if (taikhoan != null)
            {
                this.Hide();

                FrmHome home = new FrmHome();  
                home.ShowDialog();  
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
                
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
