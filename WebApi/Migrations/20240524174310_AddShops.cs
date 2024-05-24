using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddShops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("0019e351-81e9-406b-a7b6-9021b277ebb6"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("026fac1b-ee39-4efa-a4c8-9727d6ce6ab5"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("073c0801-7106-4845-94bf-12cd21be4483"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("08b47cbb-3b00-43b7-8003-18d65363cad2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("14959372-e5dc-40c7-a3a9-ef14ccf94353"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("1527e4eb-21ba-4467-a50e-cd3dabb2ade4"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("1780ec10-1d70-4fba-bf92-8b7a55f7083c"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("2805f968-1777-4f2d-940a-0c7d184873c5"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("2cd9188f-2eb4-4dd4-9c56-e2352f3e0452"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("482b0e37-9b9e-41ef-8ad6-e6280f798fb2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("52ae8452-20ee-4bc8-b354-45fe892ed0ff"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("6ecc0ad1-c959-4f60-a028-6381bcb67777"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("7bc76170-9f72-4af8-bd32-9dda4ba45569"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("7ea27507-0189-49de-b25b-4876ac6c6d8f"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("84859f38-9d56-463c-97f4-c9a8d18c81e8"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("85aef867-3136-4876-99ec-bd46c5529af1"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("9487a048-6fec-4899-8eda-fcfe113de0e7"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("b515789a-2d94-4517-8df3-12b4e6f56744"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("b764690e-0863-4aa8-b0fa-a0fc73b90196"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("b783390b-5d31-4062-9e59-85de767cdb82"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("bd755710-ca71-472a-b348-ae37136f0487"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("bfd6cbbf-c9fc-43b5-90a5-82f0fbae9ec3"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("c2f1134e-0686-4a68-b435-c34a853e6c16"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("cc776a03-84c4-422d-9485-c1fd86130787"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("da8f66d3-b880-4d51-a3ca-898661b91e75"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("de03a3be-cb2c-474c-8cb0-87a616892485"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("e24b93cb-562d-4381-89f7-715e90c9a895"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("e6861fe7-feda-4708-ba6f-7a59e3a22507"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Shops",
                columns: new[] { "ShopId", "Name", "ProductId", "Ratings", "ShopAvatarsId" },
                values: new object[,]
                {
                    { new Guid("0019e351-81e9-406b-a7b6-9021b277ebb6"), "Acer Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("026fac1b-ee39-4efa-a4c8-9727d6ce6ab5"), "Amazon Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("073c0801-7106-4845-94bf-12cd21be4483"), "SAMSUNG", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("08b47cbb-3b00-43b7-8003-18d65363cad2"), "SAMSUNG", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("14959372-e5dc-40c7-a3a9-ef14ccf94353"), "Shahriar Watch House", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("1527e4eb-21ba-4467-a50e-cd3dabb2ade4"), "Amazon Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("1780ec10-1d70-4fba-bf92-8b7a55f7083c"), "Amazon Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("2805f968-1777-4f2d-940a-0c7d184873c5"), "Energy System", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("2cd9188f-2eb4-4dd4-9c56-e2352f3e0452"), "Lenovo Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("482b0e37-9b9e-41ef-8ad6-e6280f798fb2"), "3W CLINIC", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("52ae8452-20ee-4bc8-b354-45fe892ed0ff"), "Vaseline Inc.", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("6ecc0ad1-c959-4f60-a028-6381bcb67777"), "Unbranded", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("7bc76170-9f72-4af8-bd32-9dda4ba45569"), "Louis Vuitton", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("7ea27507-0189-49de-b25b-4876ac6c6d8f"), "Dove Inc", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("84859f38-9d56-463c-97f4-c9a8d18c81e8"), "Shahriar Watch House", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("85aef867-3136-4876-99ec-bd46c5529af1"), "Alisha Shoes Mart", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("9487a048-6fec-4899-8eda-fcfe113de0e7"), "Tiaa Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("b515789a-2d94-4517-8df3-12b4e6f56744"), "Apple inc.", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("b764690e-0863-4aa8-b0fa-a0fc73b90196"), "Amazon Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("b783390b-5d31-4062-9e59-85de767cdb82"), "Apple inc", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("bd755710-ca71-472a-b348-ae37136f0487"), "Shodagor Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("bfd6cbbf-c9fc-43b5-90a5-82f0fbae9ec3"), "Oppo Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("c2f1134e-0686-4a68-b435-c34a853e6c16"), "Unik", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("cc776a03-84c4-422d-9485-c1fd86130787"), "Asus Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("da8f66d3-b880-4d51-a3ca-898661b91e75"), "Dove Inc", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("de03a3be-cb2c-474c-8cb0-87a616892485"), "Asus Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("e24b93cb-562d-4381-89f7-715e90c9a895"), "Amazon Ltd", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null },
                    { new Guid("e6861fe7-feda-4708-ba6f-7a59e3a22507"), "Unik", new Guid("008dfd3c-1ac6-49e5-be81-87b14bdae752"), 4, null }
                });
        }
    }
}
