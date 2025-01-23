using Domain.Entities;
using Domain.Entities.Products.Fashion.F_Shoes;
using Domain.Entities.Products.Fashion.F_TShirt;
using Domain.Entities.Products.Technology.T_Games;
using Domain.Entities.Products.Technology.T_Smartphones;
using Infra_Data.Configuration;
using Infra_Data.Configuration.Products.Fashion;
using Infra_Data.Configuration.Products.Technology;
using Microsoft.EntityFrameworkCore;

namespace NUnitTests.Infra_Data
{
    public class TestDbContext(DbContextOptions<TestDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shirt> Shirts { get; set; }
        public DbSet<Shoes> Shoes { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Smartphone> Smartphones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductConfiguration().Configure(modelBuilder.Entity<Product>());
            new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new ShirtConfiguration().Configure(modelBuilder.Entity<Shirt>());
            new ShoesConfiguration().Configure(modelBuilder.Entity<Shoes>());
            new GameConfiguration().Configure(modelBuilder.Entity<Game>());
            new SmartphoneConfiguration().Configure(modelBuilder.Entity<Smartphone>());
        }
    }
}
