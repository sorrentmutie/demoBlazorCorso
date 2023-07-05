using DemoBlazorWebAssembly;
using DemoBlazorWebAssembly.Services;
using LIbreriaComponentiBlazor;
using LIbreriaComponentiBlazor.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Polly;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("reqres", client =>
{
    client.BaseAddress = new Uri("https://reqres.in/api/");
})
    .AddTransientHttpErrorPolicy(
          x => x.WaitAndRetryAsync(new[]
          {
              TimeSpan.FromSeconds(1),
              TimeSpan.FromSeconds(5),
              TimeSpan.FromSeconds(10)
          }) 
    );

builder.Services.AddScoped<IGestioneEventi, ServizioEventi>();
builder.Services.AddScoped<IReqResService, ReqResService>();

await builder.Build().RunAsync();
