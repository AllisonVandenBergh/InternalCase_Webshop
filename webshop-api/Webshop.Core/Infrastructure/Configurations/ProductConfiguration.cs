﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Webshop.Contracts.Features.Products;

namespace Webshop.Core.Infrastructure.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Sku).IsRequired();
        builder.Property(x => x.Description).IsRequired(false);
        builder.Property(x => x.BasePrice).IsRequired();
        builder.Property(x => x.SellPrice).IsRequired();
        builder.Property(x => x.Image).IsRequired(false);
        builder.Property(x => x.IsInStock).IsRequired();
    }
}