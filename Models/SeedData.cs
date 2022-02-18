using GTW_App.Data;
using Microsoft.EntityFrameworkCore;

namespace GTW_App.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var db = new GtwDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GtwDbContext>>());
            // Look for any products.
            if (db.Products.Any())
            {
                return;   // DB has been seeded
            }

            db.Products.AddRange(
                new Product
                {
                    Name = "المنتج الأول",
                    Category = "تصنيف 1",
                    Description = "هذا هو وصف المنتج الأول",
                    Image = "images/product_1.jpg"
                },

                new Product
                {
                    Name = "المنتج الثاني",
                    Category = "تصنيف 2",
                    Description = "هذا هو وصف المنتج الثاني",
                    Image = "images/product_2.jpg"
                },

                new Product
                {
                    Name = "المنتج الثالث",
                    Category = "تصنيف 3",
                    Description = "هذا هو وصف المنتج الثالث",
                    Image = "images/product_3.jpg"
                }
            );
            db.SaveChanges();
        }
    }
}
