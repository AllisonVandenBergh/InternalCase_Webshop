namespace Webshop.Contracts.Features.Products.Response
{
    [Serializable]
    public class GetProductDto
	{
        public required Guid id { get; init; }

        public required DateTime createdDate { get; init; }

        public required DateTime updatedDate { get; init; }

        public required StockKeepingUnit sku { get; init; } = default!;

        public required string name { get; init; } = default!;

        public string? description { get; set; }

        public required decimal basePrice { get; init; }

        public required decimal sellPrice { get; init; }

        public string? image { get; set; }

        public required bool isInStock { get; init; }
    }
}
