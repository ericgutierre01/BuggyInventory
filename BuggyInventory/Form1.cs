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
        }


        async void irPiezas()
        {
            Piezas fm = new Piezas();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            irBuggys();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            irPiezas();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            irPiezas();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            irBuggys();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            irPiezas();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            irPiezas();
        }
    }
}
