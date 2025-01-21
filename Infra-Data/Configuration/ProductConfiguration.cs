using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_Data.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(60).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(10000).IsRequired();
        builder.Property(x => x.ImagesUrl).HasMaxLength(900).IsRequired();
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);

        builder
            .OwnsOne(x => x.DataObjectValue, dataObj =>
            {
                dataObj.Property(pd => pd.ReleaseMonth)
                    .HasMaxLength(12)
                    .IsRequired();

                dataObj.Property(pd => pd.ReleaseYear)
                    .HasMaxLength(4)
                    .IsRequired();
            });
        
        builder
            .OwnsOne(x => x.WarrantyObjectValue, warrantyObj =>
            {
                warrantyObj.Property(pd => pd.WarrantyLength)
                    .HasMaxLength(30)
                    .IsRequired();

                warrantyObj.Property(pd => pd.WarrantyInformation)
                    .HasMaxLength(30)
                    .IsRequired();
            });
        
        builder
            .OwnsOne(x => x.SpecificationObjectValue, specificationObj =>
            {
                specificationObj.Property(pd => pd.Model)
                    .HasMaxLength(50)
                    .IsRequired();

                specificationObj.Property(pd => pd.Brand)
                    .HasMaxLength(20)
                    .IsRequired();
                
                specificationObj.Property(pd => pd.Line)
                    .HasMaxLength(20)
                    .IsRequired();
                
                specificationObj.Property(pd => pd.Weight)
                    .HasMaxLength(20)
                    .IsRequired();
                
                specificationObj.Property(pd => pd.Type)
                    .HasMaxLength(20)
                    .IsRequired();
            });
        
        builder
            .OwnsOne(x => x.PriceObjectValue, priceObj =>
            {
                priceObj.Property(pd => pd.Price)
                    .HasPrecision(18,2)
                    .IsRequired();

                priceObj.Property(pd => pd.HistoryPrice)
                    .HasPrecision(18, 2);
            });
    }
}