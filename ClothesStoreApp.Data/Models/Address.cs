namespace ClothesStoreApp.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Line1 { get; set; } = null!;
        public string? Line2 { get; set; }
        public string City { get; set; } = null!;
        public string? State { get; set; }
        public string PostalCode { get; set; } = null!;
        public string Country { get; set; } = null!;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
