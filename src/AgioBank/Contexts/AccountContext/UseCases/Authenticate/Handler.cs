using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts;
using MediatR;
using System.Net;

namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate
{
    public class Handler : IRequestHandler<Request, Response>
    {
        private readonly IServico _servico;

        public Handler(IServico servico) => _servico = servico;

        public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _servico.Autenticar(request.Email, request.Senha, cancellationToken);
                return response;
            }
            catch
            {
                return new Response("Erro desconhecido ao autenticar usuário", HttpStatusCode.InternalServerError);
            }
        }
    }
}
