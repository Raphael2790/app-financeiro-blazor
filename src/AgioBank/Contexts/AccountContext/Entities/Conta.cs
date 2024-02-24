using AgioBank.Contexts.SharedContext.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AgioBank.Contexts.AccountContext.Entities
{
    public class Conta:Entidade
    {
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o n�mero do documento")]
        public string Documento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome da sua m�e")]
        public string NomeMae { get; set; } = string.Empty;

        public Conta ()
        { }
        public Conta(string nome, string sobrenome, string telefone, string email, string documento, string nomeMae)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
            Documento = documento;
            NomeMae = nomeMae;
        }
    }
}