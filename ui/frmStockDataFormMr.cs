using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utpStore.sqlQuery;
using utpStore.report;

namespace utpStore.ui
{
    public partial class frmStockDataFormMr : Form
    {
        dataAccess dataAccess = new dataAccess();

        public frmStockDataFormMr()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            timerCurrentTime.Start();
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToLongDateString();
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockDataFormMr_Load(object sender, EventArgs e)
        {
            string sql = string.Format(@"select hosp_mr_store.mr_form.form_name as 'ชื่อแบบฟอร์ม', hosp_mr_store.stock.unit_price as 'ราคาต่อหน่วย', hosp_mr_store.stock.unit as 'หน่วย', hosp_mr_store.stock.remaining as 'คงเหลือ' from hosp_mr_store.stock left join hosp_mr_store.mr_form on hosp_mr_store.stock.form_id = hosp_mr_store.mr_form.id where hosp_mr_store.stock.remaining > 0");
            DataTable dataTable = new DataTable();
            dataTable = dataAccess.retreiveData(sql);
            gcStock.DataSource = dataTable;
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"select hosp_mr_store.mr_form.form_name, hosp_mr_store.stock.unit_price, hosp_mr_store.stock.unit, hosp_mr_store.stock.remaining from hosp_mr_store.stock left join hosp_mr_store.mr_form on hosp_mr_store.stock.form_id = hosp_mr_store.mr_form.id where hosp_mr_store.stock.remaining > 0");
            rptStock rptStock = new rptStock();
            rptStock.DataSource = dataAccess.DataSetStockReport(sql);

            Directory.CreateDirectory(@"D:\Temp\EXPORT");

            string path = $@"D:\Temp\EXPORT\stock_{DateTime.Now.ToString("yyyy-MM-dd").Replace(":", "").Replace(" ", "")}.pdf";
            rptStock.ExportToPdf(path);

            Process.Start(@path);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // create directory
            Directory.CreateDirectory(@"D:\Temp\EXPORT");

            string path = $@"D:\Temp\EXPORT\stock_{DateTime.Now.ToString("yyyy-MM-dd").Replace(":","").Replace(" ","")}.xlsx";
            gcStock.ExportToXlsx(path);

            Process.Start(@path);
        }
    }
}