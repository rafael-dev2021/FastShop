using Domain.Entities.ObjectValues.ProductObjectValue;
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
        GeneralObjectValue generalObjectValue,
        MaterialObjectValue materialObjectValue,
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
        categoryId)
    {
        GeneralObjectValue = generalObjectValue;
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
        GeneralObjectValue generalObjectValue,
        MaterialObjectValue materialObjectValue,
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
            categoryId);
        GeneralObjectValue = generalObjectValue;
        MaterialObjectValue = materialObjectValue;
    }

    public GeneralObjectValue GeneralObjectValue { get; private set; }
    public MaterialObjectValue MaterialObjectValue { get; private set; }
}