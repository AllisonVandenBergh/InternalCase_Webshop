using System;
using Api.Endpoints.Internal;
using Api.Services;
using Api.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

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
            app.MapPost($"{BaseRoute}/random", CreateRandomProduct)
                .WithName("RandomProduct")
                .Produces<Product>(201)
                .WithTags(Tag);

            app.MapGet(BaseRoute, GetAllProductsAsync)
                .WithName("GetProducts")
                .Produces<IEnumerable<Product>>(200)
                .WithTags(Tag);

            app.MapGet($"{BaseRoute}/{{id}}", GetProductByIdAsync)
                .WithName("GetProductById")
                .Produces<Product>(200).Produces(404)
                .WithTags(Tag);

            app.MapDelete($"{BaseRoute}/{{id}}", DeleteProductAsync)
                .WithName("DeleteProduct")
                .Produces(204).Produces(404)
                .WithTags(Tag);
        }

        internal static async Task<IResult> GetAllProductsAsync(
            IProductService productService)
        {
            return Results.Ok(await productService.GetAllAsync());
        }

        internal static async Task<IResult> GetProductByIdAsync(
            Guid id,
            IProductService productService)
        {
            var product = await productService.GetByIdAsync(id);
            return product is not null ? Results.Ok(product) : Results.NotFound();
        }

        internal static async Task<IResult> DeleteProductAsync(Guid id, IProductService productService)
        {
            var deleted = await productService.DeleteAsync(id);
            return deleted ? Results.NoContent() : Results.NotFound();
        }

        //TODO: have doubts about this
        internal static async Task<IResult> CreateRandomProduct(IProductService productService)
        {
            var randomProduct = DatabaseSeed.GenerateFakeProduct();
            return await CreateAsync(randomProduct, productService);
        }

        internal static async Task<IResult> CreateAsync(Product product, IProductService productService)
        {
            var created = await productService.CreateAsync(product);
            if (!created)
                return Results.BadRequest();

            return Results.Created($"{BaseRoute}/{{id}}", product);
        }
    }
}

