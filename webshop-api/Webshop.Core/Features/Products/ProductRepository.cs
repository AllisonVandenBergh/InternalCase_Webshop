using System.Drawing;
using EntityFramework.Exceptions.Common;
using Microsoft.EntityFrameworkCore;
using Webshop.Contracts.Features.V1.Products;
using Webshop.Core.Features.Products.Exceptions;
using Webshop.Core.Features.Products.Interfaces;
using Webshop.Core.Infrastructure;

namespace Webshop.Core.Features.Products;

public class ProductRepository : IProductRepository
{
    private readonly WebshopContext _webshopContext;

    public ProductRepository(WebshopContext webshopContext)
    {
        _webshopContext = webshopContext;
    }

    public async Task<IList<Product>> GetAllAsync()
    {
        return await _webshopContext.Product.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        return await _webshopContext.Product.Where(product => product.Id == id).FirstOrDefaultAsync();
    }

    public async Task<bool> ExistByIdAsync(Guid id)
    {
        return await _webshopContext.Product.Where(product => product.Id == id).CountAsync() > 0;
    }

    public async Task<Guid> CreateAsync(Product product)
    {
        try
        {
            await _webshopContext.Product.AddAsync(product);
            await _webshopContext.SaveChangesAsync();

            return product.Id;

        } catch(UniqueConstraintException ex)
        {
            Console.WriteLine(ex.Message);

            throw new BadRequestException($"A product with id '{product.Id}', name '{product.Name}' or sku '{product.Sku}' already exists.");
        }
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

    public async Task<int> DeleteAsync(Product product)
    {
        try
        {
            _webshopContext.Product.Remove(product);
            return await _webshopContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException e)
        {
            //TODO: will be changed to ILogger!
            Console.WriteLine(e.Message);
            return 0;
        }
    }
}