using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string tenTK;
        private string email;
        private string mk;
        private string vaiTro;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTK, string email, string mk, string vaiTro)
        {
            this.tenTK = tenTK;
            this.email = email;
            this.mk = mk;
            this.vaiTro = vaiTro;
        }

        public TaiKhoan(DataRow row)
        {
            tenTK = row["TenTK"].ToString();
            mk = row["MK"].ToString();
            email = row["Email"].ToString();
            vaiTro = row["VaiTro"].ToString();
        }
        public string TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MK
        {
            get { return mk; }
            set { mk = value; }
        }

        public string VaiTro
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }
    }
}
