using Domain.Entities.ObjectValues.ProductObjectValue;

namespace Domain.Entities;

public class Product
{
    public int Id { get; protected set; }
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public List<string> ImagesUrl { get; protected set; }
    public byte[] RowVersion { get; protected set; } = [];
    public int Stock { get; protected set; }
    public int CategoryId { get; protected set; }
    public Category? Category { get; }

    public DataObjectValue? DataObjectValue { get; protected set; }
    public FlagsObjectValue? FlagsObjectValue { get; protected set; }
    public PriceObjectValue? PriceObjectValue { get; protected set; } 
    public SpecificationObjectValue? SpecificationObjectValue { get; protected set; } 
    public WarrantyObjectValue? WarrantyObjectValue { get; protected set; } 
    public CommonPropertiesObjectValue? CommonPropertiesObjectValue { get; protected set; } 

    public Product(int id, string name, string description, List<string> imagesUrl, int stock, int categoryId)
    {
        Id = id;
        Name = name;
        Description = description;
        ImagesUrl = imagesUrl;
        Stock = stock;
        CategoryId = categoryId;
    }

    public Product(
        string name,
        string description,
        List<string> imagesUrl,
        int stock,
        DataObjectValue dataObjectValue,
        FlagsObjectValue flagsObjectValue,
        PriceObjectValue priceObjectValue,
        SpecificationObjectValue specificationObjectValue,
        WarrantyObjectValue warrantyObjectValue,
        CommonPropertiesObjectValue? commonPropertiesObjectValue,
        int categoryId)
    {
        Name = name;
        Description = description;
        ImagesUrl = imagesUrl;
        Stock = stock;
        DataObjectValue = dataObjectValue;
        FlagsObjectValue = flagsObjectValue;
        PriceObjectValue = priceObjectValue;
        SpecificationObjectValue = specificationObjectValue;
        WarrantyObjectValue = warrantyObjectValue;
        CommonPropertiesObjectValue = commonPropertiesObjectValue;
        CategoryId = categoryId;
    }

    protected void UpdateProduct(
        string name,
        string description,
        List<string> imagesUrl,
        int stock,
        DataObjectValue dataObjectValue,
        FlagsObjectValue flagsObjectValue,
        PriceObjectValue priceObjectValue,
        SpecificationObjectValue specificationObjectValue,
        WarrantyObjectValue warrantyObjectValue,
        CommonPropertiesObjectValue? commonPropertiesObjectValue,
        int categoryId)
    {
        Name = name;
        Description = description;
        ImagesUrl = imagesUrl;
        Stock = stock;
        DataObjectValue = dataObjectValue;
        FlagsObjectValue = flagsObjectValue;
        PriceObjectValue = priceObjectValue;
        SpecificationObjectValue = specificationObjectValue;
        WarrantyObjectValue = warrantyObjectValue;
        CommonPropertiesObjectValue = commonPropertiesObjectValue;
        CategoryId = categoryId;
    }

    public void SetId(int id) => Id = id;
    public void SetName(string name) => Name = name;
    public void SetStock(int stock) => Stock = stock;
    public void SetCategoryId(int categoryId) => CategoryId = categoryId;
    public void SetFlagsObjectValue(FlagsObjectValue value) => FlagsObjectValue = value;
    public void SetSpecificationObjectValue(SpecificationObjectValue value) => SpecificationObjectValue = value;
    public void SetPriceObjectValue(PriceObjectValue value) => PriceObjectValue = value;
}