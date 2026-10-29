using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 建立表單上的所有控制項與初始設定。
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           const int BASE_HOURS = 40; // 基本工時
            const decimal OVERTIME_RATE = 1.5m; // 加班費率
            // 取得使用者輸入的工作時數與每小時薪資。
            decimal hoursWorked = Convert.ToDecimal(hoursWorkedTextBox.Text);
            decimal hourlyPayRate = Convert.ToDecimal(hourlyPayRateTextBox.Text);
            decimal grossPay;
            // 計算總薪資，考慮加班情況。
            if (hoursWorked <= BASE_HOURS)
            {
                grossPay = hoursWorked * hourlyPayRate;
            }
            else
            {
                decimal overtimeHours = hoursWorked - BASE_HOURS;
                grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_RATE);
            }
            // 將計算結果顯示在總薪資標籤上，格式化為貨幣形式。
            grossPayLabel.Text = grossPay.ToString("C"); 


            try
                {
                // 嘗試將使用者輸入的工作時數與每小時薪資轉換為數值。
                hoursWorked = Convert.ToDecimal(hoursWorkedTextBox.Text);
                hourlyPayRate = Convert.ToDecimal(hourlyPayRateTextBox.Text);
            }
            catch (FormatException)
            {
                // 如果輸入格式不正確，顯示錯誤訊息並清除輸入欄位。
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hoursWorkedTextBox.Clear();
                hourlyPayRateTextBox.Clear();
                grossPayLabel.Text = "";
                return;
            }








        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除工作時數、每小時薪資與總薪資欄位的內容。
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 清除後將輸入焦點移回工作時數欄位。
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的薪資計算表單。
            this.Close();
        }
    }
}
