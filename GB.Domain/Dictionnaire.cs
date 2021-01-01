using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Dictionnaire : Volume
    {
        public string Langue { get; set; }

        public Dictionnaire()
        {
        }

        public Dictionnaire(string langue)
        {
            Langue = langue;
        }
        public override string ToString()
        {
            return base.ToString() + $"Langue :{Langue}";
        }
    }
}
