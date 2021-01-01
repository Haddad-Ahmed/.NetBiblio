using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Adherent
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Champ obligatoire")]
        public string Nom{ get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        public string Prenom{ get; set; }

        [Required(ErrorMessage ="Champ obligatoire")]
        public string Login{ get; set; }

        [Required(ErrorMessage ="Champ obligatoire")]
        [DataType(DataType.Password)]
        public string Password{ get; set; }

        public virtual Bibliotheque Bibliotheque { get; set; }

        public virtual ICollection<Emprunt> Emprunts { get; set; }

        public Adherent()
        {
        }

        public Adherent(int id, string nom, string prenom, string login, string password, Bibliotheque bibliotheque, ICollection<Emprunt> emprunts)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Login = login;
            Password = password;
            Bibliotheque = bibliotheque;
            Emprunts = emprunts;
        }

        public override string ToString()
        {
            return base.ToString() + $"Id :{Id}, Nom: {Nom}, Prenom: {Prenom}";
        }
    }
}
