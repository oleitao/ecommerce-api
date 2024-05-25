using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("0591edd5-52ad-467e-a512-85cbead188f1"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("197bf979-98b1-46c6-b8a6-cfa14e33e1cd"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("1f4937f9-c38d-4833-8588-b5eb53a02f15"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("284cefab-c75a-4fa9-bc32-a3db0e87cb85"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("299920c5-5e59-46f0-a3fa-bb36f2927731"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("35361e25-8490-4947-b34b-4721539cebe6"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("3ec4529b-3f33-4380-9512-d63937ce73e7"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("41a85e06-ec28-4928-b05d-61835f2576c2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("426b9186-cfe4-4855-9a92-836bce465676"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("46a81f1d-76a7-47d0-853f-fe1505cf5fc0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("4c03a054-0ec5-4e21-9a9f-070da8780665"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("6c7264cd-d740-4f17-b2e1-707063cb0fd8"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("6f91d4ac-71eb-466c-a578-e6c24757923c"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("78d531fd-7903-40a7-b455-faadb3c7973d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("834a1b85-7920-4fe7-b47d-2a76ab3aed22"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("904bcb66-14d0-4c87-a881-951d2572a83a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("939e2aab-65f1-4c58-9700-b57f3d99218a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("99ad672c-abd2-4e0f-921b-455fe7722907"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("a28d9b40-9308-4c6c-b58c-7941691aea5c"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("ad67c0be-4a72-4b05-912b-9352c8704d0a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("b8016369-bcf0-4049-a50b-573c6e282156"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("bd6769c0-a2a6-4aa1-9201-a4be836e8d3b"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("c5a142da-c649-4eb6-b802-a550f03f6816"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("d4d869c0-b05a-43e4-898e-3947f96e9456"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("dd860f0d-d41e-48d8-886a-635bbef9d4e1"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("ddb6b5ff-3433-4a66-97c5-af2ca1787bb5"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("e368e196-c4a1-4f9b-b6f6-b3c040da473b"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("fafa573f-b375-4fc7-a0b1-31a2666fad13"));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("6f6205b9-6d84-44cc-ab27-fde3156ef95c"), "comment", null, 5, new Guid("f3d2300a-c9cf-49b4-b137-aca949bf3b6a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: new Guid("6f6205b9-6d84-44cc-ab27-fde3156ef95c"));

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Name", "ProductId", "Ratings", "ShopAvatarsId" },
                values: new object[,]
                {
                    { new Guid("0591edd5-52ad-467e-a512-85cbead188f1"), "SAMSUNG", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("197bf979-98b1-46c6-b8a6-cfa14e33e1cd"), "Shahriar Watch House", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("1f4937f9-c38d-4833-8588-b5eb53a02f15"), "Shahriar Watch House", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("284cefab-c75a-4fa9-bc32-a3db0e87cb85"), "Asus Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("299920c5-5e59-46f0-a3fa-bb36f2927731"), "3W CLINIC", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("35361e25-8490-4947-b34b-4721539cebe6"), "Amazon Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("3ec4529b-3f33-4380-9512-d63937ce73e7"), "Unik", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("41a85e06-ec28-4928-b05d-61835f2576c2"), "Oppo Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("426b9186-cfe4-4855-9a92-836bce465676"), "Amazon Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("46a81f1d-76a7-47d0-853f-fe1505cf5fc0"), "Lenovo Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("4c03a054-0ec5-4e21-9a9f-070da8780665"), "Apple inc.", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("6c7264cd-d740-4f17-b2e1-707063cb0fd8"), "Apple inc", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("6f91d4ac-71eb-466c-a578-e6c24757923c"), "Tiaa Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("78d531fd-7903-40a7-b455-faadb3c7973d"), "Dove Inc", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("834a1b85-7920-4fe7-b47d-2a76ab3aed22"), "Energy System", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("904bcb66-14d0-4c87-a881-951d2572a83a"), "Acer Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("939e2aab-65f1-4c58-9700-b57f3d99218a"), "Unbranded", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("99ad672c-abd2-4e0f-921b-455fe7722907"), "Alisha Shoes Mart", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("a28d9b40-9308-4c6c-b58c-7941691aea5c"), "Dove Inc", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("ad67c0be-4a72-4b05-912b-9352c8704d0a"), "Amazon Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("b8016369-bcf0-4049-a50b-573c6e282156"), "Shodagor Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("bd6769c0-a2a6-4aa1-9201-a4be836e8d3b"), "Louis Vuitton", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("c5a142da-c649-4eb6-b802-a550f03f6816"), "Amazon Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("d4d869c0-b05a-43e4-898e-3947f96e9456"), "Amazon Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("dd860f0d-d41e-48d8-886a-635bbef9d4e1"), "Asus Ltd", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("ddb6b5ff-3433-4a66-97c5-af2ca1787bb5"), "SAMSUNG", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("e368e196-c4a1-4f9b-b6f6-b3c040da473b"), "Vaseline Inc.", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null },
                    { new Guid("fafa573f-b375-4fc7-a0b1-31a2666fad13"), "Unik", new Guid("e6f56553-8663-4dd3-a4f0-8e21fbc2c16a"), 4, null }
                });
        }
    }
}
