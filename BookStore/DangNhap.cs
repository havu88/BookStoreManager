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
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            /*DBSQLServerUtils con = new DBSQLServerUtils(taiKhoan, matKhau);*/
            TaiKhoan taikhoan = TaiKhoanBUS.Instance.xuLyDangNhap(taiKhoan, matKhau);
            if (taikhoan != null)
            {

                FrmHome home = new FrmHome();  
                home.ShowDialog();  
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
        }
    }
}
