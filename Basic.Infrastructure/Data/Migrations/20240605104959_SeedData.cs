using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Basic.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "FoodName", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "PersianFood", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "an iranian food with rice", "Ghormesabzi", 5.5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, "PersianFood", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A delicious iranian food", "Kebab", 8.25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, "AmericanFood", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MacDonalds", "Burger", 13.65m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, "AmericanFood", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "T-Bon steak with mushrooms and vegetables", "Steak", 28.75m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, "Appetizer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Starter", "Chiken Soup", 3.35m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, "Appetizer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "persian Appetizer", "Ash", 3.35m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, "Salad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad with Chiken and olives", "SezarSalad", 4.85m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, "Salad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad with cucumber and tomato and onion", "Shirazi Salad", 2.25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9L, "Drinks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CocaCola", "Coca", 1.25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10L, "Drinks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprites", "lemon sprite", 1.25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
