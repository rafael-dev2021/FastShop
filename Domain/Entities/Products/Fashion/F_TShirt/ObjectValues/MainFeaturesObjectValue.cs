﻿using Domain.Entities.ObjectValues.ProductObjectValue;

namespace Domain.Entities.Products.Fashion.F_TShirt.ObjectValues;

public class MainFeaturesObjectValue : CommonPropertiesObjectValue
{
    public string TypeOfClothing { get; private set; } = string.Empty;
    public string FabricDesign { get; private set; } = string.Empty;
    
    public void SetTypeOfClothing(string typeOfClothing) => TypeOfClothing = typeOfClothing;
    public void SetFabricDesign(string fabricDesign) => FabricDesign = fabricDesign;
}