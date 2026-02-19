using ClothesStoreApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothesStoreApp.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity
                .ToTable("Categories");

            entity
                .HasKey(c => c.Id);

            entity
                .Property(c => c.Name)
                .HasMaxLength(120)
                .IsRequired();
        }
    }
}
