using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = "";
            // TODO 1：新增優惠結果標籤後，每次試算也要將它重設為「—」。

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                if (days >= 1 && days <= 7)
                {
                    decimal dailyRate = 0m;
                    decimal total = 0m;
                    if (days == 1)
                    {
                        dailyRate = 100m;
                    }
                    else if (days == 2)
                    {
                        dailyRate = 90m;
                    }
                    else if (days == 3)
                    {
                        dailyRate = 80m;
                    }
                    else if (days == 4)
                    {
                        dailyRate = 70m;
                    }
                    else if (days == 5)
                    {
                        dailyRate = 60m;
                    }
                    else if (days == 6)
                    {
                        dailyRate = 50m;
                    }
                    else if (days == 7)
                    {
                        dailyRate = 40m;
                    }
                    total = dailyRate * days;
                    dailyRateLabel.Text = dailyRate.ToString("C");
                    totalLabel.Text = total.ToString("C");
                }
                else
                {
                    feedbackLabel.Text = "天數必須在 1 到 7 之間。";
                }
                       }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void resultGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void dailyRateCaptionLabel_Click(object sender, EventArgs e)
        {
            int days = 0;
        }

        private void dailyRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void daysTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
