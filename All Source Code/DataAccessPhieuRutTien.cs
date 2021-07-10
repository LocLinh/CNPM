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
    class DataAccessPhieuRutTien
    {
        public int CountPhieuRut()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd = $"SELECT COUNT(*) AS SOLUONG FROM PHIEURUTTIEN";
                string res = connection.Query<int>(cmd).FirstOrDefault().ToString();
                bool check = int.TryParse(res, out int SOLUONG);
                if (check)
                {
                    return SOLUONG + 1;
                }

                return 100;

            }
        }

        public FoundKHRutTien FindCMND(string cmnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                bool check = int.TryParse(cmnd, out int real_cmnd);
                string cmd = "";
                if (check)
                {
                    cmd = $"SELECT K.TENKHACHHANG , K.CMND , K.DIACHI ,S.SODU , L.TENLOAITIETKIEM FROM SOTIETKIEM S JOIN KHACHHANG K on S.MAKHACHHANG = K.MAKHACHHANG JOIN LOAITIETKIEM L on S.MALOAITIETKIEM = L.MALOAITIETKIEM WHERE K.CMND = '{cmnd}'";
                    FoundKHRutTien res = connection.Query<FoundKHRutTien>(cmd).FirstOrDefault();
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

        public void InsertPhieuRut(string maphieurut, string ngay, string tien, string cmnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd = $"INSERT INTO PHIEURUTTIEN ( MAPHIEURUTTIEN ,MASOTIETKIEM, MAKHACHHANG, NGAYRUT,SOTIENRUT)" +
                    $" SELECT {maphieurut}, S.MASOTIETKIEM, S.MAKHACHHANG, '{ngay}', {tien}" +
                    $" FROM SOTIETKIEM S JOIN LOAITIETKIEM L on S.MALOAITIETKIEM = L.MALOAITIETKIEM" +
                    $"                   JOIN KHACHHANG K on S.MAKHACHHANG = K.MAKHACHHANG" +
                    $" WHERE K.CMND = {cmnd};";

                connection.Query(cmd);
            }
        }

        public void UpdateSoduSTK(string tien, string cmnd)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd = $"UPDATE SOTIETKIEM" +
                    $" SET SODU = SODU - {tien}" +
                    $" WHERE MAKHACHHANG = (SELECT TOP 1 P.MAKHACHHANG" +
                    $"                        FROM KHACHHANG KH JOIN PHIEURUTTIEN P ON P.MAKHACHHANG = KH.MAKHACHHANG" +
                    $"                        WHERE KH.CMND = {cmnd})";

                connection.Query(cmd);
            }
        }

        public DateTime GetSTKOpenDate(string cmnd)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd = $"SELECT S.NGAYMOSO" +
                    $" FROM SOTIETKIEM S JOIN KHACHHANG K on S.MAKHACHHANG = K.MAKHACHHANG" +
                    $" WHERE K.CMND = {cmnd}; ";
                DateTime res = connection.Query<DateTime>(cmd).FirstOrDefault();
                // bool check = DateTime.TryParse(res, out DateTime ret);
                return res;
            }
        }

    }
}
