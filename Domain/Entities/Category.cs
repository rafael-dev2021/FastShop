namespace Domain.Entities;

public sealed class Category(int id, string name, string image, bool isActive)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Image { get; set; } = image;
    public bool IsActive { get; set; } = isActive;
    public ICollection<Product> Products { get; } = [];
}