using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class TestDatabase : System.Web.UI.Page
{
    protected void btnTestConnection_Click(object sender, EventArgs e)
    {
        // Read the connection string from Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["TESDBConnection"].ConnectionString.ToString();

        try
        {
            // Test the database connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Response.Write("Database connection successful!");
            }
        }
        catch (Exception ex)
        {
            Response.Write("Database connection failed: " + ex.Message);
        }
    }
}
