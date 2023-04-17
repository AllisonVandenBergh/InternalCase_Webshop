namespace Webshop.Core.Features.Products.Interfaces;
﻿using System;
using Webshop.Contracts.Features.Products;

public interface IProductRepository
{
    internal Task<Product?> GetByIdAsync(Guid id);

    internal Task<Guid> CreateAsync(Product product);

    internal Task<int> CreateMultipleAsync(IEnumerable<Product> products);

    internal Task<int> UpdateAsync(Product product);

    internal Task<int> DeleteAsync(Product product);

    internal Task<IList<Product>> GetAllAsync();
}