using ClothesStoreApp.Data.Configurations;
using ClothesStoreApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothesStoreApp.Data
{
    public class ClothesStoreDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ClothesStoreDbContext()
        {

        }

        public ClothesStoreDbContext(DbContextOptions<ClothesStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder
                .ApplyConfiguration(new CategoryConfiguration());

            modelBuilder 
                .ApplyConfiguration(new ProductConfiguration());

            modelBuilder 
                .ApplyConfiguration(new ProductImageConfiguration());

            modelBuilder 
                .ApplyConfiguration(new CustomerConfiguration());

            modelBuilder 
                .ApplyConfiguration(new AddressConfiguration());

            modelBuilder 
                .ApplyConfiguration(new CartConfiguration());

            modelBuilder 
                .ApplyConfiguration(new CartItemConfiguration());

            modelBuilder 
                .ApplyConfiguration(new OrderConfiguration());

            modelBuilder 
                .ApplyConfiguration(new OrderItemConfiguration());

            modelBuilder 
                .ApplyConfiguration(new PaymentConfiguration());

            modelBuilder 
                .ApplyConfiguration(new ShipmentConfiguration());
        }
    }
}
