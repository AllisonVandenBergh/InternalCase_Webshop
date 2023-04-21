namespace Webshop.Contracts.Features.V1.Products.Response
{
	[Serializable]
	public class GetProductAdminDetailDto
	{
        public required Guid id { get; init; }

        public required StockKeepingUnit sku { get; init; } = default!;

        public required string name { get; init; } = default!;

        public string? description { get; set; }

        public required decimal basePrice { get; init; }

        public required decimal sellPrice { get; init; }

        public string? image { get; set; }

        public required bool isInStock { get; init; }
	}
}