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
    public partial class PhieuRutIn4Tien : Form
    {
        public PhieuRutIn4Tien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sotien = this.sotienLabel.Text;
            bool check = int.TryParse(sotien, out int tienrut);

            string tiendu = this.soduLabel.Text;
            bool check1 = int.TryParse(tiendu, out int sodu);

            if (check)
            {
                if (check1)
                {
                    if (tienrut <= sodu)
                    {
                        DataAccessPhieuRutTien rut = new();
                        string maphieu = this.maphieuLabel.Text;
                        string ngay = this.dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                        string tien = sotien.ToString();
                        string cmnd = this.cmndLabel.Text;
                        rut.InsertPhieuRut(maphieu, ngay, tien, cmnd);
                        rut.UpdateSoduSTK(tien, cmnd);
                        this.soduLabel.Text = (sodu - tienrut).ToString();
                        MessageBox.Show("Rút tiền thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Vui long nhap so tien hop le!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap so tien hop le!");
            }

        }
    }
}
