using System;
using Api.Services.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories.Interfaces;
using Infrastructure.Services;

namespace Api.Services
{
    //TODO: in a seperate repo / service or just the service? Can be changed of course!
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<bool> CreateAsync(Product product)
        {
            var existingProduct = await GetByIdAsync(product.Id);
            if (existingProduct is not null)
                return false;

            var createdProduct = await _productRepo.CreateAsync(product);
            return createdProduct > 0;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var deletedProduct = await _productRepo.DeleteAsync(id);
            return deletedProduct > 0;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepo.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(Guid id)
        {
            return await _productRepo.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Product product)
        {
            var existingProduct = await _productRepo.GetByIdAsync(product.Id);
            if (existingProduct is null)
                return false;

            var updatedProduct = await _productRepo.UpdateAsync(product);
            return updatedProduct > 0;
        }
    }
}

