using Basic.Core.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Basic.Infrastructure.Data;

public class SeedData
{
    public static void EnsurePopulated(IApplicationBuilder app)
    {
        BasicDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<BasicDbContext>();
        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }

        if (!context.Menus.Any())
        {
         context.Menus.AddRange(
             new RMenu
             {
              FoodName   = "Pizza",Price = 9.45M,
              Description = "An italian Food",Category = "FastFood"
             },             new RMenu
             {
                 FoodName   = "Burger",Price = 5,
                 Description = "An American Food",Category = "FastFood"
             },             new RMenu
             {
                 FoodName   = "Soup",Price = 2.25M,
                 Description = "a primarily liquid food",Category = "Appetizer"
             },             new RMenu
             {
                 FoodName   = "Sezar Salad",Price = 6.75M,
                 Description = "An italian Appetizer",Category = "Appetizer"
             },             new RMenu
             {
                 FoodName   = "Kebab",Price = 15.5M,
                 Description = "A Persian Food",Category = "PersianFood"
             },             new RMenu
             {
                 FoodName   = "Koko",Price = 25,
                 Description = "A Persian Food",Category = "PersianFood"
             },             new RMenu
             {
                 FoodName   = "Coke",Price = 1.25M,
                 Description = "Cocacola",Category = "Drinks"
             },             new RMenu
             {
                 FoodName   = "Sprite",Price = 1.25M,
                 Description = "Sprite Drink",Category = "Drinks"
             },             new RMenu
             {
                 FoodName   = "Deep Goda",Price = 0.75M,
                 Description = "Goda deep",Category = "Sauce"
             },             new RMenu
             {
                 FoodName   = "Mossarella",Price = 0.75M,
                 Description = "Italian Cheese",Category = "Sauce"
             }
             );
             context.SaveChanges();
        }
    }
}