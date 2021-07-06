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
        public DSKH()
        {
            InitializeComponent();
            // DS.Controls.Add(new Label() { Text = "alo" }, 1, 1);
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            // DS.GetControlFromPosition(1, 1).Text = KHs[0].TENKHACHHANG;
            int len = KHs.Count;
            for (int i = 0; i < len; i++)
            {
                DS.Controls.Add(new Label() { Text = KHs[i].MAKHACHHANG }, 1, i + 1);
                DS.Controls.Add(new Label() { Text = KHs[i].TENKHACHHANG }, 2, i + 1);
                DS.Controls.Add(new Label() { Text = KHs[i].DIACHI }, 3, i + 1);
                DS.Controls.Add(new Label() { Text = KHs[i].CMND.ToString() }, 4, i + 1);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nut tim kiem
            DataAccessForm10 db = new DataAccessForm10();

            KHs = db.GetKHs(searchNameBox.Text);

            UpdateBinding();
        }
    }
}
