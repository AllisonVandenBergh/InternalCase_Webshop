using MediatR;
using Webshop.Contracts.Features.Products.Request;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Core.Features.Products.V1.CreateProductCommand;

namespace Webshop.Core.Features.Products.V1.CreateRandomProductCommand
{
    public static class CreateRandomProducts
    {
        public record Request(IEnumerable<CreateProductRequest> createProducts) : IRequest<bool>;

        public class Handler : IRequestHandler<Request, bool>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<bool> Handle(Request request, CancellationToken cancellationToken)
            {
                var productList = request.createProducts.ToList().ConvertAll(p => p.ToProduct());
                var amountAffectedRows = await _productRepository.CreateMultipleAsync(productList)!;
                return amountAffectedRows > 0;
            }
        }
    }
}
