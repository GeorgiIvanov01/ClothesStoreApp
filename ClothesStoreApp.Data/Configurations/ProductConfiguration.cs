using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity
                .ToTable("Products");

            entity
                .HasKey(p => p.Id);

            entity
                .Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired();

            entity
                .Property(p => p.Description)
                .HasMaxLength(2000);

            entity
                .Property(p => p.Brand)
                .HasMaxLength(100)
                .IsRequired();

            entity
                .Property(p => p.Color)
                .HasMaxLength(50)
                .IsRequired();

            entity
                .Property(p => p.Size)
                .HasMaxLength(20)
                .IsRequired();

            entity
                .Property(p => p.Price)
                .HasPrecision(18,2)
                .IsRequired();

            entity
                .Property(p => p.StockQuantity)
                .IsRequired();

            // one to many between Category and Products
            entity
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many between Product and ProductImages
            entity
                .HasMany(p => p.Images)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // index for filtering
            entity
                .HasIndex(p => new { p.CategoryId, p.Brand, p.Color, p.Size });
        }
    }
}
