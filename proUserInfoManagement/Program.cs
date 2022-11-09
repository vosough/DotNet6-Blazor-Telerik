using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using proUserInfoManagement;
using proUserInfoManagement.Services;
using proUserInfoManagement.Services.Contract;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:1111/") });

builder.Services.AddScoped<IUserService, UserService>();


await builder.Build().RunAsync();
