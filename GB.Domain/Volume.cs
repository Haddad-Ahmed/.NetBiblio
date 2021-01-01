using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Volume : Document
    {
        public string Auteur { get; set; }

        public Volume()
        {
        }

        public Volume(string auteur)
        {
            Auteur = auteur;
        }
        public override string ToString()
        {
            return base.ToString() + $"Auteur :{Auteur}";
        }
    }
}
