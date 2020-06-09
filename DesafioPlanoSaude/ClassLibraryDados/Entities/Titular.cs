using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Entities
{
    public class Titular : Tipo
    {
        public int IdTitular { get; set; }


        public List<Dependente> Dependentes { get; set; }


    }
}
