using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AgioBank;
using Microsoft.Extensions.Configuration;
using AgioBank.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(
    s =>
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
        };
        return httpClient;
    }
);
builder.AddAccountExtension();
builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(Program).Assembly));

await builder.Build().RunAsync();
