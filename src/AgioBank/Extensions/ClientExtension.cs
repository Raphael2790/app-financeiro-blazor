using AgioBank.Contexts.SharedContext;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;

namespace AgioBank.Extensions
{
    public static class ClientExtension
    {
        public static void AddClientExtension(this WebAssemblyHostBuilder builder)
        {
            string? apiKey = builder.Configuration.GetValue<string>("ConfigApi:ApiKey");
            string? url = builder.Configuration.GetValue<string>("ConfigApi:ApiUrl");

            builder.Services.AddHttpClient ("api", cliente =>         
            {
                cliente.BaseAddress = new Uri(url!);
                cliente.DefaultRequestHeaders.Add("User-Agent", "user-agent");
                cliente.DefaultRequestHeaders.Add("x-apikey", apiKey);
            });
        }
    }
}
