using Domain.Entities;
using Domain.Interfaces;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories
{
    public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
    {
        public async Task<Category> CreateAsync(Category entity)
        {
            await appDbContext.AddAsync(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Category> DeleteAsync(Category entity)
        {
            appDbContext.Remove(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Category> GetByIdAsync(int? id)
        {
            var categoryId = appDbContext.Categories
                .Include(products => products.Products)
                .FirstOrDefaultAsync(category => category.Id == id);
            return await categoryId;
        }

        public async Task<List<CategoryWithProductCount>> GetCategoriesWithProductCountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetEntitiesAsync()
        {
            return await appDbContext.Categories.ToListAsync();
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            appDbContext.Update(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
