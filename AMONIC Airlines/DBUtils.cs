using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMONIC_Airlines
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"LAPTOP-73SLB28S";
            string database = "Session2_Sergeeva";
            string sec = "True";

            return DBSQLServerUtils.GetDBConnection(datasource, database, sec);
        }
    }
}
