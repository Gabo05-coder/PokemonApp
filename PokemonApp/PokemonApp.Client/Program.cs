using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using YourNamespace.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

await builder.Build().RunAsync();

builder.Services.AddScoped<PokemonDetailsService>();

