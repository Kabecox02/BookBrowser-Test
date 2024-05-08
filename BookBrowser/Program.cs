using System.Data.SqlClient;

namespace BookBrowser
{
    internal static class Program
    {
        /// <summary>  
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Connection string for SQL Server
            string connectionString = @"Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";

            // Create a SqlConnection object
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                // Open the connection
                conn.Open();

                // If connection is successful, run your form
                Application.Run(new Form3());
            }
            catch (Exception ex)
            {
                // Handle connection error
                MessageBox.Show("Connection error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }


        }
}   }