using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utpStore.controller
{
    public class closeAllForms
    {
        public void fn_closeAllForms() 
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmMain")
                    {

                    }
                    else
                    {
                        form.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}