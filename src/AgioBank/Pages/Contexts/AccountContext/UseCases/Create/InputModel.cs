using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Pages.Contexts.SharedContext.Enums;
using System.ComponentModel.DataAnnotations;

namespace AgioBank.Pages.Contexts.AccountContext.UseCases.Create
{
    public class InputModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o número do documento")]
        public string Documento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome da sua mãe")]
        public string NomeMae { get; set; } = string.Empty;

    }
}
