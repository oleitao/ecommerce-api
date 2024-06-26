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
                keyValue: "4dc23665-7f36-4f2a-a816-792724d9152f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1241de2-7187-475a-890b-328a62bf4340");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10a857e4-b45f-4ebb-93b8-65b43b52e872", null, "Administrator", "ADMINISTRATOR" },
                    { "bb7d4ddd-cf6f-47bb-8faf-5c51fd5bccd7", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image_Url", "SubTitle", "Title" },
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
                values: new object[] { new DateTime(2024, 6, 24, 12, 1, 25, 844, DateTimeKind.Local).AddTicks(4970), "4d647084-8c5d-4456-ab54-f4bfe486bced", "57a23367-b2e3-4c57-b996-32ce6b709061" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10a857e4-b45f-4ebb-93b8-65b43b52e872");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb7d4ddd-cf6f-47bb-8faf-5c51fd5bccd7");

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
                    { "4dc23665-7f36-4f2a-a816-792724d9152f", null, "Administrator", "ADMINISTRATOR" },
                    { "d1241de2-7187-475a-890b-328a62bf4340", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 24, 11, 59, 38, 839, DateTimeKind.Local).AddTicks(4150), "431c073a-fa73-4a30-a2da-cb71ece1121e", "075b9c58-d296-40f1-9d2b-0b6087ed7d70" });
        }
    }
}
