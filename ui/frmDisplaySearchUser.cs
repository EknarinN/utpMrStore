using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utpStore.ui
{
    public partial class frmDisplaySearchUser : Form
    {
        public frmDisplaySearchUser()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            timerCurentTime.Start();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerCurentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentDate.Text = DateTime.Now.ToLongDateString();
            lblCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
