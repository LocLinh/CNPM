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
    public partial class PhieuGoiTienIn4Tien : Form
    {
        public PhieuGoiTienIn4Tien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(this.tiengoiBox.Text, out int tiengoi);
            if (check)
            {
                if (tiengoi >= 100000)
                {
                    DataAccessPhieuGoiTien goi = new();

                    string maphieu = this.maphieuLabel.Text;
                    string ngay = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                    string tien = this.tiengoiBox.Text;
                    string cmnd = this.cmndLabel.Text;

                    goi.InsertPhieuGoi(maphieu, ngay, tien, cmnd);
                    goi.UpdateSoduSTK(tien, cmnd);
                    MessageBox.Show("Gởi tiền thành công!");
                }
                else
                {
                    MessageBox.Show("Số tiền gởi quá nhỏ. Số tiền gởi không được bé hơn 100.000 vnd.\n\t\t Vui lòng thử lại!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
