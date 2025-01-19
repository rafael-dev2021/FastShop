using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        public Task<Product> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsBestSellersAsync()
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
