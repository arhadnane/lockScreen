using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace lockScreen
{
    static class Program
    {
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // we need to get the current process name
            string strProcessName = Process.GetCurrentProcess().ProcessName;
            // check if this process name is existing in the current running processes
            Process[] Oprocesses = Process.GetProcessesByName(strProcessName);
            // if its existing then exit
            if (Oprocesses.Length > 2)
            {
               // MessageBox.Show("The application is already running");
            }
            else
            {
                // else let the below code run
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new freezeScreen());
            }
        }

       
    }
}
