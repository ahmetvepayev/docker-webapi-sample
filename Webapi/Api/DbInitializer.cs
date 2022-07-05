using DockerWebApiTest.Data;
using Microsoft.EntityFrameworkCore;

public static class DbInitializer
{
    public static void InitializeDb(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            using(var context = services.GetRequiredService<AppDbContext>())
            {
                context.Database.EnsureDeleted();
                context.Database.Migrate();
                
                context.Products.AddRange(
                    new Product()
                    {
                        //Id = 1,
                        Name = "Soap",
                        Price = 5,
                    },
                    new Product()
                    {
                        //Id = 2,
                        Name = "Detergent",
                        Price = 30,
                    },
                    new Product()
                    {
                        //Id = 3,
                        Name = "Milk",
                        Price = 20,
                    }
                );

                context.SaveChanges();
            }
        }
    }
}