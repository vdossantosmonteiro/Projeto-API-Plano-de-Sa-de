using ClassLibraryDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlanoSaude.Models
{
    public class TitularConsultaModel:TipoConsultaModel
    {
        public int IdTitular { get; set; }

        public List<DependenteConsultaModel> dependentes { get; set; }
    }
}