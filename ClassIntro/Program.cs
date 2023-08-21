using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Dızcılık";
            kurs1.Egitmen = "Altın Çocuk";
            kurs1.IzlenmeOrani = 155;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Kıyıcılık";
            kurs2.Egitmen = "Cio Baba";
            kurs2.IzlenmeOrani = 112;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "İcap Eder Mi";
            kurs3.Egitmen = "Savaş Satış";
            kurs3.IzlenmeOrani = 158;

            // Uzun Yolu Şuydu : Console.WriteLine(kurs1.KursAdi + " / " + kurs1.Egitmen + " / " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " / " + kurs.Egitmen + " / " + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
