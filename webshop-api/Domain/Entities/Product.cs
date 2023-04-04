using System;
namespace Domain.Entities;

public class Product
{
    //public int Id { get; set; }

    public Guid Sku { get; set; } = default!;

    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public double BasePrice { get; set; } = default!;

    public double SellPrice { get; set; } = default!;

    public string Image { get; set; } = default!;

    public bool InStock { get; set; } = true;
}

