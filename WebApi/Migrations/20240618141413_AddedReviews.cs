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
                keyValue: "37fe0441-5c42-4a82-91b5-ce9f5cf844c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6034e85b-0640-4e4e-acb1-f0e6aebac001");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55b70911-3616-4979-9021-f645e3da7fcb", null, "Administrator", "ADMINISTRATOR" },
                    { "fd8b5769-3081-40f1-8562-fab80d4ef999", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId", "UserId1" },
                values: new object[] { new Guid("e9472dba-e273-4c8e-801b-52feb331f789"), "comment", new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), 5, new Guid("efbcf454-0125-41ff-ac91-75d1564af044"), null });

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
                values: new object[] { new DateTime(2024, 6, 18, 15, 14, 12, 845, DateTimeKind.Local).AddTicks(8344), "a37a6e2d-40da-4b45-a0d2-d770df9e2e58", "60d0a673-8b4d-4746-8ec1-cc23f13b5369" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b70911-3616-4979-9021-f645e3da7fcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd8b5769-3081-40f1-8562-fab80d4ef999");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e9472dba-e273-4c8e-801b-52feb331f789"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37fe0441-5c42-4a82-91b5-ce9f5cf844c8", null, "Administrator", "ADMINISTRATOR" },
                    { "6034e85b-0640-4e4e-acb1-f0e6aebac001", null, "Manager", "MANAGER" }
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
                values: new object[] { new DateTime(2024, 6, 18, 15, 13, 47, 379, DateTimeKind.Local).AddTicks(5390), "f75875bc-e092-4433-94db-67a6c8f94b4f", "979df93b-e3b5-4ac4-822a-9b500512f8e4" });
        }
    }
}
