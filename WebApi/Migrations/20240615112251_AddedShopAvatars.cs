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
                keyValue: "0ec22d75-3ee3-4d82-a92b-ab5404380efc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85737be0-5e3e-42ae-9497-270c11af84b0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "88925595-183f-48a0-baf3-257a2e008f72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e57c3d42-d92c-4afa-9043-08467bf3d25f", null, "Administrator", "ADMINISTRATOR" },
                    { "f22ff3b9-6982-489e-aa7c-b492ccfa8619", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "Public_id", "ShopId", "Url" },
                values: new object[] { new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bb581e0-a15e-40c1-97f7-6b6e9f924474", 0, 36, new DateTime(2024, 6, 15, 12, 22, 51, 313, DateTimeKind.Local).AddTicks(2340), "84b30b3e-cd67-4b44-8b4c-802e48511060", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ac5f6fa4-eabf-43c2-bd81-5a16def7b3e9", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6bb581e0-a15e-40c1-97f7-6b6e9f924474");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ec22d75-3ee3-4d82-a92b-ab5404380efc", null, "Manager", "MANAGER" },
                    { "85737be0-5e3e-42ae-9497-270c11af84b0", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "88925595-183f-48a0-baf3-257a2e008f72", 0, 36, new DateTime(2024, 6, 15, 12, 22, 20, 92, DateTimeKind.Local).AddTicks(9478), "03697bc1-83b0-43ad-9d5f-289244898075", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "06872177-c3c7-4234-87c7-50699879f77e", false, null });
        }
    }
}
