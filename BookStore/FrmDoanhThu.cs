using BUS;
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
    public partial class FrmDoanhThu : Form
    {
        public FrmDoanhThu()
        {
            InitializeComponent();
        }

        HoaDonBUS hdBUS = new HoaDonBUS();

        private void FrmDoanhThu_Load(object sender, EventArgs e)
        {
            mskTuNgay.Text = DateTime.Now.ToString("yyyy-MM-dd");
            mskToiNgay.Text = DateTime.Now.ToString("yyyy-MM-dd");

            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            dvgHoaDon.DataSource = hdBUS.LayDanhSachHoaDon();

            /*this.dgv_DSNCC.Columns["MaNCC"].Width = 100;
            this.dgv_DSNCC.Columns["TenNCC"].Width = 200;
            this.dgv_DSNCC.Columns["DiaChi"].Width = 200;
            this.dgv_DSNCC.Columns["SDT"].Width = 100;*/
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {

        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdSach_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdSPK_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
