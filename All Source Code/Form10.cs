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
    public partial class DSKH : Form
    {
        List<DSKHForm10> KHs = new List<DSKHForm10>();
        DataAccessFom10 db = new();
        public DSKH()
        {
            InitializeComponent();

            KHs = db.GetKHs("", -1, "00");
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            DS.SuspendLayout();
            DS.Controls.Clear();
            DS.RowStyles.Clear();
            DS.RowCount = 1;
            DS.Controls.Add(new Label() { Text = "STT" }, 0, 0);
            DS.Controls.Add(new Label() { Text = "Mã sổ" }, 1, 0);
            DS.Controls.Add(new Label() { Text = "Loại tiết kiệm" }, 2, 0);
            DS.Controls.Add(new Label() { Text = "Khách hàng" }, 3, 0);
            DS.Controls.Add(new Label() { Text = "Số dư" }, 4, 0);

            int len = KHs.Count;
            if (len > 0)
            {
                for (int i = 0; i < len; i++)
                {
                    DS.RowCount += 1;
                    DS.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
                    DS.Controls.Add(new Label() { Text = $"{i+1}" }, 0, i + 1);
                    DS.Controls.Add(new Label() { Text = KHs[i].MASOTIETKIEM }, 1, i + 1);
                    DS.Controls.Add(new Label() { Text = KHs[i].TENLOAITIETKIEM }, 2, i + 1);
                    DS.Controls.Add(new Label() { Text = KHs[i].TENKHACHHANG }, 3, i + 1);
                    DS.Controls.Add(new Label() { Text = KHs[i].SODU.ToString() }, 4, i + 1);
                }
            }
            DS.ResumeLayout(true);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nut tim kiem
            string name = this.searchNameBox.Text;
            int sodu = -1;
            string loaitk = "00";

            if (this.soduBox.Text == "nhỏ hơn 500.000 vnđ")
            {
                sodu = 1;
            }
            else if (this.soduBox.Text == "từ 500.000 vnđ đến 5.000.000 vnd")
            {
                sodu = 2;
            }
            else if (this.soduBox.Text == "trên 5.000.000 vnđ")
            {
                sodu = 3;
            }
            else
            {
                sodu = -1;
            }

            if (this.loaitkBox.Text == "Không kỳ hạn")
            {
                loaitk = "01";
            }
            else if (this.loaitkBox.Text == "Hạn 3 tháng")
            {
                loaitk = "02";
            }
            else if (this.loaitkBox.Text == "Hạn 6 tháng")
            {
                loaitk = "03";
            }
            else
            {
                loaitk = "00";
            }


            KHs = db.GetKHs(name, sodu, loaitk);

            UpdateBinding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
