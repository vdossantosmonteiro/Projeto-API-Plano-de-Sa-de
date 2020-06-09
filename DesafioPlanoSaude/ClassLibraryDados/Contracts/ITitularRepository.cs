using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Contracts
{
    public interface ITitularRepository : IBaseRepository<Titular>
    {
        List<Titular>SelectAllTitular(int quantidadeRegistro, int quantidadePularRegistro);

        Titular SelectByIdTitular(int id);
        

    }
}
