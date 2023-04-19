using Webshop.Contracts.Features.V1.Products;
using Webshop.Contracts.Features.V1.Products.Request;

namespace Webshop.Core.Features.Products.V1.CreateProductCommand
{
	public static class CreateProductExtensions
	{
        public static Product ToProduct(this CreateProductRequest product)
        {
            return new Product
            {
                Id = product.Id,
                Sku = product.Sku,
                Name = product.Name,
                BasePrice = product.BasePrice,
                SellPrice = product.SellPrice,
                Description = product.Description,
                Image = product.Image,
                IsInStock = product.IsInStock,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
            };
        }
    }
}
