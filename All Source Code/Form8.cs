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
    public partial class PhieuRutIn4 : Form
    {
        public PhieuRutIn4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkCo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCo.Checked)
            {
                checkKhong.Checked = false;
            }
        }

        private void checkKhong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkKhong.Checked)
            {
                checkCo.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // xac nhan
            if (checkCo.Checked)
            {
                PhieuRutIn4Tien RutTien = new();
                RutTien.Show();
                RutTien.maphieuLabel.Text = this.maphieuLabel.Text;
                RutTien.hotenLabel.Text = this.hotenBox.Text;
                RutTien.soduLabel.Text = this.soduBox.Text;
                RutTien.cmndLabel.Text = this.cmndBox.Text;
            }
            else
            {
                this.Close();
            }

        }
    }
}
