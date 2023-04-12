using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories
{
	public class ProductRepo: IProductRepo
	{
		private readonly WebshopContext _webshopContext;
		private readonly ILogger _logger;

        public ProductRepo(WebshopContext webshopContext, ILogger<ProductRepo> logger)
		{
			_webshopContext = webshopContext;
			_logger = logger;
		}

		public async Task<IEnumerable<Product>> GetAllAsync()
		{
			return await _webshopContext.Product.ToListAsync();
		}

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await _webshopContext.Product.Where(product => product.Id == id).FirstOrDefaultAsync();
        }

		public async Task<int> CreateAsync(Product product)
		{
			await _webshopContext.Product.AddAsync(product);
			return await _webshopContext.SaveChangesAsync();
		}

		public async Task<int> UpdateAsync(Product product)
		{
            _webshopContext.Product.Update(product);
            return await _webshopContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(Guid id)
        {
			try
			{
				_webshopContext.Product.Remove(new Product { Id = id});
				return await _webshopContext.SaveChangesAsync();
			} catch(DbUpdateConcurrencyException e)
			{
				_logger.LogError(e.Message);
				return 0;
			}
        }
    }
}

