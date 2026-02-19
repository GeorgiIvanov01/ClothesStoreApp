namespace ClothesStoreApp.Data.Models
{
    public class Shipment
    {
        public Guid Id { get; set; }

        public string? Carrier { get; set; }
        public string? TrackingNumber { get; set; }

        public DateTime? TimeShipped { get; set; }
        public DateTime? TimeDelivered { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
