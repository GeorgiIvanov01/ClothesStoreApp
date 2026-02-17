using ClothesStoreApp.Data.Enums;

namespace ClothesStoreApp.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime TimeCreated { get; set; } = DateTime.UtcNow;

        public OrderStatus Status { get; set; } = OrderStatus.Pending;


        // Shipping address at checkout time
        public string ShipToLine1 { get; set; } = null!;
        public string? ShipToLine2 { get; set; }
        public string ShipToCity { get; set; } = null!;
        public string? ShipToState { get; set; }
        public string ShipToPostalCode { get; set; } = null!;
        public string ShipToCountry { get; set; } = null!;

    
        public decimal Subtotal { get; set; }

        // DiscountTotal = discounts applied (if any)
        public decimal DiscountTotal { get; set; }

        // ShippingTotal = shipping cost
        public decimal ShippingTotal { get; set; }

        // GrandTotal = Subtotal - DiscountTotal + ShippingTotal
        public decimal GrandTotal { get; set; }


        public Payment? Payment { get; set; }
        public Shipment? Shipment { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public ICollection<OrderItem> Items { get; set; }
            = new List<OrderItem>();
    }
}
