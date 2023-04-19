namespace Webshop.Contracts.Features.V1.Products
{
	public class Product: BaseEntity
	{
        public required StockKeepingUnit Sku { get; init; }

        public required string Name { get; init; } = default!;

        public string? Description { get; set; }

        public required decimal BasePrice { get; init; }

        public required decimal SellPrice { get; init; }

        public string? Image { get; set; }

        public required bool IsInStock { get; init; }
    }
}