using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04Sklep.API.Migrations
{
    /// <inheritdoc />
    public partial class seedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "Title" },
                values: new object[,]
                {
                    { 11, "orange", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Practical Fresh Sausages" },
                    { 12, "gold", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Soft Bike" },
                    { 13, "orchid", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Plastic Gloves" },
                    { 14, "orange", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Rubber Gloves" },
                    { 15, "blue", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Rubber Shoes" },
                    { 16, "orchid", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Small Cotton Cheese" },
                    { 17, "fuchsia", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Plastic Shirt" },
                    { 18, "yellow", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Frozen Towels" },
                    { 19, "white", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Granite Fish" },
                    { 20, "maroon", "The Football Is Good For Training And Recreational Purposes", "Intelligent Metal Table" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
