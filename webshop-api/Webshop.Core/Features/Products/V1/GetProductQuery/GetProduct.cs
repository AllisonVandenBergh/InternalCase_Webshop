using MediatR;
using Webshop.Contracts.Features.V1.Products.Response;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.V1.GetProductQuery
{
    public static class GetProduct
    {
        public record Request(Guid productId) : IRequest<GetProductAdminDetailDto?>;

        public class Handler : IRequestHandler<Request, GetProductAdminDetailDto?>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<GetProductAdminDetailDto?> Handle(Request request, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(request.productId);
                if (product is null)
                    return null;

                return product.ToDto();
            }
        }
    }
}
