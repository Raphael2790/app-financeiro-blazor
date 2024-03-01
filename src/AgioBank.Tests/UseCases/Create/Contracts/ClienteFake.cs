using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Create;
using AgioBank.Contexts.AccountContext.UseCases.Create.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgioBank.Tests.UseCases.Create.Contracts
{
    public class ClienteFake : ICliente
    {
        public async Task<Response> CriarConta(Conta conta, CancellationToken cancellationToken)
        {
            await Task.Delay(100);
            var response = new Response("Conta criada com sucesso", new ResponseData(Guid.NewGuid().ToString()));
            return response;
        }
    }
}
