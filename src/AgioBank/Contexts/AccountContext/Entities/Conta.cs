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
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Documento { get; set; } = string.Empty;

        public string NomeMae { get; set; } = string.Empty;

        public string Senha { get; set; } = string.Empty;

        public string NomeArquivo { get; set; } = string.Empty;

        public StreamContent? Arquivo { get; set; }

        public Conta ()
        { }
        public Conta(string nome, string sobrenome, string telefone, string email, string documento, string nomeMae, string senha, string nomeArquivo, StreamContent arquivo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
            Documento = documento;
            NomeMae = nomeMae;
            Senha = senha;
            NomeArquivo = nomeArquivo;
            Arquivo = arquivo;
        }
    }
}