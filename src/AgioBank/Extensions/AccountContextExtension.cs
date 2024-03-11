using AgioBank.Contexts.AccountContext.UseCases.Authenticate;
using AgioBank.Contexts.SharedContext;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace AgioBank.Extensions
{
    public static class AccountContextExtension
    {
        public static void AddAccountExtension(this WebAssemblyHostBuilder builder)
        {            
            #region Create
                builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.IServico, AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.Servico>();
                builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.ICliente, AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.Cliente>();
                builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Create.Handler>();
            #endregion

            #region Authenticate
                builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.IServico, AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.Servico>();
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.ICliente, AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.Cliente>();
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Handler>();
            #endregion
        }
    }
    }
