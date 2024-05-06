using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookBrowser
{
    internal static class Program
    {
        
        /// <summary>  
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
              string connectionString = "Server=N00BS-PC\\SQLEXPRESS01;Database=YourDatabaseName;Integrated Security=True;";
            
            /*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //test
                // Perform database operations here...

                connection.Close();
            }*/

            Application.Run(new Form3());
        }
    }
}