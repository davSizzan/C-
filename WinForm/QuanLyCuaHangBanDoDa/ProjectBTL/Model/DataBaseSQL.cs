using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectBTL.Model
{
    class DataBaseSQL
    {
        string ConnectString = "Data Source=desktop-im3ai9h\\sqlexpress;Initial Catalog=LTTQ_2;User ID=sa;Password=sa";

        SqlConnection sqlConnect = null;
        //Pt mo ket noi
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(ConnectString);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //PT dong ket noi
        void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //phương thức thực hiện select trả về DataTable
        public DataTable DataReturnTable(string sqlSelect)
        {
            DataTable dtResult = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConnect);
            sqlData.Fill(dtResult);
            CloseConnect();
            sqlData.Dispose();
            return dtResult;
        }
        //Phương thức thực hiện thay đổi dữ liệu: insert,delete,update
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConnect;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            CloseConnect();
            sqlComm.Dispose();
        }
    }
}
