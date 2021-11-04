using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using utpStore.dataSet_report;

namespace utpStore.sqlQuery
{
    public class dataAccess
    {
        private string connection = "server=127.0.0.1;userid=root;password=root;database=hosp_mr_store;";
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;

        #region Open Connection

        private MySqlConnection connOpen()
        {
            if (conn == null)
            {
                conn = new MySqlConnection(connection);
            }
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        #endregion Open Connection

        #region Close Connection

        private MySqlConnection connClose()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }

        #endregion Close Connection

        #region exeSQL Insert Update Delete

        public void executeSQL(string sql)
        {
            cmd = new MySqlCommand(sql, connOpen());
            cmd.ExecuteNonQuery();
            connClose();
        }

        #endregion exeSQL Insert Update Delete

        #region Select Data Useing DataTable

        public DataTable retreiveData(string sql)
        {
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter(sql, connOpen());
            adapter.Fill(dt);
            connClose();
            return dt;
        }

        #endregion Select Data Useing DataTable

        #region Report Approve

        public DataSet DataSetApproveReport(string sql)
        {
            dsApproveReport dsApproveReport = new dsApproveReport();
            adapter = new MySqlDataAdapter(sql, connOpen());
            adapter.Fill(dsApproveReport, dsApproveReport.Tables[0].TableName);
            return dsApproveReport;
        }

        #endregion Report Approve

        #region Report Stock

        public DataSet DataSetStockReport(string sql)
        {
            dsStock dsStock = new dsStock();
            adapter = new MySqlDataAdapter(sql, connOpen());
            adapter.Fill(dsStock, dsStock.Tables[0].TableName);
            return dsStock;
        }

        #endregion Report Stock
    }

}