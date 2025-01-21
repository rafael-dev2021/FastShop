using Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;
using FluentValidation.TestHelper;
using FluentValidations.Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;

namespace NUnitTests.Domain.Entities.Products.Technology.Smartphones.ObjectValues;

[TestFixture]
public class StorageObjectValueTests
{
    private readonly StorageObjectValueValidator _validator = new();

    [Test]
    public void StorageGb_WhenBelowMinimum_ShouldHaveValidationError()
    {
        // Arrange
        var storage = new StorageObjectValue();
            storage.SetStorageGb(32);
        // Act
        var result = _validator.TestValidate(storage);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.StorageGb)
            .WithErrorMessage("Storage capacity must be between 64GB and 256GB.");
    }

    [Test]
    public void StorageGb_WhenAboveMaximum_ShouldHaveValidationError()
    {
        // Arrange
        var storage = new StorageObjectValue();
        storage.SetStorageGb(320);
        // Act
        var result = _validator.TestValidate(storage);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.StorageGb)
            .WithErrorMessage("Storage capacity must be between 64GB and 256GB.");
    }

    [Test]
    public void RamGb_WhenBelowMinimum_ShouldHaveValidationError()
    {
        // Arrange
        var storage = new StorageObjectValue();
        storage.SetRamGb(1);
        // Act
        var result = _validator.TestValidate(storage);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.RamGb)
            .WithErrorMessage("RAM capacity must be between 2GB and 16GB.");
    }

    [Test]
    public void RamGb_WhenAboveMaximum_ShouldHaveValidationError()
    {
        // Arrange
        var storage = new StorageObjectValue();
        storage.SetRamGb(42);
        // Act
        var result = _validator.TestValidate(storage);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.RamGb)
            .WithErrorMessage("RAM capacity must be between 2GB and 16GB.");
    }

    [Test]
    public void StorageGb_And_RamGb_WithinValidRange_ShouldNotHaveValidationError()
    {
        // Arrange
        var storage = new StorageObjectValue();
        storage.SetStorageGb(128);
        storage.SetRamGb(12);
        // Act
        var result = _validator.TestValidate(storage);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}