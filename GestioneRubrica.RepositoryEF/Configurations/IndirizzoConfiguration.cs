using GestioneRubrica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestioneRubrica.RepositoryEF
{
    internal class IndirizzoConfiguration : IEntityTypeConfiguration<Indirizzo>
    {
        public void Configure(EntityTypeBuilder<Indirizzo> modelBuilder)
        {
            modelBuilder.ToTable("Indirizzo");
            modelBuilder.HasKey(i => i.IndirizzoID);
            modelBuilder.Property(i => i.Residenza).IsRequired();
            modelBuilder.Property(i => i.Domicilio);
            modelBuilder.Property(i => i.Via).IsRequired();
            modelBuilder.Property(i => i.Città).IsRequired();
            modelBuilder.Property(i => i.Cap).IsRequired();
            modelBuilder.Property(i => i.Provincia).IsRequired();
            modelBuilder.Property(i => i.Nazione).IsRequired();


           
            modelBuilder.HasOne(i => i.Contatto).WithMany(c => c.Indirizzi).HasForeignKey(i => i.ContattoID);


        }
    }
}