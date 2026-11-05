namespace strintcompare
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label string1Label;
        private System.Windows.Forms.Label string2Label;
        private System.Windows.Forms.TextBox string1TextBox;
        private System.Windows.Forms.TextBox string2TextBox;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Button exitButton;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.string1Label = new System.Windows.Forms.Label();
            this.string2Label = new System.Windows.Forms.Label();
            this.string1TextBox = new System.Windows.Forms.TextBox();
            this.string2TextBox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // string1Label
            // 
            this.string1Label.AutoSize = true;
            this.string1Label.Location = new System.Drawing.Point(40, 35);
            this.string1Label.Name = "string1Label";
            this.string1Label.Size = new System.Drawing.Size(50, 15);
            this.string1Label.TabIndex = 0;
            this.string1Label.Text = "字串1：";
            // 
            // string2Label
            // 
            this.string2Label.AutoSize = true;
            this.string2Label.Location = new System.Drawing.Point(40, 80);
            this.string2Label.Name = "string2Label";
            this.string2Label.Size = new System.Drawing.Size(50, 15);
            this.string2Label.TabIndex = 1;
            this.string2Label.Text = "字串2：";
            // 
            // string1TextBox
            // 
            this.string1TextBox.Location = new System.Drawing.Point(110, 32);
            this.string1TextBox.Name = "string1TextBox";
            this.string1TextBox.Size = new System.Drawing.Size(250, 23);
            this.string1TextBox.TabIndex = 2;
            // 
            // string2TextBox
            // 
            this.string2TextBox.Location = new System.Drawing.Point(110, 77);
            this.string2TextBox.Name = "string2TextBox";
            this.string2TextBox.Size = new System.Drawing.Size(250, 23);
            this.string2TextBox.TabIndex = 3;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(110, 125);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(100, 30);
            this.compareButton.TabIndex = 4;
            this.compareButton.Text = "比較";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(260, 125);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 190);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.string2TextBox);
            this.Controls.Add(this.string1TextBox);
            this.Controls.Add(this.string2Label);
            this.Controls.Add(this.string1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字串比較";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

