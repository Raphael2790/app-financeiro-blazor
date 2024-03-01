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
        public string Nome { get; private set; } = string.Empty;
        public string Sobrenome { get; private set; } = string.Empty;
        public string Telefone { get; private set; } = string.Empty;

        public string Email { get; private set; } = string.Empty;

        public string Documento { get; private set; } = string.Empty;

        public string NomeMae { get; private set; } = string.Empty;

        public string Senha { get; private set; } = string.Empty;

        public string NomeArquivo { get; private set; } = string.Empty;

        public StreamContent? Arquivo { get; private set; }

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