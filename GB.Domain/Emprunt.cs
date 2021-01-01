using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Emprunt
    {
        [Key]
        [Column(Order = 1)]
        [DataType(DataType.Date)]
        public DateTime DateEmprunt { get; set; }
        
        public DateTime? DateRetour { get; set; }

        public int DureeEmprunt { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Adherent")]
        public int AdherentFK { get; set; }

        [Key]
        [Column(Order = 3)]
        [ForeignKey("Document")]
        public int DocumentFK { get; set; }

        public virtual Adherent Adherent { get; set; }

        public virtual Document Document{ get; set; }

        public Emprunt()
        {
        }

        public Emprunt(DateTime dateEmprunt, DateTime? dateRetour, int dureeEmprunt, int adherentFK, int documentFK, Adherent adherent, Document document)
        {
            DateEmprunt = dateEmprunt;
            DateRetour = dateRetour;
            DureeEmprunt = dureeEmprunt;
            AdherentFK = adherentFK;
            DocumentFK = documentFK;
            Adherent = adherent;
            Document = document;
        }

        public override string ToString()
        {
            return base.ToString() + $"Id :{DateEmprunt}|{AdherentFK}|{DocumentFK}, dateRetour: {DateRetour}, duree: {DureeEmprunt}";
        }
    }
}
