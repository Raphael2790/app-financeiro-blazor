using AgioBank.Contexts.AccountContext.UseCases.Create;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgioBank.Pages.Contexts.AccountContext.UseCases.Create
{
    public class InputViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress (ErrorMessage = "E-mail inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o número do documento")]
        public string Documento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o nome da sua mãe")]
        public string NomeMae { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe uma senha")]
        public string Senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirme a senha")]
        [Compare("Senha", ErrorMessage = "Senhas não conferem")]
        public string ConfirmarSenha { get; set; } = string.Empty;

        public static implicit operator Request(InputViewModel viewModel) 
            => new Request(
                viewModel.NomeMae,
                viewModel.Sobrenome,
                viewModel.Telefone,
                viewModel.Email,
                viewModel.Documento,
                viewModel.NomeMae
                );


    }
}
