using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Mappings
{
    public class TitularMap : EntityTypeConfiguration<Titular>
    {
        public TitularMap()
        {
            ToTable("Titular");

            //Chave primaria
            HasKey(p => new { p.IdTitular});

            Property(p => p.IdTitular).HasColumnName("IdTitular");

            Property(p => p.Contrato)
                .HasColumnName("Contrato")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Cpf)
                .HasColumnName("Cpf")
                .HasMaxLength(100)
                .IsRequired();

            HasMany(p => p.Dependentes)
                .WithRequired(t => t.Titular)
                .HasForeignKey<int>(t => t.IdTitular);
                

        }
    }
}
