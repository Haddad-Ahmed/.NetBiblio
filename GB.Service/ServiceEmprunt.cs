using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class ServiceEmprunt : Service<Emprunt>, IServiceEmprunt
    {
        public bool Empruntable(Document document)
        {

            if (document is Livre)
            return GetMany(e => e.DocumentFK.Equals(document.Id) && e.DateRetour == null).Count() == 0;
            return false;
        }

        public void Emprunter(Document document, Adherent adherent)
        {
            
            if (!Empruntable(document))
                Console.WriteLine("le document est deja emprunte");
            else {
                Add(
                    new Emprunt() {
                    AdherentFK = adherent.Id,
                    DocumentFK = document.Id,
                    DateEmprunt = DateTime.Now,
                    });
                Commit();
                
            }

        }

        public void Rendre(Document document)
        {
            Emprunt emp = new Emprunt();
            emp = GetMany(e => e.DocumentFK.Equals(document.Id) && e.DateRetour == null).First();
            emp.DateRetour = DateTime.Now;
            emp.DureeEmprunt = DateTime.Now.Subtract(emp.DateEmprunt).Days;
            Update(emp);
            Console.WriteLine($"Document: {document.Titre} returned !");
        }
    }
}
