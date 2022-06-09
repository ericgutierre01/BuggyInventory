using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuggyInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            irBuggys();
        }

        async void irBuggys()
        {


            Buggys fm = new Buggys();
            this.Hide();
            fm.ShowDialog();
            this.Show();
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            irBuggys();
        }
    }
}
