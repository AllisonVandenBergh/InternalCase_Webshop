﻿using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Sku).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.BasePrice).IsRequired();
        builder.Property(x => x.SellPrice).IsRequired();
        builder.Property(x => x.Image).IsRequired();
        builder.Property(x => x.InStock).IsRequired();
    }
}