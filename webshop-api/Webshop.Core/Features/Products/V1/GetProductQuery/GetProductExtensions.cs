using Webshop.Contracts.Features.V1.Products;
using Webshop.Contracts.Features.V1.Products.Response;

namespace Webshop.Core.Features.Products.V1.GetProductQuery
{
	public static class GetProductExtensions
	{
        public static GetProductAdminDetailDto ToDto(this Product product)
        {
            return new GetProductAdminDetailDto
            {
                id = product.Id,
                sku = product.Sku,
                name = product.Name,
                description = product.Description,
                basePrice = product.BasePrice,
                sellPrice = product.SellPrice,
                image = product.Image,
                isInStock = product.IsInStock,
            };
        }
    }
}