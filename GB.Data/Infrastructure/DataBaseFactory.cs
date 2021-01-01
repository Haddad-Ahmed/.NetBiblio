
using GB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Infrastructure
{
   
    public class DataBaseFactory : Disposable, IDataBaseFactory
    {
        private Context dataContext;

        public Context DataContext
        {
            get
            {
                return dataContext;
            }
        }

        public DataBaseFactory()
        {
            dataContext = new Context();
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
