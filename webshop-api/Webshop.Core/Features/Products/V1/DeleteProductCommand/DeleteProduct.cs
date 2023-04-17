using MediatR;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.V1.DeleteProductCommand
{
    public static class DeleteProduct
    {
        public record Request(Guid productId) : IRequest<bool>;

        public class Handler : IRequestHandler<Request, bool>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<bool> Handle(Request request, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(request.productId);
                if (product is null)
                    return false;

                var deletedRows = await _productRepository.DeleteAsync(product);
                return deletedRows > 0;
            }
        }
    }
}
