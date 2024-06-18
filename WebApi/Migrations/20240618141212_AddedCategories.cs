using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38e49853-8edb-4261-b946-e7794ca997a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9524c45e-37f1-466d-a605-5e516d3c4caf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38c88648-151f-4ccd-abe0-777682699b45", null, "Administrator", "ADMINISTRATOR" },
                    { "6c565480-efe2-4d62-bc6c-1308f227f2b3", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 12, 11, 433, DateTimeKind.Local).AddTicks(2322), "6b7bd0f5-5126-4965-90b9-3b9ec517e524", "3d7b1de6-200d-42db-acdb-54c3d6526afb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38c88648-151f-4ccd-abe0-777682699b45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c565480-efe2-4d62-bc6c-1308f227f2b3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38e49853-8edb-4261-b946-e7794ca997a4", null, "Manager", "MANAGER" },
                    { "9524c45e-37f1-466d-a605-5e516d3c4caf", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 11, 41, 610, DateTimeKind.Local).AddTicks(5938), "5c788d5c-b6b4-45a4-bf72-7e4462025e61", "ac0a5d24-0552-43d9-88a5-f72d69f36c5c" });
        }
    }
}
