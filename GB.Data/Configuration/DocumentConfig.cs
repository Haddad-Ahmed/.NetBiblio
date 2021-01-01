using GB.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Data.Configuration
{
    public class DocumentConfig : EntityTypeConfiguration<Document>
    {
        public DocumentConfig() 
        {
            HasRequired(d => d.Bibliotheque)
                .WithMany(b => b.Documents)
                .HasForeignKey(d => d.BibliothequeFK)
                .WillCascadeOnDelete(false);
        }

    }
}
