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
    public partial class STK : Form
    {
        public STK()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccessSoTietKiem DangKy = new DataAccessSoTietKiem();

            string invalid_Tinh = "Nhập tỉnh / thành phố";
            string invalid_LoaiTK = "Chọn loại tiết kiệm";
            string Loaikyhan = "01";

            var isNumeric = int.TryParse(TienGuiBox.Text, out int SoTienGoi);
            bool flag = true;

            if (TinhBox.Text == invalid_Tinh && DiaChiCuThe.Text.Length == 0)
            {
                flag = false;
                MessageBox.Show("Chua nhap dung dia chi!");
            }
            else if (HotenBox.Text.Length < 1)
            {
                flag = false;
                MessageBox.Show("Chua nhap ho ten!");
            }
            else if (CMNDBox.Text.Length == 0 && CMND_k_Box.Text.Length == 0)
            {
                flag = false;
                MessageBox.Show("Chua nhap CMND!");
            }
            else if (!isNumeric || SoTienGoi < 100000)
            {
                flag = false;
                MessageBox.Show("Nhap sai dinh dang so hoac so tien goi qua nho!");
            }
            else if (invalid_LoaiTK == DkyLTKBox.Text)
            {
                flag = false;
                MessageBox.Show("Vui long chon loai tiet kiem");
            }

            if (flag)
            {
                // xu ly cmnd
                string CMND;
                if (CMNDBox.Text.Length != 0)
                {
                    CMND = CMNDBox.Text;
                }
                else
                {
                    CMND = CMND_k_Box.Text;
                }

                string diachi = DiaChiCuThe.Text + ", " + PhuongBox.Text + QuanBox.Text + TinhBox.Text;
                // xu ly loai ky han
                if (DkyLTKBox.Text == "Không kỳ hạn")
                {
                    Loaikyhan = "01";
                }
                else if (DkyLTKBox.Text == "Hạn 3 tháng")
                {
                    Loaikyhan = "02";
                }
                else if (DkyLTKBox.Text == "Hạn 6 tháng")
                {
                    Loaikyhan = "03";
                }
                // xu ly ngay thang
                string NgayMoSo;
                NgayMoSo = dateTimePickerSTK.Value.Date.ToString("dd/MM/yyyy");

                // dang ky khach hang
                DangKy.SetKH(HotenBox.Text, diachi, CMND);

                // dang ky so tiet kiem
                DangKy.SetSTK(SoTienGoi, Loaikyhan, NgayMoSo);
                MessageBox.Show("Dang ky thanh cong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
