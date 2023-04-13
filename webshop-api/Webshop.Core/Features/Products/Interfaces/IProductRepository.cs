using System;
namespace Webshop.Core.Features.Products.Interfaces
{
	public interface IProductRepository
	{
        public Task<IEnumerable<Product>> GetAllAsync();
        public Task<Product?> GetByIdAsync(Guid id);
        public Task<int> CreateAsync(Product product);
        Task<int> CreateMultipleAsync(IEnumerable<Product> products);
        public Task<int> UpdateAsync(Product product);
        public Task<int> DeleteAsync(Guid id);
    }
}

