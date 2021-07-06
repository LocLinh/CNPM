
namespace App1
{
    partial class QuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenSTKbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnalyticButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SettingButton = new System.Windows.Forms.Button();
            this.DSKHButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(37, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sổ tiết kiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Created by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nguyễn Lộc Linh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trần Duy Quang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nguyễn Trí Tài";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // OpenSTKbutton
            // 
            this.OpenSTKbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenSTKbutton.BackgroundImage")));
            this.OpenSTKbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenSTKbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenSTKbutton.ForeColor = System.Drawing.Color.GhostWhite;
            this.OpenSTKbutton.ImageIndex = 1;
            this.OpenSTKbutton.Location = new System.Drawing.Point(543, 34);
            this.OpenSTKbutton.Name = "OpenSTKbutton";
            this.OpenSTKbutton.Size = new System.Drawing.Size(143, 104);
            this.OpenSTKbutton.TabIndex = 6;
            this.OpenSTKbutton.UseVisualStyleBackColor = true;
            this.OpenSTKbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(555, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mở sổ tiết kiệm";
            // 
            // depositButton
            // 
            this.depositButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("depositButton.BackgroundImage")));
            this.depositButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.depositButton.Location = new System.Drawing.Point(457, 170);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(143, 104);
            this.depositButton.TabIndex = 8;
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WithdrawButton.BackgroundImage")));
            this.WithdrawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WithdrawButton.Location = new System.Drawing.Point(636, 170);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(143, 104);
            this.WithdrawButton.TabIndex = 9;
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(496, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gửi tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(675, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Rút tiền";
            // 
            // AnalyticButton
            // 
            this.AnalyticButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnalyticButton.BackgroundImage")));
            this.AnalyticButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnalyticButton.Location = new System.Drawing.Point(457, 322);
            this.AnalyticButton.Name = "AnalyticButton";
            this.AnalyticButton.Size = new System.Drawing.Size(143, 104);
            this.AnalyticButton.TabIndex = 12;
            this.AnalyticButton.UseVisualStyleBackColor = true;
            this.AnalyticButton.Click += new System.EventHandler(this.AnalyticButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(464, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Thống kê báo cáo";
            // 
            // SettingButton
            // 
            this.SettingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingButton.BackgroundImage")));
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingButton.Location = new System.Drawing.Point(750, 34);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(38, 33);
            this.SettingButton.TabIndex = 14;
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // DSKHButton
            // 
            this.DSKHButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DSKHButton.BackgroundImage")));
            this.DSKHButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DSKHButton.Location = new System.Drawing.Point(636, 322);
            this.DSKHButton.Name = "DSKHButton";
            this.DSKHButton.Size = new System.Drawing.Size(143, 104);
            this.DSKHButton.TabIndex = 15;
            this.DSKHButton.UseVisualStyleBackColor = true;
            this.DSKHButton.Click += new System.EventHandler(this.DSKHButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(625, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Danh sách khách hàng";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DSKHButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AnalyticButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OpenSTKbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenSTKbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AnalyticButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button DSKHButton;
        private System.Windows.Forms.Label label10;
    }
}