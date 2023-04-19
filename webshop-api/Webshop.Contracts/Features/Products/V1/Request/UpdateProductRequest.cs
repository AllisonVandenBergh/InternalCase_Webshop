namespace Webshop.Contracts.Features.V1.Products.Request
{
    [Serializable]
    public class UpdateProductRequest
    {
        public required Guid Id { get; init; }

        public required StockKeepingUnit Sku { get; init; }

        public required string Name { get; init; }

        public string? Description { get; set; }

        public required decimal BasePrice { get; set; }

        public required decimal SellPrice { get; set; }

        public string? Image { get; set; }

        public required bool IsInStock { get; init; }
    }
}