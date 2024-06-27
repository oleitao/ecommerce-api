using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dd37cce-4138-4baa-939e-edeed0d77dfb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e86cc8f-2350-428c-9337-ffdbd93e66cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3daae705-2ae2-45be-af23-e380c5489e14", null, "Manager", "MANAGER" },
                    { "e0e90d29-a6fb-4774-b597-9004eef275be", null, "Administrator", "ADMINISTRATOR" }
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
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId", "UserId1" },
                values: new object[] { new Guid("2913f590-3edc-47b8-acfb-2489c2afa74f"), "comment", new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), 5, new Guid("efbcf454-0125-41ff-ac91-75d1564af044"), null });

            migrationBuilder.UpdateData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"),
                column: "Public_id",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 24, 12, 5, 9, 72, DateTimeKind.Local).AddTicks(1048), "d5537b58-9487-4e5c-9f1a-f8713a918fd8", "a4f471f7-36e5-4403-8726-ba3733ba60d1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3daae705-2ae2-45be-af23-e380c5489e14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0e90d29-a6fb-4774-b597-9004eef275be");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("2913f590-3edc-47b8-acfb-2489c2afa74f"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4dd37cce-4138-4baa-939e-edeed0d77dfb", null, "Manager", "MANAGER" },
                    { "8e86cc8f-2350-428c-9337-ffdbd93e66cf", null, "Administrator", "ADMINISTRATOR" }
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
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"),
                column: "Public_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 24, 12, 4, 21, 993, DateTimeKind.Local).AddTicks(6293), "7d913c6d-8f5e-42ab-80dd-6ddc58ba66c7", "5811f4a6-35a0-4f29-896b-dd3ac88f239a" });
        }
    }
}
