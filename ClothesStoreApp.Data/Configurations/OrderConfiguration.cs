using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity
                .ToTable("Orders");

            entity
                .HasKey(o => o.Id);

            entity
                .Property(o => o.Status)
                .IsRequired();

            entity
                .Property(o => o.ShipToLine1)
                .HasMaxLength(200)
                .IsRequired();

            entity
                .Property(o => o.ShipToLine2)
                .HasMaxLength(200);

            entity
                .Property(o => o.ShipToCity)
                .HasMaxLength(100)
                .IsRequired();

            entity
                .Property(o => o.ShipToState)
                .HasMaxLength(100);

            entity
                .Property(o => o.ShipToPostalCode)
                .HasMaxLength(30)
                .IsRequired();

            entity
                .Property(o => o.ShipToCountry)
                .HasMaxLength(100)
                .IsRequired();

            
            entity
                .Property(o => o.Subtotal)
                .HasPrecision(18, 2);

            entity
                .Property(o => o.DiscountTotal)
                .HasPrecision(18, 2);

            entity
                .Property(o => o.ShippingTotal)
                .HasPrecision(18, 2);

            entity
                .Property(o => o.GrandTotal)
                .HasPrecision(18, 2);


            entity
                .HasMany(o => o.Items)
                .WithOne(i => i.Order)
                .HasForeignKey(i => i.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(o => o.Shipment)
                .WithOne(s => s.Order)
                .HasForeignKey<Shipment>(s => s.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
