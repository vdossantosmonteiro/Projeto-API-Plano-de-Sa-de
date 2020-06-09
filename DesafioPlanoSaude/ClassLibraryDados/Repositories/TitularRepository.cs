using ClassLibraryDados.Context;
using ClassLibraryDados.Contracts;
using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Repositories
{
    public class TitularRepository : BaseRepository<Titular>, ITitularRepository
    {
        public List<Titular> SelectAllTitular(int quantidadeRegistro, int quantidadePularRegistro)
        {
            using (var context = new DataContext())
            {
                return context.Titular.Include("Dependentes")
                    .OrderBy(x => x.IdTitular)
                    .Skip(quantidadePularRegistro)
                    .Take(quantidadeRegistro)
                    .ToList();
            }
        }

        public Titular SelectByIdTitular(int id)
        {
            using(var context = new DataContext())
            {
                return context.Titular.Include("Dependentes").FirstOrDefault(t => t.IdTitular == id);
            }
        }
    }
}
