using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Exchange_Rates_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Create the database if it does not exists and initialize it
            //DatabaseManager db = new DatabaseManager();

            //if (db.DBcreate())
            //db.DBinitialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCurrencyExchangeRates());
        }
    }
}
