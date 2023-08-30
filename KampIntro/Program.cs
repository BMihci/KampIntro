using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 17.35;
            double dolarBugun = 17.75;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolar Düşüyor Cano");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Uçuyor Cano");
            }

            else
            {
                Console.WriteLine("Dolar Aynı Cano");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Giriş Yapıldı");
            
            }

            else if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Çıkış Yapıldı");
            }

            Console.WriteLine(kategoriEtiketi);

        
        }
    }
}
