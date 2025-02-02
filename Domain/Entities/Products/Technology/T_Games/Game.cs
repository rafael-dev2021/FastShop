﻿using Domain.Entities.ObjectValues.ProductObjectValue;
using Domain.Entities.Products.Technology.T_Games.ObjectValues;

namespace Domain.Entities.Products.Technology.T_Games;

public sealed class Game : Product
{
    public Game(int id, string name, string description, List<string> imagesUrl, int stock, int categoryId) :
        base(id, name, description, imagesUrl, stock, categoryId)
    { }

    public Game(
        string name,
        string description,
        List<string> imagesUrl,
        int stock,
        DataObjectValue dataObjectValue,
        FlagsObjectValue flagsObjectValue,
        PriceObjectValue priceObjectValue,
        SpecificationObjectValue specificationObjectValue,
        WarrantyObjectValue warrantyObjectValue,
        GeneralFeaturesObjectValue generalFeaturesObjectValue,
        MediaSpecificationObjectValue mediaSpecificationObjectValue,
        RequirementObjectValue requirementObjectValue,
        CommonPropertiesObjectValue? commonPropertiesObjectValue,
        int categoryId) :
        base(
            name,
            description,
            imagesUrl,
            stock, dataObjectValue,
            flagsObjectValue,
            priceObjectValue,
            specificationObjectValue,
            warrantyObjectValue,
            commonPropertiesObjectValue,
            categoryId)
    {
        GeneralFeaturesObjectValue = generalFeaturesObjectValue;
        MediaSpecificationObjectValue = mediaSpecificationObjectValue;
        RequirementObjectValue = requirementObjectValue;
    }

    public void UpdateGame(
        string name,
        string description,
        List<string> imagesUrl,
        int stock,
        DataObjectValue dataObjectValue,
        FlagsObjectValue flagsObjectValue,
        PriceObjectValue priceObjectValue,
        SpecificationObjectValue specificationObjectValue,
        WarrantyObjectValue warrantyObjectValue,
        GeneralFeaturesObjectValue generalFeaturesObjectValue,
        MediaSpecificationObjectValue mediaSpecificationObjectValue,
        RequirementObjectValue requirementObjectValue,
        CommonPropertiesObjectValue? commonPropertiesObjectValue,
        int categoryId)
    {
        UpdateProduct(
                name,
                description,
                imagesUrl,
                stock,
                dataObjectValue,
                flagsObjectValue,
                priceObjectValue,
                specificationObjectValue,
                warrantyObjectValue,
                commonPropertiesObjectValue,
                categoryId);
        
        GeneralFeaturesObjectValue = generalFeaturesObjectValue;
        MediaSpecificationObjectValue = mediaSpecificationObjectValue;
        RequirementObjectValue = requirementObjectValue;
    }

    public GeneralFeaturesObjectValue? GeneralFeaturesObjectValue { get; private set; }
    public MediaSpecificationObjectValue? MediaSpecificationObjectValue { get; private set; }
    public RequirementObjectValue? RequirementObjectValue { get; private set; }
}