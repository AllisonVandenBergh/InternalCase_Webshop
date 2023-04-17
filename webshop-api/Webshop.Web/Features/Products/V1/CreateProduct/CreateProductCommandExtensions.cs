using Webshop.Contracts.Features.Products;
using Webshop.Contracts.Features.Products.Request;

namespace Webshop.Web.Features.Products.V1.CreateProduct
{
    public static class CreateProductCommandExtensions
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
                CreatedDate = product.CreatedDate ?? DateTime.UtcNow,
                UpdatedDate = product.UpdatedDate ?? DateTime.UtcNow
            };
        }

        public static CreateProductRequest ToCreateProductRequest(this Product product)
        {
            return new CreateProductRequest
            {
                Id = product.Id,
                Sku = product.Sku,
                Name = product.Name,
                BasePrice = product.BasePrice,
                SellPrice = product.SellPrice,
                Description = product.Description,
                Image = product.Image,
                IsInStock = product.IsInStock,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
            };
        }
    }
}