using BethanyPieShopHRM;
using BethanyPieShopHRM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(
    client => client.BaseAddress = new Uri("https://localhost:44340/")
);
builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(
    client => client.BaseAddress = new Uri("https://localhost:44340/")
);
builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(
    client => client.BaseAddress = new Uri("https://localhost:44340/")
);

await builder.Build().RunAsync();
