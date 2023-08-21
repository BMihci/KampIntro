using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı İlk harf büyük kalanı küçük
        public void Ekle(Urun product)
        {
            //Ekle kodunu çağırınca ne yapmasını istediğini söylediğin kısım bura
            Console.WriteLine("Eri Lan Sana" + " " + product.Adi +" " + "Sepette Gardaş!");
        }

    }
}
