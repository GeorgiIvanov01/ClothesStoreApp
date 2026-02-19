using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity
                .ToTable("Customers");

            entity
                .HasKey(c => c.Id);

            entity
                .HasOne(c => c.User)
                .WithOne(u => u.Customer)
                .HasForeignKey<Customer>(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .Property(c => c.Email)
                .HasMaxLength(256)
                .IsRequired();

            entity
                .Property(c => c.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            entity
                .Property(c => c.LastName)
                .HasMaxLength(100)
                .IsRequired();

            // one to one relationship between Address and Customer
            entity
                .HasOne(c => c.Address)
                .WithOne(a => a.Customer)
                .HasForeignKey<Address>(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            // one to one relationship between Cart and Customer
            entity
                .HasOne(c => c.Cart)
                .WithOne(cart => cart.Customer)
                .HasForeignKey<Cart>(cart => cart.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
