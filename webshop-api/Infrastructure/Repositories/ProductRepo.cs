using System;
using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class ProductRepo: IProductRepo
	{
		private readonly WebshopContext _webshopContext;

		public ProductRepo(WebshopContext webshopContext)
		{
			_webshopContext = webshopContext;
		}

		public async Task<IEnumerable<Product>> GetAllAsync()
		{
			return await _webshopContext.Product.ToListAsync();
		}

        public async Task<Product?> GetBySkuAsync(Guid sku)
        {
            return await _webshopContext.Product.Where(product => product.Sku == sku).FirstOrDefaultAsync();
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

        public async Task<int> DeleteAsync(Guid sku)
        {
            _webshopContext.Product.Remove(new Product { Sku = sku});
            return await _webshopContext.SaveChangesAsync();
        }
    }
}

