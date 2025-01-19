using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Products.Fashion;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories
{
    public class ProductRepository(AppDbContext appDbContext) : IProductRepository
    {
        public async Task<Product> GetByIdAsync(int? id)
        {
            return await appDbContext.Products
                .FirstOrDefaultAsync(product => product.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsBestSellersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByCategoriesAsync(string categoryStr)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsDailyOffersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsFavoritesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetSearchProductAsync(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
