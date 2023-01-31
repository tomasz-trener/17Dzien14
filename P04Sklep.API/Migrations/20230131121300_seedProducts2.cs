using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04Sklep.API.Migrations
{
    /// <inheritdoc />
    public partial class seedProducts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 31, "maroon", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://loremflickr.com/320/240?lock=1169386606", "Practical Soft Tuna" },
                    { 32, "azure", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "https://loremflickr.com/320/240?lock=143765656", "Incredible Granite Chair" },
                    { 33, "purple", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=1838222584", "Awesome Fresh Fish" },
                    { 34, "turquoise", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=131869673", "Intelligent Wooden Computer" },
                    { 35, "black", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://loremflickr.com/320/240?lock=49825613", "Incredible Frozen Car" },
                    { 36, "salmon", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=1353590140", "Generic Cotton Cheese" },
                    { 37, "pink", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://loremflickr.com/320/240?lock=1137660981", "Fantastic Plastic Shoes" },
                    { 38, "silver", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=2036824952", "Practical Metal Shoes" },
                    { 39, "lavender", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://loremflickr.com/320/240?lock=2061613799", "Rustic Soft Shoes" },
                    { 40, "orange", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "https://loremflickr.com/320/240?lock=256177860", "Intelligent Concrete Sausages" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "cyan", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=299964152", "Licensed Wooden Shoes" },
                    { 2, "turquoise", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=2123807840", "Sleek Concrete Tuna" },
                    { 3, "tan", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://loremflickr.com/320/240?lock=160184147", "Sleek Granite Table" },
                    { 4, "teal", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=607508437", "Ergonomic Fresh Cheese" },
                    { 5, "orange", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=1073771022", "Handcrafted Metal Computer" },
                    { 6, "salmon", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=1313793306", "Small Cotton Hat" },
                    { 7, "purple", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=783199101", "Fantastic Plastic Pants" },
                    { 8, "magenta", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://loremflickr.com/320/240?lock=388427480", "Unbranded Concrete Hat" },
                    { 9, "ivory", "The Football Is Good For Training And Recreational Purposes", "https://loremflickr.com/320/240?lock=1693823615", "Gorgeous Frozen Chair" },
                    { 10, "blue", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=1289193751", "Incredible Cotton Chips" }
                });
        }
    }
}
