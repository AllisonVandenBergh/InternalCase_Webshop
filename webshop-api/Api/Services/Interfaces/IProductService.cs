using System;
using Domain.Entities;

namespace Api.Services.Interfaces
{
	public interface IProductService
	{
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<Product?> GetBySkuAsync(Guid sku);
        public Task<bool> CreateAsync(Product product);
        public Task<bool> UpdateAsync(Product product);
        public Task<bool> DeleteAsync(Guid sku);
    }
}

