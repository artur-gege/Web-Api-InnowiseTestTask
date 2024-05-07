using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WEB_API_Innowise_TestTask.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FridgeModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FridgeModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fridges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FridgeModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fridges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FridgesProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FridgeId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FridgesProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FridgeModels",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Samsung RF28R7551SR", 2020 },
                    { 2, "LG LFXS28968S", 2021 },
                    { 3, "ATLANT GNE29GMHES", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "Id", "FridgeModelId", "Name", "OwnerName" },
                values: new object[,]
                {
                    { 1, 1, "Kitchen Fridge", "John Doe" },
                    { 2, 2, "Cellar Fridge", "Jane Smith" },
                    { 3, 3, "Garage Fridge", "Bob Johnson" }
                });

            migrationBuilder.InsertData(
                table: "FridgesProducts",
                columns: new[] { "Id", "FridgeId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 5 },
                    { 2, 1, 2, 3 },
                    { 3, 1, 3, 10 },
                    { 4, 1, 4, 2 },
                    { 5, 1, 5, 6 },
                    { 6, 2, 6, 12 },
                    { 7, 2, 7, 8 },
                    { 8, 2, 8, 4 },
                    { 9, 2, 9, 3 },
                    { 10, 3, 10, 15 },
                    { 11, 3, 11, 10 },
                    { 12, 3, 12, 7 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Apple", 1.99 },
                    { 2, "Orange", 2.9900000000000002 },
                    { 3, "Banana", 0.98999999999999999 },
                    { 4, "Carrot", 0.79000000000000004 },
                    { 5, "Onion", 0.68999999999999995 },
                    { 6, "Potato", 0.48999999999999999 },
                    { 7, "Egg", 0.28999999999999998 },
                    { 8, "Milk", 3.9900000000000002 },
                    { 9, "Cheese", 4.9900000000000002 },
                    { 10, "Chicken", 6.9900000000000002 },
                    { 11, "Beef", 7.9900000000000002 },
                    { 12, "Pork", 5.9900000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FridgeModels");

            migrationBuilder.DropTable(
                name: "Fridges");

            migrationBuilder.DropTable(
                name: "FridgesProducts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
