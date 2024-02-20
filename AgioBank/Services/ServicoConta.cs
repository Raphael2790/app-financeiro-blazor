using AgioBank.Clients;
using AgioBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgioBank.Services
{
    public class ServicoConta : IServicoConta
    {
        public ServicoConta(ApiCliente client) 
        { 
        
        }
        
        public async Task<ResultadoConta> CreateAccount(Conta account)
        {
            throw new NotImplementedException();
        }
    }
}