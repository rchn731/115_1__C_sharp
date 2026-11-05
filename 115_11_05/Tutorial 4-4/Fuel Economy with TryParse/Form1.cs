using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;   //
            double liters;  // Declare variables to hold the kilometers and liters values.  
            double kmpl;  // Declare a variable to hold the kilometers per liter value. 


            // Use TryParse to convert the text in the kilometersTextBox to a double.
            if (!double.TryParse(milesTextBox.Text, out km))
            {
                if (!double.TryParse(gallonsTextBox.Text, out liters))
                {
                    kmpl = km / liters;
                    mpgLabel.Text = kmpl.ToString("n2");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for kilometers.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for kilometers.");
            }
        }
            
               



        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void milesPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void gallonsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
