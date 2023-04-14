namespace Webshop.Core.Features.Products;

public class Product : BaseEntity
{
    //public required string Sku { get; init; } = default!;

    //public required string Name { get; init; } = default!;

    //public string? Description { get; set; }

    //public required double BasePrice { get; init; }

    //public required double SellPrice { get; init; }

    //public string? Image { get; set; }

    //public required bool IsInStock { get; init; }

    // StockKeepingUnit
    public string Sku { get; set; } = default!;

    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    public decimal BasePrice { get; set; }

    public decimal SellPrice { get; set; }

    public string? Image { get; set; }

    public bool IsInStock { get; set; }
}

// Value object
//https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects
//https://learn.microsoft.com/en-us/ef/core/modeling/value-conversions?tabs=data-annotations
public class StockKeepingUnit
{
    // TryParse()
    // check lengte of regex

    // ToString()
}