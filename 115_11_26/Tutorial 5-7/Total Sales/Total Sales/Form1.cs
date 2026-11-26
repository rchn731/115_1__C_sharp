using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Total_Sales.txt");
                decimal total=0m
           while(inputFile.Read() != 0)
                {
                    total += Total_Sales;

            }
           EventLogSession 


            catch (Exception ex)
                    {
                        MessageBox.Show("發生錯誤:" + ex.message):    
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
