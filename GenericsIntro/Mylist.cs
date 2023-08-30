using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // Burada <> arasındaki ifade "Mylist" isimli listemde ne classı ile çalışacağımı söyler. Bu bir int,bool,string de olabilir,
    // herşey olabilir teamülen tek tiple çalışırken ve programcı her ne tip verirse o olsun diye büyük T ile çalışılır.
    class Mylist<T>
    {

        T[] items;
        public Mylist()
        {

            items = new T[0];

        }
        
        public void Add(T item)
        {
            //Temp Array geçici dizi anlamına gelir
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }


    }
}
