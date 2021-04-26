using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konditerka
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"LAPTOP-73SLB28S";
            string database = "projekt2";
            string sec = "True";

            return DBSQLServerUtils.GetDBConnection(datasource, database, sec);
        }
    }
}
