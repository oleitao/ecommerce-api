using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d07be3d-ab4f-4a1f-b714-9e7b8fa12bf2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de368416-43f5-4ee8-9ba4-7c82401591a4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "99c42d1f-5b82-4486-bc97-7ec3e541ed10");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5215bfd2-18e7-454f-928b-2a879ccf2495", null, "Manager", "MANAGER" },
                    { "c0f537bf-69b7-44df-a487-d5303c1c909b", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("0e6ce5fb-e66d-4fd9-a869-39f14944ca05"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("128d53bd-88b6-44ab-be2f-221ff4b72e37"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("2bb8d7b8-9882-4fb8-9864-21c254346b4d"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" },
                    { new Guid("407a5a04-b476-4487-b1e4-348b105ac161"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" },
                    { new Guid("5dd20645-63bb-4f12-bf9b-613c0fca6ed9"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" },
                    { new Guid("7f3ed17d-d4d1-4b3a-8690-c9a1c87995fe"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("8cfc9538-c592-4725-bd02-cf7f42f46198"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("924e3c81-f889-487f-b7a6-d2a19eb13836"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("94f9e96a-6171-4d9a-9011-46b7007bcd1f"), "", "", "Others" },
                    { new Guid("ff52f5c4-e0cb-4998-bf26-ab3e181a44b6"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f02ac8e9-50bc-42c6-a919-8560e6538891", 0, 36, new DateTime(2024, 6, 14, 16, 41, 4, 892, DateTimeKind.Local).AddTicks(9544), "16eaacb2-186e-41ff-814b-81dd7c226033", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d670378a-e862-4ae4-80ba-71fdbef9d4eb", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5215bfd2-18e7-454f-928b-2a879ccf2495");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0f537bf-69b7-44df-a487-d5303c1c909b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e6ce5fb-e66d-4fd9-a869-39f14944ca05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("128d53bd-88b6-44ab-be2f-221ff4b72e37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2bb8d7b8-9882-4fb8-9864-21c254346b4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("407a5a04-b476-4487-b1e4-348b105ac161"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dd20645-63bb-4f12-bf9b-613c0fca6ed9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f3ed17d-d4d1-4b3a-8690-c9a1c87995fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8cfc9538-c592-4725-bd02-cf7f42f46198"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("924e3c81-f889-487f-b7a6-d2a19eb13836"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94f9e96a-6171-4d9a-9011-46b7007bcd1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff52f5c4-e0cb-4998-bf26-ab3e181a44b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f02ac8e9-50bc-42c6-a919-8560e6538891");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d07be3d-ab4f-4a1f-b714-9e7b8fa12bf2", null, "Administrator", "ADMINISTRATOR" },
                    { "de368416-43f5-4ee8-9ba4-7c82401591a4", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "99c42d1f-5b82-4486-bc97-7ec3e541ed10", 0, 36, new DateTime(2024, 6, 14, 16, 40, 25, 70, DateTimeKind.Local).AddTicks(3287), "c0749dd5-756a-4efc-8cc1-03649593942b", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6ca302dd-7c40-4a5d-b381-c6932a24399e", false, null });
        }
    }
}
