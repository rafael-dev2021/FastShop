using Domain.Entities.Products.Fashion.F_Shoes.ObjectValues;
using FluentValidation.TestHelper;
using FluentValidations.Domain.Entities.Products.Fashion.F_Shoes.ObjectValues;
using Xunit;

namespace NUnitTests.Domain.Entities.Products.Fashion.Shoes.ObjectValues;

[TestFixture]
public class MaterialObjectValueTests
{
    private readonly MaterialObjectValueValidator _validator = new();

    [Fact]
    [Test]
    public void MaterialsFromAbroad_WhenEmpty_ShouldHaveValidationError()
    {
        // Arrange
        var material = new MaterialObjectValue();
        material.SetMaterialFromAbroad("");
        // Act
        var result = _validator.TestValidate(material);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MaterialFromAbroad)
            .WithErrorMessage("Materials from abroad cannot be empty.");
    }

    [Fact]
    [Test]
    public void MaterialsFromAbroad_WhenExceedsMaxLength_ShouldHaveValidationError()
    {
        // Arrange
        var material = new MaterialObjectValue();
        material.SetMaterialFromAbroad(" ".PadRight(11, 'a'));
        // Act
        var result = _validator.TestValidate(material);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MaterialFromAbroad)
            .WithErrorMessage("Materials from abroad must have a maximum length of 10 characters.");
    }

    [Fact]
    [Test]
    public void InteriorMaterials_WhenEmpty_ShouldHaveValidationError()
    {
        // Arrange
        var material = new MaterialObjectValue();
        material.SetMaterialInterior("");
        // Act
        var result = _validator.TestValidate(material);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MaterialInterior)
            .WithErrorMessage("Interior materials cannot be empty.");
    }

    [Fact]
    [Test]
    public void InteriorMaterials_WhenExceedsMaxLength_ShouldHaveValidationError()
    {
        // Arrange
        var material = new MaterialObjectValue();
        material.SetMaterialInterior(" ".PadRight(11, 'a'));
        // Act
        var result = _validator.TestValidate(material);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MaterialInterior)
            .WithErrorMessage("Interior materials must have a maximum length of 10 characters.");
    }

    [Fact]
    [Test]
    public void SoleMaterials_WhenEmpty_ShouldHaveValidationError()
    {
        // Arrange
        var material = new MaterialObjectValue();
        material.SetMaterialSole("");
        // Act
        var result = _validator.TestValidate(material);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MaterialSole)
            .WithErrorMessage("Sole materials cannot be empty.");
    }

    [Fact]
    [Test]
    public void SoleMaterials_WhenExceedsMaxLength_ShouldHaveValidationError()
    {
        // Arrange
        var material = new MaterialObjectValue();
        material.SetMaterialSole(" ".PadRight(11, 'a'));
        // Act
        var result = _validator.TestValidate(material);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.MaterialSole)
            .WithErrorMessage("Sole materials must have a maximum length of 10 characters.");
    }

    [Fact]
    [Test]
    public void AllProperties_WithinValidLength_ShouldNotHaveValidationError()
    {
        // Arrange
        var material = new MaterialObjectValue();
        material.SetMaterialFromAbroad("Leather");
        material.SetMaterialInterior("Fabric");
        material.SetMaterialSole("Rubber");
        // Act
        var result = _validator.TestValidate(material);
        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}