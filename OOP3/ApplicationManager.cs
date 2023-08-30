using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {

        public void ApplyCredit(ICreditManager creditManager, ILoggerService loggerService)
        {

            creditManager.Count();
            loggerService.Log();
        }

        public void CreditPreInfo(List<ICreditManager> credits)
        {

            foreach (var credit in credits)
            {
                credit.Count();
            }

        }

    }
}
