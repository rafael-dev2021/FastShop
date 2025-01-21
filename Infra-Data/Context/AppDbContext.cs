using Domain.Entities;
using Domain.Entities.Products.Fashion.F_Shoes;
using Domain.Entities.Products.Fashion.F_TShirt;
using Domain.Entities.Products.Technology.T_Games;
using Domain.Entities.Products.Technology.T_Smartphones;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Shirt> Shirts { get; set; }
    public DbSet<Shoes> Shoes { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Smartphone> Smartphones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}