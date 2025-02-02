using Domain.Entities.Products.Fashion.F_Shoes;
using Domain.Interfaces.Products.Fashion;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories.Products.Fashion;

public class ShoesRepository(AppDbContext appDbContext) : IShoesRepository
{
    
    public async Task<IEnumerable<Shoes>> GetEntitiesAsync()
    {
        return await appDbContext.Shoes
            .AsNoTracking()
            .Include(x=>x.Category)
            .OrderBy(x=>x.Name)
            .ToListAsync();
    }

    public async Task<Shoes> GetByIdAsync(int? id) =>
        (await appDbContext.Shoes.FindAsync(id))!;
    
    public async Task<Shoes> CreateAsync(Shoes entity)
    {
        await appDbContext.AddAsync(entity);
        await appDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<Shoes> UpdateAsync(Shoes entity)
    {
        appDbContext.Update(entity);
        await appDbContext.SaveChangesAsync();
        return entity;
    }
    
    public async Task<Shoes> DeleteAsync(Shoes entity)
    {
        appDbContext.Remove(entity);
        await appDbContext.SaveChangesAsync();
        return entity;
    }
}