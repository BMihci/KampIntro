using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

           //Burası ekrandaki açılır kutu gibi düşün
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vechileCreditManager = new VechileCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ApplyCredit(new ArtisanCreditManager(), new SmsLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {consumerCreditManager, vechileCreditManager };

           //applicationManager.CreditPreInfo(credits);


        }
    }
}
