using NewBank.Core;
using NewBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBank.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.AddInstance();
            var cust = GlobalConfig.CustoRepo;
            var login = GlobalConfig._auth;
            var operation = GlobalConfig.BankOp;
            var account = GlobalConfig.AccountRepo;


            Application.Run(new Login(login, cust, operation, account));
        }
    }
}
