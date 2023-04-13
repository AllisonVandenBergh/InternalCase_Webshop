using Bogus;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Webshop.Core.Features.Products;
using Webshop.Core.Features.Products.Domain.Request;
using Webshop.Core.Features.Products.Domain.Response;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Web.Endpoints.Internal;
using Webshop.Web.Features.Products.V1.CreateProduct;
using Webshop.Web.Features.Products.V1.CreateRandomProduct;
using Webshop.Web.Features.Products.V1.DeleteProduct;
using Webshop.Web.Features.Products.V1.GetProduct;
using Webshop.Web.Features.Products.V1.GetProductList;

namespace Webshop.Web.Features.Products.V1
{
    public class ProductEndpoints : IEndpoints
    {
        private const string ContentType = "application/json";
        private const string Tag = "Products";
        private const string BaseRoute = "/api/products";

        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }

        public static void DefineEndpoints(IEndpointRouteBuilder app)
        {
            app.MapPost($"{BaseRoute}/random-multiple", CreateRandomProducts)
                .WithName("RandomProductMultiple")
                .Produces<GetProductDto>(201)
                .WithTags(Tag);

            app.MapPost($"{BaseRoute}/random-single", CreateRandomProduct)
                .WithName("RandomProductSingle")
                .Produces<GetProductDto>(201)
                .WithTags(Tag);

            app.MapGet(BaseRoute, GetAllProductsAsync)
                .WithName("GetProducts")
                .Produces<IEnumerable<GetProductDto>>(200)
                .WithTags(Tag);

            app.MapGet($"{BaseRoute}/{{id}}", GetProductByIdAsync)
                .WithName("GetProductById")
                .Produces<GetProductDto>(200).Produces(404).Produces(400)
                .WithTags(Tag);

            app.MapPost(BaseRoute, CreateAsync)
                .WithName("CreateProduct")
                .Accepts<CreateProductRequest>(ContentType)
                .Produces<GetProductDto>(201)
                .Produces(400)
                .WithTags(Tag);

            app.MapDelete($"{BaseRoute}/{{id}}", DeleteProductAsync)
                .WithName("DeleteProduct")
                .Produces(204).Produces(404)
                .WithTags(Tag);
        }

        //internal static async Task<IResult> GetAllProductsAsync(
        //    IProductService productService)
        //{
        //    return Results.Ok(await productService.GetAllAsync());
        //}

        //internal static async Task<IResult> GetProductByIdAsync(
        //    string id,
        //    IProductService productService)
        //{
        //    var guidId = Utils.StringToGuid(id);

        //    if (guidId == null)
        //        return Results.NotFound();

        //    var product = await productService.GetByIdAsync(guidId ?? Guid.Empty);
        //    return product is not null ? Results.Ok(product) : Results.NotFound();
        //}


        //internal static async Task<IResult> DeleteProductAsync(string id, IProductService productService)
        //{
        //    var guidId = Utils.StringToGuid(id);

        //    if (guidId == null)
        //        return Results.NotFound();

        //    var deleted = await productService.DeleteAsync(guidId ?? Guid.Empty);
        //    return deleted ? Results.NoContent() : Results.NotFound();
        //}

        ////TODO: have doubts about this
        //internal static async Task<IResult> CreateRandomProduct(IProductService productService,
        //    IValidator<Product> validator, LinkGenerator linker,
        //    HttpContext context)
        //{
        //    var randomProduct = DatabaseSeed.GenerateFakeProduct();
        //    return await CreateAsync(randomProduct, productService, validator, linker, context);
        //}

        //internal static async Task<IResult> CreateAsync(Product product,
        //    IProductService productService, IValidator<Product> validator,
        //    LinkGenerator linker, HttpContext context)
        //{
        //    var validationResult = await validator.ValidateAsync(product);
        //    if (!validationResult.IsValid)
        //    {
        //        return Results.BadRequest(validationResult.Errors);
        //    }

        //    var created = await productService.CreateAsync(product);
        //    if (!created)
        //        return Results.BadRequest();

        //    var locationUri = linker.GetUriByName(context, "GetProductById", new { product.Id })!;
        //    return Results.Created(locationUri, product);
        //}
        //}

        internal static async Task<IResult> GetAllProductsAsync(
                IMediator mediator)
            => Results.Ok(await mediator.Send(new GetProductListQuery()));

        internal static async Task<IResult> GetProductByIdAsync(
            Guid id,
            IMediator mediator)
        {
            var product = await mediator.Send(new GetProductQuery(id));
            return product is not null ? Results.Ok(product) : Results.NotFound();
        }

        internal static async Task<IResult> CreateAsync(CreateProductRequest product,
            IMediator mediator, IValidator<CreateProductRequest> validator, LinkGenerator linker, HttpContext context)
        {
            var validationResult = await validator.ValidateAsync(product);
            if (!validationResult.IsValid)
            {
                return Results.BadRequest(validationResult.Errors);
            }

            var createdProduct = await mediator.Send(new CreateProductCommand(product));
            if (createdProduct is null)
                return Results.BadRequest((new List<ValidationFailure>
                {
                    new("Id", "A product with this Id already exists")
                }));

            var locationUri = linker.GetUriByName(context, "GetProductById", new { createdProduct.id })!;
            return Results.Created(locationUri, createdProduct);
        }

        //TODO: have doubts about this
        internal static async Task<IResult> CreateRandomProduct(IValidator<CreateProductRequest> validator, IMediator mediator, LinkGenerator linker,
            HttpContext context)
        {
            var randomProduct = new Faker<CreateProductRequest>()
               .RuleFor(p => p.Sku, b => b.Random.String2(8, 12))
               .RuleFor(p => p.Name, b => b.Commerce.ProductName())
               .RuleFor(p => p.Description, b => b.Lorem.Sentences())
               .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
               .RuleFor(p => p.BasePrice, b => double.Parse(b.Commerce.Price()))
               .RuleFor(p => p.SellPrice, b => double.Parse(b.Commerce.Price()))
               .RuleFor(p => p.InStock, b => b.Random.Bool()).Generate();

            return await CreateAsync(randomProduct, mediator, validator, linker, context);
        }

        internal static async Task<IResult> CreateRandomProducts(IValidator<CreateProductRequest> validator, IMediator mediator, LinkGenerator linker,
            HttpContext context)
        {
            var randomProducts = new Faker<CreateProductRequest>()
               .RuleFor(p => p.Sku, b => b.Random.String2(8, 12))
               .RuleFor(p => p.Name, b => b.Commerce.ProductName())
               .RuleFor(p => p.Description, b => b.Lorem.Sentences())
               .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
               .RuleFor(p => p.BasePrice, b => double.Parse(b.Commerce.Price()))
               .RuleFor(p => p.SellPrice, b => double.Parse(b.Commerce.Price()))
               .RuleFor(p => p.InStock, b => b.Random.Bool()).Generate(100);

            var createdProducts = await mediator.Send(new CreateRandomProductsCommand(randomProducts));

            var locationUri = linker.GetUriByName(context, "GetProducts")!;
            return Results.Created(locationUri, randomProducts);
        }

        internal static async Task<IResult> DeleteProductAsync(Guid id, IMediator mediator)
        {
            var productDeleted = await mediator.Send(new DeleteProductCommand(id));
            return productDeleted ? Results.NoContent() : Results.NotFound();
        }
    }
}

