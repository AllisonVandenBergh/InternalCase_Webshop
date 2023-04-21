using MediatR;
using Webshop.Contracts.Features.V1.Products.Request;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.V1.UpdateProductCommand
{
    public static class UpdateProduct
    {
        public record Request(UpdateProductRequest updateProduct, Guid Id) : IRequest<Guid?>;

        public class Handler : IRequestHandler<Request, Guid?>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<Guid?> Handle(Request request, CancellationToken cancellationToken)
            {
                var existingProduct = await _productRepository.ExistByIdAsync(request.Id);
                if (!existingProduct)
                    return null;

                var productToUpdate = request.updateProduct.ToProduct();
                productToUpdate.Id = request.Id;

                var affectedRows = await _productRepository.UpdateAsync(productToUpdate);
                if (affectedRows == 0)
                    return null;

                return request.Id;
            }
        }
    }
}

