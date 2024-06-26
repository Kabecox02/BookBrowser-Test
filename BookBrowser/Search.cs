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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookBrowser
{
    public partial class Search : Form
    {
        private string author;
        private string ISBN;
        private string publisher;
        private string title;
        public static bool hassearched;

        public Search()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
        }

        SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;");

        public void button1_Click(object sender, EventArgs e)
        {
            //Variables used
            author = textBox1.Text;
            ISBN = textBox2.Text;
            publisher = textBox3.Text;
            title = textBox4.Text;

            //Will catch if the user hasn't inserted any information into the search feature
            if (author.Length == 0 && ISBN.Length == 0 && publisher.Length == 0 && title.Length == 0)
            {
                MessageBox.Show("At least one field must be filled out");
            }
            
            else
            {
                //Creates a query that will display the table that fit within the parameters given by user
                //And adds said query into BookHistory for the History Form
                string query = @"SELECT * FROM Books WHERE Author = '" + textBox1.Text + "' OR ISBN = '" + textBox2.Text + "' OR Publisher = '"+textBox3.Text+"' OR Title = '"+textBox4.Text+ @"';
                                INSERT INTO BookHistory 
                                SELECT * FROM Books
                                WHERE Author = '" + textBox1.Text + "' OR ISBN = '" + textBox2.Text + "' OR Publisher = '" + textBox3.Text + "' OR Title = '" + textBox4.Text + "'; ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                //shows the program that the user has searched something
                hassearched = true; 
                
                //Displays the Results of the search
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                //Shows if the searched book isn't in the system
                dataGridView1.DataSource = dtable;
                if (dtable.Rows.Count < 1)
                {
                    MessageBox.Show("No results match this search criteria \n Please Try Again!");
                }

            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookBrowser_MainMenu form4 = new BookBrowser_MainMenu();
            form4.Show();
            this.Hide();
        }
    }
}
