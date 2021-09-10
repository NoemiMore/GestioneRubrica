using GestioneRubrica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestioneRubrica.RepositoryEF
{
    internal class ContattoConfiguration : IEntityTypeConfiguration<Contatto>
    {

        

        public void Configure(EntityTypeBuilder<Contatto> modelBuilder)
        {
           
                modelBuilder.ToTable("Contatto");
                modelBuilder.HasKey(c => c.ContattoID);
                modelBuilder.Property(c => c.Nome).IsRequired();
                modelBuilder.Property(c => c.Cognome).IsRequired();
               
              

                
                modelBuilder.HasMany(c => c.Indirizzi).WithOne(i => i.Contatto).HasForeignKey(c => c.ContattoID);
            
        }
    }
}