namespace Domain.Entities.Products.Fashion.F_Shoes.ObjectValues;

public class MaterialObjectValue
{
    public string MaterialFromAbroad { get; private set; } = string.Empty;
    public string MaterialInterior { get; private set; } = string.Empty;
    public string MaterialSole { get; private set; } = string.Empty;

    public void SetMaterialFromAbroad(string materialFromAbroad) => MaterialFromAbroad = materialFromAbroad;
    public void SetMaterialInterior(string materialInterior) => MaterialInterior = materialInterior;
    public void SetMaterialSole(string materialSole) => MaterialSole = materialSole;
}