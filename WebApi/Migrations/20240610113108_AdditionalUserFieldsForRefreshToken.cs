﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalUserFieldsForRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cf5ddc6-2562-403e-9132-e2ddc0f9bf5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4a5abae-8c16-4bc7-80f9-fecc4a649190");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2e3c853f-562d-4468-b731-e693d927a20d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5584ac69-93cb-4464-b726-19a8f6dbf3a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60fbc859-21a1-411a-8e20-9fb2359d20e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e6d5204-c12f-4162-b8e2-bd1ced52b205"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91a56d00-c014-4a41-af07-8a32a7468dc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4e8509c-79e0-4466-8831-8eaf2db27355"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3fa2ce9-fbdb-4bff-81dd-d4831875e328"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd93d780-f010-4362-8b30-b2c71f8bb322"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e835a2b0-a253-43e8-94d8-bb4014f9b758"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec00550b-bf14-4fdf-b60e-4384bf57129e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("03113f34-d4b2-49b0-9d29-201719ec90cc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("06e2c2a0-ec68-4f52-afea-7e48c04608dc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("07570d87-0264-4c77-996c-7bfad9a9529f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0df32950-f3d3-4df9-8ac3-9b767cdb7c88"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0e933bf9-63f8-4a06-800a-14ce2089ae84"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("10698917-9305-4b89-b007-d33bdd86a5f8"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("143f3e8b-31a4-4144-bc2e-b60da15d93f3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("14610ae4-31bf-4bdd-ab3d-726682cdf2a4"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("146e5496-d1fc-4ebf-bae1-cb27e843deec"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("16c5cc4e-3dcb-4161-a9dd-d0edd4ba8ef4"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("18228a68-bfe7-493d-803f-a730c5be5f14"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("1f60f90c-dca6-47d0-8862-f573baca3bef"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("2fa9b489-272e-4f64-bd24-4684139bbbc1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("32d813f5-439f-403a-9234-e03cd302e99d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("33c09638-ad69-4045-8eb3-7be41d00e946"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("39d27f91-f4de-4f7d-8140-e61e966173ea"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3b8f188a-75f3-419f-94e1-5aec4b177757"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3d7badb9-061c-4a4f-a2de-110b2497eedc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3ef99c5e-2a77-4746-80d1-db3f102c55a2"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3f693d7c-2b12-4348-8e5b-9ee43b5d4125"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("43138110-7e74-4163-9c70-2e36267501a9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("45fe42b6-c84f-42eb-842f-ca40d65e919d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("473eda4c-f025-4b54-a205-88639991f5e0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4b5cdb24-0a9c-4355-9a04-c53cb864bac2"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4c7a253e-4801-4b26-a02a-5b88bf352f5c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("55bf927e-a428-4b0e-ae14-04f655f2ad22"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("5e58cf56-dc16-4686-bc6f-a5e708ae6a9d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6345509a-f148-49e7-89f9-0a128030440b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6a0cb54c-fea8-4ac7-b213-eeb4c7495466"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6bd61e5b-3bf9-4dcc-8637-7adcc2e5038e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6c69e0d3-f6cc-46c1-bd65-4cc650314109"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6e3524ff-ba6b-4903-80e5-bca4fdb74429"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("82116667-cd45-439f-b64b-f2109068f698"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("82224ab0-14fd-4ca0-94f6-05a70e4841cf"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("86f92ca1-85d4-43a0-86ae-516e973750b0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8f0b93c6-506e-47f3-a196-caf8934d8009"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("96dd12f5-a64e-4cea-9762-604da469d3e5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("981ef740-94cb-4bf2-8a0c-fc6ddd7e1ca1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("987fc4b5-62bf-4d28-b556-0763ead9a713"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("99b2b22c-2d0e-43be-9834-4dde8a5ef592"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("9d8e60d9-9c6b-443a-8ffa-e538fec91fe1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a066a2f1-263f-4297-8699-132ec33db28a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a483c334-8c0b-46be-9a21-85f8d4e5bad5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a4aedc7d-cd6b-4ce5-acb3-c64248e90f0d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a606e509-5d92-416b-8a6b-bdf4eef1c2f8"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a6d195d9-12e2-4074-85df-f6dced0908a2"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a7a21659-0141-4522-8963-321ea9803c93"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b3caaa1f-4538-423f-8109-f5fc520d475d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b8cc2761-0e4c-485a-831f-34a783533c35"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("c08583ea-6514-4df8-b387-df8b7be6d1f9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("c6f227ec-bce7-4407-bc33-1a4c6f080d58"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("cadb81eb-df33-49de-bc9e-aaada562f460"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("cc449002-a4a7-49e5-b79c-5c41b74df07b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("dd5d875a-3b40-4a8a-a504-7b22efefece1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("eb563e05-8dd6-42eb-8e18-44577521ca65"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("fc7cfcf9-dab5-4dec-9e44-7794625e6f4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1aae6456-626d-4875-b05f-c48e77cb1578"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b6d293b-2995-4290-a715-0f3f3d73dcb7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1eafc910-4538-44a9-a752-e91b585dc1fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("270c9225-026a-420b-b4e7-3e0545577cf3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43586853-83de-413f-838c-4c936e2c6ed9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43c6188f-afa1-4a9c-8d7a-9489a4207614"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4de99f83-df15-4872-8152-9034a4bf4872"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("586ea1bd-c0ac-4985-ba42-1c90063dc311"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c2ffd03-6488-489d-9bda-4eef42a9cd51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("671bb128-d5b3-4ae4-98f3-5358545b8219"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e9358f6-fa2c-42f0-b6f3-0d78e7da43e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81d14f9c-8a47-4c1b-ac7b-ad7f5a244613"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("904ffa23-7aff-4c5f-8eef-a0d08262df91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99326da9-f126-4ea1-b6de-221b20cd4685"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac0cfed2-698b-487f-bad0-568c5c5a1fe6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae98d15a-e137-4e69-bb63-666e0456c84a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8ae55af-3c7a-4b27-9203-43c0df3c758e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be114ac8-de23-4b62-adc8-ce4827e2c66a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8215456-0f68-4cab-8ddf-7e384a00ff64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8e6f6d3-28c8-470b-beb5-a9254ea0cd60"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c98ae0be-ba59-43d2-b785-3308f90aefbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca0c5096-ed20-4426-af88-bbbc89a500f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc9baf54-213f-43c6-961b-ba3e775bf1f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dfecd375-0d9e-405c-8e48-ff8b639831bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea89dee7-3be0-4099-9161-1fb61331de12"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec4bba36-d3c3-41a7-964a-770024dc2b0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee3069df-93d7-40fe-9828-a38acd6bf9e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb5b1cdb-8119-49b3-8a65-7577517c0b84"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("12d1a67f-9bec-4640-b1d7-c87bf3fd81aa"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("02435cad-1fd2-47b8-8fbe-1d8ab9946bcc"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("054a5bfe-8ea9-408e-ab10-a1ca8001da2e"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("08f5fe17-e8c6-4a0d-8833-f2a640788a02"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("1a7ae8ed-6c49-493c-870d-b3e97d1c8364"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("1b22dc8a-cdca-4f3d-bf8f-e19a7a7e83b6"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("1dc224bd-d24c-4c40-b56d-fbc0a59ead62"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("20a9feea-138c-4ae8-b5bb-d69968215b25"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("2ff61cc5-d9a0-4b11-9679-b733aa8d077a"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("30b527eb-4c80-4c65-8a2c-ab8637ef3574"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("37e7319a-dd62-4213-902d-8f3e07331634"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("40230b82-65ea-4395-ab16-24025ad04733"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("477f35a0-50ce-4a11-809e-0f6b187afe60"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("5178bb20-89f0-420c-ba8b-bae1769565fe"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("52cfa952-a799-4fae-843a-d5416b5273ba"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("565f957d-67b1-451a-b824-d853ecd96fa0"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("6e76835e-78f8-4882-a4c2-4fd72570c4b4"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("9a0828d9-9300-45dd-a019-86d1d23a36a7"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("b91059a9-02e0-48ae-a2e6-8a7a569baa7b"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("c085065e-6d02-4798-b2c6-42152e0bd0e4"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("c6080620-89e4-4205-8a40-99a5b4fc91dd"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("c7154e88-8d4e-4d38-91ae-db6618d9d3d6"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("c9fd09de-96f0-4e07-ad39-27ae833092eb"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("edf8c28b-af0d-462a-afc8-b4792b25bba0"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("ee7ec040-4469-4016-a9d4-e2546d35e73c"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f0b5d68e-52ea-40f7-b1e8-5bac1c962a4d"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f2938b10-f6c7-4d90-90d1-18834de8f6bf"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f41e8c6a-243c-4c0d-97c5-6a4a6a368201"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f7e9136d-a4a5-460e-8360-89a1399fb281"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("050fdcbe-6f15-45ac-9cd5-1c0b18a2d9e6"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("061bb05f-b316-47e5-845f-249d6e8baf4f"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("13ec4f66-6dd5-4ff8-a350-1968456e8ad3"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("18de83e3-ca69-4fae-ae59-3eace814227d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("296cd27f-c30f-4680-a6eb-4fb0cc084e3b"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("2db59025-375a-422e-9a7d-b753d09dde36"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("385980c1-4bc6-4835-b839-0e8dfee11861"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("39e15af9-c0c4-4709-805d-9f260a67679e"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("3a14a5b5-6157-4dea-937e-f3c10f599ce0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4867f059-4c5a-4b43-a18f-4334b76400bb"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4fa3da01-15d4-49e6-bd83-0fcc01a4c645"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("5dc94767-5867-41cf-b28d-d3345d3e8ad2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("6930533c-0c8e-4ca9-aa1d-088561f23d92"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("6e0addb1-a9c4-4660-8731-2dc32059488a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7087cfe1-1906-47c7-a89c-39226714018d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7f15db37-cc93-4080-93ab-c355894fa163"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("8771e363-b254-411f-93d8-d13e5d365f15"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("92a182cd-0b55-4c76-8ffa-f7858becab26"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("9f6bbfc6-858a-45f0-adf3-cfc82356ca84"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a14c7769-2b44-4a21-89c2-fe0a8cae7b4d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a3fedf5a-47ec-41d6-9df7-5c8b48b246d0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c1ba4147-0b4c-42c0-8a93-e7b1ad7116f3"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c3bce486-c0aa-4695-99d9-306dfb0de30b"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("d0285ace-587e-41e8-859b-b287a47606d4"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("d8a2be84-0939-4b4e-80f0-c7fe85dd0adc"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("deabdf54-d633-4854-ba3e-5df5e54754ac"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("f382ee5b-a867-464f-9dff-6b161b156ed4"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("f7abb8ef-5b82-4d56-ae3e-8c631cf24877"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e824988b-492f-4489-be87-9536b536be23");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "191a5ab4-4f2f-454e-81f4-e34781a652b8", null, "Administrator", "ADMINISTRATOR" },
                    { "7017fd62-7bae-4529-b5eb-20184faea342", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("024d3bb5-fc4d-46cb-b196-2a654819ee69"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" },
                    { new Guid("17347cda-4440-467b-8275-6464c1bcbfa0"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("1c946b68-4d9c-43fa-a145-77c1a795ba0c"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" },
                    { new Guid("4bf4985d-e022-4721-87df-156f72036b0d"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("59e0196a-c5b2-4340-881f-243a828f82f7"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("881f9719-003e-404e-a405-a80801f62726"), "", "", "Others" },
                    { new Guid("ba1cc706-9d4a-41b8-9f83-ef8aba14612c"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("ca9fe302-c6cd-4d5a-a460-bef0c30ef5c7"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("cd586a5c-5ba7-4a65-84db-d5908f9b2088"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" },
                    { new Guid("f02d00b6-54bb-4e48-bc43-fc9cd3def502"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" }
                });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "ProductId", "PublicId", "Url" },
                values: new object[,]
                {
                    { new Guid("0017f244-66e2-496b-bd2b-106b51dca494"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("04a29587-5d8b-41a4-a043-b162465da987"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("0d3d03a7-0e55-4c0c-a217-4e143b91cc79"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2zcpFb-6hMeoBVWrfp4LazbLD3a1tEjJjY2oYq45yJOyb28WIIYBoJ3qZMsmFdImBSZk&usqp=CAU" },
                    { new Guid("0ffbf223-1e65-4238-9437-4df219e4813a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("1093846c-050a-4cda-840b-947692e778a8"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("136753e2-bb03-46cb-a28a-fe34980ae5bf"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("18b81e19-0c38-471c-b1ae-648700aab92f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://eratablet.com/wp-content/uploads/2022/08/H51ba6537405f4948972e293927673546u.jpg" },
                    { new Guid("1eb222cb-80df-4cb7-bc8d-33a026350f7d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("1eb4add8-b3ed-4bca-8e7f-b972283b10a1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("26a5309f-13d6-49a4-9d8b-d65273106e1f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("2b96c5a0-3243-48ce-b887-7c5b527f5741"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("337dad38-f567-46f4-bf2c-00ad96e08299"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42FePhUrLX424aLie09J4Pfkn03T8h3D7PQ&usqp=CAU" },
                    { new Guid("37414111-ab1d-43f1-8066-eb683cafbba3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("3cc92386-bbba-4d74-9ed6-c919b6cf76b3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("3f647ec7-97c0-4e3f-9849-540d97bb4d87"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.startech.com.bd/image/cache/catalog/headphone/havit/h763d/h763d-02-500x500.jpg" },
                    { new Guid("45227aae-acd4-4b29-8818-463437f0bffa"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("47975165-a13f-4b78-87ba-c37bfe9aa184"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("4a4b941f-cdb9-45c9-b3e5-7b7c7403302f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("4c59a95e-ed2e-4cf0-b5c1-d93864253a01"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("4d33df82-05c6-4bac-aeb9-fb12629adb5a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("58da4458-e14e-424c-9190-97b021e1c4b6"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("638fc822-01ba-4e1c-8ae3-c4d59604e536"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("63cd6f37-c4c1-4c3d-b561-4ce2794d98fc"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("6402786b-4da2-4acb-8bbc-0db9a82f7973"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("66f542b3-011f-4b11-967d-9f088a2d823e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("6a2a86a6-4bad-4069-929d-38530f7ba366"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("6c54a19e-16cb-407b-a992-e048bae47132"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("71bbd7d1-3875-4ab7-a54b-fdd666bddf72"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.bdstall.com/asset/product-image/giant_213181.jpg" },
                    { new Guid("72d37ca1-efe6-4c46-bf29-6bf703d5f363"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("73d9effd-4509-432d-ab48-5ebeafb1c528"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://adminapi.applegadgetsbd.com/storage/media/large/iPhone-14-Pro-Max-Silver-8456.jpg" },
                    { new Guid("7937020d-8af1-4433-b8dc-f7f33a4dfb58"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("7c4d174f-e886-43a5-9013-affc86fdc1f7"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("7c99c118-8140-4171-b6ba-0e5a5a1ea243"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://unixnetworkbd.com/image/cache/wp/gj/unix_network_images/product/gaming-pc-9th-gen-core-i7-9700k/Gaming-PC-9th-Gen-Core-i7-9700k-Unix-Computer-jashore-bangladesh-500x500.webp" },
                    { new Guid("7f4f5d0a-7e8d-4158-a6bd-94b26ef29e76"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("82c748f5-85c3-4831-9ede-8d1cde4a3f6c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("8ad8675d-d91f-41aa-a6f6-34942ca5ab3d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("8d97638c-eada-46ec-bb2a-0f21abd93d3f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("95f8fe3c-6c37-4236-9af4-456cab4d4ca3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("9b728a57-8434-4c5a-a69c-016e3912c9ed"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499" },
                    { new Guid("9c8f7491-6492-4604-af50-f6b4534804c2"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("a262c2d8-932c-46f8-b91d-12895e3ad5f3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("acc1a9c8-f064-48b8-a121-b94c4d343154"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("b83883d7-35f1-4a2f-bfcd-9ad0a28b6bbe"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("bca185a6-c282-4f7c-ac93-6bf34b7e456c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("bdbfe3a6-6791-4b68-b399-2278f087ab7c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("cc7f88fe-d8c4-4a03-9db5-a61df21d0a3e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("cebf28ce-f7cd-417b-b107-cc58170bff95"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("d4ac96e9-94da-46c3-a3d7-cf3562b4b30a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("db4ee12f-f2bc-4650-9967-e930baed7930"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBOB80TIoBkL_NaeJ_5lG5LuUsD0IYEDXFJg&usqp=CAU" },
                    { new Guid("dd6f4ab9-97f6-4856-a5f2-29949e254ce0"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("e26ca839-f400-4280-afa7-db8f5f98c2c9"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("e701599b-ba03-438e-b16e-94fee5bed687"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("e7c74c3a-4978-496a-b607-80f293b9c4ce"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("efc37995-8fb1-47d3-a141-2629a2b689de"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("f2791ae6-1c0e-4206-b1f9-fa90291c090d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("fb73fdce-d216-405b-85a2-fe779f7374e6"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount_Price", "Name", "Price", "Rating", "ShopId", "Stock", "Total_Sell" },
                values: new object[,]
                {
                    { new Guid("0b1b8682-3fcd-43bb-afe9-2610ffd67e2c"), new Guid("fc7f2981-1031-4d10-8565-9cf93f211799"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("0e9099ca-542b-4f4b-b738-c9d2ad828c73"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Gaming Headphone Asus with mutiple color and free delivery", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("1156bcb0-d2bc-4ed8-8670-7c8e7cb63917"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Latest Bluetooth 5.1 Technology-This Bluetooth headset adopts Bluetooth V5.1 standard, you can achieve faster and more stable transmission. The transmission distance is up to 10m (32.8ft) (without obstacles). Compatible with most Bluetooth-enabled devices, such as iPhone, Huawei, Samsung Galaxy, LG, Sony, PC, laptop, etc. It can also be used with 2 devices can be connected at the same time, so you can separate your life and work.Long Working Time-The wireless headset has been tested for up to 10 hours of continuous calls and music time. 180 hours standby time. Fulfill your calling needs while multitasking with amazingly crisp and clear sound. The cell phone Bluetooth headset features Type-C fast charging, which can provide 7 hours of face-to-face communication experience with a single 1-hour fast charge. Clear Sound & High Quality Audio-The wireless headphones with a CVC 8.State-of-the-art noise reduction, which produces a more natural, distortion-free sound quality and clear sound. Dual microphone is designed for calls, not only is it easy to hear other people, but also prevents the noise and sounds around you from being picked up, you can enjoy high quality music and clear phone calls. Comfortable Lightweight Design-The lightweight construction makes it the perfect headset for drivers or business people,The main body of the bluetooth headset weights only 12g (0.4oz), which will not cause any pain even if worn for a long time.Moreover The earhook can rotate 270 so you can adjust it to your preferred angle. small, medium and large Three optional ear tips ensure a comfortable fit for both left and right ears.Hands-free & Mute Button- The bluetooth hands-free headset is equipped with a multi-function button, you can play or pause music, answer/end/reject calls. You can also enable voice controls like Siri and Google Assistant. In addition, you can press the separate mute button for 2 seconds to activate/deactivate the microphone, protect your privacy when you need it.", 0, "Bluetooth Wireless Headset V5.1 Hands-free In-ear Hearphone With Microphone For Iphone Android", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("1a6e15ee-64e4-4646-818e-8383da5fb00f"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Visible Glow Self Lotion 400ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("1abb8192-5116-4984-9291-a12715275215"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("336daef9-7f6f-4e39-9286-face840a7c0a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "TIAM Anti Blemish Body acne / bumpy skin / skin soothing / skin spot improvement- Special body lotion that solves skin problems- Body flaw soothing lotion: AHA, BHA, and Calamine core ingredients sooth trouble skin that is sensitive – Whitening functional ingredients clean up the bodys trouble and spots. AHA, BHA and Calamine calms down the sensitive and troubled skin. Whereas whitening ingredients helps with the dull and uneven skin tone. It also has ingredients which helps get rid of dead skin cells and sebum making skin smooth and soft. A body with a thicker skin layer than the face needs more care – Removes clogged pores and sebum with AHA, BHA, calamine and various active ingredients, and cares for skin defects to make it clean and smooth. Ingredients: Water, Niacinamide, Propanediol, Alcohol, Cetyl Ethylhex anoate, Calamine, Dimethicone, Glyceryl Stearate, PEG-100 Stearate, Polysorbate 60, Cetearyl Alcohol, Arachidyl Alcohol, Behenyl Alcohol, Arachidyl Glucoside, Sorbitan Stearate, Allantoin, Salicylic acid, Lactic Acid, Zinc PCA, (-)-alpha-bisabolol, Melaleuca Alternifolia (Tea Tree) Leaf Oil, Mentha Viridis (Spearmint) Leaf Oil, Methylpropanediol, Lauryl pyridinium Chloride, Polyacrylate-13, Polyisobutene, Polysorbate 20, Tocopheryl Acetate, PEG-60 Hydrogenated Castor Oil", 0, "TIAM ANTI BLEMISH BODY LOTION 200ML", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("3f435cf4-8ec3-4992-a5bb-0af898a6c7b6"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product 1: Do Check Partner offer section for Exciting offers from HP Product 1: Processor: Intel Core i3-1115G4 (up to 4.1 GHz with Intel Turbo Boost Technology(2g),6 MB L3 cache, 2 cores)|Memory: 8 GB DDR4-3200 SDRAM (1 x 8 GB)| Storage: 512 GB PCIe NVMe M.2 SSD Product 1: Display & Graphics : 39.6 cm (15.6) diagonal, FHD, micro-edge anti-glare, 250 nits, 141 ppi, 45%NTSC |Graphics: Intel UHD Graphics Product 1: Operating System & Preinstalled Software: Windows 11 Home 64 Plus Single Language | Microsoft Office Home & Student 2021| McAfee LiveSafe (30 days free trial as default) |Pre-installed Alexa built-in- Your life simplified with Alexa. Just ask Alexa to check your calendar, create to-do lists, shopping lists, play music, set reminders, get latest news and control smart home. Product 2: Stay unbound, stay in control - enjoy lag-free 2.4GHz wireless connectivity on this durable mouse by HP with an 18-month long battery life. Product 2: Work at your pace by speeding up or slowing down tracking with adjustable DPI settings up to 1600 (800/1200/1600). Product 2: Work on your terms with an ambidextrous, contoured design suitable for both left and right-hand use. Product 2: Enjoy great compatibility across devices and on different operating systems - Windows 10, Windows 8, Windows 7, and MacOS 10.1 or higher.", 0, "HP 15 Thin & Light Laptop (Intel i3 11th Gen/8GB RAM & 512GB SSD Storage/Win 11 Home + MS Office) X200 Wireless Mouse with 2.4 GHz Wireless connectivity and 18-Month Battery Life", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("49b90c6b-98eb-4ef1-a865-2d848ae119e2"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "1 cross button function two left and right 3D joystick functions 8 numeric keys 4 function keys. With 7 channels of LED indication.The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Dualshock Gaming Remote Controller Console Gamepad Joystick for Playstation", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("5b3405ee-3649-4fac-ae09-9d0266228031"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "All Product Size: 15.5 Inch,16 Inch,16.5 Inch MOQ: 1 Set=3 Piece (1 from every size Fabrics Type=Fancy 100% cotton Color: As picture shown Main keywords: Mens Fancy Shirt wholesale", 0, "Cheap Price Mens Formal Shirt", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("5ba51127-c364-4ca5-8c52-ae0cedad9f4b"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Kids Smart Watch,Boy Watch and Girls Watch Phone with Childrens Digital Camera Games Smart Alarm Clocks Music Player Calculator for 9 Year Olds Girls Boys As Birthday Toy Gifts or Cool Gadgets", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("5fdfd5f8-c687-4cf5-94e7-c0d9c4d4d32a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "ZenBook Pro Duo 15 OLED lets you get things done in style: calmly, efficiently, and with zero fuss. Its your powerful and elegant next-level companion for on-the-go productivity and creativity, featuring an amazing 4K OLED HDR touchscreen. It also includes the tilting ASUS ScreenPad™ Plus secondary 4K display that offers effortless ergonomics and seamless workflows. Powered by up to an Intel® Core™ i9 14-core processor and NVIDIA® GeForce RTX™ 3070Ti GPU, ZenBook Pro Duo 15 OLED brings you all the benefits of tomorrows technology, today.", 0, "Zenbook Pro Duo 15 OLED (UX582, 12th Gen Intel)", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("784240eb-b089-41e5-8a2a-b9bda33d4dc0"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space gray color with apple 1 year warranty", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("807a0c85-e2e3-4682-bb6c-6e5b859cf754"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Foldable headphones featuring Bluetooth® 5.1 wireless technology with full over-ear design for a better sense of isolation and greater comfort. Enjoy 25 hours of music with Deep Bass and clear calls with HQ voice calls.", 0, "Headphones Bluetooth Style 3 Lavender", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("8f9c22be-a69e-4b98-bffe-4118d4e35827"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "LVSE Inside-Out T-Shirt", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("9208d9bd-5b65-4ffa-9a8d-e0adbd80203a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Samsung Galaxy S21 Ultra 5G is officially announced on January 14, 2021. The smartphone is pack with 12 GB and 16 GB RAM with 128 GB, 256 GB, 512 GB internal storage options. The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Samsung S21 Ultra", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("969ceeaa-1cc2-4524-9296-1dedea07eab9"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Trendy Shoes for Men With Great Comfortable. SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure you are happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "BRUTON Trendy Sports Shoes For Men (Blue)", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("97107600-0846-40c6-921a-4db12253b008"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("a971e98b-4e59-4cb4-ae39-593a326d9d58"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("b5bbc7c1-5033-429b-8340-6ed52d170caa"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "We believe everyone, everywhere deserves healed skin. Thats why we created the Vaseline® Healing Project, to help people living in crisis and disaster care for their skin. Here, Vaseline® Jelly is a necessity. Our Essential Healing lotion, powered by the same extraordinary Vaseline® Jelly, deeply moisturizes to keep dry skin healed for 3 weeks.*Our unique formula includes pure oat extract and Vaseline® Jelly, without feeling greasy.Our revolutionary smart pump unlocks and locks with just a 90º turn - even in the raised position, with no mess.*Proven after 4 weeks daily use in a clinical study.Water, glycerin, stearic acid, isopropyl myristate, mineral oil, glyceryl stearate, glycol stearate, dimethicone, peg-100 stearate, petrolatum, cetyl alcohol, tapioca starch, phenoxyethanol, magnesium aluminum silicate, methylparaben, acrylates/c10-30 alkyl acrylate crosspolymer, fragrance, propylparaben, disodium EDTA, xanthan gum, stearamide amp, avena sativa (oat) straw extract, titanium dioxide (ci 77891).", 0, "Vaseline, Intensive Care, Essential Healing Body Lotion, 20.3 fl oz 600 ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("b62090b6-3558-446a-9618-cd895a06ee0e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Onex 16 Bangles with Golden Stone Work for Women Casual Wear Traditional Golden Diamond Single Line Bangle Set for Girls Churi Set", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("bbe52ffe-bec6-4418-b737-57a3f02a2d6e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Intel Core I7 3770 3.40 GHz Processor 4Core 8threats 8Mb Caches with turbo boost H61 Motherboard DDR III Upto 1600MHz Memory 1 x HDMI 1 x VGA 1 x PCI Express x 16 Slot 1 x PCIEX1 Slot with 10/100 Mbps LAN Onboard DDR3 8GB 1600MHz 1 TB SSD GT 730 DDR5 4GB Graphic card 22 inch Monitor VGA & HDMI has an aspect ratio of 16:9 and with 1600 x 900 pixels | GAMING Keyboard Mouse WiFi Adopter Windows 10 Pro (trail) essential software ready to play", 0, "CHIST Gaming PC Core i7 3770 processor 16 GB RAM 1 TB SSD Windows 10 GT 730 4GB ddr5 Gifted", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("cda45e29-44d4-4955-b672-5ce2750790c9"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Trend shoes for gents with all sizes", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("cf8ad8a3-c420-4509-95dc-0ed9b518f2ea"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "SOFTSPUN Microfiber Cloth - 4 pcs - 30 x 40 cms - 340 GSM - Blue", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("d497a049-514f-412b-aacd-ae72ca94e2cb"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Display The device features a 6.43-inch FHD+ Super AMOLED display with a screen resolution of 1080 x 2400 pixels. The bezel-less punch-hole display of the mobile is protected by Corning Gorilla Glass v3 and has a refresh rate of 60Hz. The display offers a fantastic viewing experience with an aspect ratio of 20:9 and a pixel density of 409ppi. The display is bright, and vivid, and offers excellent color accuracy, making it ideal for watching videos and playing games. Camera One of the most striking features of the Oppo F17 Pro is its Quad Camera setup on the rear side. The device features a 48MP f/1.7 Primary Camera with 10x Digital Zoom and ISOCELL Plus Sensor, an 8MP f/2.2 Ultra Wide Angle Camera accompanied by dual 2MP f/2.4 Mono Cameras. The camera setup offers excellent performance, capturing stunning photos and videos in all lighting conditions. The camera setup also offers features like Night mode, AI Scene Recognition, and Ultra Steady Video 2.0, making it a great device for vloggers and photographers. The device also features a dual-camera setup on the front, featuring a 16MP f/2.4 Wide Angle Primary Camera and a 2MP f/2.4 depth-sensing camera capable of capturing detailed self-portraits. The front camera setup also offers features like AI Beautification, Bokeh Effect, and AI Night Flare Portrait, making it an excellent choice for selfie lovers. Configuration and Battery The F17 Pro performs on MediaTek Helio P95 chipset and is also powered by an Octa-Core processor set up with Cortex A75 2.2GHz Dual-Core and Cortex A55 2GHz Hexa-Core. It also features a massive 8GB RAM along with PowerVR GM9446 GPU, offering an impressive gaming experience. The device runs on Android 10 and has a 4015mAh non-replaceable Li-ion battery, equipped with 30W v4.0 VOOC Charging technology. The battery life of the device is impressive, lasting a full day on moderate usage Storage and Connectivity The internal memory offered by Oppo F17 Pro is 128GB, which can be expanded up to 256GB as per users requirements. The device supports all 4G VoLTE, Mobile Hotspot, Wi-Fi, A-GPS Glonass, USB Type-C, and Bluetooth v5.1, making it a well-connected device.", 0, "OPPO F17 ProUltra Function, Ultimate Fun", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("d73d6df9-adc2-4d04-bbe8-ce342916ec8e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("dca64784-3eb3-4c8a-96b4-0b7fa930fdcf"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Beauty Cream 150ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("f7de0b4a-03ee-4f9a-99ce-ca70ec3b668f"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Immerse yourself in deep, booming sound that delivers a theater-like experience for movies, shows, and videos. Its four front speakers and Dolby Atmos® support deliver an immersive, cinematic experience.Every member of the family will have their own tailored—and secure—experience with the Tab P10. Each user gets their own account—accessible through a multi-user fingerprint reader—with individualized settings, wallpaper, and social media accounts.Since every member of the family gets their own account on the Tab P10, parents can make sure their kids stay safe. Secure the content your kids access and put time limits on their usage. The Tab P10 also boasts enhanced eye protection and easy-to-use voice search.", 0, "Lenovo Tab P10 | 10.1 Family Entertainment Tablet", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("fec29b3a-3a28-499c-8fe3-64af2249b8ec"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "3W Clinic Crystal White Milky Body Lotion is a skincare product that claims to brighten and moisturize the skin. It comes in a 150g bottle and is designed to be used on the body.The lotion contains a blend of natural ingredients such as milk protein, pearl powder, and vitamin E, which work together to nourish and hydrate the skin. Milk protein is known for its ability to moisturize and soothe dry, irritated skin, while pearl powder is believed to help brighten and even out skin tone. The lotion has a milky consistency that feels lightweight and non-greasy on the skin. It absorbs quickly without leaving a sticky residue, and leaves the skin feeling soft, smooth, and radiant. Overall, 3W Clinic Crystal White Milky Body Lotion is a good option for those looking to improve the appearance and texture of their skin, while also providing it with essential moisture and hydration.", 0, "3w clinic crystal white milky body lotion – 150gm", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("f34cc615-01a5-45e2-86dc-e5a2e510a07d"), "comment", new Guid("00000000-0000-0000-0000-000000000000"), 5, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "PublicId", "ShopId", "Url" },
                values: new object[,]
                {
                    { new Guid("044f24cd-4319-4a8d-992b-be346c888486"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("05616741-a2a2-4ad0-bbd9-10ccc088c9f5"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("08fbf5d7-9809-4345-93a2-cc18f40deb65"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("1089b636-d42a-4a38-b3d6-7f5201aa9fa6"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("16388211-2e68-44b0-9802-c36d48eb992e"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARwAAACxCAMAAAAh3/JWAAAAgVBMVEUAAAAKCgr///8GBgbb29vR0dHk5OTIyMjt7e2zs7O+vr719fWqqqqenp7e3t6Xl5cuLi4hISGBgYGJiYnExMRCQkIVFRWQkJDOzs7i4uJzc3MmJiZPT08fHx83Nzd5eXlaWlpiYmJGRkakpKRra2syMjJEREQ6OjpVVVUSEhJ1dXU8mJS/AAAE9UlEQVR4nO3c63aiPBiG4SBBAoIbQDYFRdx8as//AL/kjW2dafvOais6Os/1Y4ghKtx109quEQIAAG5oOZ/Pl/tbH8VfynEd4Ti3PgoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIDvcU+cD+jpWx/e9X3S4mP/SqGvNLGOOXGPVOnWx9+Pr1exxDwh4Va8Po5ufS6X9M0spziH1LRJ1VScTz9CoB91sXHa1Ah88W7XHT+Evvs8+i3ArDBSmVIcm+Ptlu8yz0XCGKKJJ8awEeY/0c138/V86tAdmPtxZjvznw/X55HcejnfT2n3p+1mu/1y1m+Cj10sDMVJNlocSn3D83ayicnkWXfp2vTlchwXSUd3vnwq7MSmSBvRTczDLja78hVFjmO9ZBKFmV+WfpQu77eMiRMRuRHTInojfdeNT+PAbrxAiLrdvM0E3iS3g0Qf1zQxo8A7bKOs9OR4qCk13N5tGfOsCohaLTdm2y6nB32KQTROlnZPtOoKO5JNndIg7bqIBv6KrhROhJh2oRlmSRf6vl8GT9tgPK50n+ZOy5g4aRZqWdWYTSj100kkZsovt7QnHLtiZ0dqFdPA+08sOjs1mZhtFoh6TpezWF8r831vL/JISqnzRFco00sa/WYUevoL7Q+jwKftVKxj+tLLbEMzMhLOtqShl9C2LM0LjJ0KC9qGog5okDV2iS4ycyqqU/aeppcymtgPpfQ8TxXmX68q55tSn1IZpNvWI2olnIhG4+I0sxXuIqX1XtnabW0vy0NAF+VKP8/WY91mXIV3mkbHKdSwGutXz0ifiZRVIIdelHR13orWfOGlVELsPBoN07GdqYVYhDQexlu76kCbcbGnS3Ksj3qXVjpNpZJe2/SXRsfxRkq/pSg/NG8uQ2+T7BfHvN76hbAzSr9FPSk7TOxWn/nxMLTrjx3N+Z5de1zZJZ5+VtV2rucHTp9t8pGhRmloIqmqOBwOT7GnVF0rMtqKY0T7RmFHW1V167qkmWwnVuqNnInGjrxmPYvN6pGs7zdOOxhQnnVDm1GlX3dGg8EgEondoWbCUTQaPIvAzlWlmRlU7U5/32h30tKVfqFp7ZKRX+nBQE0W/bbpNY4/IPIomtNQU2FweNmTCdGdpnOxSOTLmlHW6p8OHFGr16sV5mDrLnud8CbTntP0Guc4XRi7xPxcdVwl+gfQp2Ymcn2Su6mx7sRiT6P6Wa9x3Rkt2s7NFUzdXT07meZ0tMc8b9pU38669zA9x3HO7+P1Ds33VO7bnvM17vmaX65k3lRv8CN8n3Eu7tp9bn2+X3XVPrc+2W+4Vh/3HuM41+njOHcax+n/I2jnnuM4vfaht8u7jmP008d+K3H3cZwe+rx8UPEIcZwLP8Feb/VB4hgXCnT2+dYDxTF+3OeXj/4eLI7xg0fQb7f0gHGM7wR6/3nxg8YhXyj08a9fHjkO+fOflX3+e6mHj/PCfV/pj3+798/E+Q7EYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jD+B4GNmzYUY1XJAAAAAElFTkSuQmCC" },
                    { new Guid("20f114aa-d7ee-4240-abfb-cd823e923d3d"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("29e15c67-8505-409c-9866-0331ae31a032"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("2dab190b-5292-419d-9fdb-ddb18c9f556a"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("5b05fc28-7540-4f11-9582-4e98cc2a0203"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("79436367-1a26-4899-a8be-0c65a2318ad9"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("8016f5c8-5741-461b-99db-7c0544b0c338"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("8de4923b-654c-459c-83cf-d4018161427c"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("92dc585d-c760-4b1d-997d-2c17a16cabcf"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("9c3543a5-66ee-49b1-8c45-90ef0926448f"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("9ce37976-e2c7-438f-b098-169f67abd059"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeGWw-VaNcL9QlsHKJKPLWj-Dh0M2WguDpRg&usqp=CAU" },
                    { new Guid("a27958af-0421-45b2-88dd-5ee6ff3ddc2d"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/jpeg;base64,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" },
                    { new Guid("a5262673-0712-4378-9a9c-966d1c41d6ce"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARMAAAC3CAMAAAAGjUrGAAABEVBMVEX///9PuelOuuhQuOy74O5Etun1/v5EsuIBVJZRuOnk+vuEyudLvOxQr9tPuesAUpMAUZQXZaAAT5AAVZUAUI4jebQ/n9U0jsMSY58Za6UUaanE6PcSbqyR0Or///tPtOfa9/h0xPBhvesjerTw+/wqq98JoOB+yfCM1fYAS5Accqs7lsubu9MAV5RJquAAVZEYhL4Vn9a56/Cn2+7M5/BTtO9ZuuB5xd+Tz+y35PTN8fnS6fiayuFetdxZrN4+pdIAkMIKn9QAj8x6la5Zg6GXqcIAP39hibWq3PYASZWc2vtpi6kuapevyNhxv+Q4dKfu7vQ2gKjZ///E1+MWj9UANX52n8GPw9IApdUFkMZIp84bFDZfAAAK50lEQVR4nO2bDVvbRhKApd3YlkCWhCT8ETtWgw0E+yybAzsEQhJoekkhpb3rXa/c//8hNzMr+UOSgfQBm5B580BAH7b0enZ2dldoGsMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwf4HDZ0+K4n04WS88Jcpr9+JE14X+NDBNi52kYCdZ2EkWdpKFnWRhJ1nYSRZ2koWdZGEnWZbkxLRt+D6yhBD2aCQLsKUQhoWCSZdgirFegH+mZeu2XNatL2RpTnQh4AA5CsevX6Q5itmybSHlysNtSU6kQHSrtH54wyh8XZjgZHk3v4Bl5RNsNLZ5+kZrtTStuJbwwwzF2Mn3EifgBBLF+JgOPXn7+rT8rlx+D+yfnZ1dAx/Oh2vKifk9OdFPDzFKOgcvX24BuiiVStvb0Q5xtnO+1toV9nfjBPocaYnTY62jtdaOdndJihki28T+zj440XbhSDt5mblXwwQt1A+Yl3Sb+jH10vCN9iWb5t862fgVph/aiWlKuCphjsS4oXV+bGkHu+uxlC3TDDFSyMnOzgdwIjAZSzsDORD0T73LxAm+ug5pGTp128x5f9hlS2mbNnV7j8MJ3ovAW4WG0/n4k/bDi10kbj4YK1EsJXHyvrKISOiR+mEaERJuVla77Z4U+bcs9LDdHob2gt2rcUJ9sH7a0H77+I8T7c0rgKS8TKTEkRI7sbueQ3iE+jkI8KtryXrguF5QtfXkFrGTjwaeV5Mi964hj1UDJ+jJr2g8D59PsDGI8Ym29mlvr1P8fPFiVoo5lRI7MbuukQNsdDaFrLuAV50NCmEPPdhW0fOd6LLmuk4dneTlm5U4EcKSOqTX4sef3X4xdpKKlGjiBIqYBU5cw1VODHAyvUF4T9kHT053QeOxKwHs9iuPyAmmRhOVXO65gy9a8eDi4kJJUU62RBIpZ9jvQBWT68Q3VJw8h9sDJ1TtxMrNXuDC/iDKz/Gy64BRZ/iInJhw1eEhRMkeXPeXYvHtxYuLVxAq0PlcXcWJVi+Fysl6AUK968WZBNz4ACQWV23BfOIYvutUp28FLXMD4sAwgqGdfX8Incgjx/18ZatxAld6VNQuA7gsvw417PHx8UlMA7iAnKLrYViKlBNhV3oJfXTiNCe/V4Ry4s460aMAlRhOLcx5f2G1HQo0r5ejbFVOpA6v/4vnGz450bCUbU1Pe7O1JTHRlqL3sRPqqXB4JDccajHSiks1IbJxost24FLjCnp5bSMcxA1v4+49z8O3HXmlaV98v9/v+19wTNxSYlrq++crVdIqJ5B97IkAWzlpT3vZ2Anmk8nrh75KOH7QzY6osSNWTgyncudAeXAnYnSgnXj9GtD/ouYJWoQ67c2VqvNFmDhJSlcRx0kby61kU8aJXvUww0IjMwbRnA76btcccuJDr/VonECGbbR+wTCJnbTmT1NOtsypEzORgk6gSYATM3mtrBMBGZacYJadf2f89t7zHeXE8PPyzUqc6FbY0P5GYVKr/arajooSFSyNK1Xnj81pnMRnghO4VYyTiV/SNHUCjaoS+Fh+oBPIsuZUFr0KdcSGT2nWq1p0hbebefg6tjTjRNPSgdLYTZy8SzuxNlyfcuzkRlNxgnmm6YMTo4tNBPoWc7bAh+iKAswl/ibGCmbZyRhytU4EOXm+0EkySjbLaSd22kmm7UBHTPlzLxpS6sEKfvYioE+izaM+HhWo8v/xOEEWOVFSyp18J+2FTuD3oYdFal2qgBhEc8NfMxz4WM31pFLWtR9TnNTIyfNcJ8nY57SY58TNjRNVqEOY1LBpQGViU+IIhnODHhgcYvLthzBypkCJZqasHrOTF6/i+ZSrr3SCIdGjTqUmhVXxVC07cxFC1rBu8UAUnYchZ9+lcnsETmhAuPvyM7yGOTtQuyGf4MASuiMbf/WDqoU9EjaeoDrTeKwK1mv+IDKF1fNo0DO600LJwzvBvvh5E3n+66SOnTo5Uk7Wr05aNFcwjf7bciwMjTCFGoMQcycUrNAp12YPbqosgnVwWKMJhyp0TLdrWUbNljhp5jl5oaYOIExa2hY4MRc7SffFdjugA0ZhGI4iFOBC3zJ544iMuT3avYmjbKMvvyEn65+LxVanLKzprOJNTlTxFfUdbDBUIsNoylB9y2Taf6iGOjjSgr3k5G6j42W2nVwnFzjJdPSsCNsPSmJ2dj3TF6fixK56hj+ZcUomnybzJGE81JmdmIJe+w4TS8tx0lzo5PDg88GzBl5Bq7NFx08u+hYnqtBPT8d5Qys+uzeYt6XGRNE34ETTMEK031pFDBOsx+XCmm3OCQ513Mk904CH7noQtw67OzDU/mSfPz96WqETnZxsAs3mP//V6XTW1jrzFDu/X/4IraiUOnFRv2M4VVogaeMQ0fA8D6fycYJSDfV6NA7CoQ7Ov9E8P87re5B7MLuMHomTt+Rks/nv6w8frs+HQLvd7dY3MDcO9vZ+/s+nonZYTncINzuhGTTDHQyrE+p0/AbNQdlDF51sxLvgqKGvRse3Klmqk/P9s7P9nfPr6/Nz0gKR06zXasbeJSg5lXpKyqJ+x8D5WDWDhtUHoqbmKh6ljAot/tUwKryKpabs8PknNfWwcfuzHEty0iYl26BkZx+UkBNQAuPCmuFdFluNUyxL5/PfwprNreLULHS+LnauqqngWrIJPY2LmiBR97BP8mtSTIg3TSuYR+DkHBe2gOvYiZJS3xhcQi4pQ2tIZ7+ba/seDoaMmpqCsylaaJSMfQvWsLTmU03m7Ch0+hg6TvPWnmc5Trrt9j4o+fMMWw8+glONU4pScjw24VNOr0ll5pSSfIL9jll346Us3KvmK3WqXGGjJdSqjh+K5LkEWkN1fd8xnNJty+kPv76DTjZJyT5xfq7iZJPSSf+PotYYq7H/vBMY1lK/sYkhNHFCxWpVV7dPK1mzkwObtObXD62hg+ul7SR3qEiJcE7OdYcy96mM5Tmh+di3TVSyvbM/23ag6dTrtT8oveaNQdCJ6++5WFEki8O4NoqjXwvnS3CROBVaFVw8dINq2AcnkG3nm6O9iU5odHxjpCxlPva/H7b/BM72qd1cUzLpQsvpfnoGuWRs5X1uEBQ1WhFtTyMISlfaVLWjAPCCSupE3B94Xn8IBwVBPbWsbkYBba/eklEe3km50Vr7+4Q3QPK3mb/jGz87tfI/NlolxQdw5jYhvUgv0a7K/LNv0MaieBVVPbqTevzCNNUrVlbsxBblxuKT1g5fj+3RggG1ZU06jck2XT3IBeNnadOK4fwp9Kuluuacx9viqt/O37s0J9LUXx0s4mirVJBwCSI358V1hT7zwskmoeZj0x2I0KfliJphSSWq6c5VOoGPFJ8awGfrw9DUTfgPBRQKBb0gQ8gQ4XjhY8Lz9zezzVzwQcu4WrHxeT9ahs9N3nFluzInM3bmL8O+6apWC/+tShZ2koWdZGEnWdhJFnaShZ1kYSdZ2EkWdpKFnWRhJ1nYSRZ2koWdZGEnWdhJFnaShZ1kYSdZ2EkWdpKFnWRhJ1nuy0lrXSZ/yviNowtLiNN7cbI7mlut/YYxpZT3ESctiBMzlE8BG//y5d1a+tHmv8K6JfGpIHGXL33ydafDl3uaPpIC8sm9OCmHhdITYTz+373kk07xCdHptO4hTlqZvy34VrkPGwzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMPfN/wHscbiZ38cT4QAAAABJRU5ErkJggg==" },
                    { new Guid("b53c818a-9904-4250-b991-8850bb811540"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("bb5dfa68-8719-4d00-bcf1-ac6aacaf3d1f"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("cd190ce8-82ef-4fdf-87b6-fdf5374ebeb8"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("d0073268-9caa-4ed7-8dbc-45d9a579f295"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("d9a82560-bd6c-4edd-850b-8bd26e561431"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("dead09e4-9271-4bad-9aa5-4c196adc8c52"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("e46b63c9-6c0f-435a-a32e-ddea2516dc79"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("e4f22ef6-91ad-4d6e-89d0-e1f16465e7b8"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAABRFBMVEX///8OLHKUlZkAj8sAg8EAk8+TlJgAZaMAaKcAa6kAZqYAmdUAfLoAnNcBod0AGGoAiMQAG2uNjpIAdrOnsMecpr8AXJsNLnMAW5oLNHkFRYUATo4BVZUAHmwGQ4QAcK/n5+jW2eMAAGQGO30AJ3AuQn0oOnOOlbABUZJnbYYAI28AK3V/i60gNXIAPoIANH23vdBseqMAR47u9vrR0tNUXoEAEWkADGgANoDc4OkXMHKAhJHn7/U2S4S0vM/n5+e8vL+hoqVyeIw6SXlGUnzIzdxXZ5UAU5q80uMAPYd6f48fUYrGxshhaYVQW37W19iqrbSZnaxLXI5ug6lYc6BDV4xLaZssW5NNdaOjt8+NpcJBVYqHj612l7s6bKFigqtCeKmZu9avy99pncVWl8M+hrnO4e2BtNVQhbVqsNegzOM1PnJpOxPTAAARZklEQVR4nO2c+V/iyNaHgbEBGe6N7ISEfTXRsEQRJODWgLi0vmq349aLttp3/P9/v+dUBQiLPd39TtA7n/reHgkhSz05p845VVzKYmFiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJ6tVI3NjYSVBsb6ku35m+SmjhaOdg8Pt6y2b0Tstu2jjc3D1YSif9F3ERiZVPnslPZJqR/gIdsbW0eHG28dKN/VBtHm1s2m042yTVVlNS2tbmSeOnmf18JgLMTtmdAvI29ve3txaG2t/caDa+BFDg3V16nNRMHxwRuCpZ3b/Fw9e3O0/L68kDruuhG7untu8PF7YbXTk+wHb8yyo2VY9sUOntjbxHIciNUIeukQvRfaH356e3q4h5y2r1bm0evJAKBZ07S2Rvbq2+fcn2y0DSuZwWch9sNuMhrMOURuOY4nXd7ldgN/vtJtIEyGet67u0iUNq2Dl7QkiuTxmtsv8tBb8vlwHC/xDaUnAFOoPR6t1ZeBO/o2Ou1j9vuaZnS/Zrlpggol99te72bRzPGS2zaxvAah+iZfyudLjkjre8sNrYOEjPDUw+2xpxzD41nBl1fmUxo57BxPBtDJsa9c++dbjyT6AaQmadFm/k98mhrBM++tzoTPB1Skna2N00NrSujfND3ZofXh1xePTYtRyZG+OzbO+b2vecEhvw/kxhtBr4GeGcO+GaNR5SJLrfNADwaDgH2dtaJ+eSX4COMkmYC4YFO6F18QvPN3DtHxAVMIFwhhN5D4p4zDC5TFc2bROgl3W+WwXOmhHbvKomeL+qeukwhPDh8NXwmEfqtr4bPLML1V9D/+jKHMPrSWAaZQ8i9NJZBjJARPk8Y5apVz/jtJK76a/RRjuOwd2c8P9vHTSOU8qV2KcBnRu7GlVvt1q+kkWje72/lo1YpGwhImb8+3iCPWYTRa9xSs8bmcC3Y1Z4w7FChEPwzyqo/jrU6nJmsZrLwUv85K5pGmFkmcwglg1NmTnBPWZpGNhRv0GDnWpIQRpfwCp0pV3gBQmu1RLZDQyNyfnivjfuYzrDOf0frVUoolfGSVz/lpuYRSh2yvWTwKRyLBoyRZtJqz4gScqFMaewKL0lI+44lmerfihqgmcFxdzQahYAxhAvJsiTL5G2aCrassjU0Sshb14qSEVAi1zGof+mZENJYYxnEGg5nTNprEPibZ0tLS6edNGel7Zfl96f5wOXSWVMaAMoRctCJLOMuSugBfnjHh6zLfCZqzXDZDl7HOohdEtcsw1mdbFWaBaE1Q970nYrEQUs5yp3W9cPUEhCBpOGe9nmRAMrnLX2ys35d5PuE0VBZ1TTtxFqFv9epZokeo+X1W6yVk/qF2h1uFoQ01mhVw53UVGZk7qssp9OS37jnjFcURVoy7EkqfJojhFKIOPqJNYUvhvmXFkcc1HjpPrW5NnxPKajHpEicSZFWlDrNkxb5cD9dPMVX7fqkQ/aoESVWvCSftVu0yXV5lPADn9JvlPT76/17yFFiQLXUooa89phIGNAvzpHbt6tDXJ4E2MBaiJdT5M5+WcYGacUiH1o7wz2XvPKBcDU5qUrNclnUCYujhJ2Uh0uR3t7maC6y+KtVLkXybj8AmEporGuqpJ5JEcfFngXBEjeTMq+RxscikRgxcLvGE6xzJRKJ8GtktrNHCeVRwnIUawJSDGjWTJOQkqfJkUele5LHjNnEPqGVBBfqLxJpk+c0kM/nZRpNcE+9GEIG9byoxCJ8s9M5+0Mh1m7VIiiJWOCU1jQybyTUqiQQU4IsnRbVy50UcZ61GRDSWJOEt6Te0op8RgJB8pM8HGltnffQbtM6Lci1GkSZmELCzCc4CuQhlr5IEcKiTpgmhC0SiHn6DLLEyupaiop4bDNjPqFe17zPhEi4D0C64+XYmb/d7ueHes/aGZy3e3muCEKxNHHBNiWspSmhQgj9MqkLdMLoZDOWJPMJ9Vjj91iv8PWKT4f2WyOH1nsxzhgKWqJQnPwuRdMJlXFCECVsTiG8js6AkAYyVYribdpSuvhBT9LJdoB8VFeEGHeSHJ6rheVJwjol7OmEMUpIi4PMyxJaSTeCdIXh5LSY5glg+4rHzoibD+CWAs81rwd+e8sRL+1kDTr3GAk/9gmh10LAMhBqVuNZ6zOINP1Y08bwqMrpIk1emBogExDCCpFSjHoyHWo8mTTpplKggicgFEg2TyqxUcIYICo6Ie0PXEYXBjTrTAjpqNeCbffLikw64SfMdEKEJLCH3sXDw8OuCBJ4WvCck1N2KyJR4SPonBL2dMLIGr5c8JFYLKZYCeE+fZRlfay2ftVsXs3ChjD4Sw2+oBSUmFTSCcEuNXLnB1qVfhJEMSzWiIk/0u80v3Vhj1i5we1LWnlXKoTws0AJe/CgYjFqw/0MCcn1KGaIDOm2FpnY0VRCHP8NprqScr81EBMrlR4pRy1ajVhMC6JT1kjDRJkkRPVrpdvtEkCtKz1HGIkVKSFPy9J2dq2a4smDzK+Vy6ceUwnJADe0rO88Bd9M0zf1y0+XD/puoUpcU7349u2SdKWLQoHusmi7uzTyfhZ1QoESFiihQqqePqHcpBdMlmhkTqbKgcD1ddREQjr1kqah0aKS9kQNwyKNcMwrUtJ47q4YdMRSxqSvfi4EpxMKwpAQEmPT+I19G9DO2if5KDcyOPubRAjpBEQ6DTWLqqoYFyC8xLiynhXUVoSY6lJUqteDpiVuxGAw6IikBmNZzR8OB4MwAFEtD91CGa/1uVBV4e1FDMNshL+GbfUcEkdGCvQvVC9XrdJpoJy/lkwhzHvQQ0P6pIu1CboSIENgg2TPyVI+cF0WKmKMy3Y+fQ4HC7LUWQqUSoGlTkV0EIV57qp8HQgsnVUKgBxUsnCJj2FxHS4FLyF4OQ8KJJPElvFNDDMH75E7cPH86UmVzI+X8zBuNIkw1LdgOo05C6J6hAAKkN9iSq9XKYhgmrBYQJMFHUGhovSUPh7K6RAxT4LLEgWDYTQlnAEKw3mGZIk5IxYhiOl0iGZC+n/HlaKS1STCaMjAF1N4nhoQAQsibSRtMeHTmZxOF4j8cbmCQaeT7hlSO/QTgBCibLci9BkFEnIwOSp0lg7HjYPS2BzCEcCzUkvQDUgAC93uOJ7DQeicznn4H77cPrrIK1I6DZh4jih+3cUy4YaYUjQgEjNSxgGiOYRSf94TACNpiJ9iZGjAws3uhTiChwzAMj+QC9Kgb/AOPkHbDhg/9jON9rEgGs04FdGcWCr1LYg9hBBCCwoF7FhiuOK3aIUgdi0xHCS2c82TPwhDNuJOa/sLQFE+fAWvDQ5sCQEz8L55Ai1/gEeGV60gIjxMpcgrShEGzgZE02yoA8KTxTF7OPLpphe8vL2Ap/6pZNHuPgfF+S+3t3dhl8v36OvewSaQuXyw74vPFf94c3f/+NUVj8fn7x/vncE73I1d0+UIQ217A25ewKT5rdCFq95enleEyM0f8h8XgYj0yd+Cv4hoog3l9BCQEvZKFpoI78igyXLZfSSvqs/1B7gbbj7MO+9gB5QxX8FL1TAkQED0WSz3PprmoGuCx/bgyDA4q6PQLLXusKzTVByKKHXLA4436W3AjULUiuYREkCMoUgYxKmJQJFPWjQpD38u779Bq4pX0KoulMzqhzTUVncVSONSqmXRXJDZBahV7uMuv2W3q1mS+zimugd/dUId+yVMvFWA/CLCw+JwWkYoAlpraT9pqTex/D2zIqKZhANASlgD16yElVOL5qj5LfVutw0tD8pQhfmA8M7lhCHfowRF273LU76LA6EPjH0b74JFz4DN1U3VLbfQVwHe8hh09eNqNn8jVmpQxYeBsB2tfYCxCSetwTaZpwrpX8uaQAhJgrgoEMaA0AGEQIRV13zXD+6ngOE0ENBBo+bivppqeZTxcau70P/guDkwu+qGRxIE69FD0WtdHSQkQSfY7eLw6vYBnRgJLxTlun9svUi/YTWHMF/s90GM45UhoagTas4itKGNSn5FQh8hdK1dk150i14658qC/ZKWRzjeQg5t/+mEyANnPgQx6Do+w5EO6IPtQAn7ARBWlHz/2BZ+RwU2DJlFOAQsEEKINLsFI6FmadVglFgR4x0kdCOh+/48WsS5jHskdEttCEGq2wV2CZKUEPdBcPXU0WnBXbvQ9G8tiyr2euUBIdwrFpWiXLSY5psXF/73ZtnQADgkpDaMI+G84sd2uh41zQ2ECz53Dwgh+vwn3k1TwgV3EMdKf8bjWeyQcfeD+iXu8/lEjExf5yGx4BwIPIRuoQIPxUEIhSzOlheVtnZRLF6eBpYuJY9JhBG91IYyZkjoCA8IXevYryC8f3EioZsQ4lzFn491i+YmhO6Mhh/N4QhQe1AtGjgziEwBaJgi6r4K2Hf3C9Y4nwlhQb5G9wfTn6eLgdPWiVmE/NCCoiiUkw8OJZ+EGB/sJHd94nUSTFJY90Mbk3dx30n7ATB67eR/XB7cZ2kt+OC4hbm5wlLyT7d7zh3F0aJ24fZRFZvk69P6JdQ/XB6eQvvEr94UW8kbGE9FO0kcfApQv523lkonIXMI0wZAUVSKlaDYq0EZ6qr0xHlnpeICd4PBfbTn8rnd4YoLMJwVcW7OXZE4ueuemwsL8TlQAbdB4VpU7sKhbgrp6nmkmtzFqs6lROGMQrEmCsUahNZCQYmuVaM9HGik5X0o3zKTXxL8/3WpGAHD/SKbFppxFLbTrWvOoAWj8N3gA8Cn0g2JQadfmOvJEQeP+oBKL8PT6eWc1URCHTA8AHTqgHobJwgXpmr4+ShjXGck9bg+bhTFPiFEAiDM5XJm2XAUMDhiwal80+nGIUcYdUSnc4gYRkShb0T8qc7y6oEphIPR4Cjgc3zfxRul/AtEcYCo83ntZvwUUSckkxXfA5zE+21C32XsO+ooIkAKEeTLreIPP8z4IeJlRffRcL8TjgJO55ukm6Q0MBrNOLAi9VOd75D+dMcUQuWvAUf5BjBvfntj0CTlM2Y0OKooZJHvabH/4yszCLWeMOyEPwDYp3tGzzKOI8LNwgLire9sD34f6DXlJ8Ht/UphEtA3BvhDeEZII+PQjIZ4I2Zp92sYft5pMwPQYtk4fisU+oCuccAJ+xlYfjdqAnLcjEYrBvdJ9NzZ9hr4vLaEOYTIeLhfoJne4KJTDTgVbgrnGONIvHHsZ9E7n4zmQz5zF5I42HsrBAeVzBTAH+Kbzjhixfl94p3L7/ZGfj0+izUkVmyLOwWXcyTITOUbsPxrTGOQY4gIOU+dM/du2/jTf7vde5wwnQ+1seldvNp3fReQok3SjVEOGQfZ0efYz+HCKE/v9my2Ufc098f4o4wHW43Ft/vBuHsC0Gi+5/CMkCOM7vnzLFnTZuewYR/Fs89o0QgD5Kbdu73aLDh9kxYc4/v3qJ5hnPOdN8maPU/vjJGT4EHve5FlanCBGjBlWnC4F357hu/f0zVgJP9+Ix0PlyOCnjdqPIL3gqvwqCtbkH6BMhcJz7sBcMw9n+Ebgv5O4Ihj5nZWx2yHocX+QtYzKIHLYOHqQodvn7JCcN698ObNX5IB2psFn4N2uvXcE8A1Jum8W8evZDUsFVfDIgt04eJeT7l0ZD/siLsXiNf+PuhzJKDMuX3z5/v72WWyklluBxf3GofTVzSb4Zo7P6LEyqbNq6+31thbPHyH67Ot0xXacjmS3YbLtC0j2eHi3vhCTH3b2V8bXV9IaTe22tto7G0bF9nb3t7ba0zB0tnw5P+BpQVXNnFJyJ9cNZE8mNcPN9TG0cHm1pbtB5e+xGU+VxKJl270L0jdSKwcbOIyn7bpy5cebx6sHP1zVms1rED7j4FiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmJiYmL6R+q/4mKXN3970JAAAAAASUVORK5CYII=" },
                    { new Guid("e8df70cc-7fa0-47c9-a3c7-71eaffd3bf48"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("ea455811-f7a9-4e06-b8ba-8fa77b4bd803"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("eb553a53-5cf0-4cbc-81d8-73c0a66dea6e"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "Ratings", "ShopAvatarId" },
                values: new object[,]
                {
                    { new Guid("03f23ec7-fccf-470f-8513-c3effb1529fd"), "Amazon Ltd", 4, new Guid("e18d4836-8dbf-46b4-a146-e7e60266a627") },
                    { new Guid("086c613a-dad7-4567-97d5-beb4d680cf22"), "Tiaa Ltd", 4, new Guid("6a7042e3-e907-4877-89f3-34bef9471c74") },
                    { new Guid("09abc1a0-84d0-436d-9000-c0f45c018862"), "Apple inc", 4, new Guid("68d2ceca-afa9-40d0-83c1-d7f27f5b8755") },
                    { new Guid("0e7e92ee-fd15-4e92-bde6-89ef9036466a"), "Shodagor Ltd", 4, new Guid("91cc72db-044f-43ce-b7f2-622e856c9907") },
                    { new Guid("1756ee49-a069-4576-b426-51a830fc1982"), "SAMSUNG", 4, new Guid("0d1c0491-8e4b-4c15-b2f9-237c88280a16") },
                    { new Guid("1ca73bdf-c996-4c1c-b2ba-55daceab8a89"), "Asus Ltd", 4, new Guid("5319fc9f-5370-4742-a58b-25d3416f293c") },
                    { new Guid("27fab268-c7b9-4b31-a85e-71cd93cdb972"), "Shahriar Watch House", 4, new Guid("c8a75dea-5c76-4ceb-ad95-c102f1586618") },
                    { new Guid("3338124b-7ae8-4177-9b10-ca834a2f07e6"), "Vaseline Inc.", 4, new Guid("b7b362b2-53fb-4501-9c8a-4cb68d13bfd4") },
                    { new Guid("3d6e7f8b-dd92-453c-95cc-3b9300f5f1f3"), "Amazon Ltd", 4, new Guid("525a975f-f90b-4e6e-8fba-3fcf0e950465") },
                    { new Guid("3e1a1fb9-2d6c-4ab0-ae93-10517b4485f5"), "Asus Ltd", 4, new Guid("bfeaf43c-2993-480c-a37f-be68776abb00") },
                    { new Guid("3ef817bc-27fa-4276-8cf5-06d430115a91"), "Unik", 4, new Guid("40a52cee-5099-48b9-b1e3-de57cc99a706") },
                    { new Guid("52eb9a30-f015-468c-96ee-b32934e76dbd"), "3W CLINIC", 4, new Guid("50636934-a3c6-4bd1-bec2-d4e1a5fbdb5d") },
                    { new Guid("5a2daef1-bb8a-44fd-ab6e-07f502f1894a"), "Unik", 4, new Guid("d48f3f63-145a-4275-8251-420cf1d878b2") },
                    { new Guid("7941f613-1d77-403c-b295-33c3835adb85"), "Shahriar Watch House", 4, new Guid("f63063d0-3170-4f21-a2b6-fe0aec70d8b8") },
                    { new Guid("7adf1eaa-e25a-4d29-9de4-bc0c0675a2d4"), "Acer Ltd", 4, new Guid("5cd9dd85-06df-4cb7-88e0-37ece6b815b4") },
                    { new Guid("88034ceb-34bc-436c-9bc5-d54a3ce4cd49"), "Amazon Ltd", 4, new Guid("a1b183ce-18c8-4f47-b1df-36b152089716") },
                    { new Guid("a9b9e361-84e0-4341-92fa-f9732a739601"), "Energy System", 4, new Guid("2d870c0a-6275-44ff-8aa8-c89bab2a7ce1") },
                    { new Guid("ac42fa13-a6d1-47cd-8277-10b8e1c98d53"), "Dove Inc", 4, new Guid("94cbe604-2313-413a-9b2f-df9fa03caa3a") },
                    { new Guid("acf5cbf3-9ebb-450e-bd80-ff843800cd3f"), "Apple inc.", 4, new Guid("04eb15e4-d883-49f6-b835-32ea5a3f55ec") },
                    { new Guid("b1709420-f114-4e46-ab91-72b3dab5c829"), "Amazon Ltd", 4, new Guid("2c9e4fb2-a27b-4ed0-a6bc-2b18b471d081") },
                    { new Guid("c3f6e4f9-39a6-4597-aaf1-f4c1d0efefac"), "Alisha Shoes Mart", 4, new Guid("738143c2-fe9c-42fc-90f6-ad2cee3ec35c") },
                    { new Guid("c70d6f8d-5b3c-4b12-974c-ebf6c45cac2c"), "Lenovo Ltd", 4, new Guid("fdf75414-c5bd-4146-97c2-52eebfd2e3ff") },
                    { new Guid("c998612b-2dc7-418c-872d-68f8616ced85"), "Oppo Ltd", 4, new Guid("6cc57e9e-d45f-41c7-82b5-dd64f1311e7e") },
                    { new Guid("d5c1e9a0-b9da-4926-bfd3-ed27a5aa4765"), "Dove Inc", 4, new Guid("e2483ad2-9e9c-425a-8997-c84ae989259e") },
                    { new Guid("da7a3af8-9d09-4d2a-8925-4e2a9afd2081"), "Louis Vuitton", 4, new Guid("69c5d864-ec50-4ac9-91e2-8755280d60ee") },
                    { new Guid("e0a2dcad-a1d3-4165-8216-4a3ff0719c7d"), "Unbranded", 4, new Guid("7797bb15-b929-477b-af54-12e4cdada136") },
                    { new Guid("edea59f6-f0a4-4656-b524-1bdc15862ee3"), "Amazon Ltd", 4, new Guid("c4a26088-419e-4c34-9769-9b0056442735") },
                    { new Guid("f33c7b67-5d57-44ac-8d0b-f52ce843d2db"), "SAMSUNG", 4, new Guid("6cb74e85-5c20-47c6-9634-8711c4e0cbe0") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d645a5fa-f628-41dd-99d1-6776984bfe91", 0, 36, new DateTime(2024, 6, 10, 12, 31, 7, 974, DateTimeKind.Local).AddTicks(6710), "1399776b-21c2-4d46-83ff-e6361c691801", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "77f1acb1-dc74-4955-83c7-98aef4d97b4e", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "191a5ab4-4f2f-454e-81f4-e34781a652b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7017fd62-7bae-4529-b5eb-20184faea342");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("024d3bb5-fc4d-46cb-b196-2a654819ee69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17347cda-4440-467b-8275-6464c1bcbfa0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c946b68-4d9c-43fa-a145-77c1a795ba0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bf4985d-e022-4721-87df-156f72036b0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59e0196a-c5b2-4340-881f-243a828f82f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("881f9719-003e-404e-a405-a80801f62726"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba1cc706-9d4a-41b8-9f83-ef8aba14612c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca9fe302-c6cd-4d5a-a460-bef0c30ef5c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd586a5c-5ba7-4a65-84db-d5908f9b2088"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f02d00b6-54bb-4e48-bc43-fc9cd3def502"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0017f244-66e2-496b-bd2b-106b51dca494"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("04a29587-5d8b-41a4-a043-b162465da987"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0d3d03a7-0e55-4c0c-a217-4e143b91cc79"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0ffbf223-1e65-4238-9437-4df219e4813a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("1093846c-050a-4cda-840b-947692e778a8"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("136753e2-bb03-46cb-a28a-fe34980ae5bf"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("18b81e19-0c38-471c-b1ae-648700aab92f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("1eb222cb-80df-4cb7-bc8d-33a026350f7d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("1eb4add8-b3ed-4bca-8e7f-b972283b10a1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("26a5309f-13d6-49a4-9d8b-d65273106e1f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("2b96c5a0-3243-48ce-b887-7c5b527f5741"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("337dad38-f567-46f4-bf2c-00ad96e08299"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("37414111-ab1d-43f1-8066-eb683cafbba3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3cc92386-bbba-4d74-9ed6-c919b6cf76b3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3f647ec7-97c0-4e3f-9849-540d97bb4d87"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("45227aae-acd4-4b29-8818-463437f0bffa"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("47975165-a13f-4b78-87ba-c37bfe9aa184"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4a4b941f-cdb9-45c9-b3e5-7b7c7403302f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4c59a95e-ed2e-4cf0-b5c1-d93864253a01"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4d33df82-05c6-4bac-aeb9-fb12629adb5a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("58da4458-e14e-424c-9190-97b021e1c4b6"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("638fc822-01ba-4e1c-8ae3-c4d59604e536"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("63cd6f37-c4c1-4c3d-b561-4ce2794d98fc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6402786b-4da2-4acb-8bbc-0db9a82f7973"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("66f542b3-011f-4b11-967d-9f088a2d823e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6a2a86a6-4bad-4069-929d-38530f7ba366"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6c54a19e-16cb-407b-a992-e048bae47132"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("71bbd7d1-3875-4ab7-a54b-fdd666bddf72"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("72d37ca1-efe6-4c46-bf29-6bf703d5f363"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("73d9effd-4509-432d-ab48-5ebeafb1c528"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7937020d-8af1-4433-b8dc-f7f33a4dfb58"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7c4d174f-e886-43a5-9013-affc86fdc1f7"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7c99c118-8140-4171-b6ba-0e5a5a1ea243"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7f4f5d0a-7e8d-4158-a6bd-94b26ef29e76"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("82c748f5-85c3-4831-9ede-8d1cde4a3f6c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8ad8675d-d91f-41aa-a6f6-34942ca5ab3d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8d97638c-eada-46ec-bb2a-0f21abd93d3f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("95f8fe3c-6c37-4236-9af4-456cab4d4ca3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("9b728a57-8434-4c5a-a69c-016e3912c9ed"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("9c8f7491-6492-4604-af50-f6b4534804c2"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a262c2d8-932c-46f8-b91d-12895e3ad5f3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("acc1a9c8-f064-48b8-a121-b94c4d343154"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b83883d7-35f1-4a2f-bfcd-9ad0a28b6bbe"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("bca185a6-c282-4f7c-ac93-6bf34b7e456c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("bdbfe3a6-6791-4b68-b399-2278f087ab7c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("cc7f88fe-d8c4-4a03-9db5-a61df21d0a3e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("cebf28ce-f7cd-417b-b107-cc58170bff95"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("d4ac96e9-94da-46c3-a3d7-cf3562b4b30a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("db4ee12f-f2bc-4650-9967-e930baed7930"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("dd6f4ab9-97f6-4856-a5f2-29949e254ce0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e26ca839-f400-4280-afa7-db8f5f98c2c9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e701599b-ba03-438e-b16e-94fee5bed687"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e7c74c3a-4978-496a-b607-80f293b9c4ce"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("efc37995-8fb1-47d3-a141-2629a2b689de"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("f2791ae6-1c0e-4206-b1f9-fa90291c090d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("fb73fdce-d216-405b-85a2-fe779f7374e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b1b8682-3fcd-43bb-afe9-2610ffd67e2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e9099ca-542b-4f4b-b738-c9d2ad828c73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1156bcb0-d2bc-4ed8-8670-7c8e7cb63917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a6e15ee-64e4-4646-818e-8383da5fb00f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1abb8192-5116-4984-9291-a12715275215"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("336daef9-7f6f-4e39-9286-face840a7c0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f435cf4-8ec3-4992-a5bb-0af898a6c7b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("49b90c6b-98eb-4ef1-a865-2d848ae119e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b3405ee-3649-4fac-ae09-9d0266228031"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ba51127-c364-4ca5-8c52-ae0cedad9f4b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fdfd5f8-c687-4cf5-94e7-c0d9c4d4d32a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("784240eb-b089-41e5-8a2a-b9bda33d4dc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("807a0c85-e2e3-4682-bb6c-6e5b859cf754"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8f9c22be-a69e-4b98-bffe-4118d4e35827"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9208d9bd-5b65-4ffa-9a8d-e0adbd80203a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("969ceeaa-1cc2-4524-9296-1dedea07eab9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97107600-0846-40c6-921a-4db12253b008"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a971e98b-4e59-4cb4-ae39-593a326d9d58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5bbc7c1-5033-429b-8340-6ed52d170caa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b62090b6-3558-446a-9618-cd895a06ee0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbe52ffe-bec6-4418-b737-57a3f02a2d6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cda45e29-44d4-4955-b672-5ce2750790c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf8ad8a3-c420-4509-95dc-0ed9b518f2ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d497a049-514f-412b-aacd-ae72ca94e2cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d73d6df9-adc2-4d04-bbe8-ce342916ec8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dca64784-3eb3-4c8a-96b4-0b7fa930fdcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7de0b4a-03ee-4f9a-99ce-ca70ec3b668f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fec29b3a-3a28-499c-8fe3-64af2249b8ec"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f34cc615-01a5-45e2-86dc-e5a2e510a07d"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("044f24cd-4319-4a8d-992b-be346c888486"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("05616741-a2a2-4ad0-bbd9-10ccc088c9f5"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("08fbf5d7-9809-4345-93a2-cc18f40deb65"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("1089b636-d42a-4a38-b3d6-7f5201aa9fa6"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("16388211-2e68-44b0-9802-c36d48eb992e"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("20f114aa-d7ee-4240-abfb-cd823e923d3d"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("29e15c67-8505-409c-9866-0331ae31a032"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("2dab190b-5292-419d-9fdb-ddb18c9f556a"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("5b05fc28-7540-4f11-9582-4e98cc2a0203"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("79436367-1a26-4899-a8be-0c65a2318ad9"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("8016f5c8-5741-461b-99db-7c0544b0c338"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("8de4923b-654c-459c-83cf-d4018161427c"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("92dc585d-c760-4b1d-997d-2c17a16cabcf"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("9c3543a5-66ee-49b1-8c45-90ef0926448f"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("9ce37976-e2c7-438f-b098-169f67abd059"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("a27958af-0421-45b2-88dd-5ee6ff3ddc2d"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("a5262673-0712-4378-9a9c-966d1c41d6ce"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("b53c818a-9904-4250-b991-8850bb811540"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("bb5dfa68-8719-4d00-bcf1-ac6aacaf3d1f"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("cd190ce8-82ef-4fdf-87b6-fdf5374ebeb8"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("d0073268-9caa-4ed7-8dbc-45d9a579f295"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("d9a82560-bd6c-4edd-850b-8bd26e561431"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("dead09e4-9271-4bad-9aa5-4c196adc8c52"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("e46b63c9-6c0f-435a-a32e-ddea2516dc79"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("e4f22ef6-91ad-4d6e-89d0-e1f16465e7b8"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("e8df70cc-7fa0-47c9-a3c7-71eaffd3bf48"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("ea455811-f7a9-4e06-b8ba-8fa77b4bd803"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("eb553a53-5cf0-4cbc-81d8-73c0a66dea6e"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("03f23ec7-fccf-470f-8513-c3effb1529fd"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("086c613a-dad7-4567-97d5-beb4d680cf22"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("09abc1a0-84d0-436d-9000-c0f45c018862"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("0e7e92ee-fd15-4e92-bde6-89ef9036466a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1756ee49-a069-4576-b426-51a830fc1982"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1ca73bdf-c996-4c1c-b2ba-55daceab8a89"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("27fab268-c7b9-4b31-a85e-71cd93cdb972"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("3338124b-7ae8-4177-9b10-ca834a2f07e6"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("3d6e7f8b-dd92-453c-95cc-3b9300f5f1f3"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("3e1a1fb9-2d6c-4ab0-ae93-10517b4485f5"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("3ef817bc-27fa-4276-8cf5-06d430115a91"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("52eb9a30-f015-468c-96ee-b32934e76dbd"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("5a2daef1-bb8a-44fd-ab6e-07f502f1894a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7941f613-1d77-403c-b295-33c3835adb85"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7adf1eaa-e25a-4d29-9de4-bc0c0675a2d4"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("88034ceb-34bc-436c-9bc5-d54a3ce4cd49"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a9b9e361-84e0-4341-92fa-f9732a739601"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ac42fa13-a6d1-47cd-8277-10b8e1c98d53"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("acf5cbf3-9ebb-450e-bd80-ff843800cd3f"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("b1709420-f114-4e46-ab91-72b3dab5c829"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c3f6e4f9-39a6-4597-aaf1-f4c1d0efefac"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c70d6f8d-5b3c-4b12-974c-ebf6c45cac2c"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c998612b-2dc7-418c-872d-68f8616ced85"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("d5c1e9a0-b9da-4926-bfd3-ed27a5aa4765"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("da7a3af8-9d09-4d2a-8925-4e2a9afd2081"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("e0a2dcad-a1d3-4165-8216-4a3ff0719c7d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("edea59f6-f0a4-4656-b524-1bdc15862ee3"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("f33c7b67-5d57-44ac-8d0b-f52ce843d2db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d645a5fa-f628-41dd-99d1-6776984bfe91");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "Users");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8cf5ddc6-2562-403e-9132-e2ddc0f9bf5a", null, "Manager", "MANAGER" },
                    { "c4a5abae-8c16-4bc7-80f9-fecc4a649190", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("2e3c853f-562d-4468-b731-e693d927a20d"), "", "", "Others" },
                    { new Guid("5584ac69-93cb-4464-b726-19a8f6dbf3a7"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("60fbc859-21a1-411a-8e20-9fb2359d20e4"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("7e6d5204-c12f-4162-b8e2-bd1ced52b205"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("91a56d00-c014-4a41-af07-8a32a7468dc3"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" },
                    { new Guid("b4e8509c-79e0-4466-8831-8eaf2db27355"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" },
                    { new Guid("d3fa2ce9-fbdb-4bff-81dd-d4831875e328"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("dd93d780-f010-4362-8b30-b2c71f8bb322"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" },
                    { new Guid("e835a2b0-a253-43e8-94d8-bb4014f9b758"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("ec00550b-bf14-4fdf-b60e-4384bf57129e"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "ProductId", "PublicId", "Url" },
                values: new object[,]
                {
                    { new Guid("03113f34-d4b2-49b0-9d29-201719ec90cc"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("06e2c2a0-ec68-4f52-afea-7e48c04608dc"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("07570d87-0264-4c77-996c-7bfad9a9529f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("0df32950-f3d3-4df9-8ac3-9b767cdb7c88"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("0e933bf9-63f8-4a06-800a-14ce2089ae84"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("10698917-9305-4b89-b007-d33bdd86a5f8"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("143f3e8b-31a4-4144-bc2e-b60da15d93f3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("14610ae4-31bf-4bdd-ab3d-726682cdf2a4"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://unixnetworkbd.com/image/cache/wp/gj/unix_network_images/product/gaming-pc-9th-gen-core-i7-9700k/Gaming-PC-9th-Gen-Core-i7-9700k-Unix-Computer-jashore-bangladesh-500x500.webp" },
                    { new Guid("146e5496-d1fc-4ebf-bae1-cb27e843deec"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("16c5cc4e-3dcb-4161-a9dd-d0edd4ba8ef4"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBOB80TIoBkL_NaeJ_5lG5LuUsD0IYEDXFJg&usqp=CAU" },
                    { new Guid("18228a68-bfe7-493d-803f-a730c5be5f14"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("1f60f90c-dca6-47d0-8862-f573baca3bef"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("2fa9b489-272e-4f64-bd24-4684139bbbc1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("32d813f5-439f-403a-9234-e03cd302e99d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.bdstall.com/asset/product-image/giant_213181.jpg" },
                    { new Guid("33c09638-ad69-4045-8eb3-7be41d00e946"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("39d27f91-f4de-4f7d-8140-e61e966173ea"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("3b8f188a-75f3-419f-94e1-5aec4b177757"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("3d7badb9-061c-4a4f-a2de-110b2497eedc"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("3ef99c5e-2a77-4746-80d1-db3f102c55a2"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("3f693d7c-2b12-4348-8e5b-9ee43b5d4125"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("43138110-7e74-4163-9c70-2e36267501a9"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("45fe42b6-c84f-42eb-842f-ca40d65e919d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("473eda4c-f025-4b54-a205-88639991f5e0"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("4b5cdb24-0a9c-4355-9a04-c53cb864bac2"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("4c7a253e-4801-4b26-a02a-5b88bf352f5c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("55bf927e-a428-4b0e-ae14-04f655f2ad22"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("5e58cf56-dc16-4686-bc6f-a5e708ae6a9d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42FePhUrLX424aLie09J4Pfkn03T8h3D7PQ&usqp=CAU" },
                    { new Guid("6345509a-f148-49e7-89f9-0a128030440b"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.startech.com.bd/image/cache/catalog/headphone/havit/h763d/h763d-02-500x500.jpg" },
                    { new Guid("6a0cb54c-fea8-4ac7-b213-eeb4c7495466"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("6bd61e5b-3bf9-4dcc-8637-7adcc2e5038e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("6c69e0d3-f6cc-46c1-bd65-4cc650314109"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("6e3524ff-ba6b-4903-80e5-bca4fdb74429"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("82116667-cd45-439f-b64b-f2109068f698"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("82224ab0-14fd-4ca0-94f6-05a70e4841cf"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("86f92ca1-85d4-43a0-86ae-516e973750b0"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("8f0b93c6-506e-47f3-a196-caf8934d8009"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499" },
                    { new Guid("96dd12f5-a64e-4cea-9762-604da469d3e5"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("981ef740-94cb-4bf2-8a0c-fc6ddd7e1ca1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://eratablet.com/wp-content/uploads/2022/08/H51ba6537405f4948972e293927673546u.jpg" },
                    { new Guid("987fc4b5-62bf-4d28-b556-0763ead9a713"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("99b2b22c-2d0e-43be-9834-4dde8a5ef592"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("9d8e60d9-9c6b-443a-8ffa-e538fec91fe1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2zcpFb-6hMeoBVWrfp4LazbLD3a1tEjJjY2oYq45yJOyb28WIIYBoJ3qZMsmFdImBSZk&usqp=CAU" },
                    { new Guid("a066a2f1-263f-4297-8699-132ec33db28a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("a483c334-8c0b-46be-9a21-85f8d4e5bad5"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("a4aedc7d-cd6b-4ce5-acb3-c64248e90f0d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("a606e509-5d92-416b-8a6b-bdf4eef1c2f8"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("a6d195d9-12e2-4074-85df-f6dced0908a2"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("a7a21659-0141-4522-8963-321ea9803c93"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("b3caaa1f-4538-423f-8109-f5fc520d475d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("b8cc2761-0e4c-485a-831f-34a783533c35"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("c08583ea-6514-4df8-b387-df8b7be6d1f9"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("c6f227ec-bce7-4407-bc33-1a4c6f080d58"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("cadb81eb-df33-49de-bc9e-aaada562f460"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://adminapi.applegadgetsbd.com/storage/media/large/iPhone-14-Pro-Max-Silver-8456.jpg" },
                    { new Guid("cc449002-a4a7-49e5-b79c-5c41b74df07b"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("dd5d875a-3b40-4a8a-a504-7b22efefece1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("eb563e05-8dd6-42eb-8e18-44577521ca65"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("fc7cfcf9-dab5-4dec-9e44-7794625e6f4e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount_Price", "Name", "Price", "Rating", "ShopId", "Stock", "Total_Sell" },
                values: new object[,]
                {
                    { new Guid("1aae6456-626d-4875-b05f-c48e77cb1578"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Latest Bluetooth 5.1 Technology-This Bluetooth headset adopts Bluetooth V5.1 standard, you can achieve faster and more stable transmission. The transmission distance is up to 10m (32.8ft) (without obstacles). Compatible with most Bluetooth-enabled devices, such as iPhone, Huawei, Samsung Galaxy, LG, Sony, PC, laptop, etc. It can also be used with 2 devices can be connected at the same time, so you can separate your life and work.Long Working Time-The wireless headset has been tested for up to 10 hours of continuous calls and music time. 180 hours standby time. Fulfill your calling needs while multitasking with amazingly crisp and clear sound. The cell phone Bluetooth headset features Type-C fast charging, which can provide 7 hours of face-to-face communication experience with a single 1-hour fast charge. Clear Sound & High Quality Audio-The wireless headphones with a CVC 8.State-of-the-art noise reduction, which produces a more natural, distortion-free sound quality and clear sound. Dual microphone is designed for calls, not only is it easy to hear other people, but also prevents the noise and sounds around you from being picked up, you can enjoy high quality music and clear phone calls. Comfortable Lightweight Design-The lightweight construction makes it the perfect headset for drivers or business people,The main body of the bluetooth headset weights only 12g (0.4oz), which will not cause any pain even if worn for a long time.Moreover The earhook can rotate 270 so you can adjust it to your preferred angle. small, medium and large Three optional ear tips ensure a comfortable fit for both left and right ears.Hands-free & Mute Button- The bluetooth hands-free headset is equipped with a multi-function button, you can play or pause music, answer/end/reject calls. You can also enable voice controls like Siri and Google Assistant. In addition, you can press the separate mute button for 2 seconds to activate/deactivate the microphone, protect your privacy when you need it.", 0, "Bluetooth Wireless Headset V5.1 Hands-free In-ear Hearphone With Microphone For Iphone Android", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("1b6d293b-2995-4290-a715-0f3f3d73dcb7"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Trendy Shoes for Men With Great Comfortable. SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure you are happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "BRUTON Trendy Sports Shoes For Men (Blue)", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("1eafc910-4538-44a9-a752-e91b585dc1fb"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "All Product Size: 15.5 Inch,16 Inch,16.5 Inch MOQ: 1 Set=3 Piece (1 from every size Fabrics Type=Fancy 100% cotton Color: As picture shown Main keywords: Mens Fancy Shirt wholesale", 0, "Cheap Price Mens Formal Shirt", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("270c9225-026a-420b-b4e7-3e0545577cf3"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Visible Glow Self Lotion 400ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("43586853-83de-413f-838c-4c936e2c6ed9"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Gaming Headphone Asus with mutiple color and free delivery", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("43c6188f-afa1-4a9c-8d7a-9489a4207614"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "LVSE Inside-Out T-Shirt", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("4de99f83-df15-4872-8152-9034a4bf4872"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "TIAM Anti Blemish Body acne / bumpy skin / skin soothing / skin spot improvement- Special body lotion that solves skin problems- Body flaw soothing lotion: AHA, BHA, and Calamine core ingredients sooth trouble skin that is sensitive – Whitening functional ingredients clean up the bodys trouble and spots. AHA, BHA and Calamine calms down the sensitive and troubled skin. Whereas whitening ingredients helps with the dull and uneven skin tone. It also has ingredients which helps get rid of dead skin cells and sebum making skin smooth and soft. A body with a thicker skin layer than the face needs more care – Removes clogged pores and sebum with AHA, BHA, calamine and various active ingredients, and cares for skin defects to make it clean and smooth. Ingredients: Water, Niacinamide, Propanediol, Alcohol, Cetyl Ethylhex anoate, Calamine, Dimethicone, Glyceryl Stearate, PEG-100 Stearate, Polysorbate 60, Cetearyl Alcohol, Arachidyl Alcohol, Behenyl Alcohol, Arachidyl Glucoside, Sorbitan Stearate, Allantoin, Salicylic acid, Lactic Acid, Zinc PCA, (-)-alpha-bisabolol, Melaleuca Alternifolia (Tea Tree) Leaf Oil, Mentha Viridis (Spearmint) Leaf Oil, Methylpropanediol, Lauryl pyridinium Chloride, Polyacrylate-13, Polyisobutene, Polysorbate 20, Tocopheryl Acetate, PEG-60 Hydrogenated Castor Oil", 0, "TIAM ANTI BLEMISH BODY LOTION 200ML", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("586ea1bd-c0ac-4985-ba42-1c90063dc311"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("5c2ffd03-6488-489d-9bda-4eef42a9cd51"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Samsung Galaxy S21 Ultra 5G is officially announced on January 14, 2021. The smartphone is pack with 12 GB and 16 GB RAM with 128 GB, 256 GB, 512 GB internal storage options. The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Samsung S21 Ultra", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("671bb128-d5b3-4ae4-98f3-5358545b8219"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Intel Core I7 3770 3.40 GHz Processor 4Core 8threats 8Mb Caches with turbo boost H61 Motherboard DDR III Upto 1600MHz Memory 1 x HDMI 1 x VGA 1 x PCI Express x 16 Slot 1 x PCIEX1 Slot with 10/100 Mbps LAN Onboard DDR3 8GB 1600MHz 1 TB SSD GT 730 DDR5 4GB Graphic card 22 inch Monitor VGA & HDMI has an aspect ratio of 16:9 and with 1600 x 900 pixels | GAMING Keyboard Mouse WiFi Adopter Windows 10 Pro (trail) essential software ready to play", 0, "CHIST Gaming PC Core i7 3770 processor 16 GB RAM 1 TB SSD Windows 10 GT 730 4GB ddr5 Gifted", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("7e9358f6-fa2c-42f0-b6f3-0d78e7da43e8"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Kids Smart Watch,Boy Watch and Girls Watch Phone with Childrens Digital Camera Games Smart Alarm Clocks Music Player Calculator for 9 Year Olds Girls Boys As Birthday Toy Gifts or Cool Gadgets", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("81d14f9c-8a47-4c1b-ac7b-ad7f5a244613"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Display The device features a 6.43-inch FHD+ Super AMOLED display with a screen resolution of 1080 x 2400 pixels. The bezel-less punch-hole display of the mobile is protected by Corning Gorilla Glass v3 and has a refresh rate of 60Hz. The display offers a fantastic viewing experience with an aspect ratio of 20:9 and a pixel density of 409ppi. The display is bright, and vivid, and offers excellent color accuracy, making it ideal for watching videos and playing games. Camera One of the most striking features of the Oppo F17 Pro is its Quad Camera setup on the rear side. The device features a 48MP f/1.7 Primary Camera with 10x Digital Zoom and ISOCELL Plus Sensor, an 8MP f/2.2 Ultra Wide Angle Camera accompanied by dual 2MP f/2.4 Mono Cameras. The camera setup offers excellent performance, capturing stunning photos and videos in all lighting conditions. The camera setup also offers features like Night mode, AI Scene Recognition, and Ultra Steady Video 2.0, making it a great device for vloggers and photographers. The device also features a dual-camera setup on the front, featuring a 16MP f/2.4 Wide Angle Primary Camera and a 2MP f/2.4 depth-sensing camera capable of capturing detailed self-portraits. The front camera setup also offers features like AI Beautification, Bokeh Effect, and AI Night Flare Portrait, making it an excellent choice for selfie lovers. Configuration and Battery The F17 Pro performs on MediaTek Helio P95 chipset and is also powered by an Octa-Core processor set up with Cortex A75 2.2GHz Dual-Core and Cortex A55 2GHz Hexa-Core. It also features a massive 8GB RAM along with PowerVR GM9446 GPU, offering an impressive gaming experience. The device runs on Android 10 and has a 4015mAh non-replaceable Li-ion battery, equipped with 30W v4.0 VOOC Charging technology. The battery life of the device is impressive, lasting a full day on moderate usage Storage and Connectivity The internal memory offered by Oppo F17 Pro is 128GB, which can be expanded up to 256GB as per users requirements. The device supports all 4G VoLTE, Mobile Hotspot, Wi-Fi, A-GPS Glonass, USB Type-C, and Bluetooth v5.1, making it a well-connected device.", 0, "OPPO F17 ProUltra Function, Ultimate Fun", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("904ffa23-7aff-4c5f-8eef-a0d08262df91"), new Guid("fc7f2981-1031-4d10-8565-9cf93f211799"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("99326da9-f126-4ea1-b6de-221b20cd4685"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("ac0cfed2-698b-487f-bad0-568c5c5a1fe6"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product 1: Do Check Partner offer section for Exciting offers from HP Product 1: Processor: Intel Core i3-1115G4 (up to 4.1 GHz with Intel Turbo Boost Technology(2g),6 MB L3 cache, 2 cores)|Memory: 8 GB DDR4-3200 SDRAM (1 x 8 GB)| Storage: 512 GB PCIe NVMe M.2 SSD Product 1: Display & Graphics : 39.6 cm (15.6) diagonal, FHD, micro-edge anti-glare, 250 nits, 141 ppi, 45%NTSC |Graphics: Intel UHD Graphics Product 1: Operating System & Preinstalled Software: Windows 11 Home 64 Plus Single Language | Microsoft Office Home & Student 2021| McAfee LiveSafe (30 days free trial as default) |Pre-installed Alexa built-in- Your life simplified with Alexa. Just ask Alexa to check your calendar, create to-do lists, shopping lists, play music, set reminders, get latest news and control smart home. Product 2: Stay unbound, stay in control - enjoy lag-free 2.4GHz wireless connectivity on this durable mouse by HP with an 18-month long battery life. Product 2: Work at your pace by speeding up or slowing down tracking with adjustable DPI settings up to 1600 (800/1200/1600). Product 2: Work on your terms with an ambidextrous, contoured design suitable for both left and right-hand use. Product 2: Enjoy great compatibility across devices and on different operating systems - Windows 10, Windows 8, Windows 7, and MacOS 10.1 or higher.", 0, "HP 15 Thin & Light Laptop (Intel i3 11th Gen/8GB RAM & 512GB SSD Storage/Win 11 Home + MS Office) X200 Wireless Mouse with 2.4 GHz Wireless connectivity and 18-Month Battery Life", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("ae98d15a-e137-4e69-bb63-666e0456c84a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "1 cross button function two left and right 3D joystick functions 8 numeric keys 4 function keys. With 7 channels of LED indication.The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Dualshock Gaming Remote Controller Console Gamepad Joystick for Playstation", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("b8ae55af-3c7a-4b27-9203-43c0df3c758e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Foldable headphones featuring Bluetooth® 5.1 wireless technology with full over-ear design for a better sense of isolation and greater comfort. Enjoy 25 hours of music with Deep Bass and clear calls with HQ voice calls.", 0, "Headphones Bluetooth Style 3 Lavender", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("be114ac8-de23-4b62-adc8-ce4827e2c66a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Trend shoes for gents with all sizes", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("c8215456-0f68-4cab-8ddf-7e384a00ff64"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "3W Clinic Crystal White Milky Body Lotion is a skincare product that claims to brighten and moisturize the skin. It comes in a 150g bottle and is designed to be used on the body.The lotion contains a blend of natural ingredients such as milk protein, pearl powder, and vitamin E, which work together to nourish and hydrate the skin. Milk protein is known for its ability to moisturize and soothe dry, irritated skin, while pearl powder is believed to help brighten and even out skin tone. The lotion has a milky consistency that feels lightweight and non-greasy on the skin. It absorbs quickly without leaving a sticky residue, and leaves the skin feeling soft, smooth, and radiant. Overall, 3W Clinic Crystal White Milky Body Lotion is a good option for those looking to improve the appearance and texture of their skin, while also providing it with essential moisture and hydration.", 0, "3w clinic crystal white milky body lotion – 150gm", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("c8e6f6d3-28c8-470b-beb5-a9254ea0cd60"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Immerse yourself in deep, booming sound that delivers a theater-like experience for movies, shows, and videos. Its four front speakers and Dolby Atmos® support deliver an immersive, cinematic experience.Every member of the family will have their own tailored—and secure—experience with the Tab P10. Each user gets their own account—accessible through a multi-user fingerprint reader—with individualized settings, wallpaper, and social media accounts.Since every member of the family gets their own account on the Tab P10, parents can make sure their kids stay safe. Secure the content your kids access and put time limits on their usage. The Tab P10 also boasts enhanced eye protection and easy-to-use voice search.", 0, "Lenovo Tab P10 | 10.1 Family Entertainment Tablet", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("c98ae0be-ba59-43d2-b785-3308f90aefbd"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Onex 16 Bangles with Golden Stone Work for Women Casual Wear Traditional Golden Diamond Single Line Bangle Set for Girls Churi Set", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("ca0c5096-ed20-4426-af88-bbbc89a500f8"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space gray color with apple 1 year warranty", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("dc9baf54-213f-43c6-961b-ba3e775bf1f2"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "We believe everyone, everywhere deserves healed skin. Thats why we created the Vaseline® Healing Project, to help people living in crisis and disaster care for their skin. Here, Vaseline® Jelly is a necessity. Our Essential Healing lotion, powered by the same extraordinary Vaseline® Jelly, deeply moisturizes to keep dry skin healed for 3 weeks.*Our unique formula includes pure oat extract and Vaseline® Jelly, without feeling greasy.Our revolutionary smart pump unlocks and locks with just a 90º turn - even in the raised position, with no mess.*Proven after 4 weeks daily use in a clinical study.Water, glycerin, stearic acid, isopropyl myristate, mineral oil, glyceryl stearate, glycol stearate, dimethicone, peg-100 stearate, petrolatum, cetyl alcohol, tapioca starch, phenoxyethanol, magnesium aluminum silicate, methylparaben, acrylates/c10-30 alkyl acrylate crosspolymer, fragrance, propylparaben, disodium EDTA, xanthan gum, stearamide amp, avena sativa (oat) straw extract, titanium dioxide (ci 77891).", 0, "Vaseline, Intensive Care, Essential Healing Body Lotion, 20.3 fl oz 600 ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("dfecd375-0d9e-405c-8e48-ff8b639831bc"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "SOFTSPUN Microfiber Cloth - 4 pcs - 30 x 40 cms - 340 GSM - Blue", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("ea89dee7-3be0-4099-9161-1fb61331de12"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "ZenBook Pro Duo 15 OLED lets you get things done in style: calmly, efficiently, and with zero fuss. Its your powerful and elegant next-level companion for on-the-go productivity and creativity, featuring an amazing 4K OLED HDR touchscreen. It also includes the tilting ASUS ScreenPad™ Plus secondary 4K display that offers effortless ergonomics and seamless workflows. Powered by up to an Intel® Core™ i9 14-core processor and NVIDIA® GeForce RTX™ 3070Ti GPU, ZenBook Pro Duo 15 OLED brings you all the benefits of tomorrows technology, today.", 0, "Zenbook Pro Duo 15 OLED (UX582, 12th Gen Intel)", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("ec4bba36-d3c3-41a7-964a-770024dc2b0c"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("ee3069df-93d7-40fe-9828-a38acd6bf9e6"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Beauty Cream 150ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("fb5b1cdb-8119-49b3-8a65-7577517c0b84"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("12d1a67f-9bec-4640-b1d7-c87bf3fd81aa"), "comment", new Guid("00000000-0000-0000-0000-000000000000"), 5, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "PublicId", "ShopId", "Url" },
                values: new object[,]
                {
                    { new Guid("02435cad-1fd2-47b8-8fbe-1d8ab9946bcc"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("054a5bfe-8ea9-408e-ab10-a1ca8001da2e"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("08f5fe17-e8c6-4a0d-8833-f2a640788a02"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("1a7ae8ed-6c49-493c-870d-b3e97d1c8364"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("1b22dc8a-cdca-4f3d-bf8f-e19a7a7e83b6"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARwAAACxCAMAAAAh3/JWAAAAgVBMVEUAAAAKCgr///8GBgbb29vR0dHk5OTIyMjt7e2zs7O+vr719fWqqqqenp7e3t6Xl5cuLi4hISGBgYGJiYnExMRCQkIVFRWQkJDOzs7i4uJzc3MmJiZPT08fHx83Nzd5eXlaWlpiYmJGRkakpKRra2syMjJEREQ6OjpVVVUSEhJ1dXU8mJS/AAAE9UlEQVR4nO3c63aiPBiG4SBBAoIbQDYFRdx8as//AL/kjW2dafvOais6Os/1Y4ghKtx109quEQIAAG5oOZ/Pl/tbH8VfynEd4Ti3PgoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIDvcU+cD+jpWx/e9X3S4mP/SqGvNLGOOXGPVOnWx9+Pr1exxDwh4Va8Po5ufS6X9M0spziH1LRJ1VScTz9CoB91sXHa1Ah88W7XHT+Evvs8+i3ArDBSmVIcm+Ptlu8yz0XCGKKJJ8awEeY/0c138/V86tAdmPtxZjvznw/X55HcejnfT2n3p+1mu/1y1m+Cj10sDMVJNlocSn3D83ayicnkWXfp2vTlchwXSUd3vnwq7MSmSBvRTczDLja78hVFjmO9ZBKFmV+WfpQu77eMiRMRuRHTInojfdeNT+PAbrxAiLrdvM0E3iS3g0Qf1zQxo8A7bKOs9OR4qCk13N5tGfOsCohaLTdm2y6nB32KQTROlnZPtOoKO5JNndIg7bqIBv6KrhROhJh2oRlmSRf6vl8GT9tgPK50n+ZOy5g4aRZqWdWYTSj100kkZsovt7QnHLtiZ0dqFdPA+08sOjs1mZhtFoh6TpezWF8r831vL/JISqnzRFco00sa/WYUevoL7Q+jwKftVKxj+tLLbEMzMhLOtqShl9C2LM0LjJ0KC9qGog5okDV2iS4ycyqqU/aeppcymtgPpfQ8TxXmX68q55tSn1IZpNvWI2olnIhG4+I0sxXuIqX1XtnabW0vy0NAF+VKP8/WY91mXIV3mkbHKdSwGutXz0ifiZRVIIdelHR13orWfOGlVELsPBoN07GdqYVYhDQexlu76kCbcbGnS3Ksj3qXVjpNpZJe2/SXRsfxRkq/pSg/NG8uQ2+T7BfHvN76hbAzSr9FPSk7TOxWn/nxMLTrjx3N+Z5de1zZJZ5+VtV2rucHTp9t8pGhRmloIqmqOBwOT7GnVF0rMtqKY0T7RmFHW1V167qkmWwnVuqNnInGjrxmPYvN6pGs7zdOOxhQnnVDm1GlX3dGg8EgEondoWbCUTQaPIvAzlWlmRlU7U5/32h30tKVfqFp7ZKRX+nBQE0W/bbpNY4/IPIomtNQU2FweNmTCdGdpnOxSOTLmlHW6p8OHFGr16sV5mDrLnud8CbTntP0Guc4XRi7xPxcdVwl+gfQp2Ymcn2Su6mx7sRiT6P6Wa9x3Rkt2s7NFUzdXT07meZ0tMc8b9pU38669zA9x3HO7+P1Ds33VO7bnvM17vmaX65k3lRv8CN8n3Eu7tp9bn2+X3XVPrc+2W+4Vh/3HuM41+njOHcax+n/I2jnnuM4vfaht8u7jmP008d+K3H3cZwe+rx8UPEIcZwLP8Feb/VB4hgXCnT2+dYDxTF+3OeXj/4eLI7xg0fQb7f0gHGM7wR6/3nxg8YhXyj08a9fHjkO+fOflX3+e6mHj/PCfV/pj3+798/E+Q7EYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jD+B4GNmzYUY1XJAAAAAElFTkSuQmCC" },
                    { new Guid("1dc224bd-d24c-4c40-b56d-fbc0a59ead62"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("20a9feea-138c-4ae8-b5bb-d69968215b25"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("2ff61cc5-d9a0-4b11-9679-b733aa8d077a"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("30b527eb-4c80-4c65-8a2c-ab8637ef3574"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("37e7319a-dd62-4213-902d-8f3e07331634"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("40230b82-65ea-4395-ab16-24025ad04733"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("477f35a0-50ce-4a11-809e-0f6b187afe60"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("5178bb20-89f0-420c-ba8b-bae1769565fe"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("52cfa952-a799-4fae-843a-d5416b5273ba"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("565f957d-67b1-451a-b824-d853ecd96fa0"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("6e76835e-78f8-4882-a4c2-4fd72570c4b4"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("9a0828d9-9300-45dd-a019-86d1d23a36a7"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBQSEhgSEhIYFRgSEhwSGBgYEhkaGBwVGBwZGRkaGCEcIS4lHh4rHxkYJjomLC8xNzU1GiQ7QDszPy42NTEBDAwMEA8QHxISHj4nJSs+QD00NTU6NDY3MTQ0Pz80NDQ2PTQ0NDQ0NDQ0PT00NjQ0NjQ0NDQxMTQ0NDQ0NjQ0NP/AABEIAK4BIQMBIgACEQEDEQH/xAAcAAEAAgMBAQEAAAAAAAAAAAAABgcBBAUDAgj/xABJEAACAQIDBAYEBw4GAgMAAAABAgADEQQSIQUGBzEiQVFhcZETMoGhFEJyorGywRUzNDVDRFJic3SCksLSU1STs9HwY+EWFyT/xAAZAQEAAwEBAAAAAAAAAAAAAAAAAQIDBAX/xAAoEQADAAEDBAEEAgMAAAAAAAAAAQIDBBFBEiExURMUMmGBInEjUqH/2gAMAwEAAhEDEQA/ALmiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgGIi80sVtShS++V6aW/SqKD7zJSb8Dc3YkYxO/Wz6fPEBj2Ijv71W3vnMxHEzCL6lOq/8ACqj5zX90usOR+JZR5JXJOolZV+KR/J4T+at9gX7ZoVuJuKPqUaK+Idv6hNFpcr4KPNHstyJS9TiHjzyemvyaI/qJmtU352gfzm3hTpj+mXWiyfgj6iS8IlEnfLaB/O2/lp/2z5/+X4//ADb+Sf2yfor9oj6ifRfMSiV3y2gPzt/alP8AtnvT382gv5cN8qmh+gCQ9Fk9on6iS74lOUOJONX1hRcd9Ngfmv8AZOrhuKLflMKD3pVIPky/bKPS5VwSs0ss6JDcFxFwT2Dl6JP6dMkeaZre2SfBY+lXXNRqpUHarhvO3KY1FT9y2NFcvwzciYmZUsIiIAiIgCIiAIiIAiIgCIiAYi0Xmnj9p0cOuevVWmvazAX8O32Qk34G+xuTEgu0+JWGp3Wgj1j+kegnm2vukR2jxAxtW4V0oL2U06Vu9nv7gJ0Rpclcbf2ZVmlfkuStWVFLOwUDmWIA8zI9j9+sBR0NfOeympf3gZffKWxeKeq2aq71G7XcsfZflPGdMaH/AGZjWofCLMxvFFeVDCsew1HC+5b/AEyP4ziDj6l8r06Q/Upa+blpE4m86bHPBk8tPk3sVtnE1fvmJqtfqNRreQNvdNAKOyZibKUvCKNt+RERLECIiAIiIAiIgCIiAIiIAnrh8Q1Nw9N2RhyZGKt5jWeUSNtwWDu1xEdCKeN6SHQVVXpL3uB6w7wAfGWhSqK6hlIZWAYEG4IOoI7p+bpbHCjHtUw1SixuKFQZO5XBOX2MG8552qwKV1T2OrDlbfSyfREThOoREQBERAEREAxESKbxb74fCXRT6aqNMiEWU/rtyXw1PdJmat7JblapSt2Sq8GVDsve2vitoYf4RUyUvS/e06KXKsEzdbdMrzNuWknu+WDxNbClcJUKuHDEK+VmQXuobqNyD1crdc0vC4pKu25WcipNrg5m+P3UCM+GdBTAJZaan02Uc9WBB/hsey8qGtVZ2Luxdm5szFmPiTrLK2fv8MLSXD4uhiGrU1s5YICdTYnMwJ0tqecrSs12YqNCxKjuJNh9E7tLLlNNfv2c2at+6f6JRsvcTF4mitem1EJUXMod3DWuRqAhGtr8557Z3JxWEotXqNSZEKghXct0mCg2KAcz2y0caPgmy3C6GhgmA+UtMge+Y2unwrZb219JhM6/KyZ194ExWqydW/G5o8M7fnYooC+kmg4a40658P8A6lT+yQ2jqy97D3kS/wDbmL9Dh/SXtlqUrn9U1UVvcTN9TmuHKnkzxRNb7lI7e2JVwNUUqxQsyCoCjErlJZfjAG91PV2TtYLh9jKtNaqtQC1EVwGeoGAYAi4CGx17Z2uLeDLPhnUavmo+0lSo95k5xFUUnw1BT6zMP4UpP9uWZ1qb+OXPl77/AKLzhnqafhFM7w7tV8Bk9OyH0mbLkZm9XLe+ZR+kJ4bD2FXxrlKCA5RdmY2RQeWY2PfoATpJxxeGmGPfUH1Jt8JXT4NVUWzCvdu3KVXKfDRvIy/z2sHXyV+NfJ08HIHC+vlv8Jp5uzI1r+N/skU27sKvgXCV1HTBKOpujAWvYkA3FxcEdYk+29Wx2D2h8MY1auE60pm6quSxV0Og6XSze/qnA303vo4+ilOnSdWSpnu4S2XKykDKx7R5SMOXLVLfun/wXEJPhnK3f3Ur49Gei1NQj5DnZgb2B0yqdNZq43YdWjihg3ZC7MiAqzFbvbLqVBtqOqWBwi/B6/7cfUWcLeb8ep+3w/0pLLNfy1PCRHRPSn7OdtrcnE4Si1eq9IohUEK7lukwUWugHM9s5uwNiVcdUalRKBghqH0jMBlBVfiqdbsJa/Ej8W1Pl0/9xZC+E34a/wC6t9enKxmusNU/KJrHKtSa2L4eYymj1C1FgiFiFqOWIAuQAUAJ07ZyN3t3q2PZkoMgNNQzZ2YCzEgWyqeyXb8NBxLYY2/B1rAdoLujez1POQjh7g/g+0MbQ/w7KPk5iU+ayzONVbht+V4LVhlUtvBBdvbDq4KoKVYoWZA4yMxFiSPjKNdDNjd/djEY4k0gqohszsSFvzsLAlj3DtHKdviv+Gp+7r9Z5PNwqSps2hlFsyFz4szEma3nqcM1yyk407a4RC6nC+uFuuJps3YUZRfx1+iQ7auzKuFqmjXXKwF+dwVN7Mp6xofKSnYW+r0sbUbGYhjSbOMtswDZujlA5AC40njv/vFhsd6FsOWLU8wYshXotlsNeeoMnHeZWpvunyLUOd57Mh8RMTsMBeXLw12QcPhPSOCHxDekIPMKBZAfEXb+KRjcbcpqrLicUhWmCGSmwszEahnHUvd1+HO1xPN1edV/Gf2deDG1/Jn1EROE6RERAEREAxNXG4ynRQ1KrhFQXLMbD/34T1r1VRSzEBVUsSeQAFyT3WlIb37yvj6psStFGPo07erO3ax9wNu2+uHC8lbccmeTIoR0t6d+6uJLU8MWo0tQWBs7jvPxB3DXtPVIZET2MeKca2lHDVunuz2weFes606SF3e+VV5mwLG3sBPsljbK3nxuBpqNo4Z2pZggqnLnBPIEX6egOuh065Bd3dojC4uliGBK026QHPKysjW7wGJ9kuLaeDw+1cMEFbMpYOrU2FwRfmD3EixE5NTX8kqW69+jbCuzafc+to7Nwu1MOGOV1db06q+up1Fweeh5qewgiU9s3ZzfD6eGbUjFrTa3IhHsx8LKTLfothdk4QI1WyUwxGZgXZiSxsBzJJ5ASttzcSlTanwisy0xerXuzhVDNcBbm1z0/dMsFVM1t44L5EnU7+eSweI2I9Hs2r+uUpj+Jhf3Az33IrCrs2hfW1M0z/AWQ/Vka4obVpVMNTpUqqPmrZmCOrWCq3PKdNWE2OGu1qKYI06lZEKVnsHqKpytZrgMeVyZn0P4d/yW6/8AJt+CtHw/o8SaVrZMT6P+R8v2S5OIRtsyvbnlS3+okrPeZUG1GZHRkfEU6mZXBXpFC2o055rywN+9qUKmzqyJXpOxCWVaqljaohNgDflea596cMzx9lSPba2HGNoYGrz/AP0UK/sKkn7J8bUxV9tYWkD6mHqOfFwwHupnznnuLtqh9z6SVK9NGp5qdmqKrWVjlNiey04CbVpvvB6U1EFOmpphy6hLCkfjXt6zNMph70vSZq6WyfvY3OLo6GHP/kcfNH/Eh+7WH2gjDE4Gm5AJQlQpRrWJVgTqP+giSnipjqNWlQ9FVSoVqtcI6sQCh1Njpynxw03hpUkfC1nCFqmemxNlOYAFbnQG4uO2/dN4dLT9luZUk8vd7Ej2Fvgtar8FxVI4fEDQoxurGwNlPUSCDlPbzMjfEndqlSQYuioS7hKigWUl+TAclNxY25385TX3Uw1TGDHl2zh1qZQy5CyABW5X+Kptfqkc4m7fovSXCUnV2Lh3KkFVCXspI0zEnl1WmWLf5F8f7L39r6v0bXCL8Hr/ALcfUWcLeb8ep+3w/wBKT64abepYZ6lCs4RapDIzGyhrEFWPIXGWxPYe2TXG7s4Wvi0xzVDmUo1ldcjMvqMevs5HW0tb+PNTpeURK6oSXB58SfxbU+XT/wBxZDOE34a/7q316c7HEreGi1D4JSdXd3VnysCFVDmsSNMxIGnjI/w1xtKji3etUSmpwzKGdwoLF0NgT12B8pOOaWnrsRVL5USzeLH/AAfbOEcmy1KJoN4O5A+dkPsnao4DJtN6wGmIwgB+XTYKfmsnlK/4m4+nWxFF6FZHyUmGZHDZWzXF7HQ9cn+zd6MJUpU6j4mijtTBZWqoGViBmUgm41HumVxSiWl57M0mk6aZAuK34an7uv1nk+3H/F2H/ZfaZXHEnG062LR6VRKiigqlkcML5n0uOvWSTh7vRRGHXC1qi03pEqpYhQykkixOlxe1vD2a5Jp4J7eDOaXyM0+Hu0qRqvg3oBmetVqh2CkBRbo6i/V7598WcOqJh8iqt3e+VQL6JztJRsbdjCUK7YqgSzPm/KZlXObnLb7b6T03g3aTHPTNZ2yUcxyLoWZrXu3MCwGg7ecy+WVlVLwadD6GuSldm7NrYlxToU2duuw0UdrHko8ZaO6+4NPDlauKIrVRqF/Joe4H1j3ny65LsBgKWHQU6NNUUdSi3tPae8zaMnNqqydl2REYVPd92ZEzETlNxERAEREAREQCH8TcU1PZ7Kv5WotJvkm7MPaFt7ZTMv3efZAxmFehcBiMyE8g66qT3X0PcTKIxmFei7UqqFXQ2ZT/AN1Hf1z0tFU9Lnk49RL33PGIidxziZRypupIPaDb6JiIAYkm5Nz2nUzEzEAwBFpmIAmLTMQDFomYgGLTMRAM5ja1zbsvpPkTMQBMDlbq7JmYJgATM3sFsnEV/vNCo/eqHL/Mej75JdncOMZU1qlKA7GbO3kht86Z1mxx5ZdRVeEQyfSU2Y5VUsx5KqksfADUy29m8NcLTsazvWI6ici+S6++SrZ+y6GHGWhRSmP1UAJ8TzPtnLetlfatzWdO35Kf2VuJja9i1MUVPxqhsbdyDpedpNtkcOMNSs1dmrsOo9FL/JBufaTJuJkzlyanJfO39G04Zn8nhhcMlJAlNFRV0CqoVR4ATYiJzmwiIgCIiAIiIAiIgCIiAfJnH27u7h8amWsnSAsrro637D2dxuJ2YkptPdENJrZlQ7X4bYindsOy116lJCPb2nKfMeEieO2bXoG1ai9PvdCB7DyPnP0VPkrcWOs6o1lr7luY1p5fjsfmsHsmZf8AjN3cHW1qYWkx7fRqG8wLzlV9wNnv+RK/JquPpM6FrZ5TMnp3wylYlu1OGeDPKpXXwdD9ZDNduFuH6sTW9opn+iWWsxlfp6KqiWl/9W0f81V/lT/iZHC6h14mr5U/7ZP1mIfDfoqyJbCcL8L118QfBqY/omzS4b4JefpW8alvqgSHrMYWCinol3UtxNnr+b5vlVHP9U3qG6+Cp+pg6I7zTUnzIJlXrZ4TLLT17KCUgmw1PYOc6GG2LianqYaq1+sUmA8yLT9AUcMieoir4KB9E9bTKtc+JLLTe2UjhdxNoVOdAUx2vUQe5ST7p28JwvrHWriUXuSmznzJX6JakTJ6vI/HY0WCUQfB8NMGmtR6tXuLBF8kAPvkgwO7eDoa08NTUj4xQM38zXM7ETGst15ZdRK8IARMxKFxERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQBERAEREAREQDUGOpZivpFuBm9bq6QOvXbIb9ltZiptCirZGqKG6OhYX6bFV8yCJpDYNIqyksQ9ha69EdLorp0V6R0EymxUBzZ3JLKSTkuSrmoCejbmzDwPbYgDfOMpjU1E6/jjq0PXMUsbTb1XU9JltmF8ymzDxHXOcm71FU9EpYAqBcBAwylcpBC+sMq9LnoNdBM1NgUnuGZyGLEi665mZ7Xy5hZmY6G+tiSNIB0KOMRyQrhiLcjcG4voeR9kz8Lp/4i6gn115L6x58h1zTXZKBzUzuXZfRs3QGZbg2ICgDlzABnjU2DTIszuQUyfEFwFdRyUahajDT23gHVpV0a+Vla3PKwPnaa9XaNNWKEtmUXsKbm4uoOWy9Kxdb2va+s+MPsunTLGxOcgkG1rh3qgiwHxnPkJ8V9lekLsa9VfSgCy+j6Kgg5VuhIBsb6m+Y91gPT7q0Stw+YZUbRWY2qepYAXJI1tztrPk7Yo3AzMcyhltSc5g1rFbL0r3HLv7DbxbYNLpXLHOuQ6IP0ddFGvQXw+Llns+zUOqlkYFcrLlugpgqFW4Iy2ZtCD657rAE2vRbVWLaZhlpu1xoOjZelbML25X1tH3YoWJFQm2XlTY3zkBctl6WrDle19Z5fcKmFZUZkzoiFly5vRpYBLspuDre9yb2vYAD5Gw0Bdg7A1hlJtTOlwdbpry0vfKNFsIB11Nxftn1PKlSCKqjkqhRc3NgNNTPWAIiIAiIgCIiAIiIAiIgCIiAf/9k=" },
                    { new Guid("b91059a9-02e0-48ae-a2e6-8a7a569baa7b"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("c085065e-6d02-4798-b2c6-42152e0bd0e4"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("c6080620-89e4-4205-8a40-99a5b4fc91dd"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("c7154e88-8d4e-4d38-91ae-db6618d9d3d6"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeGWw-VaNcL9QlsHKJKPLWj-Dh0M2WguDpRg&usqp=CAU" },
                    { new Guid("c9fd09de-96f0-4e07-ad39-27ae833092eb"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("edf8c28b-af0d-462a-afc8-b4792b25bba0"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("ee7ec040-4469-4016-a9d4-e2546d35e73c"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("f0b5d68e-52ea-40f7-b1e8-5bac1c962a4d"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("f2938b10-f6c7-4d90-90d1-18834de8f6bf"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("f41e8c6a-243c-4c0d-97c5-6a4a6a368201"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("f7e9136d-a4a5-460e-8360-89a1399fb281"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "Ratings", "ShopAvatarId" },
                values: new object[,]
                {
                    { new Guid("050fdcbe-6f15-45ac-9cd5-1c0b18a2d9e6"), "Asus Ltd", 4, new Guid("b43f244b-12c5-4005-be0e-16f110c97791") },
                    { new Guid("061bb05f-b316-47e5-845f-249d6e8baf4f"), "Lenovo Ltd", 4, new Guid("64436c12-ef80-4ce9-8f9e-4c55102282b0") },
                    { new Guid("13ec4f66-6dd5-4ff8-a350-1968456e8ad3"), "Unik", 4, new Guid("32a1a64f-ec11-4331-ad69-29b075fe2651") },
                    { new Guid("18de83e3-ca69-4fae-ae59-3eace814227d"), "Oppo Ltd", 4, new Guid("ec4b348e-606c-4471-b82e-8a0e4b6b1b09") },
                    { new Guid("296cd27f-c30f-4680-a6eb-4fb0cc084e3b"), "3W CLINIC", 4, new Guid("c2e87248-a359-4509-8d23-3e892cf44953") },
                    { new Guid("2db59025-375a-422e-9a7d-b753d09dde36"), "Apple inc", 4, new Guid("cfd7aaa1-7a0d-4be8-8563-f7e7e1ecef63") },
                    { new Guid("385980c1-4bc6-4835-b839-0e8dfee11861"), "Amazon Ltd", 4, new Guid("8fd685d8-2aa3-438f-b6d9-da11d50be626") },
                    { new Guid("39e15af9-c0c4-4709-805d-9f260a67679e"), "Unbranded", 4, new Guid("4928cbe3-4061-493b-897e-6b5b5145d5fe") },
                    { new Guid("3a14a5b5-6157-4dea-937e-f3c10f599ce0"), "Amazon Ltd", 4, new Guid("be3ed2bf-eaa3-4c8a-a6c9-78f82c5eb7a2") },
                    { new Guid("4867f059-4c5a-4b43-a18f-4334b76400bb"), "Acer Ltd", 4, new Guid("348b71d5-2eb8-45c6-81f1-f6e849377978") },
                    { new Guid("4fa3da01-15d4-49e6-bd83-0fcc01a4c645"), "Shodagor Ltd", 4, new Guid("cc8070dc-9049-46d4-8d7d-ee8b2bc2a464") },
                    { new Guid("5dc94767-5867-41cf-b28d-d3345d3e8ad2"), "Unik", 4, new Guid("ec201f4d-7a74-4afb-b978-5a2adaf33c38") },
                    { new Guid("6930533c-0c8e-4ca9-aa1d-088561f23d92"), "Asus Ltd", 4, new Guid("de520fec-4e18-498e-882a-98a0089180d5") },
                    { new Guid("6e0addb1-a9c4-4660-8731-2dc32059488a"), "SAMSUNG", 4, new Guid("d070f7da-4a85-47e7-9647-5a0a436c49d2") },
                    { new Guid("7087cfe1-1906-47c7-a89c-39226714018d"), "Amazon Ltd", 4, new Guid("d729938d-d3d1-4e62-a204-6dd37970ee6a") },
                    { new Guid("7f15db37-cc93-4080-93ab-c355894fa163"), "Dove Inc", 4, new Guid("4432368e-0e30-43f5-9a59-b169f54f86f6") },
                    { new Guid("8771e363-b254-411f-93d8-d13e5d365f15"), "Shahriar Watch House", 4, new Guid("1e3c7497-f39a-4501-b710-93bc35e39ba0") },
                    { new Guid("92a182cd-0b55-4c76-8ffa-f7858becab26"), "SAMSUNG", 4, new Guid("85237d27-083d-44a3-ba51-309075e48ebb") },
                    { new Guid("9f6bbfc6-858a-45f0-adf3-cfc82356ca84"), "Dove Inc", 4, new Guid("8788065c-a161-4fb3-a006-a79c0b39eedb") },
                    { new Guid("a14c7769-2b44-4a21-89c2-fe0a8cae7b4d"), "Amazon Ltd", 4, new Guid("26c13ef9-20c3-4bfc-94fd-4aae0f2cc9db") },
                    { new Guid("a3fedf5a-47ec-41d6-9df7-5c8b48b246d0"), "Apple inc.", 4, new Guid("67e84e71-b09f-40b3-b6e4-a387fd342573") },
                    { new Guid("c1ba4147-0b4c-42c0-8a93-e7b1ad7116f3"), "Alisha Shoes Mart", 4, new Guid("82738152-cbf2-413b-b86c-40058a792c23") },
                    { new Guid("c3bce486-c0aa-4695-99d9-306dfb0de30b"), "Shahriar Watch House", 4, new Guid("a53fa525-cada-4990-a60f-3b5ffd2ca30b") },
                    { new Guid("d0285ace-587e-41e8-859b-b287a47606d4"), "Tiaa Ltd", 4, new Guid("89655fae-3f98-4c21-8852-817d8e1ebe39") },
                    { new Guid("d8a2be84-0939-4b4e-80f0-c7fe85dd0adc"), "Louis Vuitton", 4, new Guid("11a34b47-369e-49d9-ae5c-9a97cdbc17a9") },
                    { new Guid("deabdf54-d633-4854-ba3e-5df5e54754ac"), "Amazon Ltd", 4, new Guid("a5fd1930-63c7-477e-ad33-baa52920d54a") },
                    { new Guid("f382ee5b-a867-464f-9dff-6b161b156ed4"), "Energy System", 4, new Guid("943b0f63-1ec5-4600-af9e-a55632ec4886") },
                    { new Guid("f7abb8ef-5b82-4d56-ae3e-8c631cf24877"), "Vaseline Inc.", 4, new Guid("a737cfde-dd32-455c-a568-b8328b6a9b95") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e824988b-492f-4489-be87-9536b536be23", 0, 36, new DateTime(2024, 6, 7, 19, 29, 29, 769, DateTimeKind.Local).AddTicks(7201), "f73eac97-a445-4db9-859d-d853da7981c2", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, "825d961d-8e24-4916-ac2a-c07f32dded5c", false, null });
        }
    }
}
