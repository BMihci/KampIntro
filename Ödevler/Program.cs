using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "Kürede Lisyantus Aranjmanı";
            urun1.urunCesiti = "Sevgililer Günü";
            urun1.urunFiyati = 219;

            Product urun2 = new Product();
            urun2.urunAdi = "Kütükte Lisyantus Aranjmanı";
            urun2.urunCesiti = "Doğum Günü";
            urun2.urunFiyati = 189;

            Product urun3 = new Product();
            urun3.urunAdi = "Lotuslu Hindistan Cevizli Kek";
            urun3.urunCesiti = "Yenilebilir Çiçek";
            urun3.urunFiyati = 179;

            Product urun4 = new Product();
            urun4.urunAdi = "Saksıda Beyaz Saptifilyum";
            urun4.urunCesiti = "Anneler Günü";
            urun4.urunFiyati = 299;

            Product urun5 = new Product();
            urun5.urunAdi = "Beton Saksıda Sukulent ve Kaktüs";
            urun5.urunCesiti = "Yeni İş Hediyesi";
            urun5.urunFiyati = 239;

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4, urun5 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " / " + urun.urunCesiti + " / " + urun.urunFiyati);
            }

            Console.WriteLine("!!! Foreach Bitti !!!");

            for (int i = 0; i <urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " : " + urunler[i].urunCesiti + " : " + urunler[i].urunFiyati); 
            }

            Console.WriteLine("!!! For  Bitti !!!");

            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].urunAdi + " - " + urunler[a].urunCesiti + " - " + urunler[a].urunFiyati);
                a++;
            }

            Console.WriteLine("!!! While Bitti !!!");
            
        }
    }

    class Product
    {

        public string urunAdi { get; set; }
        public int urunFiyati { get; set; }
        public string urunCesiti { get; set; }




    }
}
