using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9cccc7e2-22f1-46a0-8b7f-faa915555ba0"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("418a55c2-6254-4bc7-9593-4a41665fd396"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" },
                    { new Guid("5737cb06-f21d-489b-add1-e49993005152"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("69018be2-e569-40c2-bcbb-5a85de5a369f"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("7475cdd9-3303-40bf-9cdf-61669a1f49f4"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" },
                    { new Guid("8e1f3278-b97e-45a6-ab0f-4a373a6c264d"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("bd62cefa-ffcd-44b4-8109-59f8a6f643b5"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" },
                    { new Guid("f9da526c-a651-4b98-81e0-240d29ffe55d"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" },
                    { new Guid("fc7f2981-1031-4d10-8565-9cf93f211799"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("fe58ddc2-61ee-4e1a-9402-a0c9ebfb8e5c"), "", "", "Others" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Birthday", "Email", "FullName", "Hobby", "Sex" },
                values: new object[] { new Guid("f3d2300a-c9cf-49b4-b137-aca949bf3b6a"), 36, new DateTime(2024, 5, 24, 18, 26, 25, 207, DateTimeKind.Local).AddTicks(4553), "oleitao@gmail.com", "", "swiming", "M" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("418a55c2-6254-4bc7-9593-4a41665fd396"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("5737cb06-f21d-489b-add1-e49993005152"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("69018be2-e569-40c2-bcbb-5a85de5a369f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7475cdd9-3303-40bf-9cdf-61669a1f49f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("8e1f3278-b97e-45a6-ab0f-4a373a6c264d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bd62cefa-ffcd-44b4-8109-59f8a6f643b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f9da526c-a651-4b98-81e0-240d29ffe55d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fc7f2981-1031-4d10-8565-9cf93f211799"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fe58ddc2-61ee-4e1a-9402-a0c9ebfb8e5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f3d2300a-c9cf-49b4-b137-aca949bf3b6a"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Birthday", "Email", "FullName", "Hobby", "Sex" },
                values: new object[] { new Guid("9cccc7e2-22f1-46a0-8b7f-faa915555ba0"), 36, new DateTime(2024, 5, 24, 18, 25, 29, 97, DateTimeKind.Local).AddTicks(1893), "oleitao@gmail.com", "", "swiming", "M" });
        }
    }
}
