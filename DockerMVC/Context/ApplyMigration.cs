using DockerMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerMVC.Context;

public static class ApplyMigration
{
    public static void PopulateDatabase(IApplicationBuilder app)
    {
        PopulateDatabase(app.ApplicationServices.GetRequiredService<DatabaseContext>());
    }

    private static void PopulateDatabase(DatabaseContext context)
    {
        context.Database.Migrate();

        if (!context.Produtos.Any())
        {
            context.Produtos.AddRange(
                new Produto(new Random().Next(), "Iphone 11", "Smartphones", 3800.0),
                new Produto(new Random().Next(), "Iphone 12", "Smartphones", 4800.0),
                new Produto(new Random().Next(), "Iphone 13", "Smartphones", 5800.0),
                new Produto(new Random().Next(), "Macbook Air M1", "Notebooks", 5800.0),
                new Produto(new Random().Next(), "Ipad Pro", "Tablet", 7800.0),
                new Produto(new Random().Next(), "Apple Watch", "Wearables", 3200.0)
            );
            context.SaveChanges();
        }
        else
        {
            System.Console.WriteLine("Database already has data!");
        }
    }
}