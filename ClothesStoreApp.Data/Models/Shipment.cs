namespace ClothesStoreApp.Data.Models
{
    public class Shipment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public string? Carrier { get; set; }
        public string? TrackingNumber { get; set; }

        public DateTime? TimeShipped { get; set; }
        public DateTime? TimeDelivered { get; set; }
    }
}
