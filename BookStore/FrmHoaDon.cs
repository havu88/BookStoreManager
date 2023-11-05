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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon(DataTable table)
        {
            InitializeComponent();
            loadHoaDon(table);
        }

        public void loadHoaDon(DataTable table)
        {
            lbMaHD.Text = table.Rows[0][0].ToString();
            lbNgayXuatHD.Text = table.Rows[0][1].ToString();
            lbTenKH.Text = table.Rows[0][2].ToString();
            lbSoLuong.Text = table.Rows[0][3].ToString();
            lbTriGiaHD.Text = table.Rows[0][4].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmHome home = new FrmHome();   
            home.Show();
        }
    }
}
