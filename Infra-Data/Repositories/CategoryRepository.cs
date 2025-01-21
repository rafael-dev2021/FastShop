using Domain.Entities;
using Domain.Interfaces;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories;

public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
{
    public async Task<IEnumerable<Category>> GetEntitiesAsync()
    {
        return await appDbContext.Categories
            .AsNoTracking()
            .Include(products => products.Products)
            .OrderBy(x => x.Id)
            .ToListAsync();
    }

    public async Task<Category> GetByIdAsync(int? id)
    {
        return await appDbContext.Categories
            .Include(Products => Products.Products)
            .FirstOrDefaultAsync(category => category.Id == id);
    }

    public async Task<Category> CreateAsync(Category entity)
    {
        await appDbContext.AddAsync(entity);
        await appDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<Category> UpdateAsync(Category entity)
    {
        appDbContext.Update(entity);
        await appDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<Category> DeleteAsync(Category entity)
    {
        appDbContext.Remove(entity);
        await appDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<List<CategoryWithProductCount>> GetCategoriesWithProductCountAsync()
    {
        return await appDbContext.Categories
            .AsNoTracking()
            .Select(category => new
                CategoryWithProductCount(category.Name, category.Products.Count()))
            .ToListAsync();
    }
}