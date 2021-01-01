using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Domain
{
    public class Journal : Document
    {
        [DataType(DataType.Date)]
        public DateTime DateParution { get; set; }

        public Journal()
        {
        }

        public Journal(DateTime dateParution)
        {
            DateParution = dateParution;
        }

        public override string ToString()
        {
            return base.ToString() + $"DatePuration :{DateParution}";
        }
    }
}
