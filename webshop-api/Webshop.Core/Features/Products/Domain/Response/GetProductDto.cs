using System;
namespace Webshop.Core.Features.Products.Domain.Response
{
	public class GetProductDto
	{
        public Guid id { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime updatedDate { get; set; }

        public string sku { get; set; } = default!;

        public string name { get; set; } = default!;

        public string? description { get; set; }

        public double basePrice { get; set; }

        public double sellPrice { get; set; }

        public string? image { get; set; }

        public bool inStock { get; set; }
    }
}

