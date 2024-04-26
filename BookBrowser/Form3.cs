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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Add Database info Here
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-R5VTNH0\SQLEXPRESS;Database=YourDatabaseName;Integrated Security=True;");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = textBox1.Text;
            password = textBox2.Text;
            //NEED TO ADD THE TABLE NAME HERE NOT "credentials"
            try
            {
                string query = "SELECT * FROM credentials WHERE username = '"+textBox1.Text+"' AND password = '"+textBox2.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;

                    Form2 form4 = new Form2();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                    textBox1.Clear();
                    textBox2.Clear();
                }


            }
            catch 
            {
                MessageBox.Show("Invalid Login");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
