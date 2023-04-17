using MediatR;
using Webshop.Contracts.Features.Products.Response;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Core.Features.Products.V1.GetProductQuery;

namespace Webshop.Core.Features.Products.V1.GetProductListQuery
{
    public static class GetProductList
    {
        public record Request() : IRequest<IList<GetProductDto>>;

        public class Handler : IRequestHandler<Request, IList<GetProductDto>>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<IList<GetProductDto>> Handle(Request request, CancellationToken cancellationToken)
            {
                return (await _productRepository.GetAllAsync()).Select(product => product.ToDto()).ToList();
            }
        }
    }
}
