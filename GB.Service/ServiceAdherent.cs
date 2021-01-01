using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public class ServiceAdherent : Service<Adherent>, IServiceAdherent
    {
        public Adherent Login(string username, string password)
        {
            return GetMany(a => a.Login.Equals(username) && a.Password.Equals(password)).FirstOrDefault();
        }
    }
}
