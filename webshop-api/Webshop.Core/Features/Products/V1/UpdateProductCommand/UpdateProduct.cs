using MediatR;
using Webshop.Contracts.Features.V1.Products.Request;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.V1.UpdateProductCommand
{
    public static class UpdateProduct
    {
        public record Request(UpdateProductRequest updateProduct) : IRequest<Guid?>;

        public class Handler : IRequestHandler<Request, Guid?>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<Guid?> Handle(Request request, CancellationToken cancellationToken)
            {
                var existingProduct = await _productRepository.ExistByIdAsync(request.updateProduct.Id);
                if (!existingProduct)
                    return null;

                var affectedRows = await _productRepository.UpdateAsync(request.updateProduct.ToProduct());
                if (affectedRows == 0)
                    return null;

                return request.updateProduct.Id;
            }
        }
    }
}

