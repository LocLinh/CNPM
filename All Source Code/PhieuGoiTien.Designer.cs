
namespace App1
{
    partial class PhieuGoiTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaphieuLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.CMNDFindBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu gởi tiền";
            // 
            // MaphieuLabel
            // 
            this.MaphieuLabel.AutoSize = true;
            this.MaphieuLabel.Location = new System.Drawing.Point(398, 47);
            this.MaphieuLabel.Name = "MaphieuLabel";
            this.MaphieuLabel.Size = new System.Drawing.Size(172, 15);
            this.MaphieuLabel.TabIndex = 1;
            this.MaphieuLabel.Text = "Mã phiếu: <hệ thống tự động>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thông tin người gửi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(119, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "CMND/CCCD (*):";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(507, 217);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Đóng";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindButton.Location = new System.Drawing.Point(248, 205);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(118, 35);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Tìm kiếm";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // CMNDFindBox
            // 
            this.CMNDFindBox.Location = new System.Drawing.Point(253, 137);
            this.CMNDFindBox.Name = "CMNDFindBox";
            this.CMNDFindBox.Size = new System.Drawing.Size(146, 23);
            this.CMNDFindBox.TabIndex = 6;
            this.CMNDFindBox.Text = "Nhập thông tin";
            // 
            // PhieuGoiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 252);
            this.Controls.Add(this.CMNDFindBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaphieuLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhieuGoiTien";
            this.Text = "Phiếu gởi tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaphieuLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox CMNDFindBox;
    }
}