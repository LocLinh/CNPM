using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class DataAccessBaoCao
    {
        public int TongChi(string date, string ngay, string thang, string loaitk)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd1 = $"SELECT CAST(ROUND(SUM(STK.SODU*LTK.LAISUAT),0) AS INT) AS TONGCHINGAY" +
                    $" FROM SOTIETKIEM AS STK JOIN LOAITIETKIEM AS LTK ON STK.MALOAITIETKIEM = LTK.MALOAITIETKIEM" +
                    $" WHERE day(STK.NGAYMOSO) = {ngay} AND month(STK.NGAYMOSO) = {thang} and LTK.MALOAITIETKIEM = '{loaitk}'";
                int res1, res2;
                try
                {
                    res1 = connection.Query<int>(cmd1).FirstOrDefault();
                }
                catch (Exception)
                {
                    res1 = 0;
                }
                
                string cmd2 = "set dateformat DMY; SELECT SUM(PR.SOTIENRUT) AS RUT" +
                    " FROM PHIEURUTTIEN PR JOIN SOTIETKIEM STK ON STK.MASOTIETKIEM = PR.MASOTIETKIEM" +
                    $" WHERE PR.NGAYRUT = '{date}' AND STK.MALOAITIETKIEM = '{loaitk}'";

                try
                {
                    res2 = connection.Query<int>(cmd2).FirstOrDefault();
                }
                catch (Exception)
                {
                    res2 = 0;
                }

                return res1 + res2;
            }
        }
        public int TongThu(string ngay, string loaitk)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CNPMdb")))
            {

                string cmd = $"set dateformat DMY; SELECT SUM(PGT.SOTIENGUI) AS TONGGUI" +
                    $" FROM PHIEUGUITIEN AS PGT JOIN SOTIETKIEM STK ON STK.MASOTIETKIEM = PGT.MASOTIETKIEM" +
                    $" WHERE PGT.NGAYGUI = '{ngay}' AND STK.MALOAITIETKIEM = '{loaitk}'; ";
                int res;

                try
                {
                    res = connection.Query<int>(cmd).FirstOrDefault();
                }
                catch (Exception)
                {
                    res = 0;
                }


                return res;
            }
        }
    }
}
