﻿using Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;
using FluentValidation.TestHelper;
using FluentValidations.Domain.Entities.Products.Technology.T_Smartphones.ObjectValues;
using Xunit;

namespace NUnitTests.Domain.Entities.Products.Technology.Smartphones.ObjectValues;

[TestFixture]
public class FeatureObjectValueTests
{ 
    private readonly FeatureObjectValueValidator _validator = new();
    
    [Fact]
    [Test]
    public void CellNetworkTechnology_WhenEmpty_ShouldHaveValidationError()
    {
        // Arrange
        var featureObjectValue = new FeatureObjectValue();
        featureObjectValue.SetCellNetworkTechnology("");
        // Act
        var result = _validator.TestValidate(featureObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.CellNetworkTechnology)
            .WithErrorMessage("Cell network technology cannot be empty.");
    }
    
    [Fact]
    [Test]
    public void CellNetworkTechnology_WhenExceedsMaxLength_ShouldHaveValidationError()
    {
        // Arrange
        var featureObjectValue = new FeatureObjectValue();
        featureObjectValue.SetCellNetworkTechnology(" ".PadRight(31, 'a'));
        // Act
        var result = _validator.TestValidate(featureObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.CellNetworkTechnology)
            .WithErrorMessage("Cell network technology must have a maximum length of 30 characters.");
    }
    
    [Fact]
    [Test]
    public void VirtualAssistant_WhenEmpty_ShouldHaveValidationError()
    {
        // Arrange
        var featureObjectValue = new FeatureObjectValue();
        featureObjectValue.SetVirtualAssistant("");
        // Act
        var result = _validator.TestValidate(featureObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.VirtualAssistant)
            .WithErrorMessage("Virtual assistant cannot be empty.");
    }
    
    [Fact]
    [Test]
    public void VirtualAssistant_WhenExceedsMaxLength_ShouldHaveValidationError()
    {
        // Arrange
        var featureObjectValue = new FeatureObjectValue();
        featureObjectValue.SetVirtualAssistant(" ".PadRight(51, 'a'));
        // Act
        var result = _validator.TestValidate(featureObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.VirtualAssistant)
            .WithErrorMessage("Virtual assistant must have a maximum length of 50 characters.");
    }
    
    [Fact]
    [Test]
    public void ManufacturerPartNumber_WhenEmpty_ShouldHaveValidationError()
    {
        // Arrange
        var featureObjectValue = new FeatureObjectValue();
        featureObjectValue.SetManufacturerPartNumber("");
        // Act
        var result = _validator.TestValidate(featureObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ManufacturerPartNumber)
            .WithErrorMessage("Manufacturer part number cannot be empty.");
    }
    
    [Fact]
    [Test]
    public void ManufacturerPartNumber_WhenExceedsMaxLength_ShouldHaveValidationError()
    {
        // Arrange
        var featureObjectValue = new FeatureObjectValue();
        featureObjectValue.SetManufacturerPartNumber(" ".PadRight(51, 'a'));
        // Act
        var result = _validator.TestValidate(featureObjectValue);
        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ManufacturerPartNumber)
            .WithErrorMessage("Manufacturer part number must have a maximum length of 50 characters.");
    }
}