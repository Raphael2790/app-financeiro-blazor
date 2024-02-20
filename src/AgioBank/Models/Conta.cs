using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AgioBank.Models
{
    public class Conta
    {
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o número do documento")]
        public string Documento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome da sua mãe")]
        public string NomeMae { get; set; } = string.Empty;
    }
}