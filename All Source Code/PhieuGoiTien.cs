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
    public partial class PhieuGoiTien : Form
    {
        FoundKHGoiTien KH = new();
        int soluong = 100;
        public PhieuGoiTien()
        {
            InitializeComponent();
            DataAccessPhieuGoiTien count = new();
            soluong = count.CountPhieuGoi();

            this.MaphieuLabel.Text = "Ma phieu: " + soluong.ToString();
            
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DataAccessPhieuGoiTien DtGoiTien = new();
            KH = DtGoiTien.FindCMND(CMNDFindBox.Text);
            if (KH != null)
            {
                PhieuGoiTienIn4 Phieugoi = new();
                Phieugoi.Show();
                Phieugoi.ChangeValue(KH.TENKHACHHANG, KH.CMND, KH.DIACHI, KH.SODU, KH.TENLOAITIETKIEM);
                Phieugoi.MaphieuLabel.Text = soluong.ToString();
            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
