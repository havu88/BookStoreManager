using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStore
{
    public partial class FrmQuanLySPK : Form
    {
        //SqlConnection connection;
        //SqlCommand command;
        //string str = "Data Source=LOCALHOST;Initial Catalog=QLNS;Integrated Security=True";
        //SqlDataAdapter adapter = new SqlDataAdapter();
        //DataTable table = new DataTable();
        public FrmQuanLySPK()
        {
            InitializeComponent();
            LoadData();
        }

        private void refreshGD()
        {
            txtMaSPK.Text = "";
            txtTenSPK.Text = "";
            txtDonGiaSPK.Text = "";
            txtTonKhoSPK.Text = "";
        }

        BindingSource dsSPK = new BindingSource();
        void LoadData()
        {
            dtgvSanPhamKhac.DataSource = dsSPK;
            LoadDSSPK();
        }
        void LoadDSSPK()
        {
            //command = connection.CreateCommand();
            //command.CommandText = "SELECT * FROM SanPhamKhac";
            //adapter.SelectCommand = command;
            //table.Clear();
            //adapter.Fill(table);
            //dtgvSanPhamKhac.DataSource = table;
            dsSPK.DataSource = SanPhamKhacDAO.Instance.hienThiSanPhamKhac();
        }
        private void FrmQuanLySPK_Load(object sender, EventArgs e)
        {
            //connection = new SqlConnection(str);
            //connection.Open();
            //loaddata();
        }

        private void dtgvSanPhamKhac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgvSanPhamKhac.CurrentRow.Index;
            txtMaSPK.Text = dtgvSanPhamKhac.Rows[i].Cells[0].Value.ToString();
            txtTenSPK.Text = dtgvSanPhamKhac.Rows[i].Cells[1].Value.ToString();
            txtDonGiaSPK.Text = dtgvSanPhamKhac.Rows[i].Cells[2].Value.ToString();
            txtTonKhoSPK.Text = dtgvSanPhamKhac.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThemSPK_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "EXEC [dbo].[proc_themSPKMoi] @MaSPK = '"+txtMaSPK.Text+ "',@TenSPK = N'"+txtTenSPK.Text+ "', @DonGia = '"+txtDonGiaSPK.Text+ "', @TonKho = '"+txtTonKhoSPK.Text+"'";
            //command.ExecuteNonQuery();
            //loaddata();
            //refreshGD();
            string maSPK = txtMaSPK.Text;
            string tenSPK = txtTenSPK.Text;
            float donGiaSPK = Convert.ToSingle(txtDonGiaSPK.Text);
            int tonKhoSPK = Convert.ToInt32(txtTonKhoSPK.Text);

            if (txtMaSPK.Text != "" && txtTenSPK.Text != "" && txtDonGiaSPK.Text != "" && txtTonKhoSPK.Text != "")
            {
                try
                {
                    try
                    {
                        int TonKho = Convert.ToInt32(txtTonKhoSPK.Text);
                        if (SanPhamKhacDAO.Instance.ThemSPK(maSPK, tenSPK, donGiaSPK, tonKhoSPK))
                        {
                            MessageBox.Show("Thêm sản phẩm thành công");
                            LoadDSSPK();
                            refreshGD();
                            if (themspk != null)
                                themspk(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm sản phẩm mới");
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

        private void dtgvSanPhamKhac_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSuaSPK_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "EXEC [dbo].[proc_suaSPK] @MaSPK = '"+txtMaSPK.Text+"',@TenSPK = N'"+txtTenSPK.Text+"', @DonGia = '"+txtDonGiaSPK.Text+"', @TonKho = '"+txtTonKhoSPK.Text+"'";
            //command.ExecuteNonQuery();
            //loaddata();
            //refreshGD();
            string maSPK = txtMaSPK.Text;
            string tenSPK = txtTenSPK.Text;
            float donGiaSPK = Convert.ToSingle(txtDonGiaSPK.Text);
            int tonKhoSPK = Convert.ToInt32(txtTonKhoSPK.Text);
           
            if (SanPhamKhacDAO.Instance.SuaSPK(maSPK, tenSPK, donGiaSPK, tonKhoSPK))
            {
                MessageBox.Show("Sửa sản phẩm thành công");
                LoadDSSPK();
                refreshGD();
                if (suaspk != null)
                    suaspk(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa sản phẩm");
            }
        }

        private void btnXoaSPK_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "EXEC [dbo].[proc_xoaSPK] @MaSPK = '" + txtMaSPK.Text + "'";
            //command.ExecuteNonQuery();
            //loaddata();
            //refreshGD();
            string maSPK = txtMaSPK.Text;
           
            if (SanPhamKhacDAO.Instance.XoaSPK(maSPK))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                LoadDSSPK();
                refreshGD();
                if (xoaspk != null)
                    xoaspk(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa sản phẩm");
            }

        }
        private event EventHandler themspk;
        public event EventHandler Themspk
        {
            add { themspk += value; }
            remove { themspk -= value; }
        }

        private event EventHandler xoaspk;
        public event EventHandler Xoaspk
        {
            add { xoaspk += value; }
            remove { xoaspk -= value; }
        }

        private event EventHandler suaspk;
        public event EventHandler Suaspk
        {
            add { suaspk += value; }
            remove { suaspk -= value; }
        }
    }
}
