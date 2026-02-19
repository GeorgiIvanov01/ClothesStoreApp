using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> entity)
        {
            entity
                .ToTable("Payments");

            entity
                .HasKey(p => p.Id);

            entity
                .Property(p => p.AccountNumber)
                .HasMaxLength(18)
                .IsRequired();

            entity
                .Property(p => p.Cvv)
                .HasMaxLength(4)
                .IsRequired();

            entity
                .Property(p => p.Amount)
                .HasPrecision(18, 2);
        }
    }
}
