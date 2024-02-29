using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Create.Contracts;
using MediatR;
using System.IO;
using System.Net;

namespace AgioBank.Contexts.AccountContext.UseCases.Create
{
    public class Handler : IRequestHandler<Request, Response>
    {
        private readonly IServico _servico;

        public Handler(IServico servico)
        {
            _servico = servico;
        }

        public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            Conta conta;
            conta = new Conta(request.Nome, request.Sobrenome, request.Telefone, request.Email, request.Documento, request.NomeMae, request.Senha, request.NomeArquivo, request.Arquivo);

            try
            {
                var response = await _servico.CriarConta(conta, cancellationToken);
                return response;
            }
            catch
            {
                return new Response("Erro desconhecido ao criar usuário", HttpStatusCode.InternalServerError);
            }
        }
    }
}
