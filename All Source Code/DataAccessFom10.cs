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
    public class DataAccessFom10
    {
        public List<DSKHForm10> GetKHs(string name, int sodu, string loaikt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                string cmd = "SELECT S.MASOTIETKIEM, L.TENLOAITIETKIEM, K.TENKHACHHANG, S.SODU" +
                    " FROM SOTIETKIEM S JOIN KHACHHANG K on S.MAKHACHHANG = K.MAKHACHHANG " +
                    "                   JOIN LOAITIETKIEM L on S.MALOAITIETKIEM = L.MALOAITIETKIEM" +
                    $" WHERE K.TENKHACHHANG LIKE '%{ name }%' ";
                if (sodu == 1)
                {
                    cmd += "AND S.SODU <= 500000 ";
                }
                else if (sodu == 2)
                {

                    cmd += "AND S.SODU >= 500000 AND S.SODU <= 5000000 ";
                }
                else if (sodu == 3)
                {
                    cmd += "AND S.SODU >= 5000000 ";
                }

                if (loaikt != "00")
                {
                    cmd += $"AND L.MALOAITIETKIEM = '{loaikt}' ";
                }

                var DanhSachKhachHangSauLoc = connection.Query<DSKHForm10>(cmd).ToList();
                return DanhSachKhachHangSauLoc;
            }
        }

    }
}
