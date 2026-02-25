using ClothesStoreApp.Data.Models;
using System.Text.Json;

//Uncomment the methods to import the seed data into the database.
//Do the same for the Program.cs file.
namespace ClothesStoreApp.Data.Utilities
{
    public static class DataProcessor
    {
        //public static async Task ImportCategories(ClothesStoreDbContext context)
        //{
        //    string path = Path.Combine(AppContext.BaseDirectory, "Files", "categories.seed.json");
        //    string categoriesStr = await File.ReadAllTextAsync(path);

        //    var options = new JsonSerializerOptions
        //    {
        //        PropertyNameCaseInsensitive = true
        //    };

        //    var categories = JsonSerializer.Deserialize<List<Category>>(categoriesStr, options);

        //    if (categories != null && categories.Count > 0)
        //    {
        //        await context.Categories.AddRangeAsync(categories);
        //        await context.SaveChangesAsync();
        //    }
        //}

        //public static async Task ImportProducts(ClothesStoreDbContext context)
        //{
        //    string path = Path.Combine(AppContext.BaseDirectory, "Files", "products.seed.json");
        //    string productsStr = await File.ReadAllTextAsync(path);

        //    var options = new JsonSerializerOptions
        //    {
        //        PropertyNameCaseInsensitive = true
        //    };

        //    var products = JsonSerializer.Deserialize<List<Product>>(productsStr, options);

        //    if (products != null && products.Count > 0)
        //    {
        //        await context.Products.AddRangeAsync(products);
        //        await context.SaveChangesAsync();
        //    }
        //}

        //public static async Task ImportImages(ClothesStoreDbContext context)
        //{
        //    string path = Path.Combine(AppContext.BaseDirectory, "Files", "productImages.seed.json");
        //    string imagesStr = await File.ReadAllTextAsync(path);

        //    var options = new JsonSerializerOptions
        //    {
        //        PropertyNameCaseInsensitive = true
        //    };

        //    var images = JsonSerializer.Deserialize<List<ProductImage>>(imagesStr, options);

        //    if (images != null && images.Count > 0)
        //    {
        //        await context.ProductImages.AddRangeAsync(images);
        //        await context.SaveChangesAsync();
        //    }
        //}
    }
}
