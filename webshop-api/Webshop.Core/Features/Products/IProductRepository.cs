namespace Webshop.Core.Features.Products.Interfaces;
﻿using System;
using Webshop.Contracts.Features.V1.Products;

public interface IProductRepository
{
    internal Task<Product?> GetByIdAsync(Guid id);

    internal Task<Guid> CreateAsync(Product product);

    internal Task<int> CreateMultipleAsync(IEnumerable<Product> products);

    internal Task<int> UpdateAsync(Product product);

    internal Task<int> DeleteAsync(Product product);

    internal Task<IList<Product>> GetAllAsync();

    internal Task<bool> ExistByIdAsync(Guid id);
}