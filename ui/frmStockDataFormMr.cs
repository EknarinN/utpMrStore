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
    public partial class frmStockDataFormMr : Form
    {
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
    }
}