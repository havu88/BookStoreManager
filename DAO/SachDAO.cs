using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class SachDAO
    {
        private static SachDAO instance;
        public static SachDAO Instance
        {
            get { if (instance == null) instance = new SachDAO(); return SachDAO.instance; }
            private set { SachDAO.instance = value; }
        }

        public List<Sach> hienThiSach()
        {
            try
            { 
                List<Sach> danhSachSach = new List<Sach>();
                string query = @"proc_DanhSachSach";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in table.Rows)
                {
                    Sach sach = new Sach();
                    danhSachSach.Add(sach);
                }
                return danhSachSach;
            }
            catch
            {
                return null;
            }
        }
    }
}
