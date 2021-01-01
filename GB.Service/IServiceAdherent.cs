using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public interface IServiceAdherent : IService<Adherent>
    {
        Adherent Login(string username, string password);
    }
}
