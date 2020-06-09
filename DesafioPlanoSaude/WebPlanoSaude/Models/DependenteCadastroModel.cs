using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebPlanoSaude.Models
{
    public class DependenteCadastroModel:TipoCadastroModel
    {

        [Required(ErrorMessage = "Informe o Id do Titular")]
        public int IdTitular { get; set; }

    }
}