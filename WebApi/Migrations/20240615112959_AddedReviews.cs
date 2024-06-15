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
                keyValue: "b79ff1c8-8781-4054-bd7c-e5aafd09fa33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e24239aa-8e9a-40b2-94b3-d904e0bf8d6a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "221f8f3e-f15b-4f71-b5bf-206eeca77e49", null, "Manager", "MANAGER" },
                    { "98581e90-1088-41f8-a670-36b3eedf1ea5", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("dc3a92ce-1c3c-40c8-8266-9e0d638d236b"), "comment", new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), 5, new Guid("efbcf454-0125-41ff-ac91-75d1564af044") });

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
                values: new object[] { new DateTime(2024, 6, 15, 12, 29, 58, 692, DateTimeKind.Local).AddTicks(7357), "52344a96-45c1-4109-9455-1ffa5c735dd4", "486accd8-b41e-48b6-a5ff-6abe906100a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "221f8f3e-f15b-4f71-b5bf-206eeca77e49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98581e90-1088-41f8-a670-36b3eedf1ea5");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("dc3a92ce-1c3c-40c8-8266-9e0d638d236b"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b79ff1c8-8781-4054-bd7c-e5aafd09fa33", null, "Manager", "MANAGER" },
                    { "e24239aa-8e9a-40b2-94b3-d904e0bf8d6a", null, "Administrator", "ADMINISTRATOR" }
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
                values: new object[] { new DateTime(2024, 6, 15, 12, 29, 11, 773, DateTimeKind.Local).AddTicks(9307), "bd3e6c90-710e-47e6-8840-db3597b7896d", "75a28edc-4033-406e-9a6e-312806dcb4d8" });
        }
    }
}
