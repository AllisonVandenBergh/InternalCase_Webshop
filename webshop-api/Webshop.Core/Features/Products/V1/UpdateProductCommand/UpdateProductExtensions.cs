using Webshop.Contracts.Features.V1.Products;
using Webshop.Contracts.Features.V1.Products.Request;

namespace Webshop.Core.Features.Products.V1.UpdateProductCommand
{
    public static class UpdateProductExtensions
    {
        public static Product ToProduct(this UpdateProductRequest updateProduct)
        {
            return new Product
            {
                Id = updateProduct.Id,
                Sku = updateProduct.Sku,
                Name = updateProduct.Name,
                BasePrice = updateProduct.BasePrice,
                SellPrice = updateProduct.SellPrice,
                Description = updateProduct.Description,
                Image = updateProduct.Image,
                IsInStock = updateProduct.IsInStock,
                UpdatedDate = DateTime.UtcNow,
            };
        }
    }
}
