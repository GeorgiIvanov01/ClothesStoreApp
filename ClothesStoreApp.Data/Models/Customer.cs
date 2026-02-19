namespace ClothesStoreApp.Data.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Address Address { get; set; } = null!;

        public Cart? Cart { get; set; }

        public ICollection<Order> Orders { get; set; } 
            = new List<Order>();

        //Customer is also a user of the application, so we need to link it to the ApplicationUser.
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
