using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class Form1 : Form
    {
        const int YELLOW = 1;
        const int RED = 2;
        const int WHITE = 3;
        const int BLACK = 4;

        private int colorChoice = BLACK ;

        public Form1()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = YELLOW;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = RED;
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = WHITE;
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            colorChoice = BLACK;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();

            private void Form1_Paint(object sender, PaintEventArgs e)
            {
                
                switch (colorChoice)
                {
                    case YELLOW:
                        this.BackColor = Color.Yellow;
                        break;
                    case RED:
                        this.BackColor = Color.Red ;
                        break;
                    case WHITE:
                        this.BackColor = Color.White;
                        break;
                    default:
                        this.BackColor = Color.Black;
                        break;
                }
        }
    }
}
