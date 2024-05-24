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
                keyValue: new Guid("86cb5da1-cef9-44d1-944c-0c67b9b9d2dd"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("2b83894b-d0d4-409d-958c-5086f685a7d3"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" },
                    { new Guid("59370ccf-bb31-4b4c-b62e-bfea78e4b22b"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("614b64bc-6e63-4714-a251-34128ffcec52"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" },
                    { new Guid("693e8c88-571b-41e9-9ad1-cd21fc8ff9b4"), "", "", "Others" },
                    { new Guid("86ddb7ae-86ea-49fc-800a-4a4170da4ca0"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" },
                    { new Guid("920c22f2-8941-4981-b33e-9f1b11c6525e"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("a8974ba1-5b62-4e41-8744-7f533fa81f4e"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("ac535629-bd36-4084-86e1-b2fa05d68360"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("d71b7fae-814b-4204-bc14-7bec93d84764"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" },
                    { new Guid("e54edb2a-c4f9-4d9f-bffe-d0d03d63c5bd"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Birthday", "Email", "FullName", "Hobby", "Sex" },
                values: new object[] { new Guid("1c416a29-298e-4c21-a3eb-a8d1febea78b"), 36, new DateTime(2024, 5, 24, 13, 26, 28, 967, DateTimeKind.Local).AddTicks(1592), "oleitao@gmail.com", "", "swiming", "M" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2b83894b-d0d4-409d-958c-5086f685a7d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("59370ccf-bb31-4b4c-b62e-bfea78e4b22b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("614b64bc-6e63-4714-a251-34128ffcec52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("693e8c88-571b-41e9-9ad1-cd21fc8ff9b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86ddb7ae-86ea-49fc-800a-4a4170da4ca0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("920c22f2-8941-4981-b33e-9f1b11c6525e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8974ba1-5b62-4e41-8744-7f533fa81f4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ac535629-bd36-4084-86e1-b2fa05d68360"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d71b7fae-814b-4204-bc14-7bec93d84764"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e54edb2a-c4f9-4d9f-bffe-d0d03d63c5bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1c416a29-298e-4c21-a3eb-a8d1febea78b"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Birthday", "Email", "FullName", "Hobby", "Sex" },
                values: new object[] { new Guid("86cb5da1-cef9-44d1-944c-0c67b9b9d2dd"), 36, new DateTime(2024, 5, 24, 13, 25, 2, 796, DateTimeKind.Local).AddTicks(7827), "oleitao@gmail.com", "", "swiming", "M" });
        }
    }
}
