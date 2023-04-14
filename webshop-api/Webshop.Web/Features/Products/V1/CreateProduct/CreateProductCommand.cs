using MediatR;
using Webshop.Core.Features.Products.Domain.Request;
using Webshop.Core.Features.Products.Domain.Response;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Web.Features.Products.V1.GetProduct;

namespace Webshop.Web.Features.Products.V1.CreateProduct;

public record CreateProductCommand(CreateProductRequest product) : IRequest<GetProductDto?>;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, GetProductDto?>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<GetProductDto?> Handle(CreateProductCommand requestProduct, CancellationToken cancellationToken)
    {
        var createdProduct = await _productRepository.CreateAsync(requestProduct.product.MapToProduct())!;
        return createdProduct!.MapToDto();
    }
}