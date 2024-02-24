using AgioBank.Contexts.AccountContext.Entities;
using System.Net;

namespace AgioBank.Contexts.AccountContext.UseCases.Create.Contracts
{
    public class ServicoMock : IServico
    {
        public async Task<Response> CriarConta(Conta conta, CancellationToken cancellationToken)
        {
            await Task.Delay(1000);
            return new Response("Conta criada com sucesso", HttpStatusCode.Created);
        }
    }
}
