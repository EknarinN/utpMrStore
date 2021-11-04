using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utpStore.sqlQuery;

namespace utpStore.controller
{
    public class commonCode
    {
        private dataAccess dataAccess = new dataAccess();

        public void autoCompleteTextBox(TextBox txt, string sql)
        {
            DataTable dt = new DataTable();
            dt = dataAccess.retreiveData(sql);
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

            foreach (DataRow item in dt.Rows)
            {
                autoCompleteStringCollection.Add(item[0].ToString());
            }
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        public string getVendorId(string vendorName)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dataAccess.retreiveData(string.Format(@"select hosp_mr_store.vendor.id from hosp_mr_store.vendor where hosp_mr_store.vendor.vendor_name = '{0}'", vendorName));
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return null;
            }
        }

        public string getVendorName(string vendorId)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dataAccess.retreiveData(string.Format(@"select hosp_mr_store.vendor.vendor_name from hosp_mr_store.vendor where hosp_mr_store.vendor.id = '{0}'", vendorId));
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return null;
            }
        }

        public string getFormId(string formName)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dataAccess.retreiveData(string.Format(@"select hosp_mr_store.mr_form.id from hosp_mr_store.mr_form where hosp_mr_store.mr_form.form_name = '{0}'", formName));
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return null;
            }
        }

        public string getFormName(string formId)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dataAccess.retreiveData(string.Format(@"select hosp_mr_store.mr_form.form_name from hosp_mr_store.mr_form where hosp_mr_store.mr_form.id = '{0}'", formId));
                return dt.Rows[0][0].ToString();
            }
            catch
            {
                return null;
            }
        }

        public string generateReceiveNo()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dataAccess.retreiveData(string.Format(@"select * from hosp_mr_store.receive order by hosp_mr_store.receive.id desc limit 1 "));
                if (dt.Rows.Count > 0)
                {
                    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                    string month = DateTime.Now.ToString("MM");
                    string receiveNo = year + month + "-" + (Convert.ToInt32(dt.Rows[0][1].ToString().Substring(5)) + 1);
                    return receiveNo;
                }
                else
                {
                    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                    string month = DateTime.Now.ToString("MM");
                    string receiveNo = year + month + "-" + 1;
                    return receiveNo;
                }
            }
            catch
            {
                return null;
            }
        }

        public string generateSellNo()
        {
            try
            {
                DataTable dtSell = new DataTable();
                dtSell = dataAccess.retreiveData(string.Format(@"SELECT MAX(CAST(SUBSTRING(hosp_mr_store.sell.sell_no,10) AS UNSIGNED INTEGER)) FROM hosp_mr_store.sell;"));

                DataTable dtSellDummy = new DataTable();
                dtSellDummy = dataAccess.retreiveData(string.Format(@"SELECT MAX(CAST(SUBSTRING(hosp_mr_store.sell_dummy.sell_no,10) AS UNSIGNED INTEGER)) FROM hosp_mr_store.sell_dummy; "));

                if (string.IsNullOrEmpty(dtSell.Rows[0][0].ToString()))
                {
                    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                    string month = DateTime.Now.ToString("MM");
                    string sellno = "ORD" + "-" + year + month + "-" + "1";
                    return sellno;
                }
                if (string.IsNullOrEmpty(dtSellDummy.Rows[0][0].ToString()))
                {
                    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                    string month = DateTime.Now.ToString("MM");
                    string sellno = "ORD" + "-" + year + month + "-" + (Convert.ToInt32(dtSell.Rows[0][0].ToString()) + 1);
                    return sellno;
                }

                int sellNoFromSell = Convert.ToInt32(dtSell.Rows[0][0].ToString());
                int sellNoFromSellDummy = Convert.ToInt32(dtSellDummy.Rows[0][0].ToString());

                if (sellNoFromSell > sellNoFromSellDummy)
                {
                    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                    string month = DateTime.Now.ToString("MM");
                    string sellno = "ORD" + "-" + year + month + "-" + (Convert.ToInt32(dtSell.Rows[0][0].ToString()) + 1);
                    return sellno;
                }
                else if (sellNoFromSell < sellNoFromSellDummy)
                {
                    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                    string month = DateTime.Now.ToString("MM");
                    string sellno = "ORD" + "-" + year + month + "-" + (Convert.ToInt32(dtSellDummy.Rows[0][0].ToString()) + 1);
                    return sellno;
                }
                else
                {
                    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                    string month = DateTime.Now.ToString("MM");
                    string sellno = "ORD" + "-" + year + month + "-" + (Convert.ToInt32(dtSellDummy.Rows[0][0].ToString()) + 1);
                    return sellno;
                }

                //if (dt.Rows.Count > 0)
                //{
                //    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                //    string month = DateTime.Now.ToString("MM");
                //    string sellNo = "ORD" + "-" + year + month + "-" + (Convert.ToInt32(dt.Rows[0][2].ToString().Substring(9)) + 1);
                //    return sellNo;
                //}
                //else
                //{
                //    string year = DateTime.Now.ToString("yyyy").Substring(2, 2);
                //    string month = DateTime.Now.ToString("MM");
                //    string sellNo = "ORD" + "-" + year + month + "-" + 1;
                //    return sellNo;
                //}
            }
            catch
            {
                return null;
            }
        }

        public string getDepartmentName(string userId)
        {
            return dataAccess.retreiveData(string.Format(@"select hosp_mr_store.department.department from hosp_mr_store.department left join hosp_mr_store.user on hosp_mr_store.department.id = hosp_mr_store.user.department_id where hosp_mr_store.user.id = '{0}'", userId)).Rows[0][0].ToString();
        }

        public string getDepartmentNameFromDepartmentId(string departmentId)
        {
            DataTable dt = new DataTable();
            string sql = string.Format(@"select hosp_mr_store.department.department from hosp_mr_store.department where hosp_mr_store.department.id = '{0}'", departmentId);
            dt = dataAccess.retreiveData(sql);

            return dataAccess.retreiveData(sql).Rows[0][0].ToString();
        }

        public string getDepartmentIdFromDepartmentName(string departmentName)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = string.Format(@"select hosp_mr_store.department.id from hosp_mr_store.department where hosp_mr_store.department.department = '{0}'", departmentName);
                dt = dataAccess.retreiveData(sql);

                return dataAccess.retreiveData(sql).Rows[0][0].ToString();
            }
            catch
            {
                return "";
            }
        }

        public DataTable getStockDetail(string formId)
        {
            DataTable dt = new DataTable();
            string sqlQueryStockDetail = string.Format(@"select * from hosp_mr_store.stock where hosp_mr_store.stock.form_id = '{0}'", formId);
            dt = dataAccess.retreiveData(sqlQueryStockDetail);

            return dt;
        }

        public string getDepartmentIdFromUserId(string userId)
        {
            string sql = string.Format(@"select hosp_mr_store.user.department_id from hosp_mr_store.user where hosp_mr_store.user.id = '{0}'", userId);

            return dataAccess.retreiveData(sql).Rows[0][0].ToString();
        }
    }
}