using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity
                .ToTable("Addresses");

            entity
                .HasKey(a => a.Id);

            entity
                .Property(a => a.Line1)
                .HasMaxLength(200)
                .IsRequired();

            entity
                .Property(a => a.Line2)
                .HasMaxLength(200);

            entity.
                Property(a => a.City)
                .HasMaxLength(100)
                .IsRequired();

            entity
                .Property(a => a.PostalCode)
                .HasMaxLength(30)
                .IsRequired();

            entity
                .Property(a => a.Country)
                .HasMaxLength(100)
                .IsRequired();

            // make shure we have one address per customer
            entity
                .HasIndex(a => a.CustomerId)
                .IsUnique();
        }
    }
}
