using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace AgioBank.Extensions
{
    public static class ClientExtension
    {
        public static void AddClientExtension(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddHttpClient("api", c => c.BaseAddress = new Uri($"{builder.HostEnvironment.BaseAddress}api"));
        }
    }
}
