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
                keyValue: "38c88648-151f-4ccd-abe0-777682699b45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c565480-efe2-4d62-bc6c-1308f227f2b3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57e79953-2104-4ecf-a4d6-31bee8837ed2", null, "Manager", "MANAGER" },
                    { "662eacd6-2a7e-42f7-b8ed-575582b1d355", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "Public_id", "ShopId", "Url" },
                values: new object[] { new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 12, 38, 474, DateTimeKind.Local).AddTicks(6433), "56d7bf2d-e62c-4ce0-9160-f42d5821cba6", "0d9e34a0-ae76-4e85-890e-e7c07cc904f9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57e79953-2104-4ecf-a4d6-31bee8837ed2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "662eacd6-2a7e-42f7-b8ed-575582b1d355");

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38c88648-151f-4ccd-abe0-777682699b45", null, "Administrator", "ADMINISTRATOR" },
                    { "6c565480-efe2-4d62-bc6c-1308f227f2b3", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 12, 11, 433, DateTimeKind.Local).AddTicks(2322), "6b7bd0f5-5126-4965-90b9-3b9ec517e524", "3d7b1de6-200d-42db-acdb-54c3d6526afb" });
        }
    }
}
