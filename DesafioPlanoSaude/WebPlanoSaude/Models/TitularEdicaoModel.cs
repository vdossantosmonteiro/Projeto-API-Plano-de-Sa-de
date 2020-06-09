using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebPlanoSaude.Models
{
    public class TitularEdicaoModel:TipoEdicaoModel
    {

        [Required(ErrorMessage = "Informe o Id do Titular")]
        public int IdTitular { get; set; }




    }
}