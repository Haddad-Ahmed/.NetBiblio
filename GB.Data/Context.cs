using GB.Data.Configuration;
using GB.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Data
{
    public class Context : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<Adherent> Adherents { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }
        public DbSet<Bibliotheque> Bibliotheques { get; set; }

        public Context() : base("name=connexionBiblioDB") {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DocumentConfig());
            modelBuilder.Entity<Document>().HasKey(d => d.Id);
            modelBuilder.Entity<Bibliotheque>().HasKey(b => b.Id);
            modelBuilder.Entity<Adherent>().HasKey(a => a.Id);

        }
    }
}
