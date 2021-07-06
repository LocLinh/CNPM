using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace App1
{
    class DataAccessSoTietKiem
    {
        public void SetKH(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {
                connection.Query<KhachHang>($"select * FROM KHACHHANG where TENKHACHHANG like '%{ name }%'");
            }
        }
    }
}
