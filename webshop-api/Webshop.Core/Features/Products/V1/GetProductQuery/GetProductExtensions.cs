using Webshop.Contracts.Features.Products;
using Webshop.Contracts.Features.Products.Response;

namespace Webshop.Core.Features.Products.V1.GetProductQuery
{
	public static class GetProductExtensions
	{
        public static GetProductDto ToDto(this Product product)
        {
            return new GetProductDto
            {
                id = product.Id,
                sku = product.Sku,
                name = product.Name,
                basePrice = product.BasePrice,
                sellPrice = product.SellPrice,
                description = product.Description,
                image = product.Image,
                isInStock = product.IsInStock,
                createdDate = product.CreatedDate,
                updatedDate = product.UpdatedDate,
            };
        }
    }
}
