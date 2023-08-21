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
                Console.WriteLine("Bizim Üst Kata Bir Karı Taşındı Süt Süt!");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Siktir Çık Lan Kasıyor");
            
            }

            else if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Girsene Lan Sisteme");
            }

            Console.WriteLine(kategoriEtiketi);

        
        }
    }
}
