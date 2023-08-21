using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id = 0001;
            urun1.Adi = "Şeker";
            urun1.Fiyati = 200;
            urun1.Aciklama = "Ducati!";
            urun1.StokAdedi = 50;

            Urun urun2 = new Urun();
            urun2.Id = 0002;
            urun2.Adi = "Metin Amca";
            urun2.Fiyati = 800;
            urun2.Aciklama = "Yandım da Söndüm!";
            urun2.StokAdedi = 150;

            Urun urun3 = new Urun();
            urun3.Id = 0003;
            urun3.Adi = "Cigara";
            urun3.Fiyati = 400;
            urun3.Aciklama = "Zehir, Zehir!";
            urun3.StokAdedi = 1000;

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};
            //urunler dizisindeki Urun veri tipindeki product takma isimli item
            foreach (var product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.StokAdedi + " " + "Adet/Gram Kaldı");
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------METOTLAR------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
        }
    }
}
