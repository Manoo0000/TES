using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TrainingExcellenceSystem.DAL
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        // Constructor to initialize the connection string from Web.config
        public DatabaseHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["TESDBConnection"].ConnectionString;
        }

        // Method to execute a query and return a DataTable
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        // Method to execute a non-query command (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
