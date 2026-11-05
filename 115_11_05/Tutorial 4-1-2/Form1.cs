using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double HIGH_SCORE = 95.0; 


            double test1, test2, test3, average;


            try
                {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                average = (test1 + test2 + test3) / 3.0;
                averageLabel.Text = average.ToString("n1");




                if (average >= HIGH_SCORE)
                {
                    MessageBox.Show("恭喜!平均分數及格");
                }

                else {MessageBox.Show("平均分數未達標準，請繼續努力!"); }
            }
            catch (FormatException)
            {
                // 當輸入內容不是有效數值時，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的數值作為三次測驗成績。");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入框與平均分數標籤的內容。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將輸入焦點移回第一個成績輸入框。
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
