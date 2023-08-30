using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Mylist<string> isimler = new Mylist<string>();
            isimler.Add("Sezen");
            isimler.Add("Cumhur");
            isimler.Add("Önal");

        }
    }
}
