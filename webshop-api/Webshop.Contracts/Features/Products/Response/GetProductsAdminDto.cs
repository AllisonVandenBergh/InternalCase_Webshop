namespace Webshop.Contracts.Features.Products.Response
{
	[Serializable]
	public class GetProductsAdminDto
	{
        public required Guid id { get; init; }

        public required StockKeepingUnit sku { get; init; } = default!;

        public required string name { get; init; } = default!;

        public required decimal basePrice { get; init; }

        public required decimal sellPrice { get; init; }

        public string? image { get; set; }

        public required bool isInStock { get; init; }
	}
}