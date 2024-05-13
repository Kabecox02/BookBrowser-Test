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
       
            //Database connection
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;");
        private string connectionString;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;


            username = textBox1.Text;
            password = textBox2.Text;
            //creating a query that pulls up any mathcing tables that match the credentials
            try
            {
                string query = "SELECT * FROM credentials WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;

                    BookBrowser_MainMenu form4 = new BookBrowser_MainMenu();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                    textBox1.Clear();
                    textBox2.Clear();
                }


            }
            catch
            {
                MessageBox.Show("Invalid Login \n Please try again");
                textBox1.Clear();
                textBox2.Clear();
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccountForm form7 = new CreateAccountForm();
            form7.Show();
            this.Hide();
        }
    
    }
}