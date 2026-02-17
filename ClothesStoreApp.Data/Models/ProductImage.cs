namespace ClothesStoreApp.Data.Models
{
    public class ProductImage
    {
        public int Id { get; set; }

        // Image path or URL
        public string Url { get; set; } = null!;

        // Mark one image as primary
        public bool IsPrimary { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
