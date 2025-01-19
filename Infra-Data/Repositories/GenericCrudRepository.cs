using Domain.Interfaces;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories
{
    public class GenericCrudRepository<T>(AppDbContext appDbContext) : IGenericCrudRepository<T> where T : class
    {
        public async Task<T> CreateAsync(T entity)
        {
            await appDbContext.AddAsync(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            appDbContext.Remove(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> GetByIdAsync(int? id)
        {
           return await appDbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetEntitiesAsync()
        {
            return await appDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            appDbContext.Update(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
