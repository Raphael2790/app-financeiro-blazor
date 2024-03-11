using AgioBank.Contexts.AccountContext.UseCases.Authenticate;
using System.ComponentModel.DataAnnotations;

namespace AgioBank.Pages.Contexts.AccountContext.UseCases.Authenticate
{
    public class InputViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; } = string.Empty;

        public static implicit operator Request(InputViewModel viewModel)
        {
            try
            {
                var request = new Request(
                    viewModel.Email, 
                    viewModel.Senha);
                return request;
            }
            catch
            {
                throw;
            }

        }
    }
}
