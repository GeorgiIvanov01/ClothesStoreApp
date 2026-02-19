namespace ClothesStoreApp.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Brand { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Size { get; set; } = null!;
        public decimal Price { get; set; }

        // inventory
        public int StockQuantity { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // images for this product
        public ICollection<ProductImage> Images { get; set; }
           = new List<ProductImage>();

        public ICollection<CartItem> CartItems { get; set; } 
            = new List<CartItem>();

        public ICollection<OrderItem> OrderItems { get; set; }
            = new List<OrderItem>();
    }
}
