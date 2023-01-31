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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 21, "tan", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=1090134570", "Tasty Rubber Bacon" },
                    { 22, "turquoise", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://loremflickr.com/320/240?lock=2630685", "Practical Soft Ball" },
                    { 23, "cyan", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://loremflickr.com/320/240?lock=363444386", "Awesome Metal Soap" },
                    { 24, "indigo", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://loremflickr.com/320/240?lock=47437810", "Handcrafted Cotton Soap" },
                    { 25, "cyan", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=853249890", "Intelligent Metal Ball" },
                    { 26, "purple", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://loremflickr.com/320/240?lock=1472453055", "Fantastic Frozen Bike" },
                    { 27, "magenta", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=1032651746", "Sleek Steel Salad" },
                    { 28, "plum", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://loremflickr.com/320/240?lock=1011612411", "Ergonomic Metal Shoes" },
                    { 29, "mint green", "The Football Is Good For Training And Recreational Purposes", "https://loremflickr.com/320/240?lock=1443680306", "Handcrafted Soft Car" },
                    { 30, "orange", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=488923307", "Unbranded Metal Cheese" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "Title" },
                values: new object[,]
                {
                    { 11, "black", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Granite Fish" },
                    { 12, "teal", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Fresh Chips" },
                    { 13, "silver", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Soft Chips" },
                    { 14, "ivory", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Wooden Chips" },
                    { 15, "violet", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Metal Gloves" },
                    { 16, "fuchsia", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Soft Soap" },
                    { 17, "yellow", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Fresh Bacon" },
                    { 18, "azure", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Intelligent Rubber Chips" },
                    { 19, "lavender", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Soft Bike" },
                    { 20, "ivory", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Rubber Soap" }
                });
        }
    }
}
