using Bogus;
using Webshop.Contracts.Features.Products;

namespace Webshop.Core.Utilities
{
    public static class ProductSeeding
    {
        public static Product GenerateFakeProduct => new Faker<Product>()
               .RuleFor(p => p.Id, b => b.Random.Guid())
               .RuleFor(p => p.Sku, f => new StockKeepingUnit(f.Random.AlphaNumeric(8)))
               .RuleFor(p => p.Name, b => b.Commerce.ProductName())
               .RuleFor(p => p.Description, b => b.Lorem.Sentences())
               .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
               .RuleFor(p => p.BasePrice, b => Utils.StringToDecimal(b.Commerce.Price()))
               .RuleFor(p => p.SellPrice, b => Utils.StringToDecimal(b.Commerce.Price()))
               .RuleFor(p => p.CreatedDate, b => b.Date.Past())
               .RuleFor(p => p.UpdatedDate, b => b.Date.Recent())
               .RuleFor(p => p.IsInStock, b => b.Random.Bool()).Generate();

        public static IList<Product> GenerateFakeProducts => new Faker<Product>()
                .RuleFor(p => p.Id, b => b.Random.Guid())
                .RuleFor(p => p.Sku, f => new StockKeepingUnit(f.Random.AlphaNumeric(8)))
                .RuleFor(p => p.Name, b => b.Commerce.ProductName())
                .RuleFor(p => p.Description, b => b.Lorem.Sentences())
                .RuleFor(p => p.Image, b => b.Image.PicsumUrl())
                .RuleFor(p => p.BasePrice, b => Utils.StringToDecimal(b.Commerce.Price()))
                .RuleFor(p => p.SellPrice, b => Utils.StringToDecimal(b.Commerce.Price()))
                .RuleFor(p => p.CreatedDate, b => b.Date.Past())
                .RuleFor(p => p.UpdatedDate, b => b.Date.Recent())
                .RuleFor(p => p.IsInStock, b => b.Random.Bool()).Generate(100);
    }
}