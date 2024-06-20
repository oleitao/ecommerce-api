using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1e1078e-2579-46a1-92bb-3516e4f1a58d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5a2de42-2afb-4ec9-8209-b0f66d694995");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37fe0441-5c42-4a82-91b5-ce9f5cf844c8", null, "Administrator", "ADMINISTRATOR" },
                    { "6034e85b-0640-4e4e-acb1-f0e6aebac001", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount_price", "Name", "Price", "Rating", "ShopId", "Stock", "Total_sell" },
                values: new object[,]
                {
                    { new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty", 0, 0, new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), 0, 0 },
                    { new Guid("398e76bb-70f0-4712-af76-10726bb6dd93"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), 0, 0 }
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
                values: new object[] { new DateTime(2024, 6, 18, 15, 13, 47, 379, DateTimeKind.Local).AddTicks(5390), "f75875bc-e092-4433-94db-67a6c8f94b4f", "979df93b-e3b5-4ac4-822a-9b500512f8e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37fe0441-5c42-4a82-91b5-ce9f5cf844c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6034e85b-0640-4e4e-acb1-f0e6aebac001");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("398e76bb-70f0-4712-af76-10726bb6dd93"));

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
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "efbcf454-0125-41ff-ac91-75d1564af044",
                columns: new[] { "Birthday", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 13, 26, 663, DateTimeKind.Local).AddTicks(9695), "4d89b6f0-a34d-4369-98bc-5a951fb7968b", "8a75b037-0b44-44f3-bbef-f8161b2cd948" });
        }
    }
}
