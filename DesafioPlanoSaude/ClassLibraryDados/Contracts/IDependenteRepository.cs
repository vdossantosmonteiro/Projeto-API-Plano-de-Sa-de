using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Contracts
{
    public interface IDependenteRepository : IBaseRepository<Dependente>
    {
        
        List<Dependente> SelectAllDependente();

        Dependente SelectByIdDependente(int id);
        



    }
}
