namespace ClothesStoreApp.Data.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public List<CartItem> Items { get; set; } = new();
    }
}
