using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothesStoreApp.Data
{
    public class ClothesStoreDbContext : IdentityDbContext
    {
        public ClothesStoreDbContext(DbContextOptions<ClothesStoreDbContext> options)
            : base(options)
        {
        }
    }
}
