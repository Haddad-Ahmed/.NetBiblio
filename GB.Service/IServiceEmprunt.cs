using GB.Domain;
using GB.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Service
{
    public interface IServiceEmprunt : IService<Emprunt>
    {
        bool Empruntable(Document document);
        void Emprunter(Document document, Adherent adherent);
        void Rendre(Document document);
    }
}
