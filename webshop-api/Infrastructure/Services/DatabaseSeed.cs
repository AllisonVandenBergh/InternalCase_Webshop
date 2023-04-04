using System;
using Bogus;
using Domain.Entities;

namespace Infrastructure.Services;

	public static class DatabaseSeed
	{
    public static Product GenerateFakeProduct()
    {
        return new Faker<Product>()
           //.RuleFor(p => p.Id, _ => productId++)
           .RuleFor(p => p.Sku, b => b.Random.Guid())
           .RuleFor(p => p.Name, b => b.Commerce.ProductName())
           .RuleFor(p => p.Description, b => b.Lorem.Sentences())
           .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
           .RuleFor(p => p.BasePrice, b => double.Parse(b.Commerce.Price()))
           .RuleFor(p => p.SellPrice, b => double.Parse(b.Commerce.Price()))
           .RuleFor(p => p.InStock, b => b.Random.Bool()).Generate();
    }

    public static List<Product> GenerateFakeProducts()
    {
        //var productId = 0;

        return new Faker<Product>()
            //.RuleFor(p => p.Id, _ => productId++)
            .RuleFor(p => p.Sku, b => b.Random.Guid())
            .RuleFor(p => p.Name, b => b.Commerce.ProductName())
            .RuleFor(p => p.Description, b => b.Lorem.Sentences())
            .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
            .RuleFor(p => p.BasePrice, b => double.Parse(b.Commerce.Price()))
            .RuleFor(p => p.SellPrice, b => double.Parse(b.Commerce.Price()))
            .RuleFor(p => p.InStock, b => b.Random.Bool()).Generate(100);
    }
}

