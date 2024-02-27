using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.SharedContext;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace AgioBank.Contexts.AccountContext.UseCases.Create.Contracts
{
    public class Servico : IServico
    {
        private readonly ICliente _cliente;

        public Servico(ICliente cliente) 
        {
            _cliente = cliente;
        } 

        public async Task<Response> CriarConta(Conta conta, CancellationToken cancellationToken)
        {
            var endpoint = "api/v1/accounts";

            var content = new StringContent(JsonSerializer.Serialize(conta), Encoding.UTF8, "application/json");
            var response = (Response)await _cliente.PostAsync(endpoint, content, cancellationToken);
            return response;
        }
    }
}
