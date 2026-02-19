using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> entity)
        {
            entity
                .ToTable("OrderItems");

            entity
                .HasKey(i => i.Id);

            entity
                .Property(i => i.UnitPrice)
                .HasPrecision(18, 2);

            entity
                .Property(i => i.LineTotal)
                .HasPrecision(18, 2);

            entity
                .HasOne(i => i.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
