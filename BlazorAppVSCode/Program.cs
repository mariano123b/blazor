using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorAppVSCode;
using BlazorAppVSCode.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Logging.SetMinimumLevel(LogLevel.Debug);
var urlApi = builder.Configuration.GetValue<string>("urlApi");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(urlApi) });
builder.Services.AddScoped<IAlumnoServices, AlumnoService>();
await builder.Build().RunAsync();
