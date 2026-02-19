namespace ClothesStoreApp.Data.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        // UnitPrice * Quantity
        public decimal LineTotal { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
