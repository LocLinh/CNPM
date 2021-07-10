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
    public partial class PhieuRutTien : Form
    {
        int soluong = 0;
        DataAccessPhieuRutTien rut = new();
        FoundKHRutTien KHRUT = new();
        public PhieuRutTien()
        {
            InitializeComponent();
            soluong = rut.CountPhieuRut();
            this.maphieurutBox.Text = soluong.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmnd = this.cmndBox.Text;
            KHRUT = rut.FindCMND(cmnd);
            if (KHRUT != null)
            {
                PhieuRutIn4 Phieurut = new();

                Phieurut.Show();

                DateTime NgayMo = rut.GetSTKOpenDate(cmnd);
                DateTime Homnay = DateTime.Now;
                int daydiff = (Homnay - NgayMo).Days;
                this.maphieurutBox.Text = daydiff.ToString();

                KHRUT = rut.FindCMND(cmnd);
                Phieurut.ChangeValues(KHRUT.TENKHACHHANG, KHRUT.CMND, KHRUT.DIACHI, KHRUT.SODU, KHRUT.TENLOAITIETKIEM);

                Phieurut.maphieuLabel.Text = soluong.ToString();

                if (KHRUT.TENLOAITIETKIEM == "khong ky han")
                {
                    if (daydiff <= 15)
                    {
                        Phieurut.infoLabel.Visible = true;
                        Phieurut.muonrutLabel.Visible = false;
                        Phieurut.checkCo.Visible = false;
                        Phieurut.checkKhong.Visible = false;
                    }
                    else
                    {
                        Phieurut.infoLabel.Visible = false;
                        Phieurut.muonrutLabel.Visible = true;
                        Phieurut.checkCo.Visible = true;
                        Phieurut.checkKhong.Visible = true;
                    }
                }
                else if (KHRUT.TENLOAITIETKIEM == "3 thang")
                {
                    if (daydiff <= 90)
                    {
                        Phieurut.infoLabel.Visible = true;
                        Phieurut.muonrutLabel.Visible = false;
                        Phieurut.checkCo.Visible = false;
                        Phieurut.checkKhong.Visible = false;
                    }
                    else
                    {
                        Phieurut.infoLabel.Visible = false;
                        Phieurut.muonrutLabel.Visible = true;
                        Phieurut.checkCo.Visible = true;
                        Phieurut.checkKhong.Visible = true;
                    }
                }
                else if (KHRUT.TENLOAITIETKIEM == "6 thang")
                {
                    if (daydiff <= 180)
                    {
                        Phieurut.infoLabel.Visible = true;
                        Phieurut.muonrutLabel.Visible = false;
                        Phieurut.checkCo.Visible = false;
                        Phieurut.checkKhong.Visible = false;
                    }
                    else
                    {
                        Phieurut.infoLabel.Visible = false;
                        Phieurut.muonrutLabel.Visible = true;
                        Phieurut.checkCo.Visible = true;
                        Phieurut.checkKhong.Visible = true;
                    }
                }
                else
                {
                    Phieurut.infoLabel.Visible = true;
                    Phieurut.infoLabel.Text = "Loi ko thuoc 3 loai ky han!";
                    Phieurut.muonrutLabel.Visible = false;
                    Phieurut.checkCo.Visible = false;
                    Phieurut.checkKhong.Visible = false;
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
