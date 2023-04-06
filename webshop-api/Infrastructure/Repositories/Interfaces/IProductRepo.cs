using System;
using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
	public interface IProductRepo
	{
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<Product?> GetByIdAsync(Guid id);
        public Task<int> CreateAsync(Product product);
        public Task<int> UpdateAsync(Product product);
        public Task<int> DeleteAsync(Guid id);
    }
}

