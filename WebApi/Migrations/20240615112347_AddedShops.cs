using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedShops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "8ade8a83-034d-4046-8b05-65773b289c0b", null, "Manager", "MANAGER" },
                    { "a6722d63-4034-495a-b68b-48a27c3a05c8", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"),
                column: "Public_id",
                value: "test");

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "Ratings", "ShopAvatarId", "ShopAvatarId1" },
                values: new object[] { new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), "Apple inc", 4.0, new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "efbcf454-0125-41ff-ac91-75d1564af044", 0, 36, new DateTime(2024, 6, 15, 12, 23, 46, 837, DateTimeKind.Local).AddTicks(3459), "09bb5745-0c09-4d11-bc90-901750966d65", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "43e03d8f-3694-4906-ad60-f1f7f88a8a98", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ade8a83-034d-4046-8b05-65773b289c0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6722d63-4034-495a-b68b-48a27c3a05c8");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044");

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
                value: null);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "35f00dd4-f487-467b-841b-065da8c01d92", 0, 36, new DateTime(2024, 6, 15, 12, 23, 21, 43, DateTimeKind.Local).AddTicks(4812), "6374376a-3bc5-45ea-8e96-61150b278d9b", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "945ffdfe-f267-481f-843c-f4ac97c2c1a4", false, null });
        }
    }
}
