namespace tutorial2_3._2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.translateLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.spanishbutton = new System.Windows.Forms.Button();
            this.initilizebutton = new System.Windows.Forms.Button();
            this.gemanbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // translateLabel
            // 
            this.translateLabel.AutoSize = true;
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translateLabel.Location = new System.Drawing.Point(194, 194);
            this.translateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(469, 42);
            this.translateLabel.TabIndex = 0;
            this.translateLabel.Text = "                                             ";
            this.translateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(158, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(577, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "選擇語言，我告訴你怎麼說\"早安\"";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // spanishbutton
            // 
            this.spanishbutton.Location = new System.Drawing.Point(337, 294);
            this.spanishbutton.Name = "spanishbutton";
            this.spanishbutton.Size = new System.Drawing.Size(159, 99);
            this.spanishbutton.TabIndex = 2;
            this.spanishbutton.Text = "西班牙";
            this.spanishbutton.UseVisualStyleBackColor = true;
            this.spanishbutton.Click += new System.EventHandler(this.西班牙button_Click);
            // 
            // initilizebutton
            // 
            this.initilizebutton.Location = new System.Drawing.Point(63, 294);
            this.initilizebutton.Name = "initilizebutton";
            this.initilizebutton.Size = new System.Drawing.Size(176, 99);
            this.initilizebutton.TabIndex = 3;
            this.initilizebutton.Text = "義大利";
            this.initilizebutton.UseVisualStyleBackColor = true;
            this.initilizebutton.Click += new System.EventHandler(this.initilizebutton_Click);
            // 
            // gemanbutton
            // 
            this.gemanbutton.Location = new System.Drawing.Point(618, 294);
            this.gemanbutton.Name = "gemanbutton";
            this.gemanbutton.Size = new System.Drawing.Size(165, 98);
            this.gemanbutton.TabIndex = 4;
            this.gemanbutton.Text = "德國";
            this.gemanbutton.UseVisualStyleBackColor = true;
            this.gemanbutton.Click += new System.EventHandler(this.gemanbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 440);
            this.Controls.Add(this.gemanbutton);
            this.Controls.Add(this.initilizebutton);
            this.Controls.Add(this.spanishbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.translateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button spanishbutton;
        private System.Windows.Forms.Button initilizebutton;
        private System.Windows.Forms.Button gemanbutton;
    }
}

