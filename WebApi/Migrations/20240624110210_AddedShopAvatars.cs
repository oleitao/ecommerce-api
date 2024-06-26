using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedShopAvatars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10a857e4-b45f-4ebb-93b8-65b43b52e872");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb7d4ddd-cf6f-47bb-8faf-5c51fd5bccd7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "86d6752b-e0af-4883-a011-375a7cde2979", null, "Manager", "MANAGER" },
                    { "96651a24-03de-4869-bce6-095eac02a8cb", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"),
                column: "Image_Url",
                value: "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"),
                column: "Image_Url",
                value: "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png");

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "Public_id", "Url" },
                values: new object[] { new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"), "test", "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 24, 12, 2, 9, 981, DateTimeKind.Local).AddTicks(9560), "5233c29b-0f96-4f54-a340-7cd5dafc83a9", "818048f0-0f13-4997-ba0e-3052bf97af95" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86d6752b-e0af-4883-a011-375a7cde2979");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96651a24-03de-4869-bce6-095eac02a8cb");

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10a857e4-b45f-4ebb-93b8-65b43b52e872", null, "Administrator", "ADMINISTRATOR" },
                    { "bb7d4ddd-cf6f-47bb-8faf-5c51fd5bccd7", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"),
                column: "Image_Url",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"),
                column: "Image_Url",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 24, 12, 1, 25, 844, DateTimeKind.Local).AddTicks(4970), "4d647084-8c5d-4456-ab54-f4bfe486bced", "57a23367-b2e3-4c57-b996-32ce6b709061" });
        }
    }
}
