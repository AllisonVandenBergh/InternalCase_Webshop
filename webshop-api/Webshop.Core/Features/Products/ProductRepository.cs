using Microsoft.EntityFrameworkCore;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Core.Infrastructure;

namespace Webshop.Core.Features.Products
{
	public class ProductRepository: IProductRepository
	{
        private readonly WebshopContext _webshopContext;
        //private readonly ILogger _logger;

        public ProductRepository(WebshopContext webshopContext)
        {
            _webshopContext = webshopContext;
            //_logger = logger;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _webshopContext.Product.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await _webshopContext.Product.Where(product => product.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Product?> CreateAsync(Product product)
        {
            await _webshopContext.Product.AddAsync(product);
            var affectedRows = await _webshopContext.SaveChangesAsync();
            if(affectedRows > 0)
                return product;

            return null;
        }

        public async Task<int> CreateMultipleAsync(IEnumerable<Product> products)
        {
            await _webshopContext.Product.AddRangeAsync(products);
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
                _webshopContext.Product.Remove(new Product { Id = id });
                return await _webshopContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                Console.WriteLine(e.Message);
                //_logger.LogError(e.Message);
                return 0;
            }
        }
    }
}

