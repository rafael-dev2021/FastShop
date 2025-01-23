namespace Domain.Entities;

public sealed class Category(int id, string name, string image, bool isActive)
{
    public int Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public string Image { get; private set; } = image;
    public bool IsActive { get; private set; } = isActive;
    public ICollection<Product> Products { get; } = [];
    
    public void SetName(string name) => Name = name;
}