﻿using Domain.Entities.ObjectValues.ProductObjectValue;
using Domain.Entities.Products.Fashion.F_Shoes.ObjectValues;

namespace Domain.Entities.Products.Fashion.F_Shoes;

public sealed class Shoes : Product
{
    public Shoes(int id, string name, string description, List<string> imagesUrl, int stock, int categoryId) :
        base(id, name, description, imagesUrl, stock, categoryId)
    {
    }

    public Shoes(
        string name,
        string description,
        List<string> imagesUrl,
        int stock,
        DataObjectValue dataObjectValue,
        FlagsObjectValue flagsObjectValue,
        PriceObjectValue priceObjectValue,
        SpecificationObjectValue specificationObjectValue,
        WarrantyObjectValue warrantyObjectValue,
        MaterialObjectValue materialObjectValue,
        CommonPropertiesObjectValue? commonPropertiesObjectValue,
        int categoryId
    ) : base(
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
        categoryId)
    {
        MaterialObjectValue = materialObjectValue;
    }

    public void UpdateShoes(
        string name,
        string description,
        List<string> imagesUrl,
        int stock,
        DataObjectValue dataObjectValue,
        FlagsObjectValue flagsObjectValue,
        PriceObjectValue priceObjectValue,
        SpecificationObjectValue specificationObjectValue,
        WarrantyObjectValue warrantyObjectValue,
        MaterialObjectValue materialObjectValue,
        CommonPropertiesObjectValue? commonPropertiesObjectValue,
        int categoryId
    )
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
        MaterialObjectValue = materialObjectValue;
    }

    public MaterialObjectValue? MaterialObjectValue { get; private set; }
}