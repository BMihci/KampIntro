using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ArtisanCreditManager : ICreditManager
    {
        public void Count()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
