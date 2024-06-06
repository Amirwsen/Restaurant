using Basic.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Basic.Infrastructure.Data;

public static class SeedData2
{
    public static void Seed2(ModelBuilder modelBuilder) //seed Data to database
    {
        modelBuilder.Entity<RMenu>().HasData(
            new RMenu {Id = 1,FoodName = "Ghormesabzi",Description = "an iranian food with rice",Price = 5.5M,Category = "PersianFood"},
            new RMenu {Id = 2,FoodName = "Kebab",Description = "A delicious iranian food",Price = 8.25M,Category = "PersianFood"},
            new RMenu {Id = 3,FoodName = "Burger",Description = "MacDonalds",Price = 13.65M,Category = "AmericanFood"},
            new RMenu {Id = 4,FoodName = "Steak",Description = "T-Bon steak with mushrooms and vegetables",Price = 28.75M,Category = "AmericanFood"},
            new RMenu {Id = 5,FoodName = "Chiken Soup",Description = "Starter",Price = 3.35M,Category = "Appetizer"},
            new RMenu {Id = 6,FoodName = "Ash",Description = "persian Appetizer",Price = 3.35M,Category = "Appetizer"},
            new RMenu {Id = 7,FoodName = "SezarSalad",Description = "Salad with Chiken and olives",Price = 4.85M,Category = "Salad"},
            new RMenu {Id = 8,FoodName = "Shirazi Salad",Description = "Salad with cucumber and tomato and onion",Price = 2.25M,Category = "Salad"},
            new RMenu {Id = 9,FoodName = "Coca",Description = "CocaCola",Price = 1.25M,Category = "Drinks"},
            new RMenu {Id = 10,FoodName = "lemon sprite",Description = "Sprites",Price = 1.25M,Category = "Drinks"}
            );
    }
}  