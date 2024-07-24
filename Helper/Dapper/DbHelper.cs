using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Dapper
{
    public class DbHelper
    {
        // method to initialise sql connection
        public static SqlConnection SqlConnection()
        {
            var conn = new SqlConnection(DbConn.ConnectionString);
            conn.Open();
            return conn;
        }
        // method to execute procedure which accept sql procedure as parameter and return dynamic list
        public static IEnumerable<T> RunProc<T>(string sql, object parameter = null, DynamicParameters parameter1 = null)
        {
            using (var conn = SqlConnection())
            {
                var data = conn.Query<T>(sql, parameter, commandType:
                CommandType.StoredProcedure);
                return data;
            }
        }
        // method to execute sql query which accept sql query as parameter and return dynamic list
        public async static Task<IEnumerable<T>> RunQuery<T>(string sql, object param = null)
        {
            using (var conn = SqlConnection())
            {
                var data = await conn.QueryAsync<T>(sql, param);
                return data;
            }
        }

    }
}
