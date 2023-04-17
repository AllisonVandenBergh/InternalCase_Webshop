﻿using FluentValidation;
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
using Webshop.Web.Features.Products.V1.CreateProduct;

namespace Webshop.Web.Endpoints
{
    public class ProductEndpoints : IEndpoints
    {
        private const string ContentType = "application/json";
        private const string Tag = "Products";
        private const string BaseRoute = "/api/products";

        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddProducts();
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
            IMediator mediator, IValidator<CreateProductRequest> validator, LinkGenerator linker, HttpContext context)
        {
            var validationResult = await validator.ValidateAsync(product);
            if (!validationResult.IsValid)
            {
                return Results.BadRequest(validationResult.Errors);
            }

            var createdProductId = await mediator.Send(new CreateProduct.Request(product));

            var locationUri = linker.GetUriByName(context, "GetProductById", new { createdProductId })!;
            return Results.Created(locationUri, createdProductId);
        }

        internal static async Task<IResult> CreateRandomProduct(IMediator mediator, LinkGenerator linker,
            HttpContext context)
        {
            var randomProduct = ProductSeeding.GenerateFakeProduct;
            var createdProductId = await mediator.Send(new CreateProduct.Request(randomProduct.ToCreateProductRequest()));

            var locationUri = linker.GetUriByName(context, "GetProductById", new { createdProductId })!;
            return Results.Created(locationUri, createdProductId);
        }

        internal static async Task<IResult> CreateRandomProducts(IMediator mediator,
            LinkGenerator linker,
            HttpContext context)
        {
            var randomProducts = ProductSeeding.GenerateFakeProducts.ToList().ConvertAll(p => p.ToCreateProductRequest());
            var createdProducts = await mediator.Send(new CreateRandomProducts.Request(randomProducts));

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