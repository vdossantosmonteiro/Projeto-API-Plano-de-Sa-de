using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlanoSaude.Models
{
    public class DependenteConsultaModel:TipoConsultaModel
    {
        public int IdDependente { get; set; }
        public int IdTitular { get; set; }


        public TitularConsultaModel titular { get; set; }
        


    }
}