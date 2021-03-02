using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;
using Shop.Application.Services;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Infrastructure.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IProductService, ProductService>();
        }
    }
}
