using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BookBrowser
{
    public partial class CreateAccountForm : Form
    {
        private SqlConnection? dbconnection; // to establish connection
        private SqlConnection? connection; // to keep Database connected to database


        public CreateAccountForm()
        {
            InitializeComponent();
            //InitializeDatabaseConnection();
        }

        // Method to initialize database connection
        /*private void InitializeDatabaseConnection()
        {
            try
            {
                string serverName = textBox3.Text; // Get server name from textbox3
                string connectionString = $"Data Source={serverName};Initial Catalog=YourDatabaseName;Integrated Security=True";
                connection = new SqlConnection(connectionString);

                connection.Open();
                MessageBox.Show("Database connection established successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
                // Optionally, handle the exception according to your application's requirements
            }
        }
        */
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        /*private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Email validation on TextChanged event
            if (!IsValidEmail(textBox1.Text))
            {
                // Display error if email is not valid
                errorProvider1.SetError(textBox1, "Invalid email address");
            }
            else
            {
                // Clear error if email is valid
                errorProvider1.SetError(textBox1, "");
            }
        }
        */
        // Regular expression for email validation
        /*private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Use regular expression to validate email
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Password validation on TextChanged event
            if (!IsValidPassword(textBox2.Text))
            {
                // Display error if password is not valid
                errorProvider2.SetError(textBox2, "Password must be at least 6 characters long");
            }
            else
            {
                // Clear error if password is valid
                errorProvider2.SetError(textBox2, "");
            }
        }
        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 6;
        }


        /*private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string serverName = textBox3.Text.Trim(); // Trim any extra whitespace

            // Check if the server name is not empty
            if (!string.IsNullOrEmpty(serverName))
            {
                try
                {
                    string connectionString = $"Data Source={serverName};Initial Catalog=YourDatabaseName;Integrated Security=True";
                    connection = new SqlConnection(connectionString);

                    connection.Open();
                    MessageBox.Show("Database connection established successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                    // Optionally, handle the exception according to your application's requirements
                }
            }
        
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;");
            conn.Open();

            SqlCommand cnn = new SqlCommand("insert into credentials values(@username,@password)", conn);

            cnn.Parameters.AddWithValue("@username", (textBox1.Text));
            cnn.Parameters.AddWithValue("@password", (textBox2.Text));
          

            cnn.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Account has been created successfully");





            /* Previous code
            if (connection != null && connection.State == ConnectionState.Open)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                

                try
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                        MessageBox.Show("User account created successfully.");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating user account: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Database connection is not established or closed.");
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookBrowser_LogIn LogIn = new BookBrowser_LogIn();
            LogIn.Show();
            this.Hide();
        }
    }
}
