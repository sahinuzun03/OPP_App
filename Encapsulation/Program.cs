using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.Name = "Şahin";
            personel.Surname = "Uzun";
            personel.Wage = -100;

            //ilk oluşturulan personel maaşı yazdırıldığı zaman 0 çıktısını elde edeceğiz.Bunun sebebi ise kapsüllemede gelen değer 0'dan küçük ise personel maaşının 0 olarak girileceğini gösterdik.
            Console.WriteLine("Birinci Personel Maaşı : " + personel.Wage.ToString());

            //ikinci personele ait oluşturulan maaş bilgisi yazdırıldığı zaman 100 çıktısını elde edeceğiz
            Personel personel2 = new Personel();
            personel2.Name = "Şahin";
            personel2.Surname = "Uzun";
            personel2.Wage = 100;
            Console.WriteLine("İkinci Personel Maaşı : " + personel2.Wage.ToString());
            Console.ReadLine();
        }
    }
}
