using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using utpStore.ui; //เก็บ form ไว้ที่ Folder ไหน ต้อง using Directory ที่เก็บ form นั้นเข้ามาด้วย

namespace utpStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new frmMain());
            //Application.Run(new frmAddUser());
            //Application.Run(new frmDisplaySearchUser());
            //Application.Run(new frmAddFormMr());
            //Application.Run(new frmReceiveFormMr());
        }
    }
}