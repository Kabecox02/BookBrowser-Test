using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Security.Cryptography.RandomNumberGenerator;

namespace BookBrowser
{
    public partial class Randomize : Form
    {
        public Randomize()
        {
            InitializeComponent();
        }

        Random x = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //choose for me 
            int randomnumber = x.Next();
            MessageBox.Show("Your Random Book is Book number: " +  randomnumber.ToString());

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
