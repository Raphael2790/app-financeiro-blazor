using AgioBank.Contexts.AccountContext.Entities;
using AgioBank.Contexts.AccountContext.UseCases.Authenticate;
using AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts;
using AgioBank.Contexts.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AgioBank.Tests.UseCases.Authenticate.Contracts
{
    public class ClienteFake : ICliente
    {
        public async Task<Contexts.AccountContext.UseCases.Authenticate.Response> Autenticar(string email, string senha, CancellationToken cancellationToken)
        {
            await Task.Delay(100);
            if (email.Equals("eduardo.boca@gmail.com") && senha.Equals("123456"))
            {
                var response = new Contexts.AccountContext.UseCases.Authenticate.Response("Login efetuado com sucesso",
                    new ResponseData
                    {
                        Email = "eduardo.boca@gmail.com",
                        Id = Guid.NewGuid().ToString(),
                        Name = "Eduardo Freitas",
                        Token = "AKDFDLJ"
                    }
                );
                return response;
            }
            else
            {
                return new Contexts.AccountContext.UseCases.Authenticate.Response($"Dados inválidos", HttpStatusCode.Unauthorized);
            }
        }
    }
}
