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
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o número do documento")]
        public string Document { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome da sua mãe")]
        public string MotherName { get; set; } = string.Empty;
    }
}