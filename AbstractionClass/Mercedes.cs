using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionClass
{
    public class Mercedes : UlasimAraci
    {
        //Kalıtım alan sınıf base sınıf'a gelen x parametresini gönderdi
        public Mercedes(int x) : base(x)
        {

        }
        //Abstract olarak işaretlenen property Mercedes içerisinde tekrardan ezildi
        public override string Name { get => "Mercedes"; }

        //abstract olarak işaretlenen HareketHizi mecbur olduğu için ezildi
        public override void HareketHizi()
        {
            Console.WriteLine("100km/s");
        }

        //İsteğe bağlı virtual olarak işaretlenen Yakit Harca metodu override edildi.
        public override void YakitHarca()
        {
            Console.WriteLine("Elektrik harca");
        }
    }
}
