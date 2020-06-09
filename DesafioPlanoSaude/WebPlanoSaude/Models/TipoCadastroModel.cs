using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebPlanoSaude.Models
{
    public class TipoCadastroModel
    {
        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o contrato")]
        public string Contrato { get; set; }

        [Required(ErrorMessage = "Informe o Cpf")]
        public string Cpf { get; set; }
    }
}