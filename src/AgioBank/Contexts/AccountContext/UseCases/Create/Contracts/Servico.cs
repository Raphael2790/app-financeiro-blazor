using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.SharedContext;
using AgioBank.Pages;
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
            var response = (Response) await _cliente.CriarConta(conta, cancellationToken);
            return response;
        }
    }
}
