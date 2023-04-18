using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webshop.Contracts.Features.Products;

namespace Webshop.Core.Infrastructure.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        var converter = new ValueConverter<StockKeepingUnit, string>(
            p => p.ToString(),
            p => StockKeepingUnit.ConvertToStockKeepingUnit(p));

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Sku).IsRequired()
                                    .HasConversion(converter);
        builder.Property(x => x.Description).IsRequired(false);
        builder.Property(x => x.BasePrice).IsRequired().HasPrecision(28,2);
        builder.Property(x => x.SellPrice).IsRequired().HasPrecision(28,2);
        builder.Property(x => x.Image).IsRequired(false);
        builder.Property(x => x.IsInStock).IsRequired();
    }
}