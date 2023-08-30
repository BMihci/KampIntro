using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array = Listeler / Diziler
            string[] kurslar = new string[] {"Yazılımcı Geliştirme Kampı","C# Başlangıç Kampı","Python Kampı", "Java Kursu", "Noktalı Virgül Unutmama Kursu"};
            
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For'un Sonu Foreach'in Başı");
            //dizi temelli yapı dönderen döngü biçimi foreach
            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);

            }

            Console.WriteLine("Sayfa Bitti !");
        }
    }
}
