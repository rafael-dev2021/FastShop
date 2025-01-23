using Domain.Entities.Products.Technology.T_Games;
using Infra_Data.Context;
using Infra_Data.Repositories.Products.Technology;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Assert = Xunit.Assert;

namespace NUnitTests.Infra_Data.Repositories.Products.Technology;

public abstract class GameRepositoryTests
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
        public async Task GetByIdAsync_ShouldReturnGame()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new GameRepository(context);

            var game = new Game(1, "Game", "Description", [], 10, 1);

            context.Games.Add(game);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.GetByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Game", result.Name);
        }
    }

    public class CreateAsyncTests
    {
        [Fact]
        public async Task CreateAsync_ShouldAddGame()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new GameRepository(context);

            var game = new Game(3, "Game", "Description", [], 10, 1);

            // Act
            var result = await repository.CreateAsync(game);

            // Assert
            Assert.Equal(3, result.Id);
            Assert.Equal("Game", result.Name);

            var gameInDb = await context.Games.FindAsync(3);
            Assert.NotNull(gameInDb);
            Assert.Equal("Game", gameInDb.Name);
        }
    }

    public class UpdateAsyncTests
    {
        [Fact]
        public async Task UpdateAsync_ShouldUpdateGame()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new GameRepository(context);

            var game = new Game(1, "Game", "Description", [], 10, 1);

            context.Games.Add(game);
            await context.SaveChangesAsync();

            game.SetName("UpdatedGame");

            // Act
            var result = await repository.UpdateAsync(game);

            // Assert
            Assert.Equal("UpdatedGame", result.Name);

            var updatedGameInDb = await context.Games.FindAsync(1);
            Assert.NotNull(updatedGameInDb);
            Assert.Equal("UpdatedGame", updatedGameInDb.Name);
        }
    }

    public class DeleteAsyncTests
    {
        [Fact]
        public async Task DeleteAsync_ShouldRemoveGame()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new GameRepository(context);

            var game = new Game(1, "Game", "Description", [], 10, 1);

            context.Games.Add(game);
            await context.SaveChangesAsync();

            // Act
            var result = await repository.DeleteAsync(game);

            // Assert
            Assert.Equal(1, result.Id);

            var gameInDb = await context.Games.FindAsync(1);
            Assert.Null(gameInDb);
        }
    }
}