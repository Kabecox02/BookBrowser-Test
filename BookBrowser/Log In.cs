using System;
using System.Data;
using System.Data.SqlClient;


namespace BookBrowser
{
    public partial class BookBrowser_LogIn : Form
    {
        public BookBrowser_LogIn()
        {
            InitializeComponent();
        }
        //Add Database info Here
        SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            // These strings are stored after the user's account is created.
            // The db will verify if the user is in the system granting access.
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;"))
                {
                    string query = "SELECT * FROM credentials WHERE username = @username AND password = @password";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@username", username);
                    sda.SelectCommand.Parameters.AddWithValue("@password", password);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        // Proceed with your logic here, like opening the main menu form
                        BookBrowser_MainMenu form4 = new BookBrowser_MainMenu();
                        form4.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CreateAccountForm createAccountForm = new CreateAccountForm();
                createAccountForm.Show();
                this.Hide();
            }
            catch { }
        }
    }
}