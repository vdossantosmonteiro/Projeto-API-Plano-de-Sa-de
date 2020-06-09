using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDados.Entities
{
    public class Dependente : Tipo
    {
        public int IdDependente { get; set; }



        public int IdTitular { get; set; }
        public Titular Titular { get; set; }
    }
}
