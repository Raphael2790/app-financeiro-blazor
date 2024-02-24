using AgioBank.Contexts.AccountContext.UseCases.Authenticate;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace AgioBank.Extensions
{
    public static class AccountContentExtension
    {
        public static void AddAccountExtension(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.IServico, AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.ServicoMock>();
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.IServico, AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.ServicoMock>();
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Create.Handler>();
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Handler>();
        }
    }
}
