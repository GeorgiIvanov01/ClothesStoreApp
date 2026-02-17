namespace ClothesStoreApp.Data.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        // UnitPrice * Quantity
        public decimal LineTotal { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        // Product snapshot reference
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
