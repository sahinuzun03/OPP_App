using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionClass
{
    public class Gemi : UlasimAraci
    {
        //Constructor metot yazıldı
        public Gemi(int YolcuSayisi) : base(YolcuSayisi)
        {
        }

        //abstract işaretlenen metot override edildi
        public override string Name => "Gemi";

        //Hareket hizi abstract işaretlendiği için override edildi
        public override void HareketHizi()
        {
            Console.WriteLine("50km/s");
        }

        //Mercedes'te virtual işaretlenen yakıt harca metodunu burada override etmiyoruz.Nedeni ise virtual olarak işaretlendiği için override etme gibi bir zorunluluğumuz yok.
    }
}
