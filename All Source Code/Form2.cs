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
    public partial class BCDS : Form
    {
    
        public BCDS()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không tìm thấy máy in!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công báo cáo ở đường dẫn file: %USERPROFILE%\\Document\\App1\\BaoCao\\");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string date = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
            string day = this.dateTimePicker1.Value.Day.ToString();
            string month = this.dateTimePicker1.Value.Month.ToString();

            DataAccessBaoCao dt = new();
            int chikkh = dt.TongChi(date, day, month, "01");
            int chi3 = dt.TongChi(date, day, month, "02");
            int chi6 = dt.TongChi(date, day, month, "03");
            int thukkh = dt.TongThu(date, "01");
            int thu3 = dt.TongThu(date, "02");
            int thu6 = dt.TongThu(date, "03");
            int thuAll = 0, chiAll = 0;

            this.thuKKH.Text = thukkh.ToString();
            this.thu3.Text = thu3.ToString();
            this.thu6.Text = thu6.ToString();

            thuAll = (thukkh + thu3 + thu6);
            this.thuAll.Text = thuAll.ToString();

            this.chiKKH.Text = chikkh.ToString();
            this.chi3.Text = chi3.ToString();
            this.chi6.Text = chi6.ToString();

            chiAll = (chikkh + chi3 + chi6);
            this.chiAll.Text = chiAll.ToString();

            this.diffKKH.Text = (thukkh - chikkh).ToString();
            this.diff3.Text = (thu3 - chi3).ToString();
            this.diff6.Text = (thu6 - chi6).ToString();
            this.diffAll.Text = (thuAll - chiAll).ToString();
        }
    }
}
