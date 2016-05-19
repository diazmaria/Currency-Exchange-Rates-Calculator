using System;
using System.IO;

namespace Currency_Exchange_Rates_Calculator
{
    //TRIED TO AUTOMATIZE THE CREATION AND INITIALIZATION OF THE DATABASE
    class DatabaseManager
    {
        public bool DBcreate()
        {
            using (var dbContext = new CurrencyDBEntities())
            {
                try
                {
                    if (!dbContext.Database.Exists())
                    {
                        dbContext.Database.Create();
                        return true;
                    }
                }
                catch (Exception) {}
            }

            return false;
        }

        public void DBinitialize()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var lines = File.ReadAllLines(path + @"\Currency Exchange Rates Calculator\currencies.txt");

            foreach (var line in lines)
            {
                var dbContext = new CurrencyDBEntities();

                try
                {
                    Currency myCurrency = new Currency()
                    {
                        CurrencyName = line
                    };

                    dbContext.Currencies.Add(myCurrency);
                    dbContext.SaveChanges();
                }
                catch (Exception) { }
            }
        }
    }
}
