using MediatR;
using Webshop.Contracts.Features.Products.Request;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.V1.CreateProductCommand
{
    public static class CreateProduct
    {
        public record Request(CreateProductRequest createProductRequest) : IRequest<Guid>;

        public class Handler : IRequestHandler<Request, Guid>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<Guid> Handle(Request command, CancellationToken cancellationToken)
            {
                return await _productRepository.CreateAsync(command.createProductRequest.ToProduct())!;
            }
        }
    }
}
