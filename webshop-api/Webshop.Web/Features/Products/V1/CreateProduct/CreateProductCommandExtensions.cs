using Webshop.Core.Features.Products;
using Webshop.Core.Features.Products.Domain.Request;

namespace Webshop.Web.Features.Products.V1.CreateProduct;

public static class CreateProductCommandExtensions
{
    public static Product MapToProduct(this CreateProductRequest product)
    {
        return new Product
        {
            Sku = product.Sku,
            Name = product.Name,
            BasePrice = product.BasePrice,
            SellPrice = product.SellPrice,
            Description = product.Description,
            Image = product.Image,
            IsInStock = product.InStock,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
        };
    }
}