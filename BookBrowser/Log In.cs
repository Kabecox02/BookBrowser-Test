using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string username, password;


            username = textBox1.Text;
            password = textBox2.Text;
            //NEED TO ADD THE TABLE NAME HERE NOT "credentials"
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

        }
    }
}
