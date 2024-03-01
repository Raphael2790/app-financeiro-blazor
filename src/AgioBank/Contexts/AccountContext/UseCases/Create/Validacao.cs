using AgioBank.Contexts.AccountContext.Entities;
using FluentValidation;

namespace AgioBank.Contexts.AccountContext.UseCases.Create
{
    public class Validacao : AbstractValidator<Conta>
    {
        public Validacao()
        {
            RuleFor(conta => conta.Nome).NotEmpty();
            RuleFor(conta => conta.Senha).NotEmpty();            
            RuleFor(conta => conta.Email).EmailAddress();
        }
    }
}
