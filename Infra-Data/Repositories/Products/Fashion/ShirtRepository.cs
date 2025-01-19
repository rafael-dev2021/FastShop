using Domain.Entities.Products.Fashion.F_TShirt;
using Domain.Interfaces.Products.Fashion;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories.Products.Fashion
{
    public class ShirtRepository(AppDbContext appDbContext) : IShirtRepository
    {
        public async Task<Shirt> CreateAsync(Shirt entity)
        {
            await appDbContext.AddAsync(entity);
            await appDbContext.SaveChangesAsync();  
            return entity;
        }

        public async Task<Shirt> DeleteAsync(Shirt entity)
        {
            appDbContext.Remove(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Shirt> GetByIdAsync(int? id)
        {
            return await appDbContext.Shirts.FindAsync(id);
        }

        public async Task<IEnumerable<Shirt>> GetEntitiesAsync()
        {
            return await appDbContext.Shirts.ToListAsync();
        }

        public async Task<Shirt> UpdateAsync(Shirt entity)
        {
            appDbContext.Update(entity);
            await appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
