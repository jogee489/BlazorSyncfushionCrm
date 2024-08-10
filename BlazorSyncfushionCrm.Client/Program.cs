using BlazorSyncfushionCrm.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQwMzk2MUAzMjM2MmUzMDJlMzBlUmNTM3BXbUpvdjlqbzFrQWhESWUrUHZaNllTaUxTU0UrcFhMZkp1MEFRPQ==");

await builder.Build().RunAsync();
