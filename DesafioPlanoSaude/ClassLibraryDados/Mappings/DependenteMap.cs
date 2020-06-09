using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Mappings
{
    public class DependenteMap : EntityTypeConfiguration<Dependente>
    {

        public DependenteMap()
        {
            ToTable("Dependente");

            HasKey(p => p.IdDependente);

            Property(p => p.IdDependente)
                .HasColumnName("IdDependente");

            Property(p => p.Contrato)
                .HasMaxLength(50)
                .HasColumnName("Contrato")
                .IsRequired();

            Property(p => p.Nome)
                .HasMaxLength(100)
                .HasColumnName("Nome")
                .IsRequired();

            Property(p => p.Cpf)
                .HasMaxLength(100)
                .HasColumnName("Cpf")
                .IsRequired();


            //Chave estrangeira
            
            HasRequired<Titular>(p => p.Titular)
                .WithMany(p => p.Dependentes)
                .HasForeignKey<int>(p => p.IdTitular);
   

        }
    }


}
