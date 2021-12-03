using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FlowerShop.method
{
    class Backup
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader qlddr = null;

        string s = "Data Source=.\\;database=FlowerShop;uid=sa;pwd=123456";
        SqlConnection getcon;
        public SqlConnection getsqlconnect()
        {
            getcon = new SqlConnection(s);
            getcon.Open();
            return getcon;
        }
    }
}
