using Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;
using FluentValidation.TestHelper;
using FluentValidations.Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;

namespace NUnitTests.Domain.Entities.Products.Technology.Smartphones.ObjectValues;

[TestFixture]
public class DisplayObjectValueTests
{ 
    private readonly DisplayObjectValueValidator _validator = new();

    [Test]
    public void Should_Not_Have_Error_When_DisplayType_Is_Valid()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue();
        displayObjectValue.SetDisplayType("LED");
        // Act
        var result = _validator.TestValidate(displayObjectValue);
        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.DisplayType);
    }

    [Test]
    public void Should_Not_Have_Error_When_DisplayResolution_Is_Valid()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue(); 
        displayObjectValue.SetDisplayResolution("1920x1080");
        // Act
        var result = _validator.TestValidate(displayObjectValue);
        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.DisplayResolution);
    }

    [Test]
    public void Should_Not_Have_Error_When_DisplayProtection_Is_Valid()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue(); 
        displayObjectValue.SetDisplayProtection("Gorilla Glass");
        // Act
        var result = _validator.TestValidate(displayObjectValue);

        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.DisplayProtection);
    }

    [Test]
    public void Should_Not_Have_Error_When_DisplaySizeInches_Is_Valid()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue(); 
        displayObjectValue.SetDisplaySizeInches(6.5);
        // Act
        var result = _validator.TestValidate(displayObjectValue);
        // Assert
        result.ShouldNotHaveValidationErrorFor(x => x.DisplaySizeInches);
    }

    [Test]
    public void Should_Have_Error_When_DisplayType_Is_Empty()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue();
        // Act
        var result = _validator.TestValidate(displayObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.DisplayType)
            .WithErrorMessage("Display type cannot be empty.");
    }

    [Test]
    public void Should_Have_Error_When_DisplayResolution_Is_Empty()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue();
        // Act
        var result = _validator.TestValidate(displayObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.DisplayResolution)
            .WithErrorMessage("Display resolution cannot be empty.");
    }

    [Test]
    public void Should_Have_Error_When_DisplayProtection_Is_Empty()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue();

        // Act
        var result = _validator.TestValidate(displayObjectValue);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.DisplayProtection)
            .WithErrorMessage("Display protection cannot be empty.");
    }

    [Test]
    public void Should_Have_Error_When_DisplaySizeInches_Is_Zero()
    {
        // Arrange
        var displayObjectValue = new DisplayObjectValue();
        displayObjectValue.SetDisplaySizeInches(0);
        // Act
        var result = _validator.TestValidate(displayObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.DisplaySizeInches)
            .WithErrorMessage("Display size in inches must be greater than zero.");
    }
}