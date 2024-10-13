using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Logging;
using WebConta.Frontend;
using WebConta.Frontend.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Esta es la url que provee los servicios del backend
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7042/") });

//Inyectamos el Repositorio porque el Frontend solo ebtiene datos de repositorio
builder.Services.AddScoped<IRepository, Repository>();

//Inyectamos el SweetAlert2
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();