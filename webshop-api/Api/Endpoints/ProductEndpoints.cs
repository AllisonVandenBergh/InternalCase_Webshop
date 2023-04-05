using System;
using Api.Endpoints.Internal;
using Api.Services;
using Api.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;

namespace Api.Endpoints
{
	public class ProductEndpoints: IEndpoints
	{
        private const string ContentType = "application/json";
        private const string Tag = "Products";
        private const string BaseRoute = "products";

        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepo, ProductRepo>();
        }

        public static void DefineEndpoints(IEndpointRouteBuilder app)
        {
            app.MapGet(BaseRoute, GetAllProductsAsync)
                .WithName("GetProducts")
                .Produces<IEnumerable<Product>>(200)
                .WithTags(Tag);

            app.MapGet($"{BaseRoute}/{{sku}}", GetProductBySkuAsync)
                .WithName("GetProductBySku")
                .Produces<Product>(200).Produces(404)
                .WithTags(Tag);
        }

        internal static async Task<IResult> GetAllProductsAsync(
            IProductService productService)
        {
            return Results.Ok(await productService.GetAllAsync());
        }

        internal static async Task<IResult> GetProductBySkuAsync(
            Guid sku,
            IProductService productService)
        {
            var product = await productService.GetBySkuAsync(sku);
            return product is not null ? Results.Ok(product) : Results.NotFound();
        }
    }
}

