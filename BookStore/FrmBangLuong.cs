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
    public partial class FrmBangLuong : Form
    {
        NhanVienBus nvBus = new NhanVienBus();
        public FrmBangLuong()
        {
            InitializeComponent();
        }

        private void dgv_BangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDanhSach()
        {
            this.dgv_BangLuong.DataSource = nvBus.XemLuong();
        }

        private void FrmBangLuong_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
    }
}
