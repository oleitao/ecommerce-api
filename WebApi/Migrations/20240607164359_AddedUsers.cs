using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89a63f60-3e33-4fc8-b2ec-a1d3f0c34593");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "967df242-2f0d-46e1-b94e-bfbb28c329fa");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ff47985e-9b2f-4f74-baa1-ac4d3c60dbb5", 0, 36, new DateTime(2024, 6, 7, 17, 43, 59, 385, DateTimeKind.Local).AddTicks(9062), "6939ea74-7b5e-477d-b353-10cb5ae7acaa", "oleitao@gmail.com", false, "", "M", "swiming", false, null, null, null, null, null, false, "4dfe3dfa-05b3-4a13-ba14-99187936e780", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ff47985e-9b2f-4f74-baa1-ac4d3c60dbb5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "89a63f60-3e33-4fc8-b2ec-a1d3f0c34593", null, "Manager", "MANAGER" },
                    { "967df242-2f0d-46e1-b94e-bfbb28c329fa", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
