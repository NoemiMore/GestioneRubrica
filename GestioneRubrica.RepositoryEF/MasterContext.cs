using GestioneRubrica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRubrica.RepositoryEF
{
    class MasterContext: DbContext
    {
        public DbSet<Contatto> Contatti { get; set; }
        public DbSet<Indirizzo> Indirizzi { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Rubrica; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Contatto>(new ContattoConfiguration());
            modelBuilder.ApplyConfiguration<Indirizzo>(new IndirizzoConfiguration());
            
        }


    }
}
