using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Livre : Volume
    {
        public int NbPages{ get; set; }

        public Livre()
        {
        }

        public Livre(int nbPages)
        {
            NbPages = nbPages;
        }
        public override string ToString()
        {
            return base.ToString() + $"NbPages :{NbPages}";
        }
    }
}
