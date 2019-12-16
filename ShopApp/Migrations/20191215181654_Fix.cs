using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("61da7ca3-fba0-4f5b-9fdd-91216f4a4b42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1aafe5e9-e8ab-4713-b9b0-c4296ed97ae0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df3c97c0-eaca-4714-a6dc-40cc7f710104"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed1345fe-f338-491a-be9c-39e0ae7aa740"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("61da7ca3-fba0-4f5b-9fdd-91216f4a4b42"), false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1aafe5e9-e8ab-4713-b9b0-c4296ed97ae0"), null, 1000, "Белая корова", "Корова" },
                    { new Guid("df3c97c0-eaca-4714-a6dc-40cc7f710104"), null, 100, "Белый хлеб", "Хлеб" },
                    { new Guid("ed1345fe-f338-491a-be9c-39e0ae7aa740"), null, 250, "Коровье", "Молоко" }
                });
        }
    }
}
