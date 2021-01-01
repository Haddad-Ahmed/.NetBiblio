using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Document
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        [DataType(DataType.MultilineText)]
        public string Resume { get; set; }

        public int? BibliothequeFK { get; set; }

        public virtual Bibliotheque Bibliotheque { get; set; }

        public virtual ICollection<Emprunt> Emprunts{ get; set; }

        public Document()
        {
        }

        public Document(int id, string titre, string resume, int? bibliothequeFK, Bibliotheque bibliotheque, ICollection<Emprunt> emprunts)
        {
            Id = id;
            Titre = titre;
            Resume = resume;
            BibliothequeFK = bibliothequeFK;
            Bibliotheque = bibliotheque;
            Emprunts = emprunts;
        }

        public override string ToString()
        {
            return base.ToString() + $"Id :{Id}, Titre: {Titre}, Resume: {Resume}, BiblioFK: {BibliothequeFK} ";
        }

    }
}
