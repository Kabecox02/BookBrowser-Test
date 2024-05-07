using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBrowser
{
    public partial class Search : Form
    {
        private string author;
        private string ISBN;
        private string publisher;
        private string title;

        public Search()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            author = textBox1.Text;
            ISBN = textBox2.Text;
            publisher = textBox3.Text;
            title = textBox4.Text;

            if (author.Length == 0 && ISBN.Length == 0 && publisher.Length == 0 && title.Length == 0)
            {
                isValid = false;
                MessageBox.Show("At least one field must be filled out");
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
