namespace ClothesStoreApp.Data.Models
{
    public class ProductImage
    {
        public Guid Id { get; set; }

        // image path
        public string Url { get; set; } = null!;

        // mark one image as primary
        public bool IsPrimary { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
