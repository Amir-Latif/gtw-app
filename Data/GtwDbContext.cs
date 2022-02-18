using GTW_App.Models;
using Microsoft.EntityFrameworkCore;

namespace GTW_App.Data
{
    public class GtwDbContext : DbContext
    {
        public GtwDbContext(DbContextOptions<GtwDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
