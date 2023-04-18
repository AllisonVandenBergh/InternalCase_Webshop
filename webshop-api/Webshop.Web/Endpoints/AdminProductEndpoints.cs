using FluentValidation;
using MediatR;
using Webshop.Contracts.Features.Products.Request;
using Webshop.Contracts.Features.Products.Response;
using Webshop.Core.Features.Products.V1.GetProductQuery;
using Webshop.Core.Utilities;
using Webshop.Web.Endpoints.Internal;
using Webshop.Core.Features.Products.Extensions;
using Webshop.Core.Features.Products.V1.GetProductListQuery;
using Webshop.Core.Features.Products.V1.CreateProductCommand;
using Webshop.Core.Features.Products.V1.CreateRandomProductCommand;
using Webshop.Core.Features.Products.V1.DeleteProductCommand;
using FluentValidation.Results;
using Webshop.Web.Features.Products.V1;

namespace Webshop.Web.Endpoints
{
    public class AdminProductEndpoints : IEndpoints
    {
        private const string ContentType = "application/json";
        private const string Tag = "Products";

        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddProducts();
        }

        public static void DefineEndpoints(IEndpointRouteBuilder app)
        {
            app.MapPost(ApiEndpoints.Admin.RandomMulti, CreateRandomProducts)
                .WithName("RandomProductMultiple")
                .Produces<IEnumerable<GetProductsAdminDto>>(201)
                .WithTags(Tag);

            app.MapPost(ApiEndpoints.Admin.RandomSingle, CreateRandomProduct)
                .WithName("RandomProductSingle")
                .Produces<Guid>(201)
                .WithTags(Tag);

            app.MapGet(ApiEndpoints.Admin.GetAll, GetAllProductsAsync)
                .WithName("GetProducts")
                .Produces<IEnumerable<GetProductsAdminDto>>(200)
                .WithTags(Tag);

            app.MapGet(ApiEndpoints.Admin.Get, GetProductByIdAsync)
                .WithName("GetProductById")
                .Produces<GetProductAdminDetailDto>(200).Produces(404)
                .Produces(400)
                .WithTags(Tag);

            app.MapPost(ApiEndpoints.Admin.Create, CreateAsync)
                .WithName("CreateProduct")
                .Accepts<CreateProductRequest>(ContentType)
                .Produces<Guid>(201)
                .Produces(400)
                .Produces(500)
                .WithTags(Tag);

            app.MapDelete(ApiEndpoints.Admin.Delete, DeleteProductAsync)
                .WithName("DeleteProduct")
                .Produces(204).Produces(404)
                .WithTags(Tag);
        }

        internal static async Task<IResult> GetAllProductsAsync(
                IMediator mediator)
            => Results.Ok(await mediator.Send(new GetProductList.Request()));

        internal static async Task<IResult> GetProductByIdAsync(
            Guid id,
            IMediator mediator)
        {
            var product = await mediator.Send(new GetProduct.Request(id));
            return product is not null ? Results.Ok(product) : Results.NotFound();
        }

        internal static async Task<IResult> CreateAsync(CreateProductRequest product,
            IMediator mediator, IValidator<CreateProductRequest> validator, LinkGenerator linker, HttpContext context, CancellationToken token)
        {
            await validator.ValidateAndThrowAsync(product, cancellationToken: token);

            var createdProductId = await mediator.Send(new CreateProduct.Request(product));
            if (createdProductId is null)
            {
                return Results.BadRequest(new List<ValidationFailure>
                {
                    new("Id", "A product with this Id already exists")
                });
            }

            var locationUri = linker.GetUriByName(context, "GetProductById", new { id = createdProductId })!;
            return Results.Created(locationUri, createdProductId);
        }

        internal static async Task<IResult> CreateRandomProduct(IMediator mediator, LinkGenerator linker,
            HttpContext context)
        {
            var randomProduct = ProductSeeding.GenerateFakeProduct;
            var createdProductId = await mediator.Send(new CreateProduct.Request(randomProduct.ToCreateProductRequest()));
            if (createdProductId is null)
            {
                return Results.BadRequest(new List<ValidationFailure>
                {
                    new("Id", "A product with this Id already exists")
                });
            }


            var locationUri = linker.GetUriByName(context, "GetProductById", new { id = createdProductId })!;
            return Results.Created(locationUri, createdProductId);
        }

        internal static async Task<IResult> CreateRandomProducts(IMediator mediator,
            LinkGenerator linker,
            HttpContext context)
        {
            var randomProducts = ProductSeeding.GenerateFakeProducts.ToList().ConvertAll(p => p.ToCreateProductRequest());
            var createdProducts = await mediator.Send(new CreateRandomProducts.Request(randomProducts));
            if (!createdProducts)
            {
                return Results.BadRequest(new List<ValidationFailure>
                {
                    new("message", "Problem adding the multiple products")
                });
            }

            var locationUri = linker.GetUriByName(context, "GetProducts")!;
            return Results.Created(locationUri, randomProducts);
        }

        internal static async Task<IResult> DeleteProductAsync(Guid id, IMediator mediator)
        {
            var productDeleted = await mediator.Send(new DeleteProduct.Request(id));
            return productDeleted ? Results.NoContent() : Results.NotFound();
        }
    }
}