using System;
using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
	public interface IProductRepo
	{
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<Product?> GetBySkuAsync(Guid sku);
        public Task<int> CreateAsync(Product product);
        public Task<int> UpdateAsync(Product product);
        public Task<int> DeleteAsync(Guid sku);
    }
}

