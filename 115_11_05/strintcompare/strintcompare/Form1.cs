using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strintcompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compareButton_Click(object sender, System.EventArgs e)
        {
            string result = string.Equals(string1TextBox.Text, string2TextBox.Text)
                ? "兩個字串相同。"
                : "兩個字串不同。";

            MessageBox.Show(result, "比較結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
