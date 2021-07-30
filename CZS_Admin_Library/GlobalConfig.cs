using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZS_Admin_Library.DataAccess;

namespace CZS_Admin_Library
{
    public class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeSql()
        {
            var sql = new SqlConnector();
            Connection = sql;
        }
    }
}
