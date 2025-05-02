using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Entities.Interfaces;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();


Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");