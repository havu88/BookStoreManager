using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DBSQLServerUtils
    {
        static string userName = "sa";
        static string Password = "123456";
        

        public DBSQLServerUtils()
        {
        }

        public DBSQLServerUtils(string username, string password)
        {
            userName = username;
            Password = password;
        }

        public string conString()
        {
            
            return "Data Source=Admin-PC\\SQLEXPRESS;Initial Catalog=QLNS" +
                ";Persist Security Info=True;" +
                "User ID=" + userName + ";Password=" + Password;
            
        }
    }
}
