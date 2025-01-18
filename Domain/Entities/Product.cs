using Domain.Entities.ObjectValues.ProductObjectValue;

namespace Domain.Entities;

public class Product
{
    public int Id { get; protected set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public List<string> ImagesUrl { get; private set; }
    public byte[] RowVersion { get; private set; } = [];
    public int Stock { get; private set; }
    public int CategoryId { get; private set; }
    public Category? Category { get; }

    public DataObjectValue DataObjectValue { get; protected set; } = null!;
    public FlagsObjectValue FlagsObjectValue { get; protected set; } = null!;
    public PriceObjectValue PriceObjectValue { get; protected set; } = null!;
    public SpecificationObjectValue SpecificationObjectValue { get; protected set; } = null!;
    public WarrantyObjectValue WarrantyObjectValue { get; protected set; } = null!;

    public Product()
    {
    }

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
        CategoryId = categoryId;
    }

    public void SetId(int id) => Id = id;
    public void SetStock(int stock) => Stock = stock;
    public void SetCategoryId(int categoryId) => CategoryId = categoryId;
}