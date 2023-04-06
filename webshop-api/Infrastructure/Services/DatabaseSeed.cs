using System;
using Bogus;
using Domain.Entities;

namespace Infrastructure.Services
{
	public static class DatabaseSeed
	{
        public static Product GenerateFakeProduct()
        {
            return new Faker<Product>()
               .RuleFor(p => p.Id, b => b.Random.Guid())
               .RuleFor(p => p.Sku, b => b.Random.String2(8, 12))
               .RuleFor(p => p.Name, b => b.Commerce.ProductName())
               .RuleFor(p => p.Description, b => b.Lorem.Sentences())
               .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
               .RuleFor(p => p.BasePrice, b => double.Parse(b.Commerce.Price()))
               .RuleFor(p => p.SellPrice, b => double.Parse(b.Commerce.Price()))
               .RuleFor(p => p.InStock, b => b.Random.Bool()).Generate();
        }

        public static List<Product> GenerateFakeProducts()
        {
            return new Faker<Product>()
                .RuleFor(p => p.Id, b => b.Random.Guid())
                .RuleFor(p => p.Sku, b => b.Random.String2(8,12))
                .RuleFor(p => p.Name, b => b.Commerce.ProductName())
                .RuleFor(p => p.Description, b => b.Lorem.Sentences())
                .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
                .RuleFor(p => p.BasePrice, b => double.Parse(b.Commerce.Price()))
                .RuleFor(p => p.SellPrice, b => double.Parse(b.Commerce.Price()))
                .RuleFor(p => p.InStock, b => b.Random.Bool()).Generate(100);
        }
    }
}

