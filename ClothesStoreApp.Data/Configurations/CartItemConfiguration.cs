using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> entity)
        {
            entity
                .ToTable("CartItems");

            entity
                .HasKey(i => i.Id);

            entity
                .Property(i => i.Quantity)
                .IsRequired();

            entity
                .HasOne(i => i.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // avoid duplicates
            entity
                .HasIndex(i => new { i.CartId, i.ProductId })
                .IsUnique();
        }
    }
}
