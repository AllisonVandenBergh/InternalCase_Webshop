using Webshop.Core.Features.Products;
using Webshop.Core.Features.Products.Domain.Response;

namespace Webshop.Web.Features.Products.V1.GetProduct;

public static class GetProductQueryExtensions
{
    public static GetProductDto MapToDto(this Product product)
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
            inStock = product.IsInStock,
            createdDate = product.CreatedDate,
            updatedDate = product.UpdatedDate,
        };
    }
}