using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Bibliotheque
    {
        public int Id { get; set; }
        public virtual ICollection<Adherent> Adherents{ get; set; }
        public virtual ICollection<Document> Documents{ get; set; }

        public Bibliotheque()
        {
        }

        public Bibliotheque(int id, ICollection<Adherent> adherents, ICollection<Document> documents)
        {
            Id = id;
            Adherents = adherents;
            Documents = documents;
        }

        public override string ToString()
        {
            return base.ToString()+", Id : " + Id;
        }
    }
}
