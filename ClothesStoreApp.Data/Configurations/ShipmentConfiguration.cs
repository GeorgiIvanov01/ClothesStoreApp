using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> entity)
        {
            entity
                .ToTable("Shipments");

            entity
                .HasKey(s => s.Id);

            entity
                .Property(s => s.Carrier)
                .HasMaxLength(50);

            entity
                .Property(s => s.TrackingNumber)
                .HasMaxLength(80);
        }
    }
}
