﻿namespace Domain.Entities.ObjectValues.ProductObjectValue;

public class CommonPropertiesObjectValue
{
    public string Gender { get; private set; } = string.Empty;
    public string Color { get; private set; } = string.Empty;
    public string Age { get; private set; } = string.Empty;
    public string RecommendedUser { get; private set; } = string.Empty;
    public string Size { get; private set; } = string.Empty;

    public void SetGender(string gender) => Gender = gender;
    public void SetColor(string color) => Color = color;
    public void SetAge(string age) => Age = age;
    public void SetRecommendedUser(string recommendedUser) => RecommendedUser = recommendedUser;
    public void SetSize(string size) => Size = size;
}