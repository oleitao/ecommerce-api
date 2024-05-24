using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("016f5238-a091-46a1-b460-8dbf43c8e42e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("16232bf2-1e50-4c44-bfac-fcb8bf78fabe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1a880c04-9766-4225-8adb-07a44dc9fba4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1b7b9131-8835-4305-966f-cdce7dbd1e2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1f323240-b620-4f5b-9832-7422dc60a479"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("20bce264-21b5-41c4-a026-54b456d705c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("21a4f24f-8a9a-4288-a74f-aec57d9a81d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2ec5aa33-9976-48d6-8632-61c86d3b0bd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("43a5c240-7031-4bf2-80c5-93bcfcd79dd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e831872-1041-4e8b-92a1-57c415b7c779"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5302924a-517f-4001-ba8a-1cd3fd8f507a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53908a26-1b53-4bab-9b2e-150971b235db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("67162f94-7890-4aa8-8bce-38b6ff543e43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("68949202-512a-4177-8be3-586018aad405"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6ae8d364-71f7-4697-8ea2-856497f2b293"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b916088-88e0-4e91-b1d7-7cf3dc3240ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7996c998-8438-4d39-bdac-6391ed95f681"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84ec88b1-18e5-449d-b371-00c99ea5bdb4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("875b1782-293b-4556-a29f-86a37cc2a457"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9891662c-c985-4d7f-93b6-6157c81e7b3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9c1c4ba6-c80b-4098-96f7-8e974caf4910"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5ee7002-d9ea-4d6a-a62a-b57f4fdf1549"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a999c4d8-e857-404c-9fa0-fbbc22d30956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bd3c3750-6dd4-4765-b5b3-9651f5e82454"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e435fa18-70f5-441b-ac3b-c18fea7e1545"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e61a7b5d-844b-459f-9c41-1e5fee5214a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e978c68c-987a-404f-ba58-655cee5074da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("eaf098a5-a400-4ac7-b70e-ad07eb2ffd0c"));

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "ImageUrlId", "ProductId", "PublicUrl", "Url" },
                values: new object[,]
                {
                    { new Guid("01848ecf-26af-4a4d-8cfd-2eff42e407cc"), null, "test", "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499" },
                    { new Guid("0fe80206-b480-4c00-a973-cf31c29d7634"), null, "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("185f6eed-fd14-44b3-b76e-3338ec49d203"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("1877aae0-b790-4812-9874-2b56be800823"), null, "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("1cb7860f-ff8f-41a4-acd7-fd5fd5699b69"), null, "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("1d9050ec-7b98-4c25-b797-bddda6af7a4f"), null, "test", "https://unixnetworkbd.com/image/cache/wp/gj/unix_network_images/product/gaming-pc-9th-gen-core-i7-9700k/Gaming-PC-9th-Gen-Core-i7-9700k-Unix-Computer-jashore-bangladesh-500x500.webp" },
                    { new Guid("1f65429d-e22c-436c-9d8d-75faa42998ca"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBOB80TIoBkL_NaeJ_5lG5LuUsD0IYEDXFJg&usqp=CAU" },
                    { new Guid("20c47ce7-d102-450e-a868-5308cc1061c1"), null, "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("2757576e-ad5f-4b45-99df-1b055e332cd5"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("2b36c506-8a20-41e8-8faf-02b1df746104"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("30488fd8-0454-466d-9025-c7b7064ef2c4"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("32fe106c-fa5d-4d7a-8b4d-15089584ce23"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("34951477-c4e7-4437-806b-5dd5b24c3518"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("34f03c4b-57d2-4982-a7f6-7d1cf1130de7"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("3f166a0c-c690-475d-b4fd-de4b777d5ccc"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("4271c7ac-6bd8-4c60-937e-52ef41c6deda"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("4570a650-bc2e-4a22-bdd4-56356db4c4c4"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("4870fe9d-0d52-41cc-a45f-96c0412f1349"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("508d6b5d-c1a4-48aa-9e80-35fce7cf5821"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("5af7b311-f23c-4300-a30d-2be9a00bfab9"), null, "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("5d48f1c9-84d8-42e5-a423-1082e7272832"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("61a515e3-93e4-428d-9458-e345942b9c49"), null, "test", "https://adminapi.applegadgetsbd.com/storage/media/large/iPhone-14-Pro-Max-Silver-8456.jpg" },
                    { new Guid("658caf8f-f8de-4e90-87fb-1b4794c46481"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("6ef972d4-12be-4ada-a11a-ae4ba1e578ce"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("6fcda14d-2872-4433-b4bf-fa9b48c475a3"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2zcpFb-6hMeoBVWrfp4LazbLD3a1tEjJjY2oYq45yJOyb28WIIYBoJ3qZMsmFdImBSZk&usqp=CAU" },
                    { new Guid("76082b3c-45ba-410f-b249-279d76d8474f"), null, "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("794b89f8-309f-43b6-9dc5-acacf5adf27b"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("7958ffb7-51f4-4b3c-b711-b71674580876"), null, "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("79b09059-7158-47b3-b359-14110d2ff2f0"), null, "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("7ba01de0-3dde-492f-b965-4b38ab3d0d72"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("9bcaf53b-c304-4b6c-9173-b398bfcee8e9"), null, "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("9cbeec46-f118-49c6-980b-a8a054491226"), null, "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("9e2762dd-cab2-495d-91e1-ef6410bae2aa"), null, "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("9f7d872b-82a3-423f-b104-a25c71eefbba"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("a1655193-d279-4e4b-b189-1e399252b36f"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("adbb7a13-a1f8-4ca7-bd3e-ae78be4ce6d8"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("b41d8b5c-1ce5-4b8d-95b5-32bcfe5a6c37"), null, "test", "https://www.bdstall.com/asset/product-image/giant_213181.jpg" },
                    { new Guid("b5b9504f-ca2a-4956-8bf2-81256d884382"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("b7c29ca9-11b3-44ff-b047-84ccb0f1cfa0"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("b8333f6b-5c83-4d39-aa45-7906456ece77"), null, "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("bdb38aee-0a13-4df8-b7ca-1561d87dedaf"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("bea1e1df-86af-4c84-8b23-36a241704671"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("c1439a03-ca5d-42b4-b141-f2ee6933c119"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("c336faed-515a-4622-866d-246bc3aba711"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("c9ac0af4-c846-4fa0-8f9b-a14349a8528d"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("cb32cc3b-45cc-4f4b-8db2-cabfe4337a50"), null, "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("cdc9d381-c774-4d66-8ca9-6ccc14aa9a74"), null, "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("d810bd67-3c9a-4502-8d6a-34655761fc1c"), null, "test", "https://www.startech.com.bd/image/cache/catalog/headphone/havit/h763d/h763d-02-500x500.jpg" },
                    { new Guid("d9a78e8b-3496-4d0d-b185-e99a5a32b4fb"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("dd3d0660-25a2-474b-afd4-85688f23efa3"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42FePhUrLX424aLie09J4Pfkn03T8h3D7PQ&usqp=CAU" },
                    { new Guid("df45dfbf-4f6f-497f-b303-20eb2447269c"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("e049e6e2-8837-403f-9b0b-f057d76fbb95"), null, "test", "https://eratablet.com/wp-content/uploads/2022/08/H51ba6537405f4948972e293927673546u.jpg" },
                    { new Guid("e17fb555-4818-4f89-80a5-2a049d2f7cc5"), null, "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("eac8aec4-ef9f-415f-9acc-aaf0fec4ddae"), null, "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("fb52a8d1-3f0c-45e6-a12f-b1d49b8152a9"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("fc8d876e-c8fb-4059-91e9-d665935433e4"), null, "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("01848ecf-26af-4a4d-8cfd-2eff42e407cc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("0fe80206-b480-4c00-a973-cf31c29d7634"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("185f6eed-fd14-44b3-b76e-3338ec49d203"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("1877aae0-b790-4812-9874-2b56be800823"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("1cb7860f-ff8f-41a4-acd7-fd5fd5699b69"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("1d9050ec-7b98-4c25-b797-bddda6af7a4f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("1f65429d-e22c-436c-9d8d-75faa42998ca"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("20c47ce7-d102-450e-a868-5308cc1061c1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("2757576e-ad5f-4b45-99df-1b055e332cd5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("2b36c506-8a20-41e8-8faf-02b1df746104"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("30488fd8-0454-466d-9025-c7b7064ef2c4"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("32fe106c-fa5d-4d7a-8b4d-15089584ce23"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("34951477-c4e7-4437-806b-5dd5b24c3518"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("34f03c4b-57d2-4982-a7f6-7d1cf1130de7"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("3f166a0c-c690-475d-b4fd-de4b777d5ccc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("4271c7ac-6bd8-4c60-937e-52ef41c6deda"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("4570a650-bc2e-4a22-bdd4-56356db4c4c4"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("4870fe9d-0d52-41cc-a45f-96c0412f1349"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("508d6b5d-c1a4-48aa-9e80-35fce7cf5821"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("5af7b311-f23c-4300-a30d-2be9a00bfab9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("5d48f1c9-84d8-42e5-a423-1082e7272832"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("61a515e3-93e4-428d-9458-e345942b9c49"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("658caf8f-f8de-4e90-87fb-1b4794c46481"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("6ef972d4-12be-4ada-a11a-ae4ba1e578ce"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("6fcda14d-2872-4433-b4bf-fa9b48c475a3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("76082b3c-45ba-410f-b249-279d76d8474f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("794b89f8-309f-43b6-9dc5-acacf5adf27b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("7958ffb7-51f4-4b3c-b711-b71674580876"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("79b09059-7158-47b3-b359-14110d2ff2f0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("7ba01de0-3dde-492f-b965-4b38ab3d0d72"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("9bcaf53b-c304-4b6c-9173-b398bfcee8e9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("9cbeec46-f118-49c6-980b-a8a054491226"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("9e2762dd-cab2-495d-91e1-ef6410bae2aa"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("9f7d872b-82a3-423f-b104-a25c71eefbba"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("a1655193-d279-4e4b-b189-1e399252b36f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("adbb7a13-a1f8-4ca7-bd3e-ae78be4ce6d8"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("b41d8b5c-1ce5-4b8d-95b5-32bcfe5a6c37"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("b5b9504f-ca2a-4956-8bf2-81256d884382"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("b7c29ca9-11b3-44ff-b047-84ccb0f1cfa0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("b8333f6b-5c83-4d39-aa45-7906456ece77"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("bdb38aee-0a13-4df8-b7ca-1561d87dedaf"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("bea1e1df-86af-4c84-8b23-36a241704671"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("c1439a03-ca5d-42b4-b141-f2ee6933c119"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("c336faed-515a-4622-866d-246bc3aba711"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("c9ac0af4-c846-4fa0-8f9b-a14349a8528d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("cb32cc3b-45cc-4f4b-8db2-cabfe4337a50"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("cdc9d381-c774-4d66-8ca9-6ccc14aa9a74"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("d810bd67-3c9a-4502-8d6a-34655761fc1c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("d9a78e8b-3496-4d0d-b185-e99a5a32b4fb"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("dd3d0660-25a2-474b-afd4-85688f23efa3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("df45dfbf-4f6f-497f-b303-20eb2447269c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("e049e6e2-8837-403f-9b0b-f057d76fbb95"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("e17fb555-4818-4f89-80a5-2a049d2f7cc5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("eac8aec4-ef9f-415f-9acc-aaf0fec4ddae"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("fb52a8d1-3f0c-45e6-a12f-b1d49b8152a9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "ImageUrlId",
                keyValue: new Guid("fc8d876e-c8fb-4059-91e9-d665935433e4"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Discount_Price", "Name", "Price", "Rating", "Stock", "Total_Sell" },
                values: new object[,]
                {
                    { new Guid("016f5238-a091-46a1-b460-8dbf43c8e42e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "TIAM Anti Blemish Body acne / bumpy skin / skin soothing / skin spot improvement- Special body lotion that solves skin problems- Body flaw soothing lotion: AHA, BHA, and Calamine core ingredients sooth trouble skin that is sensitive – Whitening functional ingredients clean up the bodys trouble and spots. AHA, BHA and Calamine calms down the sensitive and troubled skin. Whereas whitening ingredients helps with the dull and uneven skin tone. It also has ingredients which helps get rid of dead skin cells and sebum making skin smooth and soft. A body with a thicker skin layer than the face needs more care – Removes clogged pores and sebum with AHA, BHA, calamine and various active ingredients, and cares for skin defects to make it clean and smooth. Ingredients: Water, Niacinamide, Propanediol, Alcohol, Cetyl Ethylhex anoate, Calamine, Dimethicone, Glyceryl Stearate, PEG-100 Stearate, Polysorbate 60, Cetearyl Alcohol, Arachidyl Alcohol, Behenyl Alcohol, Arachidyl Glucoside, Sorbitan Stearate, Allantoin, Salicylic acid, Lactic Acid, Zinc PCA, (-)-alpha-bisabolol, Melaleuca Alternifolia (Tea Tree) Leaf Oil, Mentha Viridis (Spearmint) Leaf Oil, Methylpropanediol, Lauryl pyridinium Chloride, Polyacrylate-13, Polyisobutene, Polysorbate 20, Tocopheryl Acetate, PEG-60 Hydrogenated Castor Oil", null, "TIAM ANTI BLEMISH BODY LOTION 200ML", 0, 0, 0, null },
                    { new Guid("16232bf2-1e50-4c44-bfac-fcb8bf78fabe"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "Dove Nourishing Body Care Visible Glow Self Lotion 400ml", 0, 0, 0, null },
                    { new Guid("1a880c04-9766-4225-8adb-07a44dc9fba4"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Latest Bluetooth 5.1 Technology-This Bluetooth headset adopts Bluetooth V5.1 standard, you can achieve faster and more stable transmission. The transmission distance is up to 10m (32.8ft) (without obstacles). Compatible with most Bluetooth-enabled devices, such as iPhone, Huawei, Samsung Galaxy, LG, Sony, PC, laptop, etc. It can also be used with 2 devices can be connected at the same time, so you can separate your life and work.Long Working Time-The wireless headset has been tested for up to 10 hours of continuous calls and music time. 180 hours standby time. Fulfill your calling needs while multitasking with amazingly crisp and clear sound. The cell phone Bluetooth headset features Type-C fast charging, which can provide 7 hours of face-to-face communication experience with a single 1-hour fast charge. Clear Sound & High Quality Audio-The wireless headphones with a CVC 8.State-of-the-art noise reduction, which produces a more natural, distortion-free sound quality and clear sound. Dual microphone is designed for calls, not only is it easy to hear other people, but also prevents the noise and sounds around you from being picked up, you can enjoy high quality music and clear phone calls. Comfortable Lightweight Design-The lightweight construction makes it the perfect headset for drivers or business people,The main body of the bluetooth headset weights only 12g (0.4oz), which will not cause any pain even if worn for a long time.Moreover The earhook can rotate 270 so you can adjust it to your preferred angle. small, medium and large Three optional ear tips ensure a comfortable fit for both left and right ears.Hands-free & Mute Button- The bluetooth hands-free headset is equipped with a multi-function button, you can play or pause music, answer/end/reject calls. You can also enable voice controls like Siri and Google Assistant. In addition, you can press the separate mute button for 2 seconds to activate/deactivate the microphone, protect your privacy when you need it.", null, "Bluetooth Wireless Headset V5.1 Hands-free In-ear Hearphone With Microphone For Iphone Android", 0, 0, 0, null },
                    { new Guid("1b7b9131-8835-4305-966f-cdce7dbd1e2c"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "3W Clinic Crystal White Milky Body Lotion is a skincare product that claims to brighten and moisturize the skin. It comes in a 150g bottle and is designed to be used on the body.The lotion contains a blend of natural ingredients such as milk protein, pearl powder, and vitamin E, which work together to nourish and hydrate the skin. Milk protein is known for its ability to moisturize and soothe dry, irritated skin, while pearl powder is believed to help brighten and even out skin tone. The lotion has a milky consistency that feels lightweight and non-greasy on the skin. It absorbs quickly without leaving a sticky residue, and leaves the skin feeling soft, smooth, and radiant. Overall, 3W Clinic Crystal White Milky Body Lotion is a good option for those looking to improve the appearance and texture of their skin, while also providing it with essential moisture and hydration.", null, "3w clinic crystal white milky body lotion – 150gm", 0, 0, 0, null },
                    { new Guid("1f323240-b620-4f5b-9832-7422dc60a479"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", null, "LVSE Inside-Out T-Shirt", 0, 0, 0, null },
                    { new Guid("20bce264-21b5-41c4-a026-54b456d705c0"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product 1: Do Check Partner offer section for Exciting offers from HP Product 1: Processor: Intel Core i3-1115G4 (up to 4.1 GHz with Intel Turbo Boost Technology(2g),6 MB L3 cache, 2 cores)|Memory: 8 GB DDR4-3200 SDRAM (1 x 8 GB)| Storage: 512 GB PCIe NVMe M.2 SSD Product 1: Display & Graphics : 39.6 cm (15.6) diagonal, FHD, micro-edge anti-glare, 250 nits, 141 ppi, 45%NTSC |Graphics: Intel UHD Graphics Product 1: Operating System & Preinstalled Software: Windows 11 Home 64 Plus Single Language | Microsoft Office Home & Student 2021| McAfee LiveSafe (30 days free trial as default) |Pre-installed Alexa built-in- Your life simplified with Alexa. Just ask Alexa to check your calendar, create to-do lists, shopping lists, play music, set reminders, get latest news and control smart home. Product 2: Stay unbound, stay in control - enjoy lag-free 2.4GHz wireless connectivity on this durable mouse by HP with an 18-month long battery life. Product 2: Work at your pace by speeding up or slowing down tracking with adjustable DPI settings up to 1600 (800/1200/1600). Product 2: Work on your terms with an ambidextrous, contoured design suitable for both left and right-hand use. Product 2: Enjoy great compatibility across devices and on different operating systems - Windows 10, Windows 8, Windows 7, and MacOS 10.1 or higher.", null, "HP 15 Thin & Light Laptop (Intel i3 11th Gen/8GB RAM & 512GB SSD Storage/Win 11 Home + MS Office) X200 Wireless Mouse with 2.4 GHz Wireless connectivity and 18-Month Battery Life", 0, 0, 0, null },
                    { new Guid("21a4f24f-8a9a-4288-a74f-aec57d9a81d2"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "MacBook pro M2 chipset 256gb ssd 8gb ram space gray color with apple 1 year warranty", 0, 0, 0, null },
                    { new Guid("2ec5aa33-9976-48d6-8632-61c86d3b0bd5"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, 0, null },
                    { new Guid("43a5c240-7031-4bf2-80c5-93bcfcd79dd6"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Trendy Shoes for Men With Great Comfortable. SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure you are happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", null, "BRUTON Trendy Sports Shoes For Men (Blue)", 0, 0, 0, null },
                    { new Guid("4e831872-1041-4e8b-92a1-57c415b7c779"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, 0, null },
                    { new Guid("5302924a-517f-4001-ba8a-1cd3fd8f507a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "We believe everyone, everywhere deserves healed skin. Thats why we created the Vaseline® Healing Project, to help people living in crisis and disaster care for their skin. Here, Vaseline® Jelly is a necessity. Our Essential Healing lotion, powered by the same extraordinary Vaseline® Jelly, deeply moisturizes to keep dry skin healed for 3 weeks.*Our unique formula includes pure oat extract and Vaseline® Jelly, without feeling greasy.Our revolutionary smart pump unlocks and locks with just a 90º turn - even in the raised position, with no mess.*Proven after 4 weeks daily use in a clinical study.Water, glycerin, stearic acid, isopropyl myristate, mineral oil, glyceryl stearate, glycol stearate, dimethicone, peg-100 stearate, petrolatum, cetyl alcohol, tapioca starch, phenoxyethanol, magnesium aluminum silicate, methylparaben, acrylates/c10-30 alkyl acrylate crosspolymer, fragrance, propylparaben, disodium EDTA, xanthan gum, stearamide amp, avena sativa (oat) straw extract, titanium dioxide (ci 77891).", null, "Vaseline, Intensive Care, Essential Healing Body Lotion, 20.3 fl oz 600 ml", 0, 0, 0, null },
                    { new Guid("53908a26-1b53-4bab-9b2e-150971b235db"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "New Trend shoes for gents with all sizes", 0, 0, 0, null },
                    { new Guid("67162f94-7890-4aa8-8bce-38b6ff543e43"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Foldable headphones featuring Bluetooth® 5.1 wireless technology with full over-ear design for a better sense of isolation and greater comfort. Enjoy 25 hours of music with Deep Bass and clear calls with HQ voice calls.", null, "Headphones Bluetooth Style 3 Lavender", 0, 0, 0, null },
                    { new Guid("68949202-512a-4177-8be3-586018aad405"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "Kids Smart Watch,Boy Watch and Girls Watch Phone with Childrens Digital Camera Games Smart Alarm Clocks Music Player Calculator for 9 Year Olds Girls Boys As Birthday Toy Gifts or Cool Gadgets", 0, 0, 0, null },
                    { new Guid("6ae8d364-71f7-4697-8ea2-856497f2b293"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "Dove Nourishing Body Care Beauty Cream 150ml", 0, 0, 0, null },
                    { new Guid("6b916088-88e0-4e91-b1d7-7cf3dc3240ba"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Display The device features a 6.43-inch FHD+ Super AMOLED display with a screen resolution of 1080 x 2400 pixels. The bezel-less punch-hole display of the mobile is protected by Corning Gorilla Glass v3 and has a refresh rate of 60Hz. The display offers a fantastic viewing experience with an aspect ratio of 20:9 and a pixel density of 409ppi. The display is bright, and vivid, and offers excellent color accuracy, making it ideal for watching videos and playing games. Camera One of the most striking features of the Oppo F17 Pro is its Quad Camera setup on the rear side. The device features a 48MP f/1.7 Primary Camera with 10x Digital Zoom and ISOCELL Plus Sensor, an 8MP f/2.2 Ultra Wide Angle Camera accompanied by dual 2MP f/2.4 Mono Cameras. The camera setup offers excellent performance, capturing stunning photos and videos in all lighting conditions. The camera setup also offers features like Night mode, AI Scene Recognition, and Ultra Steady Video 2.0, making it a great device for vloggers and photographers. The device also features a dual-camera setup on the front, featuring a 16MP f/2.4 Wide Angle Primary Camera and a 2MP f/2.4 depth-sensing camera capable of capturing detailed self-portraits. The front camera setup also offers features like AI Beautification, Bokeh Effect, and AI Night Flare Portrait, making it an excellent choice for selfie lovers. Configuration and Battery The F17 Pro performs on MediaTek Helio P95 chipset and is also powered by an Octa-Core processor set up with Cortex A75 2.2GHz Dual-Core and Cortex A55 2GHz Hexa-Core. It also features a massive 8GB RAM along with PowerVR GM9446 GPU, offering an impressive gaming experience. The device runs on Android 10 and has a 4015mAh non-replaceable Li-ion battery, equipped with 30W v4.0 VOOC Charging technology. The battery life of the device is impressive, lasting a full day on moderate usage Storage and Connectivity The internal memory offered by Oppo F17 Pro is 128GB, which can be expanded up to 256GB as per users requirements. The device supports all 4G VoLTE, Mobile Hotspot, Wi-Fi, A-GPS Glonass, USB Type-C, and Bluetooth v5.1, making it a well-connected device.", null, "OPPO F17 ProUltra Function, Ultimate Fun", 0, 0, 0, null },
                    { new Guid("7996c998-8438-4d39-bdac-6391ed95f681"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty", 0, 0, 0, null },
                    { new Guid("84ec88b1-18e5-449d-b371-00c99ea5bdb4"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "Onex 16 Bangles with Golden Stone Work for Women Casual Wear Traditional Golden Diamond Single Line Bangle Set for Girls Churi Set", 0, 0, 0, null },
                    { new Guid("875b1782-293b-4556-a29f-86a37cc2a457"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, 0, null },
                    { new Guid("9891662c-c985-4d7f-93b6-6157c81e7b3e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", null, "SOFTSPUN Microfiber Cloth - 4 pcs - 30 x 40 cms - 340 GSM - Blue", 0, 0, 0, null },
                    { new Guid("9c1c4ba6-c80b-4098-96f7-8e974caf4910"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Samsung Galaxy S21 Ultra 5G is officially announced on January 14, 2021. The smartphone is pack with 12 GB and 16 GB RAM with 128 GB, 256 GB, 512 GB internal storage options. The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", null, "Samsung S21 Ultra", 0, 0, 0, null },
                    { new Guid("a5ee7002-d9ea-4d6a-a62a-b57f4fdf1549"), new Guid("fc7f2981-1031-4d10-8565-9cf93f211799"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, 0, null },
                    { new Guid("a999c4d8-e857-404c-9fa0-fbbc22d30956"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "All Product Size: 15.5 Inch,16 Inch,16.5 Inch MOQ: 1 Set=3 Piece (1 from every size Fabrics Type=Fancy 100% cotton Color: As picture shown Main keywords: Mens Fancy Shirt wholesale", null, "Cheap Price Mens Formal Shirt", 0, 0, 0, null },
                    { new Guid("bd3c3750-6dd4-4765-b5b3-9651f5e82454"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", null, "Gaming Headphone Asus with mutiple color and free delivery", 0, 0, 0, null },
                    { new Guid("e435fa18-70f5-441b-ac3b-c18fea7e1545"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Immerse yourself in deep, booming sound that delivers a theater-like experience for movies, shows, and videos. Its four front speakers and Dolby Atmos® support deliver an immersive, cinematic experience.Every member of the family will have their own tailored—and secure—experience with the Tab P10. Each user gets their own account—accessible through a multi-user fingerprint reader—with individualized settings, wallpaper, and social media accounts.Since every member of the family gets their own account on the Tab P10, parents can make sure their kids stay safe. Secure the content your kids access and put time limits on their usage. The Tab P10 also boasts enhanced eye protection and easy-to-use voice search.", null, "Lenovo Tab P10 | 10.1 Family Entertainment Tablet", 0, 0, 0, null },
                    { new Guid("e61a7b5d-844b-459f-9c41-1e5fee5214a0"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Intel Core I7 3770 3.40 GHz Processor 4Core 8threats 8Mb Caches with turbo boost H61 Motherboard DDR III Upto 1600MHz Memory 1 x HDMI 1 x VGA 1 x PCI Express x 16 Slot 1 x PCIEX1 Slot with 10/100 Mbps LAN Onboard DDR3 8GB 1600MHz 1 TB SSD GT 730 DDR5 4GB Graphic card 22 inch Monitor VGA & HDMI has an aspect ratio of 16:9 and with 1600 x 900 pixels | GAMING Keyboard Mouse WiFi Adopter Windows 10 Pro (trail) essential software ready to play", null, "CHIST Gaming PC Core i7 3770 processor 16 GB RAM 1 TB SSD Windows 10 GT 730 4GB ddr5 Gifted", 0, 0, 0, null },
                    { new Guid("e978c68c-987a-404f-ba58-655cee5074da"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "ZenBook Pro Duo 15 OLED lets you get things done in style: calmly, efficiently, and with zero fuss. Its your powerful and elegant next-level companion for on-the-go productivity and creativity, featuring an amazing 4K OLED HDR touchscreen. It also includes the tilting ASUS ScreenPad™ Plus secondary 4K display that offers effortless ergonomics and seamless workflows. Powered by up to an Intel® Core™ i9 14-core processor and NVIDIA® GeForce RTX™ 3070Ti GPU, ZenBook Pro Duo 15 OLED brings you all the benefits of tomorrows technology, today.", null, "Zenbook Pro Duo 15 OLED (UX582, 12th Gen Intel)", 0, 0, 0, null },
                    { new Guid("eaf098a5-a400-4ac7-b70e-ad07eb2ffd0c"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "1 cross button function two left and right 3D joystick functions 8 numeric keys 4 function keys. With 7 channels of LED indication.The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", null, "Dualshock Gaming Remote Controller Console Gamepad Joystick for Playstation", 0, 0, 0, null }
                });
        }
    }
}
