namespace Webshop.Contracts.Features.Products.Request
{
    [Serializable]
    public class CreateProductRequest
	{
        public required Guid Id { get; init; }

        public required StockKeepingUnit Sku { get; init; }

        public required string Name { get; init; }

        public string? Description { get; set; }

        public required decimal BasePrice { get; set; }

        public required decimal SellPrice { get; set; }

        public string? Image { get; set; }

        public required bool IsInStock { get; init; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
