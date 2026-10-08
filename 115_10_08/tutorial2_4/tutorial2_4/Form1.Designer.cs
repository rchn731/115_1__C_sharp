namespace tutorial2_4
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
            this.Gemany = new System.Windows.Forms.PictureBox();
            this.France = new System.Windows.Forms.PictureBox();
            this.finland = new System.Windows.Forms.PictureBox();
            this.country = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gemany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.France)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finland)).BeginInit();
            this.SuspendLayout();
            // 
            // Gemany
            // 
            this.Gemany.Image = global::tutorial2_4.Properties.Resources.Germany;
            this.Gemany.Location = new System.Drawing.Point(815, 148);
            this.Gemany.Name = "Gemany";
            this.Gemany.Size = new System.Drawing.Size(221, 145);
            this.Gemany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gemany.TabIndex = 2;
            this.Gemany.TabStop = false;
            this.Gemany.Click += new System.EventHandler(this.Gemany_Click_1);
            // 
            // France
            // 
            this.France.Image = global::tutorial2_4.Properties.Resources.France;
            this.France.Location = new System.Drawing.Point(430, 148);
            this.France.Name = "France";
            this.France.Size = new System.Drawing.Size(218, 145);
            this.France.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.France.TabIndex = 1;
            this.France.TabStop = false;
            this.France.Click += new System.EventHandler(this.France_Click);
            // 
            // finland
            // 
            this.finland.Image = global::tutorial2_4.Properties.Resources.Finland;
            this.finland.Location = new System.Drawing.Point(56, 148);
            this.finland.Name = "finland";
            this.finland.Size = new System.Drawing.Size(237, 145);
            this.finland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finland.TabIndex = 0;
            this.finland.TabStop = false;
            this.finland.Click += new System.EventHandler(this.finland_Click);
            // 
            // country
            // 
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.country.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.country.Location = new System.Drawing.Point(362, 370);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(391, 90);
            this.country.TabIndex = 5;
            this.country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(116, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(920, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "點選一個國旗，我告訴你是哪個國家";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.country);
            this.Controls.Add(this.Gemany);
            this.Controls.Add(this.France);
            this.Controls.Add(this.finland);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gemany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.France)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finland)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finland;
        private System.Windows.Forms.PictureBox France;
        private System.Windows.Forms.PictureBox Gemany;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label label1;
    }
}

