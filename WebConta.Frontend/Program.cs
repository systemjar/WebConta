using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebConta.Frontend;
using WebConta.Frontend.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Esta es la url que provee los servicios del backend
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7166//") });

//Inyectamos el Repositorio porque el Frontend solo ebtiene datos de repositorio
builder.Services.AddScoped<IRepository, Repository>();

await builder.Build().RunAsync();
