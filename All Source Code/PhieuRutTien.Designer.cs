
namespace App1
{
    partial class PhieuRutTien
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelNguoiRut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Nhập thông tin";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(232, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(103, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "CMND/CCCD (*):";
            // 
            // LabelNguoiRut
            // 
            this.LabelNguoiRut.AutoSize = true;
            this.LabelNguoiRut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNguoiRut.Location = new System.Drawing.Point(44, 86);
            this.LabelNguoiRut.Name = "LabelNguoiRut";
            this.LabelNguoiRut.Size = new System.Drawing.Size(156, 21);
            this.LabelNguoiRut.TabIndex = 9;
            this.LabelNguoiRut.Text = "Thông tin người rút:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã phiếu: <hệ thống tự động>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phiếu rút tiền";
            // 
            // PhieuRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 283);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelNguoiRut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuRutTien";
            this.Text = "Phiếu rút tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelNguoiRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}