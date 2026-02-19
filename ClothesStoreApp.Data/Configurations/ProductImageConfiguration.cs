using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> entity)
        {
            entity
                .ToTable("ProductImages");

            entity
                .HasKey(i => i.Id);

            entity
                .Property(i => i.Url)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
