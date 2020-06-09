using ClassLibraryDados.Entities;
using ClassLibraryDados.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClassLibraryDados.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["BancoPlano"].ConnectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TitularMap());
            modelBuilder.Configurations.Add(new DependenteMap());

            


        }

        public DbSet<Titular> Titular { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }
    }
}
