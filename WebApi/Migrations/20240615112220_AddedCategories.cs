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
                keyValue: "65313372-81fb-4fba-9cfb-6aca4fe60be8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7d9a3b6-f287-4fd8-b533-ef96341dec1e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "424d410e-29a3-48b0-b5fd-3ce93a80bea9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ec22d75-3ee3-4d82-a92b-ab5404380efc", null, "Manager", "MANAGER" },
                    { "85737be0-5e3e-42ae-9497-270c11af84b0", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "88925595-183f-48a0-baf3-257a2e008f72", 0, 36, new DateTime(2024, 6, 15, 12, 22, 20, 92, DateTimeKind.Local).AddTicks(9478), "03697bc1-83b0-43ad-9d5f-289244898075", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "06872177-c3c7-4234-87c7-50699879f77e", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ec22d75-3ee3-4d82-a92b-ab5404380efc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85737be0-5e3e-42ae-9497-270c11af84b0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "88925595-183f-48a0-baf3-257a2e008f72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65313372-81fb-4fba-9cfb-6aca4fe60be8", null, "Manager", "MANAGER" },
                    { "a7d9a3b6-f287-4fd8-b533-ef96341dec1e", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "424d410e-29a3-48b0-b5fd-3ce93a80bea9", 0, 36, new DateTime(2024, 6, 15, 12, 21, 55, 646, DateTimeKind.Local).AddTicks(2493), "f915ef7c-d3a4-4bf5-8dba-0c21499f9c00", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f372fccf-ab79-4e90-bfd5-c45fa0e1a114", false, null });
        }
    }
}
