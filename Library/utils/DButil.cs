using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Library.utils
{

    class DButil
    {
        public SqlConnection SqlOpen()
        {
            string conn = ConfigurationManager.ConnectionStrings["constr"].ConnectionString; //链接数据库
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            return con;
        }
    }
}
