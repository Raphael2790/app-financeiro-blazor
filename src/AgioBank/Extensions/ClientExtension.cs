using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace AgioBank.Extensions
{
    public static class ClientExtension
    {
        public static void AddClientExtension(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddHttpClient("api", c
            => 
            {
                c.DefaultRequestHeaders.Add("Authoriztion", "token");
                c.DefaultRequestHeaders.Add("User-Agent", "user-agent");
                c.BaseAddress = new Uri("https://localhost:5000/api");
            });
        }
    }
}
