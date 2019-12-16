using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class Fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("9a31104b-cf9b-4716-a01e-36d4053387d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64e3ebc4-948f-427f-8c0c-fef2f8d45786"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b84a6f07-4822-4e81-9e16-fe40317b641a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1b17124-1fd2-44d5-b7df-2f99e2691ef0"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("9a31104b-cf9b-4716-a01e-36d4053387d6"), false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("64e3ebc4-948f-427f-8c0c-fef2f8d45786"), null, 1000, "Белая корова", "Корова" },
                    { new Guid("b84a6f07-4822-4e81-9e16-fe40317b641a"), null, 100, "Белый хлеб", "Хлеб" },
                    { new Guid("c1b17124-1fd2-44d5-b7df-2f99e2691ef0"), null, 250, "Коровье", "Молоко" }
                });
        }
    }
}
