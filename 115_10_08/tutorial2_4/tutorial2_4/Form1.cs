using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void finland_Click(object sender, EventArgs e)
        {
            country.Text="芬蘭";
        }

        private void France_Click(object sender, EventArgs e)
        {
            country.Text="法國";
        }

        

        private void Gemany_Click_1(object sender, EventArgs e)
        {
            country.Text = "德國";
        }
    }
}
