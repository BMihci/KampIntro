using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); 
            //burada int veri tipi bir değer tip olduğu için, 3. satırda sayı1'in değeri 30a atanır sonra sayı2'nin ne olduğu önemli değildir
            //sonuç bu yüzden 30 çıkar.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //Burada arrayler bir referans tip olduğu için print satırında sayilar2 dizisindeki değişiklik sayilar1'de sağlanan eşitliği etkiler
            //sonuç bu yüzden 999 çıkar


        }
    }
}
