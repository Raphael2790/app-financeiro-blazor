using MediatR;

namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate
{
    public record Request
    (
        string Email,
        string Senha
    ) : IRequest<Response>;
}
