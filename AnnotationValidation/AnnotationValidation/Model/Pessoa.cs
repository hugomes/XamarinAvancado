using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AnnotationValidation.Model
{
    public class Pessoa
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Erro!")]
        [StringLength(60, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceName = "MSG_E01", ErrorMessageResourceType = typeof(Lang.Mensagens))]
        [EmailAddress(ErrorMessage = null, ErrorMessageResourceName = "MSG_E02", ErrorMessageResourceType = typeof(Lang.Mensagens))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "MSG_E01", ErrorMessageResourceType = typeof(Lang.Mensagens))]
        [CPFValidate(ErrorMessageResourceName = "MSG_E02", ErrorMessageResourceType = typeof(Lang.Mensagens))]
        public string CPF { get; set; }
    }
}
