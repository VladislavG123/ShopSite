using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class Fix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("0dac153d-d1d0-4fa2-8877-c268f472f28b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("446d3b8f-7589-4790-b65f-f4e9b0ce749e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("caca4e74-5667-44e0-9e69-d255ed66fd2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5b2df4f-5144-426f-a96f-639bc93dbc13"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("0dac153d-d1d0-4fa2-8877-c268f472f28b"), false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("f5b2df4f-5144-426f-a96f-639bc93dbc13"), null, 1000, "Белая корова", "Корова" },
                    { new Guid("446d3b8f-7589-4790-b65f-f4e9b0ce749e"), null, 100, "Белый хлеб", "Хлеб" },
                    { new Guid("caca4e74-5667-44e0-9e69-d255ed66fd2a"), null, 250, "Коровье", "Молоко" }
                });
        }
    }
}
