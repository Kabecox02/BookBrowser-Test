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
using static System.Security.Cryptography.RandomNumberGenerator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookBrowser
{
    public partial class Randomize : Form
    {
        public Randomize()
        {
            InitializeComponent();
        }
        //Initializes SQL connection on this Form
        SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;");

        //creates a variable for the random number generator
        Random x = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //Picks a random number from 1 - 10
            int randomnumber = x.Next(1, 10);
            //creates a table view for the random number picked
            string query = "SELECT * FROM Books WHERE ISBN = '" + randomnumber.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            //Fills the table for User
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            //Error message created incase something fails
            dataGridView1.DataSource = dtable;
            if (dtable.Rows.Count < 1)
            {
                MessageBox.Show("Unknown error arisen.\n Please Try Again!");
            }

        }
        //Returns back to Menu
        private void button2_Click(object sender, EventArgs e)
        {
            BookBrowser_MainMenu form4 = new BookBrowser_MainMenu();
            form4.Show();
            this.Hide();
        }
    }
}
