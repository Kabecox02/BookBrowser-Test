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
    public partial class History : Form
    {
        //Shared Variables From Search
        bool hassearched = Search.hassearched;

        public History()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=BookBrowser;Integrated Security=SSPI;");
            //Checks if there has been a search during the current session
            if (hassearched != true)
            {
                MessageBox.Show("No previous Search from this account");
            }
            //Shows the Table with all the previous searches from this user
            else
            {
                string query = "SELECT * FROM BookHistory";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable historytable = new DataTable();
                sda.Fill(historytable);

                HistoryGridView.DataSource = historytable;
            }

        }
        //Takes you back to Main Menu
        private void button1_Click(object sender, EventArgs e)
        {
            BookBrowser_MainMenu form4 = new BookBrowser_MainMenu();
            form4.Show();
            this.Hide();
        }

        private void HistoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}