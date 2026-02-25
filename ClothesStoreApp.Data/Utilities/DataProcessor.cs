using ClothesStoreApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

//Uncomment the methods to import the seed data into the database.
//Do the same for the Program.cs file.
namespace ClothesStoreApp.Data.Utilities
{
    public  class DataProcessor
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

        public static void SeedUsers(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            SeedUser(userManager, "admin@example.com", "Admin@123", "Admin");
            SeedUser(userManager, "appManager@example.com", "Manager@123", "Manager");
            SeedUser(userManager, "appUser@example.com", "User@123", "User");
        }

        public static void SeedRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            string[] roles = { "Admin", "Manager", "User" };

            foreach (var role in roles)
            {
                var roleExists = roleManager.RoleExistsAsync(role).GetAwaiter().GetResult();
                if (!roleExists)
                {
                    var result = roleManager.CreateAsync(new IdentityRole<Guid>(role)).GetAwaiter().GetResult();
                    if (!result.Succeeded)
                    {
                        throw new Exception($"Failed to create role: {role}");
                    }
                }
            }
        }


        private static void SeedUser(UserManager<ApplicationUser> userManager, string email, string password, string role)
        {
            var user = userManager.FindByEmailAsync(email).GetAwaiter().GetResult();
            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = email,
                    Email = email
                };
                var createUserResult = userManager.CreateAsync(user, password).GetAwaiter().GetResult();
                if (!createUserResult.Succeeded)
                {
                    throw new Exception($"Failed to create user: {email}");
                }
            }

            var isInRole = userManager.IsInRoleAsync(user, role).GetAwaiter().GetResult();
            if (!isInRole)
            {
                var addRoleResult = userManager.AddToRoleAsync(user, role).GetAwaiter().GetResult();
                if (!addRoleResult.Succeeded)
                {
                    throw new Exception($"Failed to assign {role} role to user: {email}");
                }
            }
        }

    }
}
