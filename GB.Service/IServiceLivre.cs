using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GB.Service
{
    public interface IServiceLivre : IService<Livre>
    {

        IEnumerable<Livre> GetLivres(Bibliotheque b);
      
    }
}
