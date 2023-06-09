﻿using System;
namespace Webshop.Core.Features.Products.Domain.Request
{
	public class CreateProductRequest
	{
        public required string Sku { get; init; }

        public required string Name { get; init; }

        public string? Description { get; set; }

        public required double BasePrice { get; set; }

        public required double SellPrice { get; set; }

        public string? Image { get; set; }

        public required bool InStock { get; set; }
    }
}

