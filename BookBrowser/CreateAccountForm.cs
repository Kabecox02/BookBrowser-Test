using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;


namespace BookBrowser
{
    public partial class CreateAccountForm : Form
    {
        public static CreateAccountForm instance;

        private SqlConnection conn;

        public SqlConnection Connection
        {
            get { return conn; }
        }
        // Property to indicate if the connection is successful
        public bool Connected { get; private set; }


        public CreateAccountForm()
        {
            InitializeComponent();
            // Initialize the connection object after the form is loaded
            InitializeConnection();
        }
        private void InitializeConnection()
        {
            // Connection string for SQL Server
            string connectionString = @"Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";

            // Create the connection object
            conn = new SqlConnection(connectionString);

            try
            {
                // Open the connection
                conn.Open();

                // Connection successful
                Connected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
        }

        private void CreateUsersTable()
        {
            // Create users table if not exists
            using (var cmd = new SqlCommand("CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, username TEXT, password TEXT)", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Validate the email format using a regular expression
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(textBox1.Text, emailPattern))
            {
                errorProvider1.SetError(textBox1, "Please enter a valid email address");
            }
            else
            {
                errorProvider1.SetError(textBox1, ""); // Clear the error message
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Validate the password format
            if (textBox2.Text.Length < 8)
            {
                errorProvider2.SetError(textBox2, "Password must be at least 8 characters long");
            }
            else
            {
                errorProvider2.SetError(textBox2, ""); // Clear the error message
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Validate the database path
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider3.SetError(textBox3, "Please enter a valid database path");
            }
            else
            {
                errorProvider3.SetError(textBox3, ""); // Clear the error message
            }
        }


    }
}