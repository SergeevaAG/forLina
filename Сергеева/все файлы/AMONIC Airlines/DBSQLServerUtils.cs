using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMONIC_Airlines
{
    public class DBSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database, string sec)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=" + sec;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
