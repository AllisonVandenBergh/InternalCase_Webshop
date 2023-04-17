using MediatR;
using Webshop.Contracts.Features.Products.Response;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.V1.GetProductQuery
{
    public static class GetProduct
    {
        public record Request(Guid productId) : IRequest<GetProductDto?>;

        public class Handler : IRequestHandler<Request, GetProductDto?>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<GetProductDto?> Handle(Request request, CancellationToken cancellationToken)
            {
                return (await _productRepository.GetByIdAsync(request.productId)).ToDto();
            }
        }
    }
}
