using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utpStore.sqlQuery;
using utpStore.controller;
using utpStore.dataSet_report;
using utpStore.report;
using DevExpress.XtraReports.UI;

namespace utpStore.ui
{
    public partial class frmApproveFormMr : Form
    {
        private dataAccess dataAccess = new dataAccess();
        private commonCode commonCode = new commonCode();

        public frmApproveFormMr()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            timerCurrentDateTime.Start();
        }

        private void timerCurrentDateTime_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToLongDateString();
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmApproveFormMr_Load(object sender, EventArgs e)
        {
            fillDatagridDepartment();
            fillDataGrid();

        }

        private void fillDatagridDepartment()
        {
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("วันที่ขอเบิก");
            dtTemp.Columns.Add("หน่วยงาน");
            dtTemp.Columns.Add("จำนวนรายการ");

            DataTable dtTemp2 = new DataTable();

            string sqlDepartment = string.Format(@"select distinct(hosp_mr_store.sell_dummy.department_id) from hosp_mr_store.sell_dummy");
            DataTable dtDepartment = new DataTable();
            dtDepartment = dataAccess.retreiveData(sqlDepartment);

            foreach (DataRow row in dtDepartment.Rows)
            {
                string sql = string.Format(@"select
                date_format(hosp_mr_store.sell_dummy.sell_date,'%Y-%m-%d') as Date,
                (select distinct(hosp_mr_store.sell_dummy.department_id) from hosp_mr_store.sell_dummy where hosp_mr_store.sell_dummy.department_id = '{0}') ,
                (select count(hosp_mr_store.sell_dummy.department_id) from hosp_mr_store.sell_dummy where hosp_mr_store.sell_dummy.department_id = '{1}') as Amount
                from hosp_mr_store.sell_dummy", row[0].ToString(), row[0].ToString());

                dtTemp2 = dataAccess.retreiveData(sql);
                dtTemp.Rows.Add(dtTemp2.Rows[0][0].ToString(), commonCode.getDepartmentNameFromDepartmentId(dtTemp2.Rows[0][1].ToString()), dtTemp2.Rows[0][2].ToString());
            }

            dataGridRequest.DataSource = dtTemp;
            dataGridRequest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridRequest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridRequest.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridRequest_Click(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void fillDataGrid()
        {
            try
            {
                dataGridRequestDetail.DataSource = null;
                string a = dataGridRequest.SelectedRows[0].Cells[1].Value?.ToString();
                //MessageBox.Show(a);

                DataTable dt = new DataTable();
                string sql = string.Format(@"select
                hosp_mr_store.sell_dummy.id,
                date_format(hosp_mr_store.sell_dummy.sell_date,'%Y-%m-%d') as Date,
                hosp_mr_store.sell_dummy.sell_no as 'เลขที่เบิก',
                hosp_mr_store.sell_dummy.user_id,
                hosp_mr_store.sell_dummy.department_id,
                hosp_mr_store.sell_dummy.form_id,
                hosp_mr_store.mr_form.form_name as 'แบบฟอร์ม',
                hosp_mr_store.sell_dummy.qty as 'จำนวนเบิก',
                hosp_mr_store.sell_dummy.unit as 'หน่วย',
                hosp_mr_store.sell_dummy.unit_price as 'ราคาต่อหน่วย',
                hosp_mr_store.sell_dummy.total_price as 'ราคารวม',
                hosp_mr_store.stock.remaining as 'คงเหลือ'
                from hosp_mr_store.sell_dummy
                left join hosp_mr_store.mr_form on hosp_mr_store.sell_dummy.form_id = hosp_mr_store.mr_form.id 
                left join hosp_mr_store.stock on hosp_mr_store.sell_dummy.form_id = hosp_mr_store.stock.form_id
                where hosp_mr_store.sell_dummy.department_id = '{0}'", commonCode.getDepartmentIdFromDepartmentName(dataGridRequest.CurrentRow.Cells[1].Value.ToString()));

                dt = dataAccess.retreiveData(sql);

                dataGridRequestDetail.DataSource = dt;

                dataGridRequestDetail.Columns[0].Visible = false;
                dataGridRequestDetail.Columns[1].Visible = false;
                dataGridRequestDetail.Columns[3].Visible = false;
                dataGridRequestDetail.Columns[4].Visible = false;
                dataGridRequestDetail.Columns[5].Visible = false;
                //dataGridRequestDetail.Columns[11].Visible = false;

                dataGridRequestDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridRequestDetail.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridRequestDetail.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridRequestDetail.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridRequestDetail.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridRequestDetail.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
                //dataGridRequestDetail.Columns[2].Width = 120;
                //dataGridRequestDetail.Columns[6].Width = 650;
            }
            catch
            {
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (dataGridRequestDetail != null)
            {
                if (dataGridRequestDetail.Rows.Count > 0)
                {
                    if (dataGridRequestDetail.SelectedRows.Count == 1)
                    {
                        dataGridRequestDetail.Enabled = false;
                        dataGridRequest.Enabled = false;

                        btnSaveEdit.Enabled = true;

                        txtFormMrName.Text = commonCode.getFormName(dataGridRequestDetail.CurrentRow.Cells[5].Value.ToString());
                        txtRemaining.Text = commonCode.getStockDetail(dataGridRequestDetail.CurrentRow.Cells[5].Value.ToString()).Rows[0][4].ToString();
                        cboxUnit.Text = dataGridRequestDetail.CurrentRow.Cells[8].Value.ToString();
                        txtQty.Text = dataGridRequestDetail.CurrentRow.Cells[7].Value.ToString();
                        txtPricePerUnit.Text = dataGridRequestDetail.CurrentRow.Cells[9].Value.ToString();
                        txtTotalPrice.Text = dataGridRequestDetail.CurrentRow.Cells[10].Value.ToString();
                        
                        txtFormMrName.ReadOnly = true;
                        txtPricePerUnit.ReadOnly = true;
                        txtRemaining.ReadOnly = true;
                        txtTotalPrice.ReadOnly = true;
                        cboxUnit.Enabled = false;

                        txtQty.Focus();
                        txtQty.SelectAll();
                    }
                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = 0;
                int.TryParse(txtQty.Text, out qty);

                decimal price = 0;
                decimal.TryParse(txtPricePerUnit.Text, out price);

                txtTotalPrice.Text = Convert.ToString(qty * price);
            }
            catch
            {
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveEdit.Focus();
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"update hosp_mr_store.sell_dummy set hosp_mr_store.sell_dummy.qty = '{0}',hosp_mr_store.sell_dummy.total_price = '{1}' where hosp_mr_store.sell_dummy.id = '{2}'", txtQty.Text, txtTotalPrice.Text, dataGridRequestDetail.CurrentRow.Cells[0].Value.ToString());

            dataAccess.executeSQL(sql);

            dataGridRequestDetail.Enabled = true;
            dataGridRequest.Enabled = true;
            btnSaveEdit.Enabled = false;

            txtFormMrName.Clear();
            txtPricePerUnit.Clear();
            txtQty.Clear();
            txtRemaining.Clear();
            txtTotalPrice.Clear();
            cboxUnit.Text = "";

            fillDataGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtFormMrName.Clear();
            txtRemaining.Clear();
            cboxUnit.Text = "";
            txtQty.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();

            dataGridRequest.Enabled = true;
            dataGridRequestDetail.Enabled = true;

            btnSaveEdit.Enabled = false;
            btnCancelEdit.Enabled = false;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dataGridRequestDetail.Rows.Count <= 0 || dataGridRequestDetail.DataSource == null)
            {
                MessageBox.Show("กรุณาทำรายการก่อนครับ");
                return;
                // done...
            }
            
            string sellDate = "";
            string sellNo = "";
            int totalAmount = 0;
            int userId = 0;
            int departmentId = 0;
            decimal totalPrice = 0;
            string approveDate = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                for (int i = 0; i < dataGridRequestDetail.Rows.Count; i++)
                {
                    int qty = Convert.ToInt32(dataGridRequestDetail.Rows[i].Cells[6].Value.ToString());
                    int remaining = Convert.ToInt32(dataGridRequestDetail.Rows[i].Cells[10].Value.ToString());

                    if (qty > remaining)
                    {
                        MessageBox.Show("จำนวนเบิกมากกว่าคงเหลือ \nกรุณากรอกข้อมูลใหม่ !");
                        return;
                    }
                }
            }
            catch
            {
            }

            try
            {
                for (int i = 0; i < dataGridRequestDetail.Rows.Count; i++)
                {
                    sellDate = dataGridRequestDetail.Rows[i].Cells[1].Value.ToString();
                    sellNo = dataGridRequestDetail.Rows[i].Cells[2].Value.ToString();
                    totalAmount = dataGridRequestDetail.Rows.Count;
                    userId = Convert.ToInt32(dataGridRequestDetail.Rows[i].Cells[3].Value.ToString());
                    departmentId = Convert.ToInt32(dataGridRequestDetail.Rows[i].Cells[4].Value.ToString());
                    totalPrice = totalPrice + Convert.ToDecimal(dataGridRequestDetail.Rows[i].Cells[9].Value.ToString());
                }
            }
            catch
            {
            }

            string sqlInsertToSell = string.Format(@"insert into hosp_mr_store.sell (sell_date, sell_no, total_amount, user_id, department_id, total_price, approve_date) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", sellDate, sellNo, totalAmount, userId, departmentId, totalPrice, approveDate);
            dataAccess.executeSQL(sqlInsertToSell);

            // select last id from sell
            //string sqlSelectSellId = "select max(hosp_mr_store.sell.id) from hosp_mr_store.sell";
            //DataTable dataTable = new DataTable();
            //dataTable = dataAccess.retreiveData(sqlSelectSellId);

            string sellId = dataAccess.retreiveData("select max(hosp_mr_store.sell.id) from hosp_mr_store.sell").Rows[0][0].ToString();

            try
            {
                for (int i = 0; i < dataGridRequestDetail.Rows.Count; i++)

                {
                    string form_id = dataGridRequestDetail.Rows[i].Cells[5].Value.ToString();
                    int qty = Convert.ToInt32(dataGridRequestDetail.Rows[i].Cells[7].Value.ToString());
                    decimal unit_price = Convert.ToDecimal(dataGridRequestDetail.Rows[i].Cells[9].Value.ToString());
                    string unit = dataGridRequestDetail.Rows[i].Cells[8].Value.ToString();
                    decimal total_price = Convert.ToDecimal(dataGridRequestDetail.Rows[i].Cells[10].Value.ToString());

                    //Insert To Sell_Detail
                    string sqlInsertSellDetail = string.Format(@"insert into hosp_mr_store.sell_detail (sell_id, form_id, qty, unit_price, unit, total_price) values ('{0}','{1}','{2}','{3}','{4}','{5}')", sellId, form_id  , qty , unit_price , unit , total_price);
                    dataAccess.executeSQL(sqlInsertSellDetail);

                    string sqlUpdateStock = string.Format(@"update hosp_mr_store.stock set hosp_mr_store.stock.remaining = hosp_mr_store.stock.remaining - '{0}' where hosp_mr_store.stock.form_id = '{1}'", qty, form_id);
                    dataAccess.executeSQL(sqlUpdateStock);
                }
            }
            catch
            {
            }

            dataAccess.executeSQL(string.Format("delete from hosp_mr_store.sell_dummy where hosp_mr_store.sell_dummy.department_id = '{0}'", departmentId));
            MessageBox.Show("อนุมัติสำเร็จ");

            string sqlQueryReport = string.Format(@"SELECT date_format(hosp_mr_store.sell.sell_date,'%Y-%m-%d') as sell_date, hosp_mr_store.sell.sell_no, hosp_mr_store.department.department, CONCAT(hosp_mr_store.user.fname,' ',hosp_mr_store.user.lname) AS userName, hosp_mr_store.sell.total_price AS grand_total_price, hosp_mr_store.mr_form.form_name, hosp_mr_store.sell_detail.qty, hosp_mr_store.sell_detail.unit_price, hosp_mr_store.sell_detail.unit, hosp_mr_store.sell_detail.total_price, hosp_mr_store.sell.approve_date FROM hosp_mr_store.sell_detail INNER JOIN hosp_mr_store.mr_form ON hosp_mr_store.sell_detail.form_id = hosp_mr_store.mr_form.id INNER JOIN hosp_mr_store.sell ON hosp_mr_store.sell_detail.sell_id = hosp_mr_store.sell.id INNER JOIN hosp_mr_store.department ON hosp_mr_store.sell.department_id = hosp_mr_store.department.id INNER JOIN hosp_mr_store.user ON hosp_mr_store.sell.user_id = hosp_mr_store.user.id WHERE hosp_mr_store.sell.id = '{0}'", sellId);

            rptApprove rpt = new rptApprove();
            rpt.DataSource = dataAccess.DataSetApproveReport(sqlQueryReport);
            rpt.ShowPreview();

            fillDatagridDepartment();
            fillDataGrid();
        }

        private void btnPrintApprove_Click(object sender, EventArgs e)
        {
            //string sellId = dataAccess.retreiveData("select max(hosp_mr_store.sell.id) from hosp_mr_store.sell").Rows[0][0].ToString();

            //string sqlQueryReport = string.Format(@"SELECT date_format(hosp_mr_store.sell.sell_date,'%Y-%m-%d') as sell_date, hosp_mr_store.sell.sell_no, hosp_mr_store.department.department, CONCAT(hosp_mr_store.user.fname,' ',hosp_mr_store.user.lname) AS userName, hosp_mr_store.sell.total_price AS grand_total_price, hosp_mr_store.mr_form.form_name, hosp_mr_store.sell_detail.qty, hosp_mr_store.sell_detail.unit_price, hosp_mr_store.sell_detail.unit, hosp_mr_store.sell_detail.total_price, hosp_mr_store.sell.approve_date FROM hosp_mr_store.sell_detail INNER JOIN hosp_mr_store.mr_form ON hosp_mr_store.sell_detail.form_id = hosp_mr_store.mr_form.id INNER JOIN hosp_mr_store.sell ON hosp_mr_store.sell_detail.sell_id = hosp_mr_store.sell.id INNER JOIN hosp_mr_store.department ON hosp_mr_store.sell.department_id = hosp_mr_store.department.id INNER JOIN hosp_mr_store.user ON hosp_mr_store.sell.user_id = hosp_mr_store.user.id WHERE hosp_mr_store.sell.id = '{0}'", sellId);

            //rptApprove rpt = new rptApprove();
            //rpt.DataSource = dataAccess.DataSetApproveReport(sqlQueryReport);
            //rpt.ShowPreview();
        }
    }
}