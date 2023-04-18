using System;
using Webshop.Contracts.Features.Products;
using Webshop.Contracts.Features.Products.Response;

namespace Webshop.Core.Features.Products.V1.GetProductListQuery
{
	public static class GetProductListExtensions
	{
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

