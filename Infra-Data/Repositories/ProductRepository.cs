using Domain.Entities;
using Domain.Interfaces;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories;

public class ProductRepository(AppDbContext appDbContext) : IProductRepository
{
    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await appDbContext.Products
            .AsNoTracking()
            .Include(category => category.Category)
            .ToListAsync();
    }

    public async Task<Product> GetByIdAsync(int? id)
    {
        return (await appDbContext.Products
            .Include(category => category.Category)
            .FirstOrDefaultAsync(x => x.Id == id))!;
    }

    public async Task<IEnumerable<Product>> GetProductsBestSellersAsync()
    {
        var products = await GetProductsAsync();

        return
        [
            .. products
                .Where(item => item.FlagsObjectValue!.IsBestSeller)
                .OrderBy(x => x.Id)
                .ThenBy(x => x.Name)
        ];
    }

    public async Task<IEnumerable<Product>> GetProductsDailyOffersAsync()
    {
        var products = await GetProductsAsync();

        return
        [
            .. products
                .Where(item => item.FlagsObjectValue!.IsDailyOffer)
                .OrderBy(x => x.Id)
                .ThenBy(x => x.Name)
        ];
    }

    public async Task<IEnumerable<Product>> GetProductsFavoritesAsync()
    {
        var products = await GetProductsAsync();

        return
        [
            .. products
                .Where(item => item.FlagsObjectValue!.IsFavorite)
                .OrderBy(x => x.Id)
                .ThenBy(x => x.Name)
        ];
    }

    public async Task<IEnumerable<Product>> GetProductsByCategoriesAsync(string categoryStr)
    {
        return await appDbContext.Products
            .AsNoTracking()
            .Where(category => category.Category!.Name.Equals(categoryStr))
            .Include(category => category.Category)
            .ToListAsync();
    }

    public async Task<IEnumerable<Product>> GetSearchProductAsync(string keyword)
    {
        var products = await GetProductsAsync();

        var filteredProducts = products
            .Where(x =>
                x.Name.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                x.Category!.Name.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                x.SpecificationObjectValue!.Brand.Contains(keyword, StringComparison.CurrentCultureIgnoreCase) ||
                x.SpecificationObjectValue.Model.Contains(keyword, StringComparison.CurrentCultureIgnoreCase))
            .OrderBy(x => x.Id)
            .ThenBy(x => x.Name)
            .ToList();

        return filteredProducts;
    }
}