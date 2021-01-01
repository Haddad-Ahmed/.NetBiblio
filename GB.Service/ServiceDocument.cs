using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class ServiceDocument : Service<Document>, IServiceDocument
    {
        public IEnumerable<Document> ChercherDocument(Bibliotheque biblio, string titre)
        {
            return GetMany(d => d.BibliothequeFK == biblio.Id && d.Titre.Contains(titre));
        }


    }
}
