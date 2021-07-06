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
            string invalid_Quan = "Nhập quận/huyện";
            string invalid_Phuong = "Nhập phường/xã";
            string invalid_DiaChi = "Nhập địa chỉ cụ thể (số nhà, tên tòa nhà, tên đường, tên khu vực)";
            string invalid_LoaiTK = "Chọn loại tiết kiệm";
            var isNumeric = int.TryParse(TienGuiBox.Text, out int SoTienGoi);
            bool flag = true;

            if (TinhBox.Text == invalid_Tinh && QuanBox.Text == invalid_Quan
                && PhuongBox.Text == invalid_Phuong && DiaChiCuThe.Text == invalid_DiaChi)
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
                MessageBox.Show("Dang ky thanh cong");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
