using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GB.Service
{
    public interface IServiceDocument : IService<Document>
    {


        IEnumerable<Document> ChercherDocument(Bibliotheque biblio, string titre);

    }
}
