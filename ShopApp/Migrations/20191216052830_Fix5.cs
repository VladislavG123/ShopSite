using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class Fix5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("0342da95-ff87-47a7-a906-9cf5434f193f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("036fa4fd-1f52-4b2d-815f-b6f5f28f8dd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88e6106d-77d4-4e4e-8bdc-f66b8974ce1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f00cac80-ff35-40a2-a773-083f36b6e6df"));

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "HasPaid" },
                values: new object[] { new Guid("f85e0701-72f5-4ebe-ac69-c3b3ea1c3c4c"), false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("069ce878-5036-44ef-82b8-61b57a4280d2"), null, 1000, "Белая корова", "Корова" },
                    { new Guid("7b2fb8a2-a61d-4088-8744-d3acf29d5ba8"), null, 100, "Белый хлеб", "Хлеб" },
                    { new Guid("1d6d387f-9365-405a-b87e-75d0e0bc0258"), null, 250, "Коровье", "Молоко" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("f85e0701-72f5-4ebe-ac69-c3b3ea1c3c4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("069ce878-5036-44ef-82b8-61b57a4280d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d6d387f-9365-405a-b87e-75d0e0bc0258"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b2fb8a2-a61d-4088-8744-d3acf29d5ba8"));

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "HasPaid" },
                values: new object[] { new Guid("0342da95-ff87-47a7-a906-9cf5434f193f"), false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("f00cac80-ff35-40a2-a773-083f36b6e6df"), null, 1000, "Белая корова", "Корова" },
                    { new Guid("036fa4fd-1f52-4b2d-815f-b6f5f28f8dd0"), null, 100, "Белый хлеб", "Хлеб" },
                    { new Guid("88e6106d-77d4-4e4e-8bdc-f66b8974ce1e"), null, 250, "Коровье", "Молоко" }
                });
        }
    }
}
