using Domain.Entities;
using Domain.Entities.Cart;
using Domain.Entities.Orders;
using Domain.Entities.Payments;
using Domain.Entities.Products.Fashion.F_Shoes;
using Domain.Entities.Products.Fashion.F_TShirt;
using Domain.Entities.Products.Technology.T_Games;
using Domain.Entities.Products.Technology.T_Smartphones;
using Domain.Entities.Reviews;
using Infra_Data.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Category> Categories { get; set; } 
    public DbSet<Product> Products { get; set; } 
    public DbSet<Order> Orders { get; set; } 
    public DbSet<OrderDetail> OrdersDetails { get; set; } 
    public DbSet<Review> Reviews { get; set; } 
    public DbSet<PaymentMethod> PaymentMethods { get; set; } 
    public DbSet<CreditCard> CreditCards { get; set; } 
    public DbSet<DebitCard> DebitCards { get; set; } 
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } 
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