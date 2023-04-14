using MediatR;
using Webshop.Core.Features.Products.Domain.Request;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Web.Features.Products.V1.CreateProduct;

namespace Webshop.Web.Features.Products.V1.CreateRandomProduct;

public record CreateRandomProductsCommand(IEnumerable<CreateProductRequest> products) : IRequest<bool>;

public class CreateRandomProductsCommandHandler : IRequestHandler<CreateRandomProductsCommand, bool>
{
    private readonly IProductRepository _productRepository;

    public CreateRandomProductsCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<bool> Handle(CreateRandomProductsCommand request, CancellationToken cancellationToken)
    {
        var productList = request.products.ToList().ConvertAll(p => p.MapToProduct());


        var createdProduct = await _productRepository.CreateMultipleAsync(productList)!;
        return createdProduct > 0;
    }
}