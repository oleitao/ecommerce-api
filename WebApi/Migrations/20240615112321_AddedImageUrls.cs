using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e57c3d42-d92c-4afa-9043-08467bf3d25f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f22ff3b9-6982-489e-aa7c-b492ccfa8619");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6bb581e0-a15e-40c1-97f7-6b6e9f924474");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8000f409-2f8a-4793-ad6f-e85b3dc30c3b", null, "Manager", "MANAGER" },
                    { "a09613cf-912e-4d79-9ad9-8af576df368d", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"),
                column: "Public_id",
                value: "test");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "35f00dd4-f487-467b-841b-065da8c01d92", 0, 36, new DateTime(2024, 6, 15, 12, 23, 21, 43, DateTimeKind.Local).AddTicks(4812), "6374376a-3bc5-45ea-8e96-61150b278d9b", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "945ffdfe-f267-481f-843c-f4ac97c2c1a4", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8000f409-2f8a-4793-ad6f-e85b3dc30c3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a09613cf-912e-4d79-9ad9-8af576df368d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35f00dd4-f487-467b-841b-065da8c01d92");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e57c3d42-d92c-4afa-9043-08467bf3d25f", null, "Administrator", "ADMINISTRATOR" },
                    { "f22ff3b9-6982-489e-aa7c-b492ccfa8619", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"),
                column: "Public_id",
                value: null);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bb581e0-a15e-40c1-97f7-6b6e9f924474", 0, 36, new DateTime(2024, 6, 15, 12, 22, 51, 313, DateTimeKind.Local).AddTicks(2340), "84b30b3e-cd67-4b44-8b4c-802e48511060", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ac5f6fa4-eabf-43c2-bd81-5a16def7b3e9", false, null });
        }
    }
}
