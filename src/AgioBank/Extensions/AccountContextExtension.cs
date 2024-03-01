using AgioBank.Contexts.AccountContext.UseCases.Authenticate;
using AgioBank.Contexts.SharedContext;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace AgioBank.Extensions
{
    public static class AccountContextExtension
    {
        public static void AddAccountExtension(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.IServico, AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.Servico>();
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.IServico, AgioBank.Contexts.AccountContext.UseCases.Authenticate.Contracts.ServicoMock>();
            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Create.Handler>();
            builder.Services.AddHttpClient<AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.ICliente, AgioBank.Contexts.AccountContext.UseCases.Create.Contracts.Cliente >((httpClient) =>
            {
                httpClient.BaseAddress = new Uri("https://localhost:5000");
            });

            builder.Services.AddTransient<AgioBank.Contexts.AccountContext.UseCases.Authenticate.Handler>();
        }
    }
}
