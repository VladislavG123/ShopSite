using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class Fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("77408561-2fb3-43fe-8147-e5ca7ad020e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("208f1acd-499e-4e97-bd54-bfc1161b7f2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba8bce03-7ddd-4d5e-934e-064a6ea1a6ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c62eaf90-ad58-4c40-9e64-bc3cb93a6da1"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("77408561-2fb3-43fe-8147-e5ca7ad020e9"), false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ba8bce03-7ddd-4d5e-934e-064a6ea1a6ec"), null, 1000, "Белая корова", "Корова" },
                    { new Guid("c62eaf90-ad58-4c40-9e64-bc3cb93a6da1"), null, 100, "Белый хлеб", "Хлеб" },
                    { new Guid("208f1acd-499e-4e97-bd54-bfc1161b7f2d"), null, 250, "Коровье", "Молоко" }
                });
        }
    }
}
