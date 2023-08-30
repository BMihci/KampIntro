using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNo = "196746";
            musteri1.CustomerName = "Savaş";
            musteri1.CustomerSurname = "Buldan";
            musteri1.TcNo = "19222113345";
            //Burada Gerçek Müşteri ve Tüzel Müşteri olmak üzere iki tür nesnem var. Bunlar sırf birbirine benziyor, ikisi de müşteri diye birbirinin yerine kullanılamazlar.

            GercekMusteri musteri2 = new GercekMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNo = "213435";
            musteri2.CustomerName = "Behçet";
            musteri2.CustomerSurname = "Cantürk";
            musteri2.TcNo = "19111113345";


            GercekMusteri musteri3 = new GercekMusteri();
            musteri3.Id = 3;
            musteri3.CustomerNo = "383506";
            musteri3.CustomerName = "Önder Lütfü";
            musteri3.CustomerSurname = "Koşar";
            musteri3.TcNo = "19333113345";

            TuzelMusteri musteri4 = new TuzelMusteri();
            musteri4.Id = 4;
            musteri4.CustomerNo = "413485";
            musteri4.FirmName = "Nedim İplik Tekstil San. ve Tic. A.Ş.";
            musteri4.VergiNo = "0507121315";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
        }
    }
}
