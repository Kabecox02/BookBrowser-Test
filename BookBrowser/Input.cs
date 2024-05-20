using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookBrowser
{
    public partial class Input : Form
    {
        private string author;
        private string ISBN;
        private string publisher;
        private string title;
        private string genre;

        public Input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookBrowser_MainMenu form4 = new BookBrowser_MainMenu();
            form4.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            author = textBox1.Text;
            genre = textBox2.Text;
            publisher = textBox3.Text;
            title = textBox4.Text;
            ISBN = textBox5.Text;

            //validates that at least one box has an entry
            if (author.Length == 0 && genre.Length == 0 && publisher.Length == 0 && title.Length == 0 && ISBN.Length == 0)
            {
                isValid = false;
                MessageBox.Show("At least one field must be filled out");
            }
           // validates that ISBN field is only numbers
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("The ISBN field may only contain numbers");
                textBox5.Text = null;
            }
            //adds the information to the table
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;");
                conn.Open();

                SqlCommand cnn = new SqlCommand("insert into books values(@author,@genre,@ISBN,@publisher,@title)", conn);

                cnn.Parameters.AddWithValue("@author", (textBox1.Text));
                cnn.Parameters.AddWithValue("@Genre", (textBox2.Text));
                cnn.Parameters.AddWithValue("@ISBN", int.Parse(textBox5.Text));
                cnn.Parameters.AddWithValue("@publisher", (textBox3.Text));
                cnn.Parameters.AddWithValue("@Title", (textBox4.Text));

                cnn.ExecuteNonQuery();


                //OLD METHODS
                //SqlCommand sc = new SqlCommand("insert into books(author,@genre,@ISBN, @publisher, @title) values('" + textBox1.Text + "','" + textBox2.Text+"','"+textBox5.Text+"','" + textBox3.Text+"',"+textBox4.Text+");",conn);
                //object obj = sc.ExecuteNonQuery();
                //DialogResult dialogResult = MessageBox.Show(obj + " has been inserted");

                //string query = @"INSERT INTO Books (author, genre, ISBN, publisher, title) VALUES(" + textBox1.Text +"," + textBox2.Text + "," + (11) + "," + textBox3.Text+"," + textBox4.Text+")";
                //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
              
                conn.Close();
                MessageBox.Show("Book has been inserted successfully");
            }


        }
    }
}
