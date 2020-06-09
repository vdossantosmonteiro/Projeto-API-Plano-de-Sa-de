using ClassLibraryDados.Context;
using ClassLibraryDados.Contracts;
using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Repositories
{
    public class DependenteRepository : BaseRepository<Dependente>, IDependenteRepository
    {
        public List<Dependente> SelectAllDependente()
        {
            using (var context = new DataContext())
            {

                return context.Dependentes.Include("Titular").ToList();
            }
        }

        public Dependente SelectByIdDependente(int id)
        {
            using (var context = new DataContext())
            {
                return context.Set<Dependente>().Include("Titular").FirstOrDefault(x => x.IdDependente == id);

            }
        }
    }
}
