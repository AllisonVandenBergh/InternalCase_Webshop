using System;
using Webshop.Contracts.Features.V1.Products;
using Webshop.Contracts.Features.V1.Products.Request;
using Webshop.Contracts.Features.V1.Products.Response;

namespace Webshop.Web.Features.Products.V1
{
	public static class ProductMapping
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

        public static GetProductsAdminDto ToDto(this Product product)
        {
            return new GetProductsAdminDto
            {
                id = product.Id,
                sku = product.Sku,
                name = product.Name,
                basePrice = product.BasePrice,
                sellPrice = product.SellPrice,
                image = product.Image,
                isInStock = product.IsInStock,
            };
        }
    }
}

