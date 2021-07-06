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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STK newSTK = new STK();
            newSTK.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePara NewSetting = new();
            NewSetting.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            PhieuGoiTien newPhieuGoi = new();
            newPhieuGoi.Show();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            PhieuRutTien newPhieuRut = new();
            newPhieuRut.Show();
        }

        private void AnalyticButton_Click(object sender, EventArgs e)
        {

        }

        private void DSKHButton_Click(object sender, EventArgs e)
        {
            DSKH newDS = new();
            newDS.Show();
        }
    }
}
