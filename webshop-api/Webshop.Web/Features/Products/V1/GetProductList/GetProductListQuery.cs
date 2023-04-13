using MediatR;
using Webshop.Core.Features.Products.Domain.Response;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Web.Features.Products.V1.GetProduct;

namespace Webshop.Web.Features.Products.V1.GetProductList
{
    public record GetProductListQuery() : IRequest<IEnumerable<GetProductDto>>;

    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, IEnumerable<GetProductDto>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductListQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<GetProductDto>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var allProducts = await _productRepository.GetAllAsync();
            var productList = new List<GetProductDto>();

            foreach (var product in allProducts)
            {
                productList.Add(product.MapToDto());
            }

            return productList;

            //return await _productRepository.GetAllAsync();
        }
    }
}

