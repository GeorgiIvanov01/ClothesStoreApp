namespace ClothesStoreApp.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public Address Address { get; set; } = null!;

        public Cart? Cart { get; set; }

        public ICollection<Order> Orders { get; set; } 
            = new List<Order>();
    }
}
