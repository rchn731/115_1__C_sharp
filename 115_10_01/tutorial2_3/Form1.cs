using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial2_3._2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void initilizebutton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Bungiorno";
        }

        private void 西班牙button_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos dias";
        }

        private void gemanbutton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Guten Morgen";
        }
    }
}
