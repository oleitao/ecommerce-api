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
                keyValue: "8ade8a83-034d-4046-8b05-65773b289c0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6722d63-4034-495a-b68b-48a27c3a05c8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b79ff1c8-8781-4054-bd7c-e5aafd09fa33", null, "Manager", "MANAGER" },
                    { "e24239aa-8e9a-40b2-94b3-d904e0bf8d6a", null, "Administrator", "ADMINISTRATOR" }
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
                values: new object[] { new DateTime(2024, 6, 15, 12, 29, 11, 773, DateTimeKind.Local).AddTicks(9307), "bd3e6c90-710e-47e6-8840-db3597b7896d", "75a28edc-4033-406e-9a6e-312806dcb4d8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b79ff1c8-8781-4054-bd7c-e5aafd09fa33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e24239aa-8e9a-40b2-94b3-d904e0bf8d6a");

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
                    { "8ade8a83-034d-4046-8b05-65773b289c0b", null, "Manager", "MANAGER" },
                    { "a6722d63-4034-495a-b68b-48a27c3a05c8", null, "Administrator", "ADMINISTRATOR" }
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
                values: new object[] { new DateTime(2024, 6, 15, 12, 23, 46, 837, DateTimeKind.Local).AddTicks(3459), "09bb5745-0c09-4d11-bc90-901750966d65", "43e03d8f-3694-4906-ad60-f1f7f88a8a98" });
        }
    }
}
