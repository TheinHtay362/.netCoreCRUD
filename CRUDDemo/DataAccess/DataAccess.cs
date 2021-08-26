using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CRUDDemo.DataAccess
{
    public class DataAccess
    {
        //Connect To DB
        public static SqlConnection Connect()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder("");
            SqlConnection conn = new SqlConnection();
            if (conn == null) conn = new SqlConnection(sb.ConnectionString);
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return conn;
            }
            conn = new SqlConnection(sb.ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
