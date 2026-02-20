using ClothesStoreApp.Data.Models;
using System.Text.Json;

namespace ClothesStoreApp.Data.Utilities
{
    public static class DataProcessor
    {
        public static async Task ImportCategories(ClothesStoreDbContext context)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Files", "categories.seed.json");
            string categoriesStr = await File.ReadAllTextAsync(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var categories = JsonSerializer.Deserialize<List<Category>>(categoriesStr, options);

            if(categories != null && categories.Count > 0)
            {
                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();
            }
        }

        public static async Task ImportProducts(ClothesStoreDbContext context)
        {
            throw new NotImplementedException();
        }

        public static async Task ImportImages(ClothesStoreDbContext context)
        {
            throw new NotImplementedException();
        }
    }
}
