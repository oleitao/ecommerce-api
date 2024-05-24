using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("69f5d3d3-6e3e-49b0-8505-d9d6d8557ae5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("74c59c62-4e45-4c6d-af88-c1cff0560aa7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a1535bd6-2977-484a-b4e8-d703d3c33f3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a7feb922-4881-4e48-87b0-6662555b1983"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a827f960-6f06-436d-9d8e-9ef5b11e696d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c393b801-baaf-4dec-b7c0-2a8113f58e55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c61436e8-d9b2-40a8-bdb7-0e85a0a94a90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d7a5780c-0bfd-4c0f-aad3-cfd11405666e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e7fa5c39-e1f2-4a99-8c83-447f2961227d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ead4c6ec-fbdd-4953-b418-1d67562b81fa"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Age", "Birthday", "Email", "FullName", "Hobby", "Sex" },
                values: new object[] { new Guid("86cb5da1-cef9-44d1-944c-0c67b9b9d2dd"), 36, new DateTime(2024, 5, 24, 13, 25, 2, 796, DateTimeKind.Local).AddTicks(7827), "oleitao@gmail.com", "", "swiming", "M" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("69f5d3d3-6e3e-49b0-8505-d9d6d8557ae5"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("74c59c62-4e45-4c6d-af88-c1cff0560aa7"), "", "", "Others" },
                    { new Guid("a1535bd6-2977-484a-b4e8-d703d3c33f3a"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("a7feb922-4881-4e48-87b0-6662555b1983"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" },
                    { new Guid("a827f960-6f06-436d-9d8e-9ef5b11e696d"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("c393b801-baaf-4dec-b7c0-2a8113f58e55"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("c61436e8-d9b2-40a8-bdb7-0e85a0a94a90"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" },
                    { new Guid("d7a5780c-0bfd-4c0f-aad3-cfd11405666e"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" },
                    { new Guid("e7fa5c39-e1f2-4a99-8c83-447f2961227d"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("ead4c6ec-fbdd-4953-b418-1d67562b81fa"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" }
                });
        }
    }
}
