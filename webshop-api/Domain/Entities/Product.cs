using System;
namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Sku { get; set; } = default!;

        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public double BasePrice { get; set; }

        public double SellPrice { get; set; }

        public string Image { get; set; } = default!;

        public bool InStock { get; set; }
    }
}

