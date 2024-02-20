using AgioBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgioBank.Services
{
    public interface IServicoConta
    {
        Task <ResultadoConta> CreateAccount(Conta account);
    }
}