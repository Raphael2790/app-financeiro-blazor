using Microsoft.AspNetCore.Components.Web.Virtualization;
using MediatR;
using AgioBank.Contexts.SharedContext;

namespace AgioBank.Contexts.AccountContext.UseCases.Create
{
    public record Request
    (
        string Nome,
        string Sobrenome,
        string Telefone,
        string Email,
        string Documento,
        string NomeMae
    ) : IRequest<Response>;
}
