using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionClass
{
    // 1. Abstract sınıfların nesneleri üretilemez
    // 2. Abstract sınıflarda metotların gövedisi yazılabilir
    // 3. Abstract sınıfıların constructor yazılabilir.
    // 4. Abstract sınfılarda metotlar abstract , virtual olarak işaretlenebilir ya da işaretlenemez.
    // 5. Propertler abstract olarka işaretlenebilir.
    // 6. Abstract olarak işaretlenen metot kalıtım alınan sınıfta override edilip gövdesinin ezilmesi gerekmektedir.
    // 7. Abstract sınıflar en temel sınıf olarak tanımlanması gerekmketedir.
    public abstract class UlasimAraci
    {
        public UlasimAraci(int YolcuSayisi)
        {
            this.YolcuSayisi = YolcuSayisi; //Constructor metot yazdık.
        }
        public int YolcuSayisi { get; set; }
        public abstract string Name { get; }
        public void HareketEt()
        {
            Console.WriteLine("Hareket Etti");
        }
        public virtual void YakitHarca()
        {
            Console.WriteLine("Petrol Türevi Yakıt");
        }

        public abstract void HareketHizi();
    }
}
