using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P04Sklep.API.Migrations
{
    /// <inheritdoc />
    public partial class seedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Description", "ImageUrl", "Title" },
                values: new object[] { "cyan", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=299964152", "Licensed Wooden Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description", "ImageUrl", "Title" },
                values: new object[] { "turquoise", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=2123807840", "Sleek Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Description", "ImageUrl", "Title" },
                values: new object[] { "tan", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "https://loremflickr.com/320/240?lock=160184147", "Sleek Granite Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "ImageUrl", "Title" },
                values: new object[] { "teal", "https://loremflickr.com/320/240?lock=607508437", "Ergonomic Fresh Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "ImageUrl", "Title" },
                values: new object[] { "orange", "https://loremflickr.com/320/240?lock=1073771022", "Handcrafted Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Description", "ImageUrl", "Title" },
                values: new object[] { "salmon", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=1313793306", "Small Cotton Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Description", "ImageUrl", "Title" },
                values: new object[] { "purple", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=783199101", "Fantastic Plastic Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "ImageUrl", "Title" },
                values: new object[] { "magenta", "https://loremflickr.com/320/240?lock=388427480", "Unbranded Concrete Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Description", "ImageUrl", "Title" },
                values: new object[] { "ivory", "The Football Is Good For Training And Recreational Purposes", "https://loremflickr.com/320/240?lock=1693823615", "Gorgeous Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Description", "ImageUrl", "Title" },
                values: new object[] { "blue", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=1289193751", "Incredible Cotton Chips" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Description", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "azure", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://loremflickr.com/320/240?lock=106293148", "", "Licensed Wooden Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "yellow", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "https://loremflickr.com/320/240?lock=1711689223", "", "Licensed Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Description", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "maroon", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=955482810", "", "Awesome Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "indigo", "https://loremflickr.com/320/240?lock=458770467", "", "Intelligent Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "blue", "https://loremflickr.com/320/240?lock=832141007", "", "Ergonomic Granite Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Description", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "black", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=438118805", "", "Awesome Steel Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Description", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "orange", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=516658653", "", "Fantastic Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "turquoise", "https://loremflickr.com/320/240?lock=1518231260", "", "Fantastic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Description", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "turquoise", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=484265138", "", "Incredible Metal Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Description", "ImageUrl", "ImageUrl2", "Title" },
                values: new object[] { "white", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=1432859347", "", "Handcrafted Fresh Shirt" });
        }
    }
}
