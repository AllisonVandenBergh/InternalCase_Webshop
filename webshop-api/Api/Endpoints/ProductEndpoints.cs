using Api.Endpoints.Internal;
using Api.Services;
using Api.Services.Interfaces;
using Api.Validators;
using Domain.Entities;
using FluentValidation;
using FluentValidation.Results;
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

            app.MapPost(BaseRoute, CreateAsync)
                .WithName("CreateProduct")
                .Accepts<Product>(ContentType)
                .Produces<Product>(201)
                .Produces<IEnumerable<ValidationFailure>>(400)
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
            string id,
            IProductService productService)
        {
            var guidId = Utils.StringToGuid(id);

            if (guidId == null)
                return Results.NotFound();

            var product = await productService.GetByIdAsync(guidId ?? Guid.Empty);
            return product is not null ? Results.Ok(product) : Results.NotFound();
        }

        internal static async Task<IResult> DeleteProductAsync(string id, IProductService productService)
        {
            var guidId = Utils.StringToGuid(id);

            if (guidId == null)
                return Results.NotFound();

            var deleted = await productService.DeleteAsync(guidId ?? Guid.Empty);
            return deleted ? Results.NoContent() : Results.NotFound();
        }

        //TODO: have doubts about this
        internal static async Task<IResult> CreateRandomProduct(IProductService productService,
            IValidator<Product> validator, LinkGenerator linker,
            HttpContext context)
        {
            var randomProduct = DatabaseSeed.GenerateFakeProduct();
            return await CreateAsync(randomProduct, productService, validator, linker, context);
        }

        internal static async Task<IResult> CreateAsync(Product product,
            IProductService productService, IValidator<Product> validator,
            LinkGenerator linker,HttpContext context)
        {
            var validationResult = await validator.ValidateAsync(product);
            if (!validationResult.IsValid)
            {
                return Results.BadRequest(validationResult.Errors);
            }

            var created = await productService.CreateAsync(product);
            if (!created)
                return Results.BadRequest();

            var locationUri = linker.GetUriByName(context, "GetProductById", new { product.Id })!;
            return Results.Created(locationUri, product);
        }
    }
}

