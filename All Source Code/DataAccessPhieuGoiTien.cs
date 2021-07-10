using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    class DataAccessPhieuGoiTien
    {
        public FoundKHGoiTien FindCMND(string cmnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                bool check = int.TryParse(cmnd, out int real_cmnd);
                string cmd = "";
                if (check)
                {
                    cmd = $"SELECT K.TENKHACHHANG , K.CMND , K.DIACHI ,S.SODU , L.TENLOAITIETKIEM FROM SOTIETKIEM S JOIN KHACHHANG K on S.MAKHACHHANG = K.MAKHACHHANG JOIN LOAITIETKIEM L on S.MALOAITIETKIEM = L.MALOAITIETKIEM WHERE K.CMND = '{cmnd}'";
                    // FoundKHGoiTien res = new();
                    FoundKHGoiTien res = connection.Query<FoundKHGoiTien>(cmd).FirstOrDefault();
                    if (res == null)
                    {
                        MessageBox.Show("Khong ton tai nguoi dung!");
                    }
                    return res;
                }
                else
                {
                    MessageBox.Show("Khong ton tai nguoi dung!");
                }
                return null;
                
            }
        }

        public int CountPhieuGoi()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                
                string cmd = $"SELECT COUNT(*) AS SOLUONG FROM PHIEUGUITIEN";
                // FoundKHGoiTien res = new();
                string res = connection.Query<int>(cmd).FirstOrDefault().ToString();
                bool check = int.TryParse(res, out int SOLUONG);
                if (check)
                {
                    return SOLUONG + 1;
                }

                return 100;

            }
        }

        public void InsertPhieuGoi(string maphieugui, string ngay, string tien, string cmnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd = $"INSERT INTO PHIEUGUITIEN ( MAPHIEUGUITIEN ,MASOTIETKIEM, MAKHACHHANG, NGAYGUI,SOTIENGUI)" +
                    $" SELECT {maphieugui}, S.MASOTIETKIEM, S.MAKHACHHANG, '{ngay}', {tien}" +
                    $" FROM SOTIETKIEM S JOIN LOAITIETKIEM L on S.MALOAITIETKIEM = L.MALOAITIETKIEM" +
                    $"                   JOIN KHACHHANG K on S.MAKHACHHANG = K.MAKHACHHANG" +
                    $" WHERE L.TENLOAITIETKIEM = 'khong ky han' AND K.CMND = {cmnd};";

                connection.Query(cmd);
            }
        }

        public void UpdateSoduSTK(string tien, string cmnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd = $"UPDATE SOTIETKIEM" +
                    $" SET SODU = SODU + {tien}" +
                    $" WHERE MAKHACHHANG = (SELECT TOP 1 P.MAKHACHHANG" +
                    $"                        FROM KHACHHANG KH JOIN PHIEUGUITIEN P ON P.MAKHACHHANG = KH.MAKHACHHANG" +
                    $"                        WHERE KH.CMND ={cmnd})";

                connection.Query(cmd);
            }
        }
    }
}
