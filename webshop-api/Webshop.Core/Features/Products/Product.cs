using System.Diagnostics.CodeAnalysis;

namespace Webshop.Core.Features.Products
{
	public class Product: BaseEntity
	{
        //public required string Sku { get; init; } = default!;

        //public required string Name { get; init; } = default!;

        //public string? Description { get; set; }

        //public required double BasePrice { get; init; }

        //public required double SellPrice { get; init; }

        //public string? Image { get; set; }

        //public required bool InStock { get; init; }

        public string Sku { get; set; } = default!;

        public string Name { get; set; } = default!;

        public string? Description { get; set; }
        
        public double BasePrice { get; set; }

        public double SellPrice { get; set; }

        public string? Image { get; set; }

        public bool InStock { get; set; }
    }
}

