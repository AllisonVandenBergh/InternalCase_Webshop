using MediatR;
using Webshop.Contracts.Features.V1.Products.Response;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Core.Features.Products.V1.GetProductListQuery
{
    public static class GetProductList
    {
        public record Request() : IRequest<IList<GetProductsAdminDto>>;

        public class Handler : IRequestHandler<Request, IList<GetProductsAdminDto>>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<IList<GetProductsAdminDto>> Handle(Request request, CancellationToken cancellationToken)
            {
                return (await _productRepository.GetAllAsync()).Select(product => product.ToDto()).ToList();
            }
        }
    }
}
