using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace App1
{
    public class DataAccessForm10
    {
        public List<DSKHForm10> GetKHs(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                var DanhSachKhachHangSauLoc = connection.Query<DSKHForm10>($"select * FROM KHACHHANG where TENKHACHHANG like '%{ name }%'").ToList();
                return DanhSachKhachHangSauLoc;
            }
        }
    }
}
