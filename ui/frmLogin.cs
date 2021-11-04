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
using utpStore.ui;

namespace utpStore
{
    public partial class frmLogin : Form
    {
        private dataAccess dataAccess = new dataAccess();

        public frmLogin()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxLogo_DoubleClick(object sender, EventArgs e)
        {
            frmConnectDatabase frmConnect = new frmConnectDatabase();
            frmConnect.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้งาน");
                return;
            }
            if (string.IsNullOrEmpty(txtPasswd.Text))
            {
                MessageBox.Show("กรุณากรอกรหัสผ่าน");
                return;
            }
            string sql = string.Format(@"select * from hosp_mr_store.user where hosp_mr_store.user.username = '{0}' and hosp_mr_store.user.password = '{1}'", txtUsername.Text, txtPasswd.Text);
            DataTable dt = new DataTable();
            dt = dataAccess.retreiveData(sql);
            if (dt.Rows.Count > 0)
            {
                string userId = dt.Rows[0]["id"].ToString();
                string fullName = dt.Rows[0]["fname"].ToString() + " " + dt.Rows[0]["lname"].ToString();
                frmMain frmMain = new frmMain(userId, fullName);
                this.Hide();
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("ไม่สามารเข้าสู่ระบบได้ !!!");
                return;
            }
        }

        private void txtPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}