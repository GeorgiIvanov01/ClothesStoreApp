namespace ClothesStoreApp.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        // Product name
        public string Name { get; set; } = null!;

        // Optional description text
        public string? Description { get; set; }

        // Brand is required
        public string Brand { get; set; } = null!;

        public string Color { get; set; } = null!;
        public string Size { get; set; } = null!;

        // Current price
        public decimal Price { get; set; }

        // inventory
        public int StockQuantity { get; set; }

        // category relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        // Images for this product
        public ICollection<ProductImage> Images { get; set; }
           = new List<ProductImage>();

        // Navigation (used by CartItem / OrderItem)
        public ICollection<CartItem> CartItems { get; set; } 
            = new List<CartItem>();

        public ICollection<OrderItem> OrderItems { get; set; }
            = new List<OrderItem>();
    }
}
