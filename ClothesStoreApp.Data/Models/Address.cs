namespace ClothesStoreApp.Data.Models
{
    public class Address
    {
        public Guid Id { get; set; }

        public string Line1 { get; set; } = null!;
        public string? Line2 { get; set; }
        public string City { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string Country { get; set; } = null!;

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
