using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class Fix6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("b1b34c78-ddda-4659-81be-975aa9019174"), false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "Cost", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3ce707f5-b77e-459f-849e-390cca47a0dd"), null, 1000, "Белая корова", "Корова" },
                    { new Guid("a1747698-7a56-4c6b-8bdc-c3506e62e06e"), null, 100, "Белый хлеб", "Хлеб" },
                    { new Guid("f8837dba-5e8e-4c66-a035-11a4db797cdf"), null, 250, "Коровье", "Молоко" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: new Guid("b1b34c78-ddda-4659-81be-975aa9019174"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ce707f5-b77e-459f-849e-390cca47a0dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1747698-7a56-4c6b-8bdc-c3506e62e06e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8837dba-5e8e-4c66-a035-11a4db797cdf"));

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
    }
}
