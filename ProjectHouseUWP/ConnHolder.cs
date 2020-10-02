using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectHouseUWP
{
    class ConnHolder
    {
        private static string _connectionString = "";
        private static string connectionString { get => _connectionString; set => _connectionString = value; }

        public static void SetConnStr(string ConnectionString) => connectionString = ConnectionString;

        public static string GetConnStr() => connectionString;

        public static async Task<bool> CheckConAsync()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception eSql)
            {
                return false;
            }
        }

        public static async Task NonQueryAsyncConnect(string Query)
        {
            var changedRows = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnHolder.GetConnStr()))
                {
                    await conn.OpenAsync();
                    if (conn.State == ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = Query;
                            changedRows = cmd.ExecuteNonQuery();
                            //Debug.WriteLine(changedRows);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
