using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        IDataBaseFactory Factory;
        public UnitOfWork(IDataBaseFactory Factory)
        {
            this.Factory = Factory;
        }

        public UnitOfWork()
        {
        }

        public void Commit()
        {
            Factory.DataContext.SaveChanges();
        }
        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(Factory);
        }
        public void Dispose()
        {
            Factory.Dispose();
        }
    }
}
