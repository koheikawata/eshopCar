using eshopCar.Interfaces;
using eshopCar.Services;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshopCar.Configuration
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<CatalogViewModelService>();
            services.AddScoped<ICatalogItemViewModelService, CatalogItemViewModelService>();
            services.AddScoped<ICatalogViewModelService, CachedCatalogViewModelService>();

            return services;
        }
    }
}
