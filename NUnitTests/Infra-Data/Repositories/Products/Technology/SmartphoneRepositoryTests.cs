using Domain.Entities.Products.Technology.T_Smartphones;
using Infra_Data.Context;
using Infra_Data.Repositories.Products.Technology;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Assert = Xunit.Assert;

namespace NUnitTests.Infra_Data.Repositories.Products.Technology;

public abstract class SmartphoneRepositoryTests
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
        public async Task GetByIdAsync_ShouldReturnSmartphone()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new SmartphoneRepository(context);

            var smartphone = new Smartphone(1, "Phone", "Description", [], 10, 1);

            context.Smartphones.Add(smartphone);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.GetByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Phone", result.Name);
        }
    }

    public class CreateAsyncTests
    {
        [Fact]
        public async Task CreateAsync_ShouldAddSmartphone()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new SmartphoneRepository(context);

            var smartphone = new Smartphone(3, "Phone", "Description", [], 10, 1);

            // Act
            var result = await repository.CreateAsync(smartphone);

            // Assert
            Assert.Equal(3, result.Id);
            Assert.Equal("Phone", result.Name);

            var phoneInDb = await context.Smartphones.FindAsync(3);
            Assert.NotNull(phoneInDb);
            Assert.Equal("Phone", phoneInDb.Name);
        }
    }

    public class UpdateAsyncTests
    {
        [Fact]
        public async Task UpdateAsync_ShouldUpdateSmartphone()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new SmartphoneRepository(context);

            var smartphone = new Smartphone(1, "Phone", "Description", [], 10, 1);

            context.Smartphones.Add(smartphone);
            await context.SaveChangesAsync();

            smartphone.SetName("UpdatedPhone");

            // Act
            var result = await repository.UpdateAsync(smartphone);

            // Assert
            Assert.Equal("UpdatedPhone", result.Name);

            var updatedPhoneInDb = await context.Smartphones.FindAsync(1);
            Assert.NotNull(updatedPhoneInDb);
            Assert.Equal("UpdatedPhone", updatedPhoneInDb.Name);
        }
    }

    public class DeleteAsyncTests
    {
        [Fact]
        public async Task DeleteAsync_ShouldRemoveSmartphone()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new SmartphoneRepository(context);

            var smartphone = new Smartphone(1, "Phone", "Description", [], 10, 1);

            context.Smartphones.Add(smartphone);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.DeleteAsync(smartphone);

            // Assert
            Assert.Equal(1, result.Id);

            var phoneInDb = await context.Smartphones.FindAsync(1);
            Assert.Null(phoneInDb);
        }
    }
}