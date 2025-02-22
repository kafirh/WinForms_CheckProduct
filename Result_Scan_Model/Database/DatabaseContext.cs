using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Result_Scan_Model.Data
{
    public class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["LSBUConnection"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
