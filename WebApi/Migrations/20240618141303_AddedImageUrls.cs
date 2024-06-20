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
                keyValue: "57e79953-2104-4ecf-a4d6-31bee8837ed2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "662eacd6-2a7e-42f7-b8ed-575582b1d355");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cbb703fc-8661-490a-b5f5-120a24dcd655", null, "Administrator", "ADMINISTRATOR" },
                    { "fc00faaa-f701-40d8-8654-988d54791191", null, "Manager", "MANAGER" }
                });

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
                values: new object[] { new DateTime(2024, 6, 18, 15, 13, 2, 747, DateTimeKind.Local).AddTicks(9786), "2b387f4a-0b3a-4905-bcfe-b73eb3a320ad", "6add70a3-46fe-4507-9f29-5bca90cd5a6d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb703fc-8661-490a-b5f5-120a24dcd655");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc00faaa-f701-40d8-8654-988d54791191");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57e79953-2104-4ecf-a4d6-31bee8837ed2", null, "Manager", "MANAGER" },
                    { "662eacd6-2a7e-42f7-b8ed-575582b1d355", null, "Administrator", "ADMINISTRATOR" }
                });

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
                values: new object[] { new DateTime(2024, 6, 18, 15, 12, 38, 474, DateTimeKind.Local).AddTicks(6433), "56d7bf2d-e62c-4ce0-9160-f42d5821cba6", "0d9e34a0-ae76-4e85-890e-e7c07cc904f9" });
        }
    }
}
