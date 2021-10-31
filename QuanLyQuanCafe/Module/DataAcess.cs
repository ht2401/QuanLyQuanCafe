using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCafe.Module
{
    class DataAcess
    {
        //B1 Khai báo một chỗi kết nối
        string connectStr = "Data Source=THANHCONG\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        //B2 Mở kết nối
        SqlConnection sqlConn = null;

        void OpenConnect()
        {
            sqlConn = new SqlConnection(connectStr);
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }
        }

        //Đóng kết nối
        void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }

        //Thực thi câu lệnh Insert, Update, Delete
        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand sqlComand = new SqlCommand();
            sqlComand.Connection = sqlConn;
            sqlComand.CommandText = sql;
            sqlComand.ExecuteNonQuery();
            CloseConnect();
            sqlComand.Dispose();
        }

        //Thực hiện câu select trả về một Datatable
        public DataTable DataReader(string sqlSelect)
        {
            DataTable dtTable = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlData.Fill(dtTable);
            CloseConnect();
            sqlData.Dispose();
            return dtTable;
        }
    }
}
