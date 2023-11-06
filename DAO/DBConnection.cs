using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DBConnection
    {
        string strConn = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection conn = null;

        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable dttb = new DataTable();
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dttb);
            }
            catch (Exception exc)
            {
                string errorMessage = exc.Message;
                // Hiển thị thông báo lỗi
                Console.WriteLine(errorMessage);
            }
            finally
            {
                conn.Close();
            }
            return dttb;
        }
        public void Execute(string sqlStr)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thành công");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Thất bại  " + exc);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
