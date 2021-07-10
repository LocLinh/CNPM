using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace App1
{
    class DataAccessSoTietKiem
    {
        string MAKH;
        public void SetKH(string HoTen, string DiaChi, string CMND)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                try
                {
                    int KHcount = connection.Query<KhachHang>($"select * from KHACHHANG").ToList().Count;
                    if (KHcount + 1 < 10)
                    {
                        connection.Query<KhachHang>($"insert into KHACHHANG values ('0{KHcount+1}', '{HoTen}', '{DiaChi}', '{CMND}')");
                        MAKH = $"0{KHcount + 1}";
                    }
                    else
                    {
                        connection.Query<KhachHang>($"insert into KHACHHANG values ('{KHcount + 1}', '{HoTen}', '{DiaChi}', '{CMND}')");
                        MAKH = $"{KHcount + 1}";
                    }
                    
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Khong the dang ky do loi:\n {error}");
                }
            }
        }

        public void SetSTK(int SoTienGoi, string LoaiTK, string NgayMoSo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                try
                {
                    // loai tiet kiem
                    // 01: khong ky han
                    // 02: 3 thang
                    // 03: 6 thang
                    // co 2 loai tinh trang: Mo / Dong
                    // khi mo so thi tinh trang auto Mo
                    int STKcount = connection.Query<STK_class>($"select * from SOTIETKIEM").ToList().Count;

                    if (STKcount + 1 < 10)
                    {
                        // MASOTIETKIEM, MAKHACHHANG, SODU, MALOAITIETKIEM, NGAYMOSO, TINHTRANG
                        connection.Query<STK_class>($"insert into SOTIETKIEM values ('0{STKcount + 1}', '{MAKH}', {SoTienGoi}, '{LoaiTK}', '{NgayMoSo}', 'Mo')");
                    }
                    else
                    {
                        // MASOTIETKIEM, MAKHACHHANG, SODU, MALOAITIETKIEM, NGAYMOSO, TINHTRANG
                        connection.Query<STK_class>($"insert into SOTIETKIEM values ('{STKcount + 1}', '{MAKH}', {SoTienGoi}, '{LoaiTK}', '{NgayMoSo}', 'Mo')");
                    }
                
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Khong the dang ky do loi:\n {error}");
                }
            }
        }
    }
}
