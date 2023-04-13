using MediatR;
using Webshop.Core.Features.Products.Domain.Response;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Web.Features.Products.V1.GetProduct
{
    public record GetProductQuery(Guid Id) : IRequest<GetProductDto>;

    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductDto>
    {
        private readonly IProductRepository _productRepository;

        public GetProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return (await _productRepository.GetByIdAsync(request.Id))!.MapToDto();
        }
    }
}

