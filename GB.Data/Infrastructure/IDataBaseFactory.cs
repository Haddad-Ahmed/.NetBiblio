using GB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Infrastructure
{
    public interface IDataBaseFactory: IDisposable
    {
        Context DataContext { get; }
    }
}
