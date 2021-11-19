using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Entity.Core.EntityClient;

namespace QuanLyCafe.DBaccess
{
    class SQLHelper
    {
        SqlConnection cn;
        public SQLHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
