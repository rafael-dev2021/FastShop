using Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;
using FluentValidation.TestHelper;
using FluentValidations.Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;

namespace UnitTests.Domain.Entities.Products.Technology.Smartphones.ObjectValues;

[TestFixture]
public class DimensionObjectValueTests
{ 
    private readonly DimensionObjectValueValidator _validator = new();

    public void Should_Not_Have_Error_When_HeightInches_Is_Valid()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        dimensionObjectValue.SetHeightInches(5.5);
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.HeightInches);
    }

    [Test]
    public void Should_Not_Have_Error_When_WidthInches_Is_Valid()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        dimensionObjectValue.SetWidthInches(5.5);
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.WidthInches);
    }

    [Test]
    public void Should_Not_Have_Error_When_ThicknessInches_Is_Valid()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        dimensionObjectValue.SetThicknessInches(0.5);
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.ThicknessInches);
    }

    [Test]
    public void Should_Have_Error_When_HeightInches_Is_Zero()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        dimensionObjectValue.SetHeightInches(0);
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.HeightInches)
            .WithErrorMessage("Height in inches must be greater than zero.");
    }

    [Test]
    public void Should_Have_Error_When_WidthInches_Is_Zero()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        dimensionObjectValue.SetWidthInches(0);
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.WidthInches)
            .WithErrorMessage("Width in inches must be greater than zero.");
    }

    [Test]
    public void Should_Have_Error_When_ThicknessInches_Is_Zero()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        dimensionObjectValue.SetThicknessInches(0);
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ThicknessInches)
            .WithErrorMessage("Thickness in inches must be greater than zero.");
    }

    [Test]
    public void Should_Have_Error_When_HeightInches_Is_Empty()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.HeightInches)
            .WithErrorMessage("Height in inches cannot be empty.");
    }

    [Test]
    public void Should_Have_Error_When_WidthInches_Is_Empty()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.WidthInches)
            .WithErrorMessage("Width in inches cannot be empty.");
    }

    [Test]
    public void Should_Have_Error_When_ThicknessInches_Is_Empty()
    {
        // Arrange
        var dimensionObjectValue = new DimensionObjectValue();
        // Act
        var result = _validator.TestValidate(dimensionObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ThicknessInches)
            .WithErrorMessage("Thickness in inches cannot be empty.");
    }
}