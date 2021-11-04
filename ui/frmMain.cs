using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utpStore.controller; //(C1) เรียกใช้ Class ที่มี FN ที่เราต้องการใช้จากภายนอก
using utpStore.sqlQuery;

namespace utpStore.ui
{
    public partial class frmMain : Form
    {
        private dataAccess dataAccess = new dataAccess();

        private string user_Id = null;
        private string full_Name = null;

        public frmMain(string userId, string fullName)
        {
            this.user_Id = userId;
            this.full_Name = fullName;
            InitializeComponent();
            //MinimizeBox = false;
            MaximizeBox = false;
        }

        //Function ภายในฟอร์ม
        //private void CloseAllForms()
        //{
        //    try
        //    {
        //        foreach (Form form in Application.OpenForms)
        //        {
        //            if(form.Name == "frmMain")
        //            {
        //            }
        //            else
        //            {
        //                form.Close();
        //            }

        //        }
        //    }
        //    catch
        //    {
        //    }

        //}

        private closeAllForms closeAllForms = new closeAllForms(); //(C2) เมื่อ Import Class จากภายนอก (C1) แล้ว ก็สร้าง Instant มารับ

        private void menuReceive_Click(object sender, EventArgs e)
        {
            //เรียกใช้ Function ภายในฟอร์ม
            //CloseAllForms();

            //(C3) เรียกใช้ FN จาก Class ภายนอก ผ่าน Instant ที่สร้างขึ้นจาก (C2)
            //closeAllForms.fn_closeAllForms();

            //try
            //{
            //    foreach (Form form in Application.OpenForms)
            //    {
            //        if (form.Name == "frmMain")
            //        {
            //        }
            //        else
            //        {
            //            form.Close();
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //}

            // check if form is activate
            frmReceiveFormMr frmReceiveFormMr = new frmReceiveFormMr(user_Id, full_Name);

            frmReceiveFormMr.FormBorderStyle = FormBorderStyle.None;

            frmReceiveFormMr.TopLevel = false;

            panelMain.Controls.Add(frmReceiveFormMr);

            frmReceiveFormMr.BringToFront();

            frmReceiveFormMr.Show();
        }

        private void menuAddUser_Click(object sender, EventArgs e)
        {
            //เรียกใช้ Function ภายในฟอร์ม
            //CloseAllForms();
            //closeAllForms.fn_closeAllForms();

            // check if form is activate
            frmAddUser frmAddUser = new frmAddUser();

            frmAddUser.FormBorderStyle = FormBorderStyle.None;

            frmAddUser.TopLevel = false;

            panelMain.Controls.Add(frmAddUser);

            frmAddUser.BringToFront();

            frmAddUser.Show();
        }

        private void menuStockData_Click(object sender, EventArgs e)
        {
            //เรียกใช้ Function ภายในฟอร์ม
            //CloseAllForms();
            //closeAllForms.fn_closeAllForms();

            // check if form is activate
            frmStockDataFormMr frmStockData = new frmStockDataFormMr();

            frmStockData.FormBorderStyle = FormBorderStyle.None;

            frmStockData.TopLevel = false;

            panelMain.Controls.Add(frmStockData);

            frmStockData.BringToFront();

            frmStockData.Show();
        }

        private void menuRequest_Click(object sender, EventArgs e)
        {
            //closeAllForms.fn_closeAllForms();

            frmRequestFormMr frmOrderFormMr = new frmRequestFormMr(user_Id, full_Name);

            frmOrderFormMr.FormBorderStyle = FormBorderStyle.None;

            frmOrderFormMr.TopLevel = false;

            panelMain.Controls.Add(frmOrderFormMr);

            frmOrderFormMr.BringToFront();

            frmOrderFormMr.Show();
        }

        private void menuOrderApprove_Click(object sender, EventArgs e)
        {
            //closeAllForms.fn_closeAllForms();

            frmApproveFormMr frmApproveFormMr = new frmApproveFormMr();

            frmApproveFormMr.FormBorderStyle = FormBorderStyle.None;

            frmApproveFormMr.TopLevel = false;

            panelMain.Controls.Add(frmApproveFormMr);

            frmApproveFormMr.BringToFront();

            frmApproveFormMr.Show();
        }

        private void menuCloseProgram_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string sqlChkUser = string.Format(@"select * from hosp_mr_store.user where hosp_mr_store.user.id = '{0}'", user_Id);
            //CHK Admin
            if (dataAccess.retreiveData(sqlChkUser).Rows[0][7].ToString() == "00")
            {
            }
            //CHK User
            else
            {
                menuReceive.Enabled = false;
                menuStockData.Enabled = false;
                menuOrderApprove.Enabled = false;
                menuReport.Enabled = false;
                //menuSetting.Enabled = false;
            }
        }
    }
}