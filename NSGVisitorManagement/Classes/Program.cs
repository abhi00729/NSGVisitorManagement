using NSGVisitorManagement.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSGVisitorManagement
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
            GlobalClass.MachineName = Dns.GetHostName().ToUpper();
            GlobalClass.BuildVersion = Application.ProductVersion;
            GlobalClass.ProductName = Application.ProductName;
            GlobalClass.PrinterName = ConfigurationManager.AppSettings["PrinterName"].ToString();
            GlobalClass.DefaultPassValidHours = int.Parse(ConfigurationManager.AppSettings["DefaultPassValidHours"].ToString());
            GlobalClass.MaxSearchRows = int.Parse(ConfigurationManager.AppSettings["MaxSearchRows"].ToString());

            Application.Run(new frmLogin());
        }
    }
}
