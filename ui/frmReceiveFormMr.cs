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
    public partial class frmReceiveFormMr : Form
    {
        private commonCode commonCode = new commonCode();
        private dataAccess dataAccess = new dataAccess();

        private string user_Id = null;
        private string full_Name = null;

        private decimal totalPrice = 0;

        private void fillDataGrid()
        {
            // ชงกาแฟแป๊ป
            dataGridReceive.DataSource = null;
            totalPrice = 0;
            DataTable dt = new DataTable();
            dt = dataAccess.retreiveData(@"select hosp_mr_store.receive_dummy.id,
                                            hosp_mr_store.receive_dummy.receive_no,
                                            date_format(hosp_mr_store.receive_dummy.receive_date,('%Y-%m-%d')) as receive_date,
                                            hosp_mr_store.receive_dummy.invoice_no,
                                            hosp_mr_store.receive_dummy.vendor_id,
                                            hosp_mr_store.receive_dummy.form_id,
                                            hosp_mr_store.receive_dummy.qty,
                                            hosp_mr_store.receive_dummy.unit,
                                            hosp_mr_store.receive_dummy.unit_price,
                                            hosp_mr_store.receive_dummy.total_price,
                                            hosp_mr_store.receive_dummy.lot_no
                                            from hosp_mr_store.receive_dummy");
            dataGridReceive.DataSource = dt;

            foreach (DataRow item in dt.Rows)
            {
                totalPrice = totalPrice + Convert.ToDecimal(item[9].ToString());
            }
            txtGrandTotalPrice.Text = totalPrice.ToString();
        }

        public frmReceiveFormMr(string userId, string fullName)
        {
            this.user_Id = userId;
            this.full_Name = fullName;
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            timerCurentDateTime.Start();
        }

        private void frmReceiveFormMr_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            commonCode.autoCompleteTextBox(txtVendor, "select hosp_mr_store.vendor.vendor_name from hosp_mr_store.vendor");
            commonCode.autoCompleteTextBox(txtFormMrName, "select hosp_mr_store.mr_form.form_name from hosp_mr_store.mr_form");
            txtReceiveNo.Text = commonCode.generateReceiveNo();
            txtRecorder.Text = full_Name;
            txtInvoiceNo.Focus();
            try
            {
                txtGrandTotalPrice.Text = totalPrice.ToString();
            }
            catch
            {
            }
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

            string SqlChkInvoiceNo = string.Format(@"select hosp_mr_store.receive.invoice_no from hosp_mr_store.receive where hosp_mr_store.receive.invoice_no = '{0}'", txtInvoiceNo.Text.Trim());
            DataTable dtchk = new DataTable();
            dtchk = dataAccess.retreiveData(SqlChkInvoiceNo);
            if (dtchk.Rows.Count > 0)
            {
                MessageBox.Show("มีเลขใบส่งของนี้แล้วในระบบ \nกรุณากรอกเลขใบส่งของใหม่");
                txtInvoiceNo.Focus();
                txtInvoiceNo.SelectAll();
                return;
            }

            if (string.IsNullOrEmpty(txtInvoiceNo.Text))
            {
                errorProvider1.SetError(txtInvoiceNo, "กรุณากรอกเลขที่ใบส่งของ");
                txtInvoiceNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtVendor.Text))
            {
                errorProvider1.SetError(txtVendor, "กรุณากรอกชื่อบริษัท");
                txtVendor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtFormMrName.Text))
            {
                errorProvider1.SetError(txtFormMrName, "กรุณากรอกชื่อรายการรับเข้า");
                txtFormMrName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                errorProvider1.SetError(txtQuantity, "กรุณากรอกจำนวน");
                txtQuantity.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboxUnit.Text))
            {
                errorProvider1.SetError(cboxUnit, "กรุณากรอกหน่วยนับ");
                cboxUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPricePerUnit.Text))
            {
                errorProvider1.SetError(txtPricePerUnit, "กรุณากรอกราคาต่อหน่วย");
                txtPricePerUnit.Focus();
                return;
            }

            int qty = 0;
            int.TryParse(txtQuantity.Text, out qty);

            decimal price = 0;
            decimal.TryParse(txtPricePerUnit.Text, out price);

            string sqlInsert = string.Format(@"insert into hosp_mr_store.receive_dummy (receive_no,receive_date,invoice_no,vendor_id,form_id,qty,unit,unit_price,total_price) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", txtReceiveNo.Text, dateTimePicker_ReceiveDate.Value.ToString("yyyy-MM-dd"), txtInvoiceNo.Text, commonCode.getVendorId(txtVendor.Text), commonCode.getFormId(txtFormMrName.Text), txtQuantity.Text, cboxUnit.Text, txtPricePerUnit.Text, txtTotalPrice.Text);
            dataAccess.executeSQL(sqlInsert);

            txtReceiveNo.Enabled = false;
            dateTimePicker_ReceiveDate.Enabled = false;
            txtInvoiceNo.Enabled = false;
            txtVendor.Enabled = false;

            txtFormMrName.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
            txtFormMrName.Focus();

            fillDataGrid();

            txtGrandTotalPrice.Text = totalPrice.ToString();
        }

        private void txtVendor_TextChanged(object sender, EventArgs e)
        {
            //commonCode.autoCompleteTextBox(txtVendor, "select hosp_mr_store.vendor.vendor_name from hosp_mr_store.vendor");
        }

        private void txtPricePerUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal totalPrice = 0;

                int qty = 0;
                int.TryParse(txtQuantity.Text, out qty);

                decimal price = 0;
                decimal.TryParse(txtPricePerUnit.Text, out price);

                totalPrice = qty * price;
                txtTotalPrice.Text = totalPrice.ToString();
            }
            catch
            {
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal totalPrice = 0;

                int qty = 0;
                int.TryParse(txtQuantity.Text, out qty);

                decimal price = 0;
                decimal.TryParse(txtPricePerUnit.Text, out price);

                totalPrice = qty * price;
                txtTotalPrice.Text = totalPrice.ToString();
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridReceive.Rows.Count > 0)
            {
                string receiveId = null;
                for (int i = 0; i < 1; i++)
                {
                    string receive_no = dataGridReceive.Rows[i].Cells[1].Value.ToString();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string invoice_no = dataGridReceive.Rows[i].Cells[3].Value.ToString();
                    string vendor_id = dataGridReceive.Rows[i].Cells[4].Value.ToString();
                    int amount = dataGridReceive.Rows.Count;
                    decimal grandTotalPrice = Convert.ToDecimal(txtGrandTotalPrice.Text);

                    string sqlInsertReceive = string.Format(@"insert into hosp_mr_store.receive (hosp_mr_store.receive.receive_no,
                                                                                                 hosp_mr_store.receive.receive_date,
                                                                                                    hosp_mr_store.receive.invoice_no,
                                                                                                    hosp_mr_store.receive.vendor_id,
                                                                                                    hosp_mr_store.receive.total_amount,
                                                                                                    hosp_mr_store.receive.grand_total_price)
                                                                                                    values('{0}','{1}','{2}','{3}','{4}','{5}') ", 
                                                                                                    receive_no
                                                                                                    ,date
                                                                                                    , invoice_no
                                                                                                    , vendor_id
                                                                                                    , amount
                                                                                                    , grandTotalPrice
                                                                                                    );
                    dataAccess.executeSQL(sqlInsertReceive);
                    receiveId = dataAccess.retreiveData(@"select max(hosp_mr_store.receive.id) from hosp_mr_store.receive").Rows[0][0].ToString();
                }

                for (int i = 0; i < dataGridReceive.RowCount; i++)
                {
                    //Receive Detail
                    string sqlInsertReceiveDetail = string.Format(@"insert into hosp_mr_store.receive_detail(hosp_mr_store.receive_detail.receive_id,hosp_mr_store.receive_detail.form_id,hosp_mr_store.receive_detail.qty,hosp_mr_store.receive_detail.unit,hosp_mr_store.receive_detail.unit_price,hosp_mr_store.receive_detail.total_price) values('{0}','{1}','{2}','{3}','{4}','{5}')", receiveId, dataGridReceive.Rows[i].Cells[5].Value.ToString(), dataGridReceive.Rows[i].Cells[6].Value.ToString(), dataGridReceive.Rows[i].Cells[7].Value.ToString(), dataGridReceive.Rows[i].Cells[8].Value.ToString(), dataGridReceive.Rows[i].Cells[9].Value.ToString());

                    dataAccess.executeSQL(sqlInsertReceiveDetail);

                    //Update Stock
                    string SqlChkStock = string.Format(@"select * from hosp_mr_store.stock where (hosp_mr_store.stock.form_id = '{0}' and hosp_mr_store.stock.lot_no = '{1}') or (hosp_mr_store.stock.form_id = '{0}' and hosp_mr_store.stock.lot_no = 1)", dataGridReceive.Rows[i].Cells[5].Value.ToString(), dataGridReceive.Rows[i].Cells[10].Value.ToString());
                    DataTable dtchkStock = new DataTable();
                    dtchkStock = dataAccess.retreiveData(SqlChkStock);
                    if (dtchkStock.Rows.Count > 0)
                    {
                        string sqlUpdateStock = string.Format(@"update hosp_mr_store.stock set hosp_mr_store.stock.remaining = hosp_mr_store.stock.remaining + '{0}' where hosp_mr_store.stock.form_id = '{1}'", Convert.ToInt32(dataGridReceive.Rows[i].Cells[6].Value.ToString()), dataGridReceive.Rows[i].Cells[5].Value.ToString());

                        dataAccess.executeSQL(sqlUpdateStock);
                    }
                    else
                    {
                        string sqlInsertToStock = string.Format(@"insert into hosp_mr_store.stock(hosp_mr_store.stock.form_id, hosp_mr_store.stock.unit_price, hosp_mr_store.stock.unit, hosp_mr_store.stock.remaining, hosp_mr_store.stock.picture_path, hosp_mr_store.stock.lot_no) values('{0}','{1}','{2}','{3}','{4}','{5}')", dataGridReceive.Rows[i].Cells[5].Value.ToString(), dataGridReceive.Rows[i].Cells[8].Value.ToString(), dataGridReceive.Rows[i].Cells[7].Value.ToString(), dataGridReceive.Rows[i].Cells[6].Value.ToString(), "/", dataGridReceive.Rows[i].Cells[10].Value.ToString());

                        dataAccess.executeSQL(sqlInsertToStock);
                    }
                }
                dataAccess.executeSQL(@"delete from hosp_mr_store.receive_dummy");
                fillDataGrid();
                txtGrandTotalPrice.Text = "0.00";
                MessageBox.Show("บันทึกเรียบร้อย");
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลก่อนบันทึก");
                return;
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (dataGridReceive != null)
            {
                if (dataGridReceive.Rows.Count > 0)
                {
                    if (MessageBox.Show("ต้องการลบรายการที่เลือกใช่หรือไม่", "แจ้งแตือน แจ้งทราบ !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sqlDelete = string.Format(@"delete from hosp_mr_store.receive_dummy where hosp_mr_store.receive_dummy.id ='{0}'", dataGridReceive.CurrentRow.Cells[0].Value.ToString());
                        dataAccess.executeSQL(sqlDelete);
                        fillDataGrid();
                    }
                }
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if (dataGridReceive != null)
            {
                if (dataGridReceive.Rows.Count > 0)
                {
                    if (dataGridReceive.SelectedRows.Count == 1)
                    {
                        btnAddToList.Enabled = false;
                        btnSave.Enabled = false;
                        btnEditUpdate.Enabled = true;

                        dataGridReceive.Enabled = false;
                        txtVendor.Text = commonCode.getVendorName(dataGridReceive.CurrentRow.Cells[4].Value.ToString());
                        txtFormMrName.Text = commonCode.getFormName(dataGridReceive.CurrentRow.Cells[5].Value.ToString());
                        txtQuantity.Text = dataGridReceive.CurrentRow.Cells[6].Value.ToString();
                        cboxUnit.Text = dataGridReceive.CurrentRow.Cells[7].Value.ToString();
                        txtPricePerUnit.Text = dataGridReceive.CurrentRow.Cells[8].Value.ToString();
                        txtLotNo.Text = dataGridReceive.CurrentRow.Cells[10].Value.ToString();
                        txtQuantity.Focus();
                        txtQuantity.SelectAll();
                    }
                }
            }
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            string SqlChkInvoiceNo = string.Format(@"select hosp_mr_store.receive.invoice_no from hosp_mr_store.receive where hosp_mr_store.receive.invoice_no = '{0}'", txtInvoiceNo.Text.Trim());
            DataTable dtchk = new DataTable();
            dtchk = dataAccess.retreiveData(SqlChkInvoiceNo);
            if (dtchk.Rows.Count > 0)
            {
                MessageBox.Show("มีเลขใบส่งของนี้แล้วในระบบ \nกรุณากรอกเลขใบส่งของใหม่");
                txtInvoiceNo.Focus();
                txtInvoiceNo.SelectAll();
                return;
            }

            if (string.IsNullOrEmpty(txtInvoiceNo.Text))
            {
                errorProvider1.SetError(txtInvoiceNo, "กรุณากรอกเลขที่ใบส่งของ");
                txtInvoiceNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtVendor.Text))
            {
                errorProvider1.SetError(txtVendor, "กรุณากรอกชื่อบริษัท");
                txtVendor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtFormMrName.Text))
            {
                errorProvider1.SetError(txtFormMrName, "กรุณากรอกชื่อรายการรับเข้า");
                txtFormMrName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                errorProvider1.SetError(txtQuantity, "กรุณากรอกจำนวน");
                txtQuantity.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboxUnit.Text))
            {
                errorProvider1.SetError(cboxUnit, "กรุณากรอกหน่วยนับ");
                cboxUnit.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPricePerUnit.Text))
            {
                errorProvider1.SetError(txtPricePerUnit, "กรุณากรอกราคาต่อหน่วย");
                txtPricePerUnit.Focus();
                return;
            }

            int qty = 0;
            int.TryParse(txtQuantity.Text, out qty);

            decimal price = 0;
            decimal.TryParse(txtPricePerUnit.Text, out price);

            string sqlUpdateReceiveDummy = string.Format(@"update hosp_mr_store.receive_dummy set hosp_mr_store.receive_dummy.vendor_id = '{0}',
                            hosp_mr_store.receive_dummy.form_id = '{1}',
                            hosp_mr_store.receive_dummy.qty = '{2}',
                            hosp_mr_store.receive_dummy.unit = '{3}',
                            hosp_mr_store.receive_dummy.unit_price = '{4}',
                            hosp_mr_store.receive_dummy.total_price = '{5}',
                            hosp_mr_store.receive_dummy.lot_no = '{6}'
                            where hosp_mr_store.receive_dummy.id = '{7}'", commonCode.getVendorId(txtVendor.Text), commonCode.getFormId(txtFormMrName.Text), qty, cboxUnit.Text, price, txtTotalPrice.Text, txtLotNo.Text, dataGridReceive.CurrentRow.Cells[0].Value.ToString());

            dataAccess.executeSQL(sqlUpdateReceiveDummy);

            fillDataGrid();

            txtInvoiceNo.Clear();
            txtVendor.Clear();
            txtFormMrName.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
            txtLotNo.Clear();
            dataGridReceive.Enabled = true;
            btnAddToList.Enabled = true;
            btnSave.Enabled = true;
            btnEditUpdate.Enabled = false;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            txtInvoiceNo.Clear();
            txtVendor.Clear();
            txtFormMrName.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtTotalPrice.Clear();
            txtLotNo.Clear();
            dataGridReceive.Enabled = true;
            btnAddToList.Enabled = true;
            btnSave.Enabled = true;
            btnEditUpdate.Enabled = false;
        }

        private void txtReceiveNo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}