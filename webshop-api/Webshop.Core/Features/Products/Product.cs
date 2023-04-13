namespace Webshop.Core.Features.Products
{
	public class Product: BaseEntity
	{
        public string Sku { get; set; } = default!;

        public string Name { get; set; } = default!;

        public string? Description { get; set; }

        public double BasePrice { get; set; }

        public double SellPrice { get; set; }

        public string? Image { get; set; }

        public bool InStock { get; set; }
    }
}

