using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class ServiceLivre : Service<Livre>, IServiceLivre
    {

        public IEnumerable<Livre> GetLivres(Bibliotheque biblio)
        {
            var serviceEmprunt = new ServiceEmprunt();
            return GetMany(d => d.BibliothequeFK == biblio.Id).Where(d => serviceEmprunt.Empruntable(d));
        }
    }
}
