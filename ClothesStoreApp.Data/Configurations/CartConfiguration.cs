using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> entity)
        {
            entity
                .ToTable("Carts");

            entity
                .HasKey(c => c.Id);

            // one to many relationship between Cart and CartItem
            entity
                .HasMany(c => c.Items)
                .WithOne(i => i.Cart)
                .HasForeignKey(i => i.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            // make sure we have one cart per customer
            entity
                .HasIndex(c => c.CustomerId)
                .IsUnique();
        }
    }
}
