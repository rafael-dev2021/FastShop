﻿using Domain.Entities.Products.Fashion.F_TShirt;
using Infra_Data.Context;
using Infra_Data.Repositories.Products.Fashion;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Assert = Xunit.Assert;

namespace NUnitTests.Infra_Data.Repositories.Products.Fashion;

public abstract class ShirtRepositoryTests
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
        public async Task GetByIdAsync_ShouldReturnShirt()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShirtRepository(context);

            var shirt = new Shirt(1, "Shirt1", "Description", [], 10, 1);

            context.Shirts.Add(shirt);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.GetByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Shirt1", result.Name);
        }
    }

    public class CreateAsyncTests
    {
        [Fact]
        public async Task CreateAsync_ShouldAddShirt()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShirtRepository(context);

            var shirt = new Shirt(3, "Shirt3", "Description", [], 10, 1);

            // Act
            var result = await repository.CreateAsync(shirt);

            // Assert
            Assert.Equal(3, result.Id);
            Assert.Equal("Shirt3", result.Name);

            var shirtInDb = await context.Shirts.FindAsync(3);
            Assert.NotNull(shirtInDb);
            Assert.Equal("Shirt3", shirtInDb.Name);
        }
    }

    public class UpdateAsyncTests
    {
        [Fact]
        public async Task UpdateAsync_ShouldUpdateShirt()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShirtRepository(context);

            var shirt = new Shirt(1, "Shirt1", "Description", [], 10, 1);

            context.Shirts.Add(shirt);
            await context.SaveChangesAsync();

            shirt.SetName("UpdatedShirt1");

            // Act
            var result = await repository.UpdateAsync(shirt);

            // Assert
            Assert.Equal("UpdatedShirt1", result.Name);

            var updatedShirtInDb = await context.Shirts.FindAsync(1);
            Assert.NotNull(updatedShirtInDb);
            Assert.Equal("UpdatedShirt1", updatedShirtInDb.Name);
        }
    }

    public class DeleteAsyncTests
    {
        [Fact]
        public async Task DeleteAsync_ShouldRemoveShirt()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new ShirtRepository(context);

            var shirt = new Shirt(1, "Shirt1", "Description", [], 10, 1);

            context.Shirts.Add(shirt);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.DeleteAsync(shirt);

            // Assert
            Assert.Equal(1, result.Id);

            var shirtInDb = await context.Shirts.FindAsync(1);
            Assert.Null(shirtInDb);
        }
    }
}