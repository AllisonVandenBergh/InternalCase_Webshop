using MediatR;
using Webshop.Core.Features.Products.Interfaces;

namespace Webshop.Web.Features.Products.V1.DeleteProduct
{
    public record DeleteProductCommand(Guid Id) : IRequest<bool>;

    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var deletedRows = await _productRepository.DeleteAsync(request.Id);
            return deletedRows > 0;
        }
    }
}

