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
                    { "b1e1078e-2579-46a1-92bb-3516e4f1a58d", null, "Administrator", "ADMINISTRATOR" },
                    { "e5a2de42-2afb-4ec9-8209-b0f66d694995", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"),
                column: "Public_id",
                value: "test");

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "Ratings", "ShopAvatarId", "Shop_avatarId" },
                values: new object[] { new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), "Apple inc", 4.0, new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 13, 26, 663, DateTimeKind.Local).AddTicks(9695), "4d89b6f0-a34d-4369-98bc-5a951fb7968b", "8a75b037-0b44-44f3-bbef-f8161b2cd948" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1e1078e-2579-46a1-92bb-3516e4f1a58d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5a2de42-2afb-4ec9-8209-b0f66d694995");

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"));

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
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 13, 2, 747, DateTimeKind.Local).AddTicks(9786), "2b387f4a-0b3a-4905-bcfe-b73eb3a320ad", "6add70a3-46fe-4507-9f29-5bca90cd5a6d" });
        }
    }
}
