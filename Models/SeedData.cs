using GTW_App.Data;
using Microsoft.EntityFrameworkCore;

namespace GTW_App.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new GtwDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GtwDbContext>>());
            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "First Product",
                    Category = "Category 1",
                    Description = "This is a description of the first product",
                    Image = "images/product_1.jpg"
                },

                new Product
                {
                    Name = "Second Product",
                    Category = "Category 2",
                    Description = "This is a description of the second product",
                    Image = "images/product_2.jpg"
                },

                new Product
                {
                    Name = "Third Product",
                    Category = "Category 3",
                    Description = "This is a description of the third product",
                    Image = "images/product_3.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}
