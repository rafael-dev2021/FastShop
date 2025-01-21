using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_Data.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Image).HasMaxLength(600).IsRequired();

        builder.HasData(
            new Category(1, "Smartphones", "", true),
            new Category(2, "Fashion", "", true),
            new Category(3, "Games", "", true),
            new Category(4, "Kitchen", "", true),
            new Category(5, "Kids", "", true),
            new Category(6, "Electronic", "", true),
            new Category(7, "Furniture", "", true)
        );
    }
}