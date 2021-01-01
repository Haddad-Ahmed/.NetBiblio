using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Conventions
{
    public class PrimaryKeyConvention : Convention
    {
        public PrimaryKeyConvention()
        {
            /* Properties().Where(
                 p =>
                 p.Name == p.GetValue(p) + "Id_" + p.DeclaringType.Name
                 ).Configure(p => p.IsKey());*/
        }
    }
}
