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
    public partial class PhieuGoiTienIn4 : Form
    {
        public PhieuGoiTienIn4()
        {
            InitializeComponent();
        }

        private void ChoseCo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChoseCo.Checked == true)
            {
                ChoseKhong.Checked = false;
            }
        }

        private void ChoseKhong_CheckedChanged(object sender, EventArgs e)
        {
            if (ChoseKhong.Checked == true)
            {
                ChoseCo.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChoseCo.Checked)
            {
                PhieuGoiTienIn4Tien Phieu = new();
                Phieu.Show();
                Phieu.maphieuLabel.Text = this.MaphieuLabel.Text;
                Phieu.HotenBox.Text = this.HotenLabel.Text;
                Phieu.cmndLabel.Text = this.cmndLabel.Text;
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
