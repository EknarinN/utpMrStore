using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utpStore.controller;
using utpStore.sqlQuery;

namespace utpStore.ui
{
    public partial class frmRequestFormMr : Form
    {
        private commonCode commonCode = new commonCode();
        private dataAccess dataAccess = new dataAccess();
        private string user_Id = "";
        private string full_Name = "";
        private decimal totalPrice = 0;

        public frmRequestFormMr(string user_Id, String full_Name)
        {
            this.user_Id = user_Id;
            this.full_Name = full_Name;
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            timerCurentDateTime.Start();
        }

        private void timerCurentDateTime_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToLongDateString();
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRequestFormMr_Load(object sender, EventArgs e)
        {
            txtUserRequest.Text = full_Name;
            txtDepartment.Text = commonCode.getDepartmentName(user_Id);

            string sqlQueryStock = string.Format(@"select hosp_mr_store.mr_form.form_name from hosp_mr_store.mr_form left join hosp_mr_store.stock on hosp_mr_store.mr_form.id = hosp_mr_store.stock.form_id where hosp_mr_store.stock.remaining > 0 and hosp_mr_store.mr_form.form_name like '%{0}%'", txtFormMrName.Text);

            commonCode.autoCompleteTextBox(txtFormMrName, sqlQueryStock);
            txtSellNo.Text = commonCode.generateSellNo();

            fillDatagrid();
            txtFormMrName.Focus();
        }

        private void fillDatagrid()
        {
            dataGridSell.DataSource = null;
            totalPrice = 0;
            DataTable dt = new DataTable();
            string sql = string.Format(@"select hosp_mr_store.sell_dummy.id,
                                            date_format(hosp_mr_store.sell_dummy.sell_date,('%Y-%m-%d')) as sell_date,
                                            hosp_mr_store.sell_dummy.sell_no,
                                            hosp_mr_store.sell_dummy.user_id,
                                            hosp_mr_store.sell_dummy.department_id,
                                            hosp_mr_store.sell_dummy.form_id,
                                            hosp_mr_store.sell_dummy.qty,
                                            hosp_mr_store.sell_dummy.unit,
                                            hosp_mr_store.sell_dummy.unit_price,
                                            hosp_mr_store.sell_dummy.total_price
                                            from hosp_mr_store.sell_dummy
                                            left join hosp_mr_store.user on hosp_mr_store.sell_dummy.user_id = hosp_mr_store.user.id
                                            where hosp_mr_store.sell_dummy.department_id = '{0}'
                                            ", commonCode.getDepartmentIdFromUserId(user_Id));
            dt = dataAccess.retreiveData(sql);
            dataGridSell.DataSource = dt;

            foreach (DataRow item in dt.Rows)
            {
                totalPrice = totalPrice + Convert.ToDecimal(item[9].ToString());
            }
            txtGrandTotalPrice.Text = totalPrice.ToString();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            string sqlChkFormName = string.Format(@"select hosp_mr_store.mr_form.form_name from hosp_mr_store.mr_form where hosp_mr_store.mr_form.form_name = '{0}'", txtFormMrName.Text);
            DataTable dataTable = new DataTable();
            dataTable = dataAccess.retreiveData(sqlChkFormName);

            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("กรุณากรอกชื่อแบบฟอร์มให้ถูกต้อง");
                txtFormMrName.Focus();
                txtFormMrName.SelectAll();
                return;
            }

            if (string.IsNullOrEmpty(txtFormMrName.Text))
            {
                errorProvider1.SetError(txtFormMrName, "กรุณากรอกชื่อแบบฟอร์มที่ต้องการเบิก");
                txtFormMrName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRemaining.Text))
            {
                errorProvider1.SetError(txtRemaining, "กรุณากรอกชื่อแบบฟอร์มที่ต้องการเบิกให้ถูกต้อง");
                txtRemaining.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboxUnit.Text))
            {
                errorProvider1.SetError(cboxUnit, "กรุณากรอกหน่วยนับให้ถูกต้อง");
                cboxUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                errorProvider1.SetError(txtQty, "กรุณากรอกจำนวนที่ต้องการเบิก");
                txtQty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPricePerUnit.Text))
            {
                errorProvider1.SetError(txtPricePerUnit, "กรุณากรอกราคาต่อหน่วย");
                txtPricePerUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPricePerUnit.Text))
            {
                errorProvider1.SetError(txtPricePerUnit, "กรุณากรอกราคาต่อหน่วย");
                txtPricePerUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                errorProvider1.SetError(txtTotalPrice, "กรุณากรอกราคารวม");
                txtTotalPrice.Focus();
                return;
            }

            int remaining = 0;
            int.TryParse(txtRemaining.Text, out remaining);

            int qty = 0;
            int.TryParse(txtQty.Text, out qty);

            if (qty > remaining)
            {
                MessageBox.Show("จำนวนเบิกมากกว่าจำนวนคงเหลือ \nกรุณาตรวจสอบอีกครั้ง");
                txtQty.Focus();
                return;
            }

            string sellDate = dateTimePicker_SellDate.Value.ToString("yyyy-MM-dd");

            string sqlInsert = string.Format(@"insert into hosp_mr_store.sell_dummy(hosp_mr_store.sell_dummy.sell_date,
                                                hosp_mr_store.sell_dummy.sell_no,
                                                hosp_mr_store.sell_dummy.user_id,
                                                hosp_mr_store.sell_dummy.department_id,
                                                hosp_mr_store.sell_dummy.form_id,
                                                hosp_mr_store.sell_dummy.qty,
                                                hosp_mr_store.sell_dummy.unit,
                                                hosp_mr_store.sell_dummy.unit_price,
                                                hosp_mr_store.sell_dummy.total_price) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", sellDate, txtSellNo.Text, user_Id, commonCode.getDepartmentIdFromUserId(user_Id), commonCode.getFormId(txtFormMrName.Text), qty, cboxUnit.Text, txtPricePerUnit.Text, txtTotalPrice.Text);
            dataAccess.executeSQL(sqlInsert);

            fillDatagrid();

            txtFormMrName.Clear();
            txtRemaining.Clear();
            cboxUnit.Text = "";
            txtQty.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
            menuEdit.Enabled = true;
            menuDelete.Enabled = true;
        }

        private void txtFormMrName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = commonCode.getStockDetail(commonCode.getFormId(txtFormMrName.Text));
                txtRemaining.Text = dt.Rows[0][4].ToString();
                cboxUnit.Text = dt.Rows[0][3].ToString();
                txtPricePerUnit.Text = dt.Rows[0][2].ToString();
                txtRemaining.ReadOnly = true;
                cboxUnit.Enabled = false;
                txtPricePerUnit.ReadOnly = true;
            }
            catch
            {
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal totalPrice = 0;

                int qty = 0;
                int.TryParse(txtQty.Text, out qty);

                decimal price = 0;
                decimal.TryParse(txtPricePerUnit.Text, out price);

                totalPrice = qty * price;
                txtTotalPrice.Text = totalPrice.ToString();
            }
            catch
            {
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtFormMrName.Clear();
            txtQty.Clear();
            txtRemaining.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
            dataGridSell.Enabled = true;
            btnAddToList.Enabled = true;
            btnEditUpdate.Enabled = false;
            txtFormMrName.Focus();
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (dataGridSell != null)
            {
                if (dataGridSell.Rows.Count > 0)
                {
                    if (dataGridSell.SelectedRows.Count == 1)
                    {
                        btnAddToList.Enabled = false;
                        btnEditUpdate.Enabled = true;
                        dataGridSell.Enabled = false;

                        txtFormMrName.Text = commonCode.getFormName(dataGridSell.CurrentRow.Cells[5].Value.ToString());
                        txtQty.Text = dataGridSell.CurrentRow.Cells[6].Value.ToString();

                        txtFormMrName.Focus();
                        txtFormMrName.SelectAll();
                    }
                }
            }
        }

        private void txtFormMrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFormMrName.Text))
            {
                errorProvider1.SetError(txtFormMrName, "กรุณากรอกชื่อแบบฟอร์มที่ต้องการเบิก");
                txtFormMrName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRemaining.Text))
            {
                errorProvider1.SetError(txtRemaining, "กรุณากรอกชื่อแบบฟอร์มที่ต้องการเบิกให้ถูกต้อง");
                txtRemaining.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboxUnit.Text))
            {
                errorProvider1.SetError(cboxUnit, "กรุณากรอกหน่วยนับให้ถูกต้อง");
                cboxUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                errorProvider1.SetError(txtQty, "กรุณากรอกจำนวนที่ต้องการเบิก");
                txtQty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPricePerUnit.Text))
            {
                errorProvider1.SetError(txtPricePerUnit, "กรุณากรอกราคาต่อหน่วย");
                txtPricePerUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPricePerUnit.Text))
            {
                errorProvider1.SetError(txtPricePerUnit, "กรุณากรอกราคาต่อหน่วย");
                txtPricePerUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                errorProvider1.SetError(txtTotalPrice, "กรุณากรอกราคารวม");
                txtTotalPrice.Focus();
                return;
            }

            int remaining = 0;
            int.TryParse(txtRemaining.Text, out remaining);

            int qty = 0;
            int.TryParse(txtQty.Text, out qty);

            if (qty > remaining)
            {
                MessageBox.Show("จำนวนเบิกมากกว่าจำนวนคงเหลือ \nกรุณาตรวจสอบอีกครั้ง");
                txtQty.Focus();
                return;
            }

            string sqlUpdateSellDummy = string.Format(@"update hosp_mr_store.sell_dummy set hosp_mr_store.sell_dummy.qty = '{0}', hosp_mr_store.sell_dummy.total_price = '{1}' where hosp_mr_store.sell_dummy.id = '{2}'", qty, txtTotalPrice.Text, dataGridSell.CurrentRow.Cells[0].Value.ToString());

            dataAccess.executeSQL(sqlUpdateSellDummy);

            fillDatagrid();

            txtFormMrName.Clear();
            txtQty.Clear();
            cboxUnit.Text = "";
            txtRemaining.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
            dataGridSell.Enabled = true;
            btnAddToList.Enabled = true;
            btnEditUpdate.Enabled = false;
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (dataGridSell != null)
            {
                if (dataGridSell.Rows.Count > 0)
                {
                    if (dataGridSell.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("ต้องการลบรายการนี้ใช่หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string sql = string.Format(@"delete from hosp_mr_store.sell_dummy where hosp_mr_store.sell_dummy.id ='{0}'", dataGridSell.CurrentRow.Cells[0].Value.ToString());
                            dataAccess.executeSQL(sql);
                            fillDatagrid();
                        }
                    }
                }
            }
        }
    }
}