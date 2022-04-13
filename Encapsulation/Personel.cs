using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Personel
    {
        public Guid Id { get { return Guid.NewGuid(); } }
        public string Name { get; set; }
        public string Surname { get; set; }

        //Kullanıcının maaş bilgisi kapsülleme yaparak veri girişinin kontrolünü sağladık.
        private decimal _Wage { get; set; }
        public decimal Wage
        {
            get { return _Wage; }
            set
            {
                if (value < 0)
                    _Wage = 0;
                else
                    _Wage = value;
            }
        }
    }
}

