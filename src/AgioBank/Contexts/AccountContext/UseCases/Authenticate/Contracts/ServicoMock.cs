
using System.Net;

namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts
{
    public class ServicoMock : IServico

    {
        public async Task<Response> Autenticar(string email, string senha, CancellationToken cancellationToken)
        {
            await Task.Delay(1000);
            return new Response("Conta autenticada", new ResponseData { Token = Guid.NewGuid().ToString(), Email = email, Name = "AgioBank Cliente Mock"});
        }
    }
}
