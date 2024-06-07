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
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("0174094e-d042-4dd3-9dc1-7bb14e332899"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("080553d4-8d8e-43eb-8a10-937980e11c41"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("08c1ff25-700e-4fb1-bad1-55d6a65cbcda"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("17c24b1c-9d80-4de5-ac3c-d4bc6ba6c3f2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("312155ff-91f4-4807-9d60-022a6cb5d3a4"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("48c1b682-b5a8-49e9-b521-aaff15eb6db2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("5e05bb52-a9ec-45de-9a09-a609556be7ce"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("65458d06-8bac-4dd0-afc8-537ae97a86e3"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("69d6458c-351e-491a-a11c-5411391a32c9"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("6b5b5d34-e881-41b1-910e-49e1e7a4eec9"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("6bbb7da9-fc66-4af6-9f01-24821d9446d0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("72bb4403-ddff-477c-b26c-199a3e89dc7a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("864b8a17-76a0-43e9-ae68-b17db1163fed"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("98e99411-5031-493f-9a3b-87f79a82c57a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a803c4bb-a8f3-45e2-8f10-fbcf3dc8f26e"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a87ccf0a-8b12-4009-91fb-7d356725da2e"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a983aecc-f8d6-4988-a80f-1a1540d2d805"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ac5675ca-b364-4dcc-9143-75959919b970"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c453bb5d-6752-4483-8768-cfabdf308a0e"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c65e359a-d49d-4f76-81a2-1927baa912a4"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c6ec6c1b-e1fc-47c0-afc7-d4b81864c848"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("dc02569a-b48b-4c30-8fd6-c9faeff3790d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("dcf11d0f-4eae-4bcb-b1a4-9225d52f9acf"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("dfa9cd7a-6aab-4966-80f5-6db3418cf019"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("e442c605-e0ca-4767-a64f-2dcd67ce4afd"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("eb4ad7e4-3976-407e-81c1-f24b43fe0d43"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("f0bf8378-bad5-4863-be62-469080d5fee9"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("f3728dc7-b7f3-4ef6-88d5-c254b32686c5"));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("f76b4f32-93e9-4207-972d-eeed666250c3"), "comment", new Guid("00000000-0000-0000-0000-000000000000"), 5, new Guid("00000000-0000-0000-0000-000000000000") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f76b4f32-93e9-4207-972d-eeed666250c3"));

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "Ratings", "ShopAvatarId" },
                values: new object[,]
                {
                    { new Guid("0174094e-d042-4dd3-9dc1-7bb14e332899"), "Alisha Shoes Mart", 4, new Guid("14833213-23c9-4fa2-8584-b99d5a9a414a") },
                    { new Guid("080553d4-8d8e-43eb-8a10-937980e11c41"), "Unik", 4, new Guid("21bc5f44-951b-46f5-b081-dc276a8559bc") },
                    { new Guid("08c1ff25-700e-4fb1-bad1-55d6a65cbcda"), "Shahriar Watch House", 4, new Guid("24a68a8f-4773-4c5e-b57c-0120be5b5dbc") },
                    { new Guid("17c24b1c-9d80-4de5-ac3c-d4bc6ba6c3f2"), "Dove Inc", 4, new Guid("c9b6419e-7dce-448c-bef5-44e523659d81") },
                    { new Guid("312155ff-91f4-4807-9d60-022a6cb5d3a4"), "Asus Ltd", 4, new Guid("79306669-4550-4ec5-b562-9c0892ef95f7") },
                    { new Guid("48c1b682-b5a8-49e9-b521-aaff15eb6db2"), "Oppo Ltd", 4, new Guid("ce2181b1-2b4d-4cf8-a057-06786a98661f") },
                    { new Guid("5e05bb52-a9ec-45de-9a09-a609556be7ce"), "SAMSUNG", 4, new Guid("bed97ee8-1447-44c7-9bb9-0d224132fca0") },
                    { new Guid("65458d06-8bac-4dd0-afc8-537ae97a86e3"), "Acer Ltd", 4, new Guid("32ec5915-aebf-4fb5-8696-6e1587d2ea15") },
                    { new Guid("69d6458c-351e-491a-a11c-5411391a32c9"), "Amazon Ltd", 4, new Guid("dd1b0352-1ffc-49b9-adfb-fc671a6ba923") },
                    { new Guid("6b5b5d34-e881-41b1-910e-49e1e7a4eec9"), "SAMSUNG", 4, new Guid("02a37dbd-4372-4064-8471-5087995286d8") },
                    { new Guid("6bbb7da9-fc66-4af6-9f01-24821d9446d0"), "Shodagor Ltd", 4, new Guid("07dc8a14-bff1-4bf8-b4b7-0b261ceff0fa") },
                    { new Guid("72bb4403-ddff-477c-b26c-199a3e89dc7a"), "Amazon Ltd", 4, new Guid("3a3f6d4f-04e4-4c14-8c56-20e7b17f575c") },
                    { new Guid("864b8a17-76a0-43e9-ae68-b17db1163fed"), "Asus Ltd", 4, new Guid("397e0e12-a92a-463f-8b8a-98c3473a9211") },
                    { new Guid("98e99411-5031-493f-9a3b-87f79a82c57a"), "Unik", 4, new Guid("a7432ebf-ae4b-4a06-b12a-b28bc3b29112") },
                    { new Guid("a803c4bb-a8f3-45e2-8f10-fbcf3dc8f26e"), "Amazon Ltd", 4, new Guid("df89b20c-bbb8-4d13-bef4-ed69cca6c653") },
                    { new Guid("a87ccf0a-8b12-4009-91fb-7d356725da2e"), "Vaseline Inc.", 4, new Guid("69acb09d-503f-422b-83ae-1957fa0dbe9d") },
                    { new Guid("a983aecc-f8d6-4988-a80f-1a1540d2d805"), "Lenovo Ltd", 4, new Guid("6d0a342c-e012-4a91-b133-1ad05984a9f3") },
                    { new Guid("ac5675ca-b364-4dcc-9143-75959919b970"), "Tiaa Ltd", 4, new Guid("d3fbac34-d8b8-4597-89fe-16e84698f8a9") },
                    { new Guid("c453bb5d-6752-4483-8768-cfabdf308a0e"), "3W CLINIC", 4, new Guid("207acfc3-ef9f-4a21-83c9-72f68bb969d5") },
                    { new Guid("c65e359a-d49d-4f76-81a2-1927baa912a4"), "Louis Vuitton", 4, new Guid("f26cf572-5586-46c6-827b-39d19b4977d2") },
                    { new Guid("c6ec6c1b-e1fc-47c0-afc7-d4b81864c848"), "Energy System", 4, new Guid("9928e6d7-9caa-42b0-89a5-79d3a1f86332") },
                    { new Guid("dc02569a-b48b-4c30-8fd6-c9faeff3790d"), "Unbranded", 4, new Guid("c6c64bdc-dbb6-4732-84c9-df26c332c85c") },
                    { new Guid("dcf11d0f-4eae-4bcb-b1a4-9225d52f9acf"), "Amazon Ltd", 4, new Guid("04cd1be4-88f6-4995-95a6-a0fb53d515d7") },
                    { new Guid("dfa9cd7a-6aab-4966-80f5-6db3418cf019"), "Dove Inc", 4, new Guid("b45dbcce-f6cd-4f5f-b4f9-326f0d42d9c6") },
                    { new Guid("e442c605-e0ca-4767-a64f-2dcd67ce4afd"), "Apple inc.", 4, new Guid("ba498934-c3d7-4f4c-a6f7-2e0b4c42ae7c") },
                    { new Guid("eb4ad7e4-3976-407e-81c1-f24b43fe0d43"), "Amazon Ltd", 4, new Guid("85999c5d-ee20-4ec7-a9aa-7af5d1e91415") },
                    { new Guid("f0bf8378-bad5-4863-be62-469080d5fee9"), "Apple inc", 4, new Guid("794b034a-4436-439c-8e27-cf52be867493") },
                    { new Guid("f3728dc7-b7f3-4ef6-88d5-c254b32686c5"), "Shahriar Watch House", 4, new Guid("d1635ade-1890-4b65-a5d0-86ac94c38eb5") }
                });
        }
    }
}
