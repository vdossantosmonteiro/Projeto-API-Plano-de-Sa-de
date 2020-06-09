using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPlanoSaude.Models
{
    public class DependenteEdicaoModel:TipoEdicaoModel
    {
        [Required(ErrorMessage = "Informe o Id do Dependente")]
        public int IdDependente { get; set; }

        [Required(ErrorMessage = "Informe o Id do Titular")]
        public int IdTitular { get; set; }


    }
}