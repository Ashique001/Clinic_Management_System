using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Clininc_Management_System.Data
{
    /// <summary>
    /// Central helper for obtaining SQL connections and executing parameterized commands.
    /// Uses the existing connection string from configuration (name must match your App.config).
    /// </summary>
    public static class Database
    {
        // NOTE: We do NOT create or change the connection string here; we only read it.
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["ClinicDb"].ConnectionString;

        public static SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public static SqlCommand CreateCommand(SqlConnection connection, string sql, CommandType commandType = CommandType.Text)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = commandType;
            return cmd;
        }
    }
}


