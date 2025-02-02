using Domain.Entities.Products.Fashion.F_Shoes;
using Infra_Data.Context;
using Infra_Data.Repositories.Products.Fashion;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Assert = Xunit.Assert;

namespace NUnitTests.Infra_Data.Repositories.Products.Fashion;

public abstract class ShoesRepositoryTests
{
    private static AppDbContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: $"TestDatabase-{Guid.NewGuid()}")
            .Options;

        return new AppDbContext(options);
    }

    public class GetByIdAsyncTests
    {
        [Fact]
        public async Task GetByIdAsync_ShouldReturnShoe()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShoesRepository(context);

            var shoe = new Shoes(1, "Shoes", "Description", [], 10, 1);

            context.Shoes.Add(shoe);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.GetByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Shoes", result.Name);
        }
    }
    
    public class CreateAsyncTests
    {
        [Fact]
        public async Task CreateAsync_ShouldAddShoe()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShoesRepository(context);

            var shoe = new Shoes(3, "Shoe", "Description", [], 10, 1);

            // Act
            var result = await repository.CreateAsync(shoe);

            // Assert
            Assert.Equal(3, result.Id);
            Assert.Equal("Shoe", result.Name);

            var shoeInDb = await context.Shoes.FindAsync(3);
            Assert.NotNull(shoeInDb);
            Assert.Equal("Shoe", shoeInDb.Name);
        }
    }

    public class UpdateAsyncTests
    {
        [Fact]
        public async Task UpdateAsync_ShouldUpdateShoe()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShoesRepository(context);

            var shoe = new Shoes(1, "Shoe", "Description", [], 10, 1);

            context.Shoes.Add(shoe);
            await context.SaveChangesAsync();

            shoe.SetName("UpdatedShoe");

            // Act
            var result = await repository.UpdateAsync(shoe);

            // Assert
            Assert.Equal("UpdatedShoe", result.Name);

            var updatedShoeInDb = await context.Shoes.FindAsync(1);
            Assert.NotNull(updatedShoeInDb);
            Assert.Equal("UpdatedShoe", updatedShoeInDb.Name);
        }
    }

    public class DeleteAsyncTests
    {
        [Fact]
        public async Task DeleteAsync_ShouldRemoveShoe()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShoesRepository(context);

            var shoe = new Shoes(1, "Shoe", "Description", [], 10, 1);

            context.Shoes.Add(shoe);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.DeleteAsync(shoe);

            // Assert
            Assert.Equal(1, result.Id);

            var shoeInDb = await context.Shoes.FindAsync(1);
            Assert.Null(shoeInDb);
        }
    }
}