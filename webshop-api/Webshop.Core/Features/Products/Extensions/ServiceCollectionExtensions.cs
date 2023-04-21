using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddProducts(this IServiceCollection services)
    {
        services.TryAddScoped<IProductRepository, ProductRepository>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}