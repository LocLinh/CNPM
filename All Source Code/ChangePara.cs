using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class ChangePara : Form
    {
        public ChangePara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Invalid = "<Nhập>";
            bool checkkyhan = int.TryParse(this.kyhanmoi1.Text, out int valid_kyhan);
            bool checklaisuat = double.TryParse(this.laisuatmoi1.Text, out double valid_ls);
            if (this.tenmoi1.Text == Invalid || this.laisuatmoi1.Text == Invalid || this.kyhanmoi1.Text == Invalid)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else if (checkkyhan)
            {
                if (checklaisuat)
                {
                    this.loaitkBox.Items.Add(this.tenmoi1.Text);
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Lãi suất mỗi tháng\n\t vd: 0.05");
                }
            }
            else
            {
                MessageBox.Show("Kỳ hạn là số ngày tối thiểu để được rút tiền!\n\t\t vd: 90");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string unchange = "<Nhập>";
            bool checktien = int.TryParse(this.tienmoi.Text, out int realmoney);
            bool checkngay = int.TryParse(this.ngaymoi.Text, out int kyhan);

            if (checktien)
            {
                this.tienhientai.Text = realmoney.ToString() + " vnđ";
            }
            else if (tienmoi.Text != unchange)
            {
                MessageBox.Show("Nhập số tiền không hợp lệ!");
            }

            if (checkngay)
            {
                this.ngayhientai.Text = kyhan.ToString() + " ngày";
            }

            MessageBox.Show("Thay đổi thành công!");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaitkBox.Text == "không kỳ hạn")
            {
                this.tenAuto.Text = "không kỳ hạn";
                this.laisuatAuto.Text = "0.5%";
                this.kyhanAuto.Text = "vĩnh viễn";
            }
            else if (loaitkBox.Text == "hạn 3 tháng")
            {
                this.tenAuto.Text = "hạn 3 tháng";
                this.laisuatAuto.Text = "5%";
                this.kyhanAuto.Text = "90 ngày";
            }
            else if (loaitkBox.Text == "hạn 6 tháng")
            {
                this.tenAuto.Text = "hạn 6 tháng";
                this.laisuatAuto.Text = "5.5%";
                this.kyhanAuto.Text = "180 ngày";
            }
            else
            {
                this.tenAuto.Text = "hạn 12 tháng";
                this.laisuatAuto.Text = "6%";
                this.kyhanAuto.Text = "365 ngày";
            }


        }
    }
}
