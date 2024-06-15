﻿using System;
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
                keyValue: "43023697-2e80-4897-bd7e-1af6210a6dad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab971ffc-f154-4d5f-b321-b1f4bac6d308");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c96ac86-d8dd-4e3a-80fa-b408a528d11c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a55c4b0-3bb7-4aef-b491-b89370a4809c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2122c1ea-a9ba-44e5-aee4-818ba4d7b01c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6fbd61fc-0f67-4143-80ac-f68e85c660fd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("926b1d03-ee7e-4a83-b452-c40f3c13946b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f725793-ac1b-4cee-bd8d-ecc4cd892829"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a82f0939-9d70-4b8b-8548-db1886df45cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5ebb95a-9fdd-40c9-b077-1da0d5167884"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1fa6503-dbc6-4f9a-9663-9cec1690dd5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4776445-863e-4555-b348-a3c865182f34"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("05345b80-a9a8-4bae-933d-2d57563c80fd"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("070719be-a9c8-4327-81b7-8cd4d36874fa"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("070d41d6-efc2-4ffc-a842-40435ab694c3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0c31ff2d-70e9-44c4-b4b1-9be15d03582d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0e6c331c-bba6-414c-8aed-fe96ddd1b408"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("15f4707b-d90b-4827-af2a-bb48544ab3b4"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("1fa85849-c6ba-4a85-b529-2aaf7650d9cd"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("21831f7e-4f57-4cb3-8e4a-d3e039b7a117"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("23162faf-4dc3-4b79-8654-7a492fd63916"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("2c7167ef-6591-407c-a5f2-16c86386b358"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("315971a8-aea0-4029-b265-aa95d9896b6a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("325a6b1e-51d4-449b-bfa9-f335ff9babc9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("33a04b0c-44e3-4f30-8c8d-b80d3b7738df"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("374e1468-9abd-4fba-a64a-3676468eaeff"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("44de68f8-9b20-4b8f-8eba-939cbcb1264f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4662d363-c30b-4270-9584-687e7818b39a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4a321a24-59c4-459f-bdeb-2a3c43048be8"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4d3bd074-3b0b-49a4-8c9f-bc8eb5a92fae"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4e248407-335d-49d2-8b7e-efb23fc0072b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("4e8284be-111c-4a4f-bb8c-96d4e795000c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("598bdec5-95ab-4e97-b527-0176b406b2b1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("5b4ba021-743e-4643-abcd-606c05c47832"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("66a8226d-700e-4cd0-913e-8ae8150eef9b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6c134c6d-bfc3-498a-b201-ffdaf61568d7"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6cc568a0-b1ed-438a-b643-47daa4ff5db6"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("76ad8418-2d75-4e1e-8671-05dbcfc46a1f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7ce42c9f-8388-4002-9853-a1cfb4a088a0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7e316362-73f3-42ab-9fba-26ec9eb95d2e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8bca724b-799f-4212-aed9-18dde3cf3f96"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8c1a7e45-cd69-463b-846d-aa1ba9f69247"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8ed282b4-4f6f-40e2-b54f-49e2e8720f01"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("91a91674-b0f0-43a4-b05a-e8ebc5e0bfa5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("98649531-2122-4ca9-af31-553145c445fc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("992ecfb6-93ac-4ff3-a24c-facce65500cc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("9ed50c0d-563a-412a-954c-30378ba537f5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a67fda01-7cee-42dc-a68f-4ca63de64827"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a6f5ad8b-bce8-45a5-b8d3-e00b96912ed1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("a80fd49a-46ed-4fad-bf9f-4e649910ea72"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("ab757c21-bc5d-4c71-8b50-d10c75da90b1"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("ad2f3ae3-5222-41ef-9a6f-1a5955ebbb65"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b5c575a8-f5b3-4129-8f0d-33b4e236e054"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("be838efd-0931-4349-9f74-3e91255b8d57"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("c7ee0c23-bb0b-406a-9dd1-2dcad66f7651"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("d37d4d06-c702-4f23-b4c7-eee26bb26c0b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("db49b890-cc4a-4812-9bb1-3fcc1ee7847e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e0c11dc5-bb16-460f-85a4-f6dcb46c4507"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e46f80e7-dbb7-4990-a6e3-933a77d501d3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e4db1184-3379-4337-901d-904355eff527"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e8e09518-547c-45e8-9eb4-9d25a88e9b3c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e91ce625-ff0a-49ec-a4fd-822fab55a30d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("eb9b921c-b95b-4e81-99dc-0bc713fdde2d"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("ed73c0d6-1879-4911-a249-c3989985f128"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("edadaf53-2cfa-426d-8bd3-2a3602e069fa"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("f3f36770-c784-4294-a428-1f47b9caa3c0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("f4aafad3-b0a2-465f-84d2-c56ad4467526"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("fce08e79-d026-4410-8135-e385dbfcf49e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("93ba7588-6338-471f-b0bb-9c4f94034da4"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("02403ca7-c44f-4ffa-b75e-22347d29f1b4"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("3fdef302-24da-467d-8705-2c7ce1c42a61"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("4f551209-a672-4d5c-86db-80a521e930ab"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("50e2f411-5188-40c0-9c9c-4985779f604f"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("565f7fe5-c1de-455d-be25-56a6648b7948"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("5796dbe8-95b7-4a21-88e5-8892127d6744"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("5800ffbc-ec6e-4031-98b6-d659f5d5e384"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("58e75fac-d100-4b8f-9aa5-e02257702029"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("6146f98e-346d-4bda-b1b5-a54acea98e0a"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("63c4b689-17f8-4f76-b237-ea8e2c0b8f62"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("6caaa6fd-792a-48d0-b8eb-390668dd8aac"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("7915518a-becf-4c04-9b12-fee1d807727a"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("8e9d0eae-19e7-4067-a32c-6e663a8f2441"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("9707ffca-652f-4766-8cbc-c68574184535"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("a46c6035-4ed7-43cd-a1ad-ecf4d7c2f273"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("a4ee5a76-5a85-48c1-8cfd-7001acaa7714"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("ae6571e3-fbb1-475a-b223-fe1decde716f"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("b4c6e5b5-88d3-4d66-b22d-5e3cc068914d"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("c53b9419-0cf5-4f8d-bc15-91eb888c86cd"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("c7ba492d-8e32-4f92-ae64-3381041bc765"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("cc6cc44d-f395-4c0e-8819-ba62c2d2ee42"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("d08549d3-28c2-4a85-91bb-3be22f04f4a8"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("d59576db-58ad-453e-a04f-a1706e945e5c"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("d7bea74e-1675-45a0-a51c-344305d3d23f"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("e8180110-eb59-46df-ab3e-2a55005edca5"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f4d7ee74-477d-45fe-80b5-b569c81f99eb"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f516859b-cc34-40f7-84d3-9fc03d46cddd"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f71c1802-a472-4b52-ba8e-ca896f418e23"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("0133ab03-d17e-42bf-85a2-9181d9d1da61"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("0360825f-368b-497d-b590-4b82943dc9e0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("18f6578c-8f58-43d5-80b7-0a5c01d7db6d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1a0661ac-c406-493a-a747-93b11b5269c4"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1c1438d1-fd47-426c-9a39-7ffa380042d0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("248a4afc-2ebc-4547-98f0-e5b9def6f6a2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("312f8ade-2ad6-49b5-835b-300f76d23831"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("3a62f09b-9c85-45d4-a807-56b290d765a6"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("3e914d8c-f8fd-47f7-8233-7a03c4a1295d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("412a1e25-5c86-472a-be20-80b635127fa0"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4903b8dc-796f-49f6-b0e5-0afffcf1b6a5"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("53472c47-a418-48d1-969f-ee3ee2862709"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("5626480e-e493-4665-a49b-33f0df80ea23"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("569a8312-c0a8-4807-85fd-42293b35fab9"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7410b8cc-4739-4af1-b7b5-371f245d1307"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("8154db0c-ae3f-4a85-8439-0e79f66a51d8"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("84739c97-6473-4548-9aa0-99aed2e57230"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("87600fba-1192-46a3-a02c-6fdbf95bb429"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("9fcdaa7c-a530-4d54-ae5f-f45300f4c4b7"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a36a49e3-48e8-45e6-bf16-6e3306136d25"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ae0f0ad6-b4d7-45ce-9fc3-4b5fb9f6ae06"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("bab213be-033b-4a59-b843-8eae023399a2"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("bb48ee16-faac-475d-9fde-c2b610a7bb7f"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("cde6e6d7-7fad-47f3-87fd-ecd7b8ec649e"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("dbeb95e3-ffe5-4c04-9d2a-7ab34dc9fd2a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("dc5f9ef2-0351-4dc9-98a2-1b96603bc4e3"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("e143c522-fc6d-43e6-9ec9-e338c8353652"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("fd6b8954-d2d1-482d-9c97-5844a4d08b6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "515775a3-c22c-48eb-8b7b-cd4cf711e2b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d14ca1e-9705-453b-890b-fd5d361aa72f", null, "Administrator", "ADMINISTRATOR" },
                    { "77fdb281-212b-4d18-8cd4-b782d891ca62", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("1a3c1f68-c146-4c12-89f5-edf0cd1ad439"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("41ac7021-a6e0-4a1c-a7b4-14b453685ee6"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("7decc907-6731-4351-a8ca-a8ac374227a5"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" },
                    { new Guid("a4692d2f-4d3f-44da-90ea-977dd02513b3"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("ab49fe78-5fe7-40f3-98df-80d1574f98af"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("bc76ebc8-4d5c-4ad1-8c6e-4c863c45181a"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" },
                    { new Guid("c50d2951-b2a9-4dfa-95d8-f107d941d9da"), "", "", "Others" },
                    { new Guid("df1e41f9-903b-416b-813d-c79945317da1"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("eacc8d51-b24a-4f97-9de6-ba046bf2c0bc"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" },
                    { new Guid("f15b0b7f-62e6-4b4c-b13e-ccaee110c4c7"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" }
                });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "ProductId", "PublicId", "Url" },
                values: new object[,]
                {
                    { new Guid("09471fdc-f47f-4573-a3db-84b34edcee7c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("0df0aaac-55b4-46be-ba34-05631b04e54c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("103dc498-8b1d-48f6-8242-f4048317138f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("188731a0-4430-469d-af9d-809457421a1e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("19300471-ae0c-4e7c-9222-b27daa64cf6b"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("1de2fe23-b7ed-41c9-a5d3-5442e4a63149"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("209e396a-0637-4cdd-9e46-ccc846990627"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("3068a114-dcb1-4936-be47-3a6d3e7cc7d7"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("3b9fc7c2-ab53-4ff9-b30c-b52ad5db7105"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("3dc2294d-6083-4d83-bb41-12de74e0b499"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.startech.com.bd/image/cache/catalog/headphone/havit/h763d/h763d-02-500x500.jpg" },
                    { new Guid("3e0346ab-eb7f-4259-9027-24822fbf7c98"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("402e3bef-f726-4879-ae31-bf1240df9a50"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2zcpFb-6hMeoBVWrfp4LazbLD3a1tEjJjY2oYq45yJOyb28WIIYBoJ3qZMsmFdImBSZk&usqp=CAU" },
                    { new Guid("44216031-2dbc-4752-b72d-8abbea158ae5"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("44d43c0d-ad2c-4451-944d-cef08f566bda"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("551ced04-5c78-4671-9d30-a14e10034ef3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("5bf1fc55-a008-4d6e-a307-1bb2564b2d4a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("5f17464a-aebb-4013-9b6a-746e246f2e70"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("6208e799-0167-48c9-8d5d-c9e38d3e207f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("648fb1d8-ca35-47d1-a7e3-c41ac5163fe8"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("66eb4eb4-edcd-4619-9bdf-b82d2ed37d2f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("72646896-f329-4e4c-aa94-cad8ee51af9c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42FePhUrLX424aLie09J4Pfkn03T8h3D7PQ&usqp=CAU" },
                    { new Guid("758b197f-4a96-475c-8e24-bea989375559"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("7646bca3-e7a1-417f-9c08-d9173d0375ea"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("79d08f31-3b5b-40b4-beab-d8a9c46d76c9"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("7a49ad56-c8bd-420c-971c-952e9dc2d569"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("84d2dd25-1240-4759-83cd-cb665e65e263"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.bdstall.com/asset/product-image/giant_213181.jpg" },
                    { new Guid("8757a100-9203-40f5-be88-c9cbbed39b61"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("89e45bda-c31c-4a28-a209-ec5f80c7d06e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("8c934cb5-106f-4b4e-a66e-3f0b6f9e1fb6"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("8cb726a4-18dc-4e0f-847e-63775e892d41"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("97b5c6ff-634c-4c39-9d33-fd989baccf5f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBOB80TIoBkL_NaeJ_5lG5LuUsD0IYEDXFJg&usqp=CAU" },
                    { new Guid("9ace9b23-d45b-487e-acd1-445e85cc972b"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499" },
                    { new Guid("9ba71046-1148-47f4-a9a9-266012507a7f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("9e65991c-842d-43e5-a599-12fe12a67e23"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("abfee5ed-9978-446c-92f4-8008a72f2d4e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("ac72db0e-4d9a-4079-9583-623e6ab3d063"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("ae9d90c8-0c51-4c58-bdb5-7389ffd0226e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("afb8a677-5dd2-44bf-b838-9a5e641e8e27"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://unixnetworkbd.com/image/cache/wp/gj/unix_network_images/product/gaming-pc-9th-gen-core-i7-9700k/Gaming-PC-9th-Gen-Core-i7-9700k-Unix-Computer-jashore-bangladesh-500x500.webp" },
                    { new Guid("b03e4512-6e53-4c1e-99d2-e9eb348a0df6"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("b48dd2cf-6352-47b8-94e9-e5e98a2fc2fd"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("b706db60-c38d-4287-8a2e-0f1c7de65544"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("b7c9c2f4-e8a3-447f-872c-e9f12ed1b0d8"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("b9c373e3-11f1-4eaf-bcaa-c1a9bbd5aa15"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("bb373c5c-5074-4a92-8215-933ada082463"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("bcf0656b-7f20-42e4-bef3-964ac4b8daa5"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("bd261d28-81e0-46f8-91c3-ce8cca56825a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("bd3ffe61-9d03-4889-aaa6-f5b216183b15"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://adminapi.applegadgetsbd.com/storage/media/large/iPhone-14-Pro-Max-Silver-8456.jpg" },
                    { new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://eratablet.com/wp-content/uploads/2022/08/H51ba6537405f4948972e293927673546u.jpg" },
                    { new Guid("ced55c47-9280-4adf-9ddf-e6461456eb18"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("d969a8a9-3ba8-4373-82c7-2647780acb86"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("e7344b9d-bcfd-46de-8901-07fce3f508df"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("e884b826-eb90-45ee-b196-e363c80d8d3f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("eb8752a9-1395-4c15-9b72-4015b974ee9f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("f1f9651e-d33a-4fc6-b7f6-78a2b5ba6988"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("fc680360-7dd0-4f6e-be25-b67ba1e952a9"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "DiscountPrice", "Name", "Price", "Rating", "ShopId", "Stock", "TotalSell" },
                values: new object[,]
                {
                    { new Guid("0bf303a9-c800-49a9-ad86-c556b5bb5c2b"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Foldable headphones featuring Bluetooth® 5.1 wireless technology with full over-ear design for a better sense of isolation and greater comfort. Enjoy 25 hours of music with Deep Bass and clear calls with HQ voice calls.", 0, "Headphones Bluetooth Style 3 Lavender", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("12ed6915-e46f-4ed7-8977-c93f44b389bb"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Trend shoes for gents with all sizes", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("1f73b18f-b089-4f04-8f65-924030ba676e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space gray color with apple 1 year warranty", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("25a544a0-40e9-4d6c-a2bf-d64344198c52"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product 1: Do Check Partner offer section for Exciting offers from HP Product 1: Processor: Intel Core i3-1115G4 (up to 4.1 GHz with Intel Turbo Boost Technology(2g),6 MB L3 cache, 2 cores)|Memory: 8 GB DDR4-3200 SDRAM (1 x 8 GB)| Storage: 512 GB PCIe NVMe M.2 SSD Product 1: Display & Graphics : 39.6 cm (15.6) diagonal, FHD, micro-edge anti-glare, 250 nits, 141 ppi, 45%NTSC |Graphics: Intel UHD Graphics Product 1: Operating System & Preinstalled Software: Windows 11 Home 64 Plus Single Language | Microsoft Office Home & Student 2021| McAfee LiveSafe (30 days free trial as default) |Pre-installed Alexa built-in- Your life simplified with Alexa. Just ask Alexa to check your calendar, create to-do lists, shopping lists, play music, set reminders, get latest news and control smart home. Product 2: Stay unbound, stay in control - enjoy lag-free 2.4GHz wireless connectivity on this durable mouse by HP with an 18-month long battery life. Product 2: Work at your pace by speeding up or slowing down tracking with adjustable DPI settings up to 1600 (800/1200/1600). Product 2: Work on your terms with an ambidextrous, contoured design suitable for both left and right-hand use. Product 2: Enjoy great compatibility across devices and on different operating systems - Windows 10, Windows 8, Windows 7, and MacOS 10.1 or higher.", 0, "HP 15 Thin & Light Laptop (Intel i3 11th Gen/8GB RAM & 512GB SSD Storage/Win 11 Home + MS Office) X200 Wireless Mouse with 2.4 GHz Wireless connectivity and 18-Month Battery Life", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("28794248-4c54-45c0-8cf4-b108a1eaa449"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "We believe everyone, everywhere deserves healed skin. Thats why we created the Vaseline® Healing Project, to help people living in crisis and disaster care for their skin. Here, Vaseline® Jelly is a necessity. Our Essential Healing lotion, powered by the same extraordinary Vaseline® Jelly, deeply moisturizes to keep dry skin healed for 3 weeks.*Our unique formula includes pure oat extract and Vaseline® Jelly, without feeling greasy.Our revolutionary smart pump unlocks and locks with just a 90º turn - even in the raised position, with no mess.*Proven after 4 weeks daily use in a clinical study.Water, glycerin, stearic acid, isopropyl myristate, mineral oil, glyceryl stearate, glycol stearate, dimethicone, peg-100 stearate, petrolatum, cetyl alcohol, tapioca starch, phenoxyethanol, magnesium aluminum silicate, methylparaben, acrylates/c10-30 alkyl acrylate crosspolymer, fragrance, propylparaben, disodium EDTA, xanthan gum, stearamide amp, avena sativa (oat) straw extract, titanium dioxide (ci 77891).", 0, "Vaseline, Intensive Care, Essential Healing Body Lotion, 20.3 fl oz 600 ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("2afe6d82-4276-4020-a769-fa5b976c3345"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Samsung Galaxy S21 Ultra 5G is officially announced on January 14, 2021. The smartphone is pack with 12 GB and 16 GB RAM with 128 GB, 256 GB, 512 GB internal storage options. The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Samsung S21 Ultra", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("31b3c077-fc07-486e-a3dc-7e2301a1dd77"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Onex 16 Bangles with Golden Stone Work for Women Casual Wear Traditional Golden Diamond Single Line Bangle Set for Girls Churi Set", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("36d0a8ea-0328-42f5-a67c-789867756104"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Visible Glow Self Lotion 400ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "TIAM Anti Blemish Body acne / bumpy skin / skin soothing / skin spot improvement- Special body lotion that solves skin problems- Body flaw soothing lotion: AHA, BHA, and Calamine core ingredients sooth trouble skin that is sensitive – Whitening functional ingredients clean up the bodys trouble and spots. AHA, BHA and Calamine calms down the sensitive and troubled skin. Whereas whitening ingredients helps with the dull and uneven skin tone. It also has ingredients which helps get rid of dead skin cells and sebum making skin smooth and soft. A body with a thicker skin layer than the face needs more care – Removes clogged pores and sebum with AHA, BHA, calamine and various active ingredients, and cares for skin defects to make it clean and smooth. Ingredients: Water, Niacinamide, Propanediol, Alcohol, Cetyl Ethylhex anoate, Calamine, Dimethicone, Glyceryl Stearate, PEG-100 Stearate, Polysorbate 60, Cetearyl Alcohol, Arachidyl Alcohol, Behenyl Alcohol, Arachidyl Glucoside, Sorbitan Stearate, Allantoin, Salicylic acid, Lactic Acid, Zinc PCA, (-)-alpha-bisabolol, Melaleuca Alternifolia (Tea Tree) Leaf Oil, Mentha Viridis (Spearmint) Leaf Oil, Methylpropanediol, Lauryl pyridinium Chloride, Polyacrylate-13, Polyisobutene, Polysorbate 20, Tocopheryl Acetate, PEG-60 Hydrogenated Castor Oil", 0, "TIAM ANTI BLEMISH BODY LOTION 200ML", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("4f22102f-c3ca-4b7d-be1e-95d6f97a9a6c"), new Guid("fc7f2981-1031-4d10-8565-9cf93f211799"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("719d2e87-523e-4589-83e0-1383c7bc04f8"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "1 cross button function two left and right 3D joystick functions 8 numeric keys 4 function keys. With 7 channels of LED indication.The device is built with a Glass front (Gorilla Glass Victus), a glass back (Gorilla Glass), and an aluminum frame. Samsung Galaxy S21 Ultra 5G is fueled with a non-removable Li-Po 5000 mAh battery + Fast charging 25W + USB Power Delivery 3.0 + Fast Qi/PMA wireless charging 15W + Reverse wireless charging 4.5W. The smartphone features a 6.8 inches Dynamic AMOLED 2X display that has a 1440 x 3200 pixels resolution. The device comes in Phantom Black, Phantom Silver, Phantom Titanium, Phantom Navy, and Phantom Brown. The smartphone consists of a quad-camera: 108 MP (wide) + 10 MP (periscope telephoto) + 10 MP (telephoto) + 12 MP (ultrawide) while on the front there is a 40 MP (wide). The sensors include Fingerprint (under display, ultrasonic), accelerometer, gyro, proximity, compass, and barometer.", 0, "Dualshock Gaming Remote Controller Console Gamepad Joystick for Playstation", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("7d8e4140-b9b4-4822-af43-7281b2251bc2"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("8033645b-33d8-40cf-b83e-ff9b4002107a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("828147fe-55b6-4c89-92a4-282001f23802"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Latest Bluetooth 5.1 Technology-This Bluetooth headset adopts Bluetooth V5.1 standard, you can achieve faster and more stable transmission. The transmission distance is up to 10m (32.8ft) (without obstacles). Compatible with most Bluetooth-enabled devices, such as iPhone, Huawei, Samsung Galaxy, LG, Sony, PC, laptop, etc. It can also be used with 2 devices can be connected at the same time, so you can separate your life and work.Long Working Time-The wireless headset has been tested for up to 10 hours of continuous calls and music time. 180 hours standby time. Fulfill your calling needs while multitasking with amazingly crisp and clear sound. The cell phone Bluetooth headset features Type-C fast charging, which can provide 7 hours of face-to-face communication experience with a single 1-hour fast charge. Clear Sound & High Quality Audio-The wireless headphones with a CVC 8.State-of-the-art noise reduction, which produces a more natural, distortion-free sound quality and clear sound. Dual microphone is designed for calls, not only is it easy to hear other people, but also prevents the noise and sounds around you from being picked up, you can enjoy high quality music and clear phone calls. Comfortable Lightweight Design-The lightweight construction makes it the perfect headset for drivers or business people,The main body of the bluetooth headset weights only 12g (0.4oz), which will not cause any pain even if worn for a long time.Moreover The earhook can rotate 270 so you can adjust it to your preferred angle. small, medium and large Three optional ear tips ensure a comfortable fit for both left and right ears.Hands-free & Mute Button- The bluetooth hands-free headset is equipped with a multi-function button, you can play or pause music, answer/end/reject calls. You can also enable voice controls like Siri and Google Assistant. In addition, you can press the separate mute button for 2 seconds to activate/deactivate the microphone, protect your privacy when you need it.", 0, "Bluetooth Wireless Headset V5.1 Hands-free In-ear Hearphone With Microphone For Iphone Android", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("86ba38a0-4c84-41e6-8063-ec6e1246de2c"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "All Product Size: 15.5 Inch,16 Inch,16.5 Inch MOQ: 1 Set=3 Piece (1 from every size Fabrics Type=Fancy 100% cotton Color: As picture shown Main keywords: Mens Fancy Shirt wholesale", 0, "Cheap Price Mens Formal Shirt", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("88ec14f5-5bb4-43a4-a377-1f5c978bd941"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Immerse yourself in deep, booming sound that delivers a theater-like experience for movies, shows, and videos. Its four front speakers and Dolby Atmos® support deliver an immersive, cinematic experience.Every member of the family will have their own tailored—and secure—experience with the Tab P10. Each user gets their own account—accessible through a multi-user fingerprint reader—with individualized settings, wallpaper, and social media accounts.Since every member of the family gets their own account on the Tab P10, parents can make sure their kids stay safe. Secure the content your kids access and put time limits on their usage. The Tab P10 also boasts enhanced eye protection and easy-to-use voice search.", 0, "Lenovo Tab P10 | 10.1 Family Entertainment Tablet", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("8c31dbcf-ff70-4cf8-8fa6-1f65ff46906e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Gaming Headphone Asus with mutiple color and free delivery", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("95f5b658-0e56-4ca6-94cc-bcfceaad5030"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "3W Clinic Crystal White Milky Body Lotion is a skincare product that claims to brighten and moisturize the skin. It comes in a 150g bottle and is designed to be used on the body.The lotion contains a blend of natural ingredients such as milk protein, pearl powder, and vitamin E, which work together to nourish and hydrate the skin. Milk protein is known for its ability to moisturize and soothe dry, irritated skin, while pearl powder is believed to help brighten and even out skin tone. The lotion has a milky consistency that feels lightweight and non-greasy on the skin. It absorbs quickly without leaving a sticky residue, and leaves the skin feeling soft, smooth, and radiant. Overall, 3W Clinic Crystal White Milky Body Lotion is a good option for those looking to improve the appearance and texture of their skin, while also providing it with essential moisture and hydration.", 0, "3w clinic crystal white milky body lotion – 150gm", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("9a4afca9-526b-4c20-96ff-92baea7c3d41"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("9c460034-41d4-4e62-9cc6-a9c411629333"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "ZenBook Pro Duo 15 OLED lets you get things done in style: calmly, efficiently, and with zero fuss. Its your powerful and elegant next-level companion for on-the-go productivity and creativity, featuring an amazing 4K OLED HDR touchscreen. It also includes the tilting ASUS ScreenPad™ Plus secondary 4K display that offers effortless ergonomics and seamless workflows. Powered by up to an Intel® Core™ i9 14-core processor and NVIDIA® GeForce RTX™ 3070Ti GPU, ZenBook Pro Duo 15 OLED brings you all the benefits of tomorrows technology, today.", 0, "Zenbook Pro Duo 15 OLED (UX582, 12th Gen Intel)", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("a4cb763f-3737-4b60-b8ac-7fdf80314301"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Dove Nourishing Body Care Beauty Cream 150ml", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("af86778a-736f-487e-a224-c4f25f8f7076"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "New Fashionable Watch for men 2023 with multiple colors", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("c42bc423-1dcc-4340-97ec-ca1e5e759189"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "LVSE Inside-Out T-Shirt", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("cc4a17fa-1589-46f9-acbb-dd6d94295abb"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Trendy Shoes for Men With Great Comfortable. SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure you are happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "BRUTON Trendy Sports Shoes For Men (Blue)", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("e6e56cae-aff0-41a2-a0d9-d846962ce145"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Kids Smart Watch,Boy Watch and Girls Watch Phone with Childrens Digital Camera Games Smart Alarm Clocks Music Player Calculator for 9 Year Olds Girls Boys As Birthday Toy Gifts or Cool Gadgets", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("eb70f085-b674-4dbd-a21d-395e8bc4f46a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Intel Core I7 3770 3.40 GHz Processor 4Core 8threats 8Mb Caches with turbo boost H61 Motherboard DDR III Upto 1600MHz Memory 1 x HDMI 1 x VGA 1 x PCI Express x 16 Slot 1 x PCIEX1 Slot with 10/100 Mbps LAN Onboard DDR3 8GB 1600MHz 1 TB SSD GT 730 DDR5 4GB Graphic card 22 inch Monitor VGA & HDMI has an aspect ratio of 16:9 and with 1600 x 900 pixels | GAMING Keyboard Mouse WiFi Adopter Windows 10 Pro (trail) essential software ready to play", 0, "CHIST Gaming PC Core i7 3770 processor 16 GB RAM 1 TB SSD Windows 10 GT 730 4GB ddr5 Gifted", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("f3fd70b8-c0b8-496d-913b-d469d47e867a"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Display The device features a 6.43-inch FHD+ Super AMOLED display with a screen resolution of 1080 x 2400 pixels. The bezel-less punch-hole display of the mobile is protected by Corning Gorilla Glass v3 and has a refresh rate of 60Hz. The display offers a fantastic viewing experience with an aspect ratio of 20:9 and a pixel density of 409ppi. The display is bright, and vivid, and offers excellent color accuracy, making it ideal for watching videos and playing games. Camera One of the most striking features of the Oppo F17 Pro is its Quad Camera setup on the rear side. The device features a 48MP f/1.7 Primary Camera with 10x Digital Zoom and ISOCELL Plus Sensor, an 8MP f/2.2 Ultra Wide Angle Camera accompanied by dual 2MP f/2.4 Mono Cameras. The camera setup offers excellent performance, capturing stunning photos and videos in all lighting conditions. The camera setup also offers features like Night mode, AI Scene Recognition, and Ultra Steady Video 2.0, making it a great device for vloggers and photographers. The device also features a dual-camera setup on the front, featuring a 16MP f/2.4 Wide Angle Primary Camera and a 2MP f/2.4 depth-sensing camera capable of capturing detailed self-portraits. The front camera setup also offers features like AI Beautification, Bokeh Effect, and AI Night Flare Portrait, making it an excellent choice for selfie lovers. Configuration and Battery The F17 Pro performs on MediaTek Helio P95 chipset and is also powered by an Octa-Core processor set up with Cortex A75 2.2GHz Dual-Core and Cortex A55 2GHz Hexa-Core. It also features a massive 8GB RAM along with PowerVR GM9446 GPU, offering an impressive gaming experience. The device runs on Android 10 and has a 4015mAh non-replaceable Li-ion battery, equipped with 30W v4.0 VOOC Charging technology. The battery life of the device is impressive, lasting a full day on moderate usage Storage and Connectivity The internal memory offered by Oppo F17 Pro is 128GB, which can be expanded up to 256GB as per users requirements. The device supports all 4G VoLTE, Mobile Hotspot, Wi-Fi, A-GPS Glonass, USB Type-C, and Bluetooth v5.1, making it a well-connected device.", 0, "OPPO F17 ProUltra Function, Ultimate Fun", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 },
                    { new Guid("f5f9d80c-77c0-407d-8f22-2e08e8b3f70e"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "SUPER ABSORBENT, LINT & SCRATCH FREE - MultiPurpose cloths are ultra-absorbent and can absorb fluids quickly and efficiently for any tasks. Made of high quality microfiber material, the fiber is strong durable but soft and wont scratch your silverware, plates, pots or pans. PREMIUM MATERIAL - Adopt high-class microfiber, SOFTSPUN Home & Kitchen wash towels can clean your Home efficiently without leaving any scratching paints, lint or streak residue. These cleaning cloths is an expert in your daily cleaning. MULTIPLE USES – SOFTSPUN Microfiber will clean and polish anything! Kitchen platforms, floors, appliances, Steel fittings, Crockery, Cuttlery, Glassware, Bathroom, wood & steel furniture, LED, laptops, windows, cars etc. Thats not it, use it as a Bath, Face, Hand, hair towel for both babies and adults, its great for facial cleansing & makeup removal. PRODUCT SATISFACTION GUARANTEE - Be assured by our 365 days product satisfaction guarantee. If you have an issue, just email us and well make sure youre happy! Start making your life easier, ORDER YOUR Microfiber Towels TODAY! THE BEST EXPERIENCE - Just so you know, we want to make sure you have a perfect experience with us. If you experience any dissatisfaction or inconvenience with your purchase, deliver or product, please reach out to us and we will do whatever necessary to make it right.", 0, "SOFTSPUN Microfiber Cloth - 4 pcs - 30 x 40 cms - 340 GSM - Blue", 0, 0, new Guid("00000000-0000-0000-0000-000000000000"), 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("eae24aea-1ce5-4dc9-b813-646730091450"), "comment", new Guid("00000000-0000-0000-0000-000000000000"), 5, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "PublicId", "ShopId", "Url" },
                values: new object[,]
                {
                    { new Guid("08fec919-dcef-416c-9ef9-744616562d62"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("167afbc6-f877-40b9-b3f3-3377e5f334d4"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("199bf7d4-dd16-4f18-b22f-28ae8fbd950d"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("26c70b56-b777-4c2c-bc0f-fbb3310ce271"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("3298d6cd-8186-4d3e-95aa-048133dd980e"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("433f599c-46ab-4cbc-8dbb-e605832a67d1"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("4ad6a0c7-e253-4aae-bdda-f90533fedd97"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("566ea10d-0be8-462f-a13f-85cf907d9526"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("66b7e2bb-4f9d-4303-a052-23003850e113"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("67e4375f-3cda-4df4-982a-4f9ec38c6ce3"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("733c07ed-6609-4c74-bcaf-e314d13ff382"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("74a6b512-4734-4b85-b3bf-144a8d9788e4"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("88c1e6f8-12e1-4bdb-8e82-4fefd6099f06"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("8fd406e2-e8f1-4d08-9b52-9f92ed94f6f1"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARMAAAC3CAMAAAAGjUrGAAABEVBMVEX///9PuelOuuhQuOy74O5Etun1/v5EsuIBVJZRuOnk+vuEyudLvOxQr9tPuesAUpMAUZQXZaAAT5AAVZUAUI4jebQ/n9U0jsMSY58Za6UUaanE6PcSbqyR0Or///tPtOfa9/h0xPBhvesjerTw+/wqq98JoOB+yfCM1fYAS5Accqs7lsubu9MAV5RJquAAVZEYhL4Vn9a56/Cn2+7M5/BTtO9ZuuB5xd+Tz+y35PTN8fnS6fiayuFetdxZrN4+pdIAkMIKn9QAj8x6la5Zg6GXqcIAP39hibWq3PYASZWc2vtpi6kuapevyNhxv+Q4dKfu7vQ2gKjZ///E1+MWj9UANX52n8GPw9IApdUFkMZIp84bFDZfAAAK50lEQVR4nO2bDVvbRhKApd3YlkCWhCT8ETtWgw0E+yybAzsEQhJoekkhpb3rXa/c//8hNzMr+UOSgfQBm5B580BAH7b0enZ2dldoGsMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwf4HDZ0+K4n04WS88Jcpr9+JE14X+NDBNi52kYCdZ2EkWdpKFnWRhJ1nYSRZ2koWdZGEnWZbkxLRt+D6yhBD2aCQLsKUQhoWCSZdgirFegH+mZeu2XNatL2RpTnQh4AA5CsevX6Q5itmybSHlysNtSU6kQHSrtH54wyh8XZjgZHk3v4Bl5RNsNLZ5+kZrtTStuJbwwwzF2Mn3EifgBBLF+JgOPXn7+rT8rlx+D+yfnZ1dAx/Oh2vKifk9OdFPDzFKOgcvX24BuiiVStvb0Q5xtnO+1toV9nfjBPocaYnTY62jtdaOdndJihki28T+zj440XbhSDt5mblXwwQt1A+Yl3Sb+jH10vCN9iWb5t862fgVph/aiWlKuCphjsS4oXV+bGkHu+uxlC3TDDFSyMnOzgdwIjAZSzsDORD0T73LxAm+ug5pGTp128x5f9hlS2mbNnV7j8MJ3ovAW4WG0/n4k/bDi10kbj4YK1EsJXHyvrKISOiR+mEaERJuVla77Z4U+bcs9LDdHob2gt2rcUJ9sH7a0H77+I8T7c0rgKS8TKTEkRI7sbueQ3iE+jkI8KtryXrguF5QtfXkFrGTjwaeV5Mi964hj1UDJ+jJr2g8D59PsDGI8Ym29mlvr1P8fPFiVoo5lRI7MbuukQNsdDaFrLuAV50NCmEPPdhW0fOd6LLmuk4dneTlm5U4EcKSOqTX4sef3X4xdpKKlGjiBIqYBU5cw1VODHAyvUF4T9kHT053QeOxKwHs9iuPyAmmRhOVXO65gy9a8eDi4kJJUU62RBIpZ9jvQBWT68Q3VJw8h9sDJ1TtxMrNXuDC/iDKz/Gy64BRZ/iInJhw1eEhRMkeXPeXYvHtxYuLVxAq0PlcXcWJVi+Fysl6AUK968WZBNz4ACQWV23BfOIYvutUp28FLXMD4sAwgqGdfX8Incgjx/18ZatxAld6VNQuA7gsvw417PHx8UlMA7iAnKLrYViKlBNhV3oJfXTiNCe/V4Ry4s460aMAlRhOLcx5f2G1HQo0r5ejbFVOpA6v/4vnGz450bCUbU1Pe7O1JTHRlqL3sRPqqXB4JDccajHSiks1IbJxost24FLjCnp5bSMcxA1v4+49z8O3HXmlaV98v9/v+19wTNxSYlrq++crVdIqJ5B97IkAWzlpT3vZ2Anmk8nrh75KOH7QzY6osSNWTgyncudAeXAnYnSgnXj9GtD/ouYJWoQ67c2VqvNFmDhJSlcRx0kby61kU8aJXvUww0IjMwbRnA76btcccuJDr/VonECGbbR+wTCJnbTmT1NOtsypEzORgk6gSYATM3mtrBMBGZacYJadf2f89t7zHeXE8PPyzUqc6FbY0P5GYVKr/arajooSFSyNK1Xnj81pnMRnghO4VYyTiV/SNHUCjaoS+Fh+oBPIsuZUFr0KdcSGT2nWq1p0hbebefg6tjTjRNPSgdLYTZy8SzuxNlyfcuzkRlNxgnmm6YMTo4tNBPoWc7bAh+iKAswl/ibGCmbZyRhytU4EOXm+0EkySjbLaSd22kmm7UBHTPlzLxpS6sEKfvYioE+izaM+HhWo8v/xOEEWOVFSyp18J+2FTuD3oYdFal2qgBhEc8NfMxz4WM31pFLWtR9TnNTIyfNcJ8nY57SY58TNjRNVqEOY1LBpQGViU+IIhnODHhgcYvLthzBypkCJZqasHrOTF6/i+ZSrr3SCIdGjTqUmhVXxVC07cxFC1rBu8UAUnYchZ9+lcnsETmhAuPvyM7yGOTtQuyGf4MASuiMbf/WDqoU9EjaeoDrTeKwK1mv+IDKF1fNo0DO600LJwzvBvvh5E3n+66SOnTo5Uk7Wr05aNFcwjf7bciwMjTCFGoMQcycUrNAp12YPbqosgnVwWKMJhyp0TLdrWUbNljhp5jl5oaYOIExa2hY4MRc7SffFdjugA0ZhGI4iFOBC3zJ544iMuT3avYmjbKMvvyEn65+LxVanLKzprOJNTlTxFfUdbDBUIsNoylB9y2Taf6iGOjjSgr3k5G6j42W2nVwnFzjJdPSsCNsPSmJ2dj3TF6fixK56hj+ZcUomnybzJGE81JmdmIJe+w4TS8tx0lzo5PDg88GzBl5Bq7NFx08u+hYnqtBPT8d5Qys+uzeYt6XGRNE34ETTMEK031pFDBOsx+XCmm3OCQ513Mk904CH7noQtw67OzDU/mSfPz96WqETnZxsAs3mP//V6XTW1jrzFDu/X/4IraiUOnFRv2M4VVogaeMQ0fA8D6fycYJSDfV6NA7CoQ7Ov9E8P87re5B7MLuMHomTt+Rks/nv6w8frs+HQLvd7dY3MDcO9vZ+/s+nonZYTncINzuhGTTDHQyrE+p0/AbNQdlDF51sxLvgqKGvRse3Klmqk/P9s7P9nfPr6/Nz0gKR06zXasbeJSg5lXpKyqJ+x8D5WDWDhtUHoqbmKh6ljAot/tUwKryKpabs8PknNfWwcfuzHEty0iYl26BkZx+UkBNQAuPCmuFdFluNUyxL5/PfwprNreLULHS+LnauqqngWrIJPY2LmiBR97BP8mtSTIg3TSuYR+DkHBe2gOvYiZJS3xhcQi4pQ2tIZ7+ba/seDoaMmpqCsylaaJSMfQvWsLTmU03m7Ch0+hg6TvPWnmc5Trrt9j4o+fMMWw8+glONU4pScjw24VNOr0ll5pSSfIL9jll346Us3KvmK3WqXGGjJdSqjh+K5LkEWkN1fd8xnNJty+kPv76DTjZJyT5xfq7iZJPSSf+PotYYq7H/vBMY1lK/sYkhNHFCxWpVV7dPK1mzkwObtObXD62hg+ul7SR3qEiJcE7OdYcy96mM5Tmh+di3TVSyvbM/23ag6dTrtT8oveaNQdCJ6++5WFEki8O4NoqjXwvnS3CROBVaFVw8dINq2AcnkG3nm6O9iU5odHxjpCxlPva/H7b/BM72qd1cUzLpQsvpfnoGuWRs5X1uEBQ1WhFtTyMISlfaVLWjAPCCSupE3B94Xn8IBwVBPbWsbkYBba/eklEe3km50Vr7+4Q3QPK3mb/jGz87tfI/NlolxQdw5jYhvUgv0a7K/LNv0MaieBVVPbqTevzCNNUrVlbsxBblxuKT1g5fj+3RggG1ZU06jck2XT3IBeNnadOK4fwp9Kuluuacx9viqt/O37s0J9LUXx0s4mirVJBwCSI358V1hT7zwskmoeZj0x2I0KfliJphSSWq6c5VOoGPFJ8awGfrw9DUTfgPBRQKBb0gQ8gQ4XjhY8Lz9zezzVzwQcu4WrHxeT9ahs9N3nFluzInM3bmL8O+6apWC/+tShZ2koWdZGEnWdhJFnaShZ1kYSdZ2EkWdpKFnWRhJ1nYSRZ2koWdZGEnWdhJFnaShZ1kYSdZ2EkWdpKFnWRhJ1nuy0lrXSZ/yviNowtLiNN7cbI7mlut/YYxpZT3ESctiBMzlE8BG//y5d1a+tHmv8K6JfGpIHGXL33ydafDl3uaPpIC8sm9OCmHhdITYTz+373kk07xCdHptO4hTlqZvy34VrkPGwzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMPfN/wHscbiZ38cT4QAAAABJRU5ErkJggg==" },
                    { new Guid("ad29a3c7-aab7-4f93-b477-c35b621e73ca"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("af5bda83-3908-4e74-823c-291099676fb1"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("b2e8c511-82c3-44a1-b2b8-a6fc5538bb74"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("bba3d177-b1e5-448c-9c1f-8f5ab86db4c7"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("bc6b0fbd-d198-4e1f-bfdf-7d52cb53854e"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeGWw-VaNcL9QlsHKJKPLWj-Dh0M2WguDpRg&usqp=CAU" },
                    { new Guid("be733d02-03e9-4abc-8ec3-b96c71e2f8e5"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARwAAACxCAMAAAAh3/JWAAAAgVBMVEUAAAAKCgr///8GBgbb29vR0dHk5OTIyMjt7e2zs7O+vr719fWqqqqenp7e3t6Xl5cuLi4hISGBgYGJiYnExMRCQkIVFRWQkJDOzs7i4uJzc3MmJiZPT08fHx83Nzd5eXlaWlpiYmJGRkakpKRra2syMjJEREQ6OjpVVVUSEhJ1dXU8mJS/AAAE9UlEQVR4nO3c63aiPBiG4SBBAoIbQDYFRdx8as//AL/kjW2dafvOais6Os/1Y4ghKtx109quEQIAAG5oOZ/Pl/tbH8VfynEd4Ti3PgoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIDvcU+cD+jpWx/e9X3S4mP/SqGvNLGOOXGPVOnWx9+Pr1exxDwh4Va8Po5ufS6X9M0spziH1LRJ1VScTz9CoB91sXHa1Ah88W7XHT+Evvs8+i3ArDBSmVIcm+Ptlu8yz0XCGKKJJ8awEeY/0c138/V86tAdmPtxZjvznw/X55HcejnfT2n3p+1mu/1y1m+Cj10sDMVJNlocSn3D83ayicnkWXfp2vTlchwXSUd3vnwq7MSmSBvRTczDLja78hVFjmO9ZBKFmV+WfpQu77eMiRMRuRHTInojfdeNT+PAbrxAiLrdvM0E3iS3g0Qf1zQxo8A7bKOs9OR4qCk13N5tGfOsCohaLTdm2y6nB32KQTROlnZPtOoKO5JNndIg7bqIBv6KrhROhJh2oRlmSRf6vl8GT9tgPK50n+ZOy5g4aRZqWdWYTSj100kkZsovt7QnHLtiZ0dqFdPA+08sOjs1mZhtFoh6TpezWF8r831vL/JISqnzRFco00sa/WYUevoL7Q+jwKftVKxj+tLLbEMzMhLOtqShl9C2LM0LjJ0KC9qGog5okDV2iS4ycyqqU/aeppcymtgPpfQ8TxXmX68q55tSn1IZpNvWI2olnIhG4+I0sxXuIqX1XtnabW0vy0NAF+VKP8/WY91mXIV3mkbHKdSwGutXz0ifiZRVIIdelHR13orWfOGlVELsPBoN07GdqYVYhDQexlu76kCbcbGnS3Ksj3qXVjpNpZJe2/SXRsfxRkq/pSg/NG8uQ2+T7BfHvN76hbAzSr9FPSk7TOxWn/nxMLTrjx3N+Z5de1zZJZ5+VtV2rucHTp9t8pGhRmloIqmqOBwOT7GnVF0rMtqKY0T7RmFHW1V167qkmWwnVuqNnInGjrxmPYvN6pGs7zdOOxhQnnVDm1GlX3dGg8EgEondoWbCUTQaPIvAzlWlmRlU7U5/32h30tKVfqFp7ZKRX+nBQE0W/bbpNY4/IPIomtNQU2FweNmTCdGdpnOxSOTLmlHW6p8OHFGr16sV5mDrLnud8CbTntP0Guc4XRi7xPxcdVwl+gfQp2Ymcn2Su6mx7sRiT6P6Wa9x3Rkt2s7NFUzdXT07meZ0tMc8b9pU38669zA9x3HO7+P1Ds33VO7bnvM17vmaX65k3lRv8CN8n3Eu7tp9bn2+X3XVPrc+2W+4Vh/3HuM41+njOHcax+n/I2jnnuM4vfaht8u7jmP008d+K3H3cZwe+rx8UPEIcZwLP8Feb/VB4hgXCnT2+dYDxTF+3OeXj/4eLI7xg0fQb7f0gHGM7wR6/3nxg8YhXyj08a9fHjkO+fOflX3+e6mHj/PCfV/pj3+798/E+Q7EYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jD+B4GNmzYUY1XJAAAAAElFTkSuQmCC" },
                    { new Guid("d89fb44c-8a06-4374-8431-4297dbbbf429"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("dc94a863-3a87-4267-bc3c-be4cebaac67b"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("e60b0dcf-d6fd-4b8a-88ef-4cc2d10b53a9"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("e8d5ae0b-2ba7-4e1d-8fb4-e0dc98ebbd41"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/jpeg;base64,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" },
                    { new Guid("f1b9790b-589e-44a5-b7c2-5c7121b475f3"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("f2a7fdd7-5789-4439-8ee7-ee6c97dba32a"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("f86d076f-79b6-4c21-9a00-7c2dc0c2a18a"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("fcff86c8-0db7-4a6e-aad3-07e0cc5da1ca"), "test", new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAASwAAACoCAMAAABt9SM9AAAAkFBMVEX////4VQb4UgD4RgD3QQD4SwD5ckX4TgD91cz93dX6lnv/+/r4UAD5ajj4RQD7oor8yr78uqn8wrT4XR/6imr+8/D4WRT+6+f7qZT6nIP5fVf4YSj3PQD94Nn+9fP6lHj6hWP7sp/7p5H6jW7+5+L5dk38zcH8xLf92dD8va35gFz5bD33LwD4YSf6hmT5c0l+/nmwAAAKeklEQVR4nO2dDXeiOhCGISRNVcRq/Rbb2lpt7W73//+7BQTMDIEAYoM17zn3nLtUQvKQTJLJJFiWkZGRkZGRkZGRkZGRkZGRkZGRkZFRWXX2E91ZuBqt/zD6qjsT16I5s23GR7qzcR0acNu2idNf687INSiCFeCi4yfdWWm/Yli2zelcd15arxRWYLrIXnduWi4BVmC6vozpKpIIKzRdb8Z05QvCCkyXZ0xXrjCs0HQ96M5UW5WFZRPvbqs7W+2UBJZtu/TZmC6JpLBC07XRnbMWKgdWYLqmO915a51yYRnTlVU+rMh09XTnr1UqghWYLseYLkHFsGxiTJcgBazQdL3PdGeyLVLCCkyXb9riUSVg2bZvmmKkUrDcb93ZbIdKwSJ3urPZDhlYFWRgVZCBVUEGVgUZWBVkYFWQgVVBBlYFGVgVZGBVkIFVQQZWBZ0Pa/fVR/q3fOnO978wxuR8WNQlSK7rcsY8b/n5Y8X4GTUAK/c2l9HFr1rZviQsO1zZ/k2168KwbOKNf6wsF9elYdk2W/5YYS6tAbs0LJu9/VhpLqv18MshF4Zl01+xJ6H3/Gdn7bmycp0Jizi/IGRi43EWhkS+UoXhOhOWzRc/VaRLaTdlxI5gWZMXWtgWq8AKR6WZBOh1D7e2/7ywTCwOtu30i0xXBVjE5ZxTj8HU2DWHQPe6vnssRRqZPCowXRVg0ejabAPZE3LpEl1OQycxUkwI4x5QtwFYsS2fQVpe56IFupzuH0+NRIRlTQ45pqsGLGsEKiq/zg2gs6VIhMENAh8rqemqA8viYkqkf6nyXFC9hQ/aGsO7KT6ZxHTVgtUF4xH/+oZaQ4ZGVBlYloVw1oYF26HzgW6bdTqdJkIKe+tOZ3uBN/HxN9PIJLBQQ60Nq+OABw3Fe3Yvjuc4wX/f99G/7xfdVIs4ck68JoYe3v89DXGf5isaJOTRv/Poub356Z7n46XJ4Lmbq+d5zgBQar5lsMIuAPX8dWBNPPE67wo56XvuMX3i0mVww+wPF+RHFQ5coydaC0r85P83NOmqCPPCkrx5wk1O5BzqM14g71laJvnAQA5LHFzUhgX/4L6n19eemBO+Cl4OqIRONMwA11LUsxVLxnKWNRZfB/H3lvWV7VSmhXMTPpCUaCSz2wWwYE9QDxaoWcROLj8hW8C65WF9Ro0jhjUAdwV9yMS6qwrLyy6rdOQjgiJYwUt895KbGoCVVgfrHc/a/aePcrB6B09Iau2jdIIfVYWVnVkUTZMLYAX5ncYmoR4sOKFO5tL3GS8F+1yXgvWRdOVHWH1cKOJZ7xVhZdwhhQ6YQliREyd6bC1Yj3DCE++aes+aTmQicmAt0lcewepkXUPEg92SGpYDZ2EK154CVjDjDrPYBKw4XxO1+0sGazFZncoRwXpWLh6oYREmFmRd6Hmx1bCCJIKm2Ais44hqiN4dcTMZlMCyuVhpIlgMjwUzCalhia3waVzs07PLwLI2rBFY8ZOWsBUy+/DPQ5mUwYLPCP7cgd0HoXeHKbrjCEviijw96T7N7FDlLbY1wIIFckKnYA+Z6lKwYA0l0/AQsBECGMHa+NRLBd+U0ApHuGuVSQ1r21AzZNHS9AyUxz2mO4NJlIL1BipCPPOEF2NPR2+SqvcNaPHT8D3TtdaCtWjKwB8nhztQIdhIltVSsMAtxD2mA++RuIWgBXd2OX+oByt22DQHawNgJcOJBawmClhOWCFgDY03Yj2BvGRh7SBM5/QX3F1Uh5W6ApuDBbEko3pogIphEX+RwZL6YUGZs7BgM+XCSvm5sAQvRXOwoNFIXu1DeVicR+ZpC2pW6v9ZFcNiea3wXFiDsyfSMlj/RFjp5Fo5kU7lHY7pw9lkYvtkc0NBKEkvF2NFWNBL0Rws+OqTaWxZWIQm0V7yjkIBCw76wY7TM2BhL0VzsKbnwGKr1A/9UAcWlw38zoSV9VI0Bwv6uCrBOlr2WMMasGDTPfmMzoEl8VI0Bwv23VVgxZb9DFhwuck9nA9LuorfAljOAazg1IGFWiE4DbIOrJz4EP2wGDpaogYs1ArhQmZ1WJM8L4V+WA7yldeABcfDLox0rQxrnuulaAEsFFhSA5ZNpLfUgrV3mwk5KvY66IO1RusncHW1Eqxil2pz/ix9sGAMu7CMWQFW9L5VLtVGYO31wppKjEJFWBHhfGOVPLYxH7w2WLgVos8rlIJl87tugbFKHtsErA+tsF6hExUXqBwsm3D17xqBtdUKC9kEfCJYSVhlVA8W7Ku9iU5YW5RLHBmmHZYs1kEXrLlsKaO1sAjXCkvRCvXDopIkNMFStULtsOASYbxGV9efdSYsuKhEHjOF0A0LucmPNR/Ge9eHNaoGawVbYXZzjG5YaH3rGFbw2BCsam5ltOTtZc+M1g1rDFa94okrDPpMVnd2lWEhb5cCFmqF02whdMOC9j02EzCIJlmM2ivXDTGsjqyN44qbwoLhAbKtMZphvcK9O/FiA1wTTn68qQwL9R4LWV5SWCiAThJ0qxnWDkXGxJFQcIqW+D+flbEOGBaKG48XH2DofQoLhSfZVlaaYFlhkM/9GG3ZTCKhPqFhjh0lcGJUChac0cZxALA5p7C+YCuUhb7rgWXTQJ6DfD5pO4G2JrZk0L6XgwWN39Eth2xTAgu1QuzO1wlLqnTIDKNfbL7c9p72KKelYKHDO9io15u9wGsJLBTG6r6NBb1t2waLv6S/hpM023UoxRktBesBOeFYUJ9R0HgC6w5dd0WxVdtgCXOxhTrO9egmVMB6Uj82hlX8yziirT2wxA9hSCOJPInZV8CSRoG6VGL2PwsdwXHX0xpYHKykSByz3gREEB036qhg4YD6QO4YtnIvqtCSLR1i0doFi6/Az18zhSQcTt7IVxlYkucGVRKM2FgY2tdTHFnVKljsC/68l1mgDAc+YHuEVwrWPEM9GBADb0TkXRgVL8e0CZbrZ46hGeEbwjk2mAZFzUcJC3esNlugaZAbbmVdFrbC9sAinL5LvqDVhc75cAcqtEBRZKwaFjpngz/iUofuhZ5i68QPw/KzzwlPlOSMTgfy7fWvQmyv60d931YskxNe+gAvgcpOHJlNT2UkzipyAn2LVdSXbW9EWT3uN8C19Ay5LwWwNhTLdx/vxvOH/IMI1kufhfu8GfMP8a9ehdujjTjWwRcu5RyFt+FetF+ceW48PJmtTrdFJuBLSEamoytsnr+fo6po499MfnqYL7qL+cPZR0V1hoPuYjA8+6ibN+UGunJy/Ws+0Kmsck6Wqabb+czhJz5OpbKYfUPf/pWcLFNB4lEdt6DsyTKlRfzb+165eLhYFVRO/xeeUq7WELt5S4i5N2SsgNIDEcuK01sYLuRp+45PBCgQoeObM1ZQu2nZwEmnf61nPzao+GQZhRj/FedGn63es9J0uf51HpJ5CW2/Ck0XoYeJOpHb0QPJ9bMSZ4XPfLx55W2oYOw3fZyjKUm36rj06g9tv5Aym8AIXZqPtucKbC8kzuO9+pZb1qufmC6ON5QZZTT5jkyXS7vXd0i0BnX6HqPvxliV1P3eTAONjIyMjIyMjIyMjIyMjIyMjIyMjIys/ypxrYsVXb8jAAAAAElFTkSuQmCC" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "Ratings", "ShopAvatarId" },
                values: new object[,]
                {
                    { new Guid("01be7394-f136-4e2d-b366-4de3973296ae"), "Apple inc", 4.0, new Guid("d1b6161e-649e-495f-9dfe-81ff14575503") },
                    { new Guid("064bfdc4-6c47-4b2b-8bc8-134da69f92dd"), "Dove Inc", 4.0, new Guid("b8cad678-bfd0-4a00-9aa7-de64b4b4ced3") },
                    { new Guid("0ac48a1e-b50f-4cc3-b414-d29f61c3ce31"), "Acer Ltd", 4.0, new Guid("9705ce88-67c1-4a69-bc3a-6e093cdbd067") },
                    { new Guid("12b5f811-1385-488d-981b-dc704bcd8643"), "Shodagor Ltd", 4.0, new Guid("e9094eb5-27fb-47a9-92da-1dbb40ba0206") },
                    { new Guid("1822e18c-61ea-42da-a852-f4a3668d2c04"), "Shahriar Watch House", 4.0, new Guid("3f318c89-2a55-498f-8054-095901f4a29b") },
                    { new Guid("2ef863eb-8c8e-4ed0-b724-00a3a359912a"), "Unbranded", 4.0, new Guid("c6c4a37e-5004-4384-888b-1865f8c1e4de") },
                    { new Guid("41393eb8-e86a-4cf1-9f20-4ba811055834"), "Unik", 4.0, new Guid("8caa529d-ba17-4f5a-8572-a1bdcef60528") },
                    { new Guid("4578df02-4b5c-4bb8-9817-c1404db8a63f"), "Unik", 4.0, new Guid("1e2b3012-1509-48ce-9108-d70d2c8d061a") },
                    { new Guid("51f9d627-446c-4501-a81f-b633ca1549a7"), "Shahriar Watch House", 4.0, new Guid("150f44d4-1187-46d1-8cb3-6b74ac31ea37") },
                    { new Guid("531f40e0-ac80-4010-bd6a-f8cdb16e3bb7"), "Amazon Ltd", 4.0, new Guid("907a42d3-40a2-4b44-b00c-add5526f962a") },
                    { new Guid("58cf7637-206b-4393-b51b-465ff7dd9124"), "Asus Ltd", 4.0, new Guid("dadc7dfa-0f4b-45ac-bb7c-0f8329a4b1bb") },
                    { new Guid("7302ac9c-f8ea-452a-bfaa-44966a94af10"), "Vaseline Inc.", 4.0, new Guid("501aedf8-b3a4-4138-9e05-6ce9f30c9f1c") },
                    { new Guid("7313a047-c4fc-493a-b5a2-4199fcd4e6f6"), "Amazon Ltd", 4.0, new Guid("cf66b6ba-9b91-4c46-8d67-5e124ae194e0") },
                    { new Guid("7f9775d8-306f-4113-a9fd-061451f9da5c"), "Alisha Shoes Mart", 4.0, new Guid("6d8542f9-0f6e-44c9-ae82-f654426beda9") },
                    { new Guid("8087f938-da79-4c81-9d4e-2de386d34147"), "Tiaa Ltd", 4.0, new Guid("5558154e-3668-4a83-8a1d-4f1a1c3cd500") },
                    { new Guid("869cca1f-ca60-4fe8-962d-393bfe2c6293"), "3W CLINIC", 4.0, new Guid("ec9f6558-fdcc-4e2b-825e-a04ad57937f7") },
                    { new Guid("8aa6c36a-e0a8-473a-b686-7b4beb4cb6a5"), "Amazon Ltd", 4.0, new Guid("21a605a7-88fa-4a0f-b546-bcbc6302f681") },
                    { new Guid("90bbf5af-f7a5-4a89-ac4c-8763d56a5074"), "Amazon Ltd", 4.0, new Guid("1ff51199-da88-40ea-8b07-f6fb8cac2d43") },
                    { new Guid("a1f7f1b1-222e-4535-8be4-265ff28d1cd9"), "Energy System", 4.0, new Guid("3df21afb-f6c9-41eb-91a2-3d349f143bd0") },
                    { new Guid("a9f541c1-f678-46c4-a6e9-70fd230cc3f1"), "Amazon Ltd", 4.0, new Guid("0068a29f-f74f-4987-bfa3-dfc759ca1e4e") },
                    { new Guid("ad31d32a-8557-4fdf-ad33-c8c1f3d67e8c"), "SAMSUNG", 4.0, new Guid("0a280a43-0813-4b6d-9c59-dd525f119f36") },
                    { new Guid("b25c5133-b06a-4737-888a-48040b83950a"), "Oppo Ltd", 4.0, new Guid("bdcd15f7-31c3-4997-9278-a33c0cf8d23f") },
                    { new Guid("b71592d4-d538-4bea-8e15-c4e8e5c8d59d"), "Dove Inc", 4.0, new Guid("60296b26-9489-4994-b8f6-c90b4f3d90b4") },
                    { new Guid("c9c3230f-d7d6-4640-81d5-050f118d3951"), "Lenovo Ltd", 4.0, new Guid("01024b41-b9d1-4661-8bd8-b84627cef9fa") },
                    { new Guid("cd9e0929-9a20-411b-973a-66913f3d05c7"), "Asus Ltd", 4.0, new Guid("71f089df-dd02-4686-a839-df154efabd12") },
                    { new Guid("d9db0833-5dd7-42c5-9b65-cc7c94020f3e"), "Apple inc.", 4.0, new Guid("3f33b6b1-fc9b-43f2-934c-dc1ae6104fba") },
                    { new Guid("f4bcc3c6-9209-4961-b932-443f5b17b43c"), "Louis Vuitton", 4.0, new Guid("08b5993d-9e98-4231-952a-2ffe6f2291fe") },
                    { new Guid("f78cfe15-4655-46d9-a3ea-991ecfe33102"), "SAMSUNG", 4.0, new Guid("dacb8c1f-b60f-4a6e-890e-2c3ed044bce1") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d6c0a956-0da2-4aab-8caa-a6644e746bb8", 0, 36, new DateTime(2024, 6, 14, 16, 44, 17, 511, DateTimeKind.Local).AddTicks(868), "c20b9fee-6f01-4a62-993f-823f848084ef", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "36aa6f6e-51a5-4d77-8694-20231b254e70", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d14ca1e-9705-453b-890b-fd5d361aa72f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77fdb281-212b-4d18-8cd4-b782d891ca62");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a3c1f68-c146-4c12-89f5-edf0cd1ad439"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41ac7021-a6e0-4a1c-a7b4-14b453685ee6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7decc907-6731-4351-a8ca-a8ac374227a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4692d2f-4d3f-44da-90ea-977dd02513b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab49fe78-5fe7-40f3-98df-80d1574f98af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc76ebc8-4d5c-4ad1-8c6e-4c863c45181a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c50d2951-b2a9-4dfa-95d8-f107d941d9da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df1e41f9-903b-416b-813d-c79945317da1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eacc8d51-b24a-4f97-9de6-ba046bf2c0bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f15b0b7f-62e6-4b4c-b13e-ccaee110c4c7"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("09471fdc-f47f-4573-a3db-84b34edcee7c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("0df0aaac-55b4-46be-ba34-05631b04e54c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("103dc498-8b1d-48f6-8242-f4048317138f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("188731a0-4430-469d-af9d-809457421a1e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("19300471-ae0c-4e7c-9222-b27daa64cf6b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("1de2fe23-b7ed-41c9-a5d3-5442e4a63149"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("209e396a-0637-4cdd-9e46-ccc846990627"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3068a114-dcb1-4936-be47-3a6d3e7cc7d7"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3b9fc7c2-ab53-4ff9-b30c-b52ad5db7105"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3dc2294d-6083-4d83-bb41-12de74e0b499"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("3e0346ab-eb7f-4259-9027-24822fbf7c98"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("402e3bef-f726-4879-ae31-bf1240df9a50"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("44216031-2dbc-4752-b72d-8abbea158ae5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("44d43c0d-ad2c-4451-944d-cef08f566bda"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("551ced04-5c78-4671-9d30-a14e10034ef3"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("5bf1fc55-a008-4d6e-a307-1bb2564b2d4a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("5f17464a-aebb-4013-9b6a-746e246f2e70"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("6208e799-0167-48c9-8d5d-c9e38d3e207f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("648fb1d8-ca35-47d1-a7e3-c41ac5163fe8"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("66eb4eb4-edcd-4619-9bdf-b82d2ed37d2f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("72646896-f329-4e4c-aa94-cad8ee51af9c"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("758b197f-4a96-475c-8e24-bea989375559"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7646bca3-e7a1-417f-9c08-d9173d0375ea"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("79d08f31-3b5b-40b4-beab-d8a9c46d76c9"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("7a49ad56-c8bd-420c-971c-952e9dc2d569"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("84d2dd25-1240-4759-83cd-cb665e65e263"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8757a100-9203-40f5-be88-c9cbbed39b61"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("89e45bda-c31c-4a28-a209-ec5f80c7d06e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8c934cb5-106f-4b4e-a66e-3f0b6f9e1fb6"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("8cb726a4-18dc-4e0f-847e-63775e892d41"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("97b5c6ff-634c-4c39-9d33-fd989baccf5f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("9ace9b23-d45b-487e-acd1-445e85cc972b"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("9ba71046-1148-47f4-a9a9-266012507a7f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("9e65991c-842d-43e5-a599-12fe12a67e23"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("abfee5ed-9978-446c-92f4-8008a72f2d4e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("ac72db0e-4d9a-4079-9583-623e6ab3d063"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("ae9d90c8-0c51-4c58-bdb5-7389ffd0226e"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("afb8a677-5dd2-44bf-b838-9a5e641e8e27"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b03e4512-6e53-4c1e-99d2-e9eb348a0df6"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b48dd2cf-6352-47b8-94e9-e5e98a2fc2fd"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b706db60-c38d-4287-8a2e-0f1c7de65544"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b7c9c2f4-e8a3-447f-872c-e9f12ed1b0d8"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("b9c373e3-11f1-4eaf-bcaa-c1a9bbd5aa15"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("bb373c5c-5074-4a92-8215-933ada082463"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("bcf0656b-7f20-42e4-bef3-964ac4b8daa5"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("bd261d28-81e0-46f8-91c3-ce8cca56825a"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("bd3ffe61-9d03-4889-aaa6-f5b216183b15"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("ced55c47-9280-4adf-9ddf-e6461456eb18"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("d969a8a9-3ba8-4373-82c7-2647780acb86"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e7344b9d-bcfd-46de-8901-07fce3f508df"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("e884b826-eb90-45ee-b196-e363c80d8d3f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("eb8752a9-1395-4c15-9b72-4015b974ee9f"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("f1f9651e-d33a-4fc6-b7f6-78a2b5ba6988"));

            migrationBuilder.DeleteData(
                table: "ImageUrls",
                keyColumn: "Id",
                keyValue: new Guid("fc680360-7dd0-4f6e-be25-b67ba1e952a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0bf303a9-c800-49a9-ad86-c556b5bb5c2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12ed6915-e46f-4ed7-8977-c93f44b389bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f73b18f-b089-4f04-8f65-924030ba676e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25a544a0-40e9-4d6c-a2bf-d64344198c52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28794248-4c54-45c0-8cf4-b108a1eaa449"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2afe6d82-4276-4020-a769-fa5b976c3345"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31b3c077-fc07-486e-a3dc-7e2301a1dd77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("36d0a8ea-0328-42f5-a67c-789867756104"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f22102f-c3ca-4b7d-be1e-95d6f97a9a6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("719d2e87-523e-4589-83e0-1383c7bc04f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d8e4140-b9b4-4822-af43-7281b2251bc2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8033645b-33d8-40cf-b83e-ff9b4002107a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("828147fe-55b6-4c89-92a4-282001f23802"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86ba38a0-4c84-41e6-8063-ec6e1246de2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("88ec14f5-5bb4-43a4-a377-1f5c978bd941"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c31dbcf-ff70-4cf8-8fa6-1f65ff46906e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95f5b658-0e56-4ca6-94cc-bcfceaad5030"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a4afca9-526b-4c20-96ff-92baea7c3d41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c460034-41d4-4e62-9cc6-a9c411629333"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4cb763f-3737-4b60-b8ac-7fdf80314301"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af86778a-736f-487e-a224-c4f25f8f7076"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c42bc423-1dcc-4340-97ec-ca1e5e759189"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc4a17fa-1589-46f9-acbb-dd6d94295abb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6e56cae-aff0-41a2-a0d9-d846962ce145"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eb70f085-b674-4dbd-a21d-395e8bc4f46a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3fd70b8-c0b8-496d-913b-d469d47e867a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5f9d80c-77c0-407d-8f22-2e08e8b3f70e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("eae24aea-1ce5-4dc9-b813-646730091450"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("08fec919-dcef-416c-9ef9-744616562d62"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("167afbc6-f877-40b9-b3f3-3377e5f334d4"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("199bf7d4-dd16-4f18-b22f-28ae8fbd950d"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("26c70b56-b777-4c2c-bc0f-fbb3310ce271"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("3298d6cd-8186-4d3e-95aa-048133dd980e"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("433f599c-46ab-4cbc-8dbb-e605832a67d1"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("4ad6a0c7-e253-4aae-bdda-f90533fedd97"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("566ea10d-0be8-462f-a13f-85cf907d9526"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("66b7e2bb-4f9d-4303-a052-23003850e113"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("67e4375f-3cda-4df4-982a-4f9ec38c6ce3"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("733c07ed-6609-4c74-bcaf-e314d13ff382"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("74a6b512-4734-4b85-b3bf-144a8d9788e4"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("88c1e6f8-12e1-4bdb-8e82-4fefd6099f06"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("8fd406e2-e8f1-4d08-9b52-9f92ed94f6f1"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("ad29a3c7-aab7-4f93-b477-c35b621e73ca"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("af5bda83-3908-4e74-823c-291099676fb1"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("b2e8c511-82c3-44a1-b2b8-a6fc5538bb74"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("bba3d177-b1e5-448c-9c1f-8f5ab86db4c7"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("bc6b0fbd-d198-4e1f-bfdf-7d52cb53854e"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("be733d02-03e9-4abc-8ec3-b96c71e2f8e5"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("d89fb44c-8a06-4374-8431-4297dbbbf429"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("dc94a863-3a87-4267-bc3c-be4cebaac67b"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("e60b0dcf-d6fd-4b8a-88ef-4cc2d10b53a9"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("e8d5ae0b-2ba7-4e1d-8fb4-e0dc98ebbd41"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f1b9790b-589e-44a5-b7c2-5c7121b475f3"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f2a7fdd7-5789-4439-8ee7-ee6c97dba32a"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("f86d076f-79b6-4c21-9a00-7c2dc0c2a18a"));

            migrationBuilder.DeleteData(
                table: "ShopAvatars",
                keyColumn: "Id",
                keyValue: new Guid("fcff86c8-0db7-4a6e-aad3-07e0cc5da1ca"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("01be7394-f136-4e2d-b366-4de3973296ae"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("064bfdc4-6c47-4b2b-8bc8-134da69f92dd"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("0ac48a1e-b50f-4cc3-b414-d29f61c3ce31"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("12b5f811-1385-488d-981b-dc704bcd8643"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("1822e18c-61ea-42da-a852-f4a3668d2c04"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("2ef863eb-8c8e-4ed0-b724-00a3a359912a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("41393eb8-e86a-4cf1-9f20-4ba811055834"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("4578df02-4b5c-4bb8-9817-c1404db8a63f"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("51f9d627-446c-4501-a81f-b633ca1549a7"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("531f40e0-ac80-4010-bd6a-f8cdb16e3bb7"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("58cf7637-206b-4393-b51b-465ff7dd9124"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7302ac9c-f8ea-452a-bfaa-44966a94af10"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7313a047-c4fc-493a-b5a2-4199fcd4e6f6"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("7f9775d8-306f-4113-a9fd-061451f9da5c"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("8087f938-da79-4c81-9d4e-2de386d34147"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("869cca1f-ca60-4fe8-962d-393bfe2c6293"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("8aa6c36a-e0a8-473a-b686-7b4beb4cb6a5"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("90bbf5af-f7a5-4a89-ac4c-8763d56a5074"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a1f7f1b1-222e-4535-8be4-265ff28d1cd9"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("a9f541c1-f678-46c4-a6e9-70fd230cc3f1"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("ad31d32a-8557-4fdf-ad33-c8c1f3d67e8c"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("b25c5133-b06a-4737-888a-48040b83950a"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("b71592d4-d538-4bea-8e15-c4e8e5c8d59d"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("c9c3230f-d7d6-4640-81d5-050f118d3951"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("cd9e0929-9a20-411b-973a-66913f3d05c7"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("d9db0833-5dd7-42c5-9b65-cc7c94020f3e"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("f4bcc3c6-9209-4961-b932-443f5b17b43c"));

            migrationBuilder.DeleteData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: new Guid("f78cfe15-4655-46d9-a3ea-991ecfe33102"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d6c0a956-0da2-4aab-8caa-a6644e746bb8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43023697-2e80-4897-bd7e-1af6210a6dad", null, "Manager", "MANAGER" },
                    { "ab971ffc-f154-4d5f-b321-b1f4bac6d308", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("0c96ac86-d8dd-4e3a-80fa-b408a528d11c"), "https://www.shift4shop.com/2015/images/industries/clothing/clothing-apparel.png", "", "Cloths" },
                    { new Guid("1a55c4b0-3bb7-4aef-b491-b89370a4809c"), "https://cdn.openpr.com/T/c/Tc15444071_g.jpg", "", "Pet Care" },
                    { new Guid("2122c1ea-a9ba-44e5-aee4-818ba4d7b01c"), "https://static.vecteezy.com/system/resources/previews/011/996/555/original/3d-black-headphone-illustration-ecommerce-icon-png.png", "", "Music and Gaming" },
                    { new Guid("6fbd61fc-0f67-4143-80ac-f68e85c660fd"), "", "", "Others" },
                    { new Guid("926b1d03-ee7e-4a83-b452-c40f3c13946b"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvBQPQMVNRd6TtDkGs2dCri0Y-rxKkFOiEWw&usqp=CAU", "", "Shoes" },
                    { new Guid("9f725793-ac1b-4cee-bd8d-ecc4cd892829"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" },
                    { new Guid("a82f0939-9d70-4b8b-8548-db1886df45cc"), "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mpwp3tua-apple-iphone-14-256gb-mavi-mpwp3tua-637986832343472449.jpg", "", "Mobile and Tablets" },
                    { new Guid("b5ebb95a-9fdd-40c9-b077-1da0d5167884"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("e1fa6503-dbc6-4f9a-9663-9cec1690dd5e"), "https://searchspring.com/wp-content/uploads/2022/10/Hero-Image-Platform-Others-2.png", "", "Gifts" },
                    { new Guid("e4776445-863e-4555-b348-a3c865182f34"), "https://img.freepik.com/free-vector/ordering-goods-online-internet-store-online-shopping-niche-e-commerce-website-mother-buying-babies-clothes-footwear-toys-infant-accessories_335657-2345.jpg?w=2000", "", "Accesories" }
                });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "ProductId", "PublicId", "Url" },
                values: new object[,]
                {
                    { new Guid("05345b80-a9a8-4bae-933d-2d57563c80fd"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("070719be-a9c8-4327-81b7-8cd4d36874fa"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("070d41d6-efc2-4ffc-a842-40435ab694c3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("0c31ff2d-70e9-44c4-b4b1-9be15d03582d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQc4HSepwRQjDLQitxc9LHPjdKN-8pYQPGlDA&usqp=CAU" },
                    { new Guid("0e6c331c-bba6-414c-8aed-fe96ddd1b408"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" },
                    { new Guid("15f4707b-d90b-4827-af2a-bb48544ab3b4"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://eratablet.com/wp-content/uploads/2022/08/H51ba6537405f4948972e293927673546u.jpg" },
                    { new Guid("1fa85849-c6ba-4a85-b529-2aaf7650d9cd"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("21831f7e-4f57-4cb3-8e4a-d3e039b7a117"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("23162faf-4dc3-4b79-8654-7a492fd63916"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("2c7167ef-6591-407c-a5f2-16c86386b358"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("315971a8-aea0-4029-b265-aa95d9896b6a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("325a6b1e-51d4-449b-bfa9-f335ff9babc9"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.startech.com.bd/image/cache/catalog/headphone/havit/h763d/h763d-02-500x500.jpg" },
                    { new Guid("33a04b0c-44e3-4f30-8c8d-b80d3b7738df"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("374e1468-9abd-4fba-a64a-3676468eaeff"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2zcpFb-6hMeoBVWrfp4LazbLD3a1tEjJjY2oYq45yJOyb28WIIYBoJ3qZMsmFdImBSZk&usqp=CAU" },
                    { new Guid("44de68f8-9b20-4b8f-8eba-939cbcb1264f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("4662d363-c30b-4270-9584-687e7818b39a"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR42FePhUrLX424aLie09J4Pfkn03T8h3D7PQ&usqp=CAU" },
                    { new Guid("4a321a24-59c4-459f-bdeb-2a3c43048be8"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("4d3bd074-3b0b-49a4-8c9f-bc8eb5a92fae"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://mirzacdns3.s3.ap-south-1.amazonaws.com/cache/catalog/RLV0015/2-800x800.jpg" },
                    { new Guid("4e248407-335d-49d2-8b7e-efb23fc0072b"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("4e8284be-111c-4a4f-bb8c-96d4e795000c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("598bdec5-95ab-4e97-b527-0176b406b2b1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://unixnetworkbd.com/image/cache/wp/gj/unix_network_images/product/gaming-pc-9th-gen-core-i7-9700k/Gaming-PC-9th-Gen-Core-i7-9700k-Unix-Computer-jashore-bangladesh-500x500.webp" },
                    { new Guid("5b4ba021-743e-4643-abcd-606c05c47832"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSSP2a13umWJp5HCeGtJtw9EuW8opwZfY7r6Q&usqp=CAU" },
                    { new Guid("66a8226d-700e-4cd0-913e-8ae8150eef9b"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("6c134c6d-bfc3-498a-b201-ffdaf61568d7"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("6cc568a0-b1ed-438a-b643-47daa4ff5db6"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCEvcavb1VnIbFqFEh_5sgzYPgjcVAbFLl7g&usqp=CAU" },
                    { new Guid("76ad8418-2d75-4e1e-8671-05dbcfc46a1f"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXd2u896WCZISe8VyWsmvOQhwbLREi0O93YQ&usqp=CAU" },
                    { new Guid("7ce42c9f-8388-4002-9853-a1cfb4a088a0"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://adminapi.applegadgetsbd.com/storage/media/large/iPhone-14-Pro-Max-Silver-8456.jpg" },
                    { new Guid("7e316362-73f3-42ab-9fba-26ec9eb95d2e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("8bca724b-799f-4212-aed9-18dde3cf3f96"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("8c1a7e45-cd69-463b-846d-aa1ba9f69247"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("8ed282b4-4f6f-40e2-b54f-49e2e8720f01"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBOB80TIoBkL_NaeJ_5lG5LuUsD0IYEDXFJg&usqp=CAU" },
                    { new Guid("91a91674-b0f0-43a4-b05a-e8ebc5e0bfa5"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("98649531-2122-4ca9-af31-553145c445fc"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("992ecfb6-93ac-4ff3-a24c-facce65500cc"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499" },
                    { new Guid("9ed50c0d-563a-412a-954c-30378ba537f5"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7lvpJRN10N75r-1ssE_0tpl9dvmOEiKQzXQ&usqp=CAU" },
                    { new Guid("a67fda01-7cee-42dc-a68f-4ca63de64827"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("a6f5ad8b-bce8-45a5-b8d3-e00b96912ed1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("a80fd49a-46ed-4fad-bf9f-4e649910ea72"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTg7XWy1cmt1D3uUjF29eo2q4HgqJaGEu9XDg&usqp=CAU" },
                    { new Guid("ab757c21-bc5d-4c71-8b50-d10c75da90b1"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://dlcdnwebimgs.asus.com/gain/0ad9bdfe-9c75-41fb-82f5-6a6bf25bab22/w800" },
                    { new Guid("ad2f3ae3-5222-41ef-9a6f-1a5955ebbb65"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://m.media-amazon.com/images/I/31Vle5fVdaL.jpg" },
                    { new Guid("b5c575a8-f5b3-4129-8f0d-33b4e236e054"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("be838efd-0931-4349-9f74-3e91255b8d57"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("c7ee0c23-bb0b-406a-9dd1-2dcad66f7651"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://i0.wp.com/eccocibd.com/wp-content/uploads/2022/01/1802NL02_1.png?fit=550%2C550&ssl=1" },
                    { new Guid("d37d4d06-c702-4f23-b4c7-eee26bb26c0b"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("db49b890-cc4a-4812-9bb1-3fcc1ee7847e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.lenovo.com/medias/lenovo-tablet-p10-2.png?context=bWFzdGVyfHJvb3R8NTI0NzIyfGltYWdlL3BuZ3xoM2IvaDFkLzk4MTA1NjI0ODIyMDYucG5nfDI1OGI3YjlkODNkMzI2OThkOWEwMjM1NjliNjI5ZDQ3ZjMxZTg4ZDQ5ZmE5NGY3NTEyYjMwYTA0NDBlM2VhZDA" },
                    { new Guid("e0c11dc5-bb16-460f-85a4-f6dcb46c4507"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1eifg73dBnUR8qM29W4H7iXk9NCRskq67KQ&usqp=CAU" },
                    { new Guid("e46f80e7-dbb7-4990-a6e3-933a77d501d3"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("e4db1184-3379-4337-901d-904355eff527"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_TxUk8mcOtG7_mZmNA6TOZZbADyp3L3HHCg&usqp=CAU" },
                    { new Guid("e8e09518-547c-45e8-9eb4-9d25a88e9b3c"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoJTwIqCk049REtJbZL5xEYO5W9m6iUiSRSg&usqp=CAU" },
                    { new Guid("e91ce625-ff0a-49ec-a4fd-822fab55a30d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ6AmSV387Vy0EVlO6hYPgsKqPnIA_qxq41oA&usqp=CAU" },
                    { new Guid("eb9b921c-b95b-4e81-99dc-0bc713fdde2d"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdUieJcGTqKDqG2pwd8y0PngaUFR0EvjuqPw&usqp=CAU" },
                    { new Guid("ed73c0d6-1879-4911-a249-c3989985f128"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdd3n1bpYxsBGOpZ6ZgUPIKdLVChEegzOBnQ&usqp=CAU" },
                    { new Guid("edadaf53-2cfa-426d-8bd3-2a3602e069fa"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvyCDsCiIgME0mgv_vJYB-285xwWl3bC-pSw&usqp=CAU" },
                    { new Guid("f3f36770-c784-4294-a428-1f47b9caa3c0"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://www.bdstall.com/asset/product-image/giant_213181.jpg" },
                    { new Guid("f4aafad3-b0a2-465f-84d2-c56ad4467526"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1GMCvSHthjghTol1tXK_t4eW7Vk-EuBvdnQ&usqp=CAU" },
                    { new Guid("fce08e79-d026-4410-8135-e385dbfcf49e"), new Guid("00000000-0000-0000-0000-000000000000"), "test", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwSpfSyrQUCFFTMei2zILF0-xFsIYgNgVVSA&usqp=CAU" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId" },
                values: new object[] { new Guid("93ba7588-6338-471f-b0bb-9c4f94034da4"), "comment", new Guid("00000000-0000-0000-0000-000000000000"), 5, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "PublicId", "ShopId", "Url" },
                values: new object[,]
                {
                    { new Guid("02403ca7-c44f-4ffa-b75e-22347d29f1b4"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("3fdef302-24da-467d-8705-2c7ce1c42a61"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("4f551209-a672-4d5c-86db-80a521e930ab"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeGWw-VaNcL9QlsHKJKPLWj-Dh0M2WguDpRg&usqp=CAU" },
                    { new Guid("50e2f411-5188-40c0-9c9c-4985779f604f"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARwAAACxCAMAAAAh3/JWAAAAgVBMVEUAAAAKCgr///8GBgbb29vR0dHk5OTIyMjt7e2zs7O+vr719fWqqqqenp7e3t6Xl5cuLi4hISGBgYGJiYnExMRCQkIVFRWQkJDOzs7i4uJzc3MmJiZPT08fHx83Nzd5eXlaWlpiYmJGRkakpKRra2syMjJEREQ6OjpVVVUSEhJ1dXU8mJS/AAAE9UlEQVR4nO3c63aiPBiG4SBBAoIbQDYFRdx8as//AL/kjW2dafvOais6Os/1Y4ghKtx109quEQIAAG5oOZ/Pl/tbH8VfynEd4Ti3PgoAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIDvcU+cD+jpWx/e9X3S4mP/SqGvNLGOOXGPVOnWx9+Pr1exxDwh4Va8Po5ufS6X9M0spziH1LRJ1VScTz9CoB91sXHa1Ah88W7XHT+Evvs8+i3ArDBSmVIcm+Ptlu8yz0XCGKKJJ8awEeY/0c138/V86tAdmPtxZjvznw/X55HcejnfT2n3p+1mu/1y1m+Cj10sDMVJNlocSn3D83ayicnkWXfp2vTlchwXSUd3vnwq7MSmSBvRTczDLja78hVFjmO9ZBKFmV+WfpQu77eMiRMRuRHTInojfdeNT+PAbrxAiLrdvM0E3iS3g0Qf1zQxo8A7bKOs9OR4qCk13N5tGfOsCohaLTdm2y6nB32KQTROlnZPtOoKO5JNndIg7bqIBv6KrhROhJh2oRlmSRf6vl8GT9tgPK50n+ZOy5g4aRZqWdWYTSj100kkZsovt7QnHLtiZ0dqFdPA+08sOjs1mZhtFoh6TpezWF8r831vL/JISqnzRFco00sa/WYUevoL7Q+jwKftVKxj+tLLbEMzMhLOtqShl9C2LM0LjJ0KC9qGog5okDV2iS4ycyqqU/aeppcymtgPpfQ8TxXmX68q55tSn1IZpNvWI2olnIhG4+I0sxXuIqX1XtnabW0vy0NAF+VKP8/WY91mXIV3mkbHKdSwGutXz0ifiZRVIIdelHR13orWfOGlVELsPBoN07GdqYVYhDQexlu76kCbcbGnS3Ksj3qXVjpNpZJe2/SXRsfxRkq/pSg/NG8uQ2+T7BfHvN76hbAzSr9FPSk7TOxWn/nxMLTrjx3N+Z5de1zZJZ5+VtV2rucHTp9t8pGhRmloIqmqOBwOT7GnVF0rMtqKY0T7RmFHW1V167qkmWwnVuqNnInGjrxmPYvN6pGs7zdOOxhQnnVDm1GlX3dGg8EgEondoWbCUTQaPIvAzlWlmRlU7U5/32h30tKVfqFp7ZKRX+nBQE0W/bbpNY4/IPIomtNQU2FweNmTCdGdpnOxSOTLmlHW6p8OHFGr16sV5mDrLnud8CbTntP0Guc4XRi7xPxcdVwl+gfQp2Ymcn2Su6mx7sRiT6P6Wa9x3Rkt2s7NFUzdXT07meZ0tMc8b9pU38669zA9x3HO7+P1Ds33VO7bnvM17vmaX65k3lRv8CN8n3Eu7tp9bn2+X3XVPrc+2W+4Vh/3HuM41+njOHcax+n/I2jnnuM4vfaht8u7jmP008d+K3H3cZwe+rx8UPEIcZwLP8Feb/VB4hgXCnT2+dYDxTF+3OeXj/4eLI7xg0fQb7f0gHGM7wR6/3nxg8YhXyj08a9fHjkO+fOflX3+e6mHj/PCfV/pj3+798/E+Q7EYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jAQh4E4DMRhIA4DcRiIw0AcBuIwEIeBOAzEYSAOA3EYiMNAHAbiMBCHgTgMxGEgDgNxGIjDQBwG4jD+B4GNmzYUY1XJAAAAAElFTkSuQmCC" },
                    { new Guid("565f7fe5-c1de-455d-be25-56a6648b7948"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAQMAAADCCAMAAAB6zFdcAAAAzFBMVEUDBAb///8AAAD7+/sAAASBgYF5eXqioqKVlZUDBAhnZ2gDBQUYGRk0NDaPj4+ZmZn+rBv2pRNnSBO7u7vU1NQ7OzzExMRNNxempqaGhoY9ruRjtDM8lsPa2tpcXF3n5+dSUlLy8vIkJCQSKTQXLjcVLT4ACgY2TyY8Vy0YJBFDs+9Jrdo1VSFpszlmuTBMgzA+quVBpNUQHiocMBVBbClIdSxfozUNFyBdmTU7mcoOFhcsSx1BiapntTkJEgZHR0gYEQowJBKdbhw/LxCxNpI9AAAEA0lEQVR4nO3abXvaNhiGYftBECsqpRsJ4yUQ6Npuzda03bquW5extf//P02yLWPAmLg72iHvOj8Rv8W6ka1HxlEEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4H/GGMkd21KJqPxjsYf5zGf3hci31pOnT5/YJunqTbRNSsuz775/nqUg/dSDo7EFwsjVzXR6M/3BZlD3rcqPL2a3dy9dCBLFqUlbMojk6tX01fT1T65BB0PQ6ueZdTt7IzoS1Ukz6LYlAy1XLoJfxURGH8jAXQm/3LoQZm/tdiItzMBFoI1+dnAjm8HL2ewuzUC3LwN7LdykEdRto428uX3h+sE7idqXgZbfXv8uBwaEzVZKpxHM3qsWZmDkD9cLTH0KWsvzd3d3b9+7tNqXgW2SMceLHWNLpD8lHT9bl4Eb7u9FR0q5DtGWcaGqPC4tkor1arNoNwNVdbhTJ/1J15qY0llL8tBKFuKuje7wYn4x7JlNs0QGgyRJBuv9cUGkm+mFFIKcZ8VuqeBXki0a2a9zHHtD8dWj5Ot7Oxm4W+QwDq921jUZzGXRiTc6SzmWgST5tklAEdT2g+tevG3pO3x1BsWx4nFQEdRlsKfzIL9NVmcgl7G/iNTB/3eKmmRgG5fuUp2BmFW2fB7WqHA0g1WyNo8X/k4XX2bjYVUGIvNs8XVoERzJYJSP9uv85jisyWCUp3bfQut01GZQ9GpZ5g1Mnx1VZjDI9+kHF0F9Bo83ddFo08KqDHp+SFiGF0FtBiPZ22xxIIOzfJfzACOozSAreNNppG/35EAGsV8d4hP2ugzWpX6QL0tqMzgLsRfUZ9AvZ9C5RwbBVQaZigzkkzOIL4IMwY965X5/2TyDh6tsWWhlcso3uDTZLWZ/DTLo9fN9huWOYCL3jPrI88n/nhjfi/0dXeS6eQbdYs44KIWglSVKnfpg4Vu88OcufqxvloFM4r0eFf2VOfmOkD8q6vTd7+myaUvDDIoDpXWScV+9+uarzNcnfpMQfyXHZzYFWVzEn5aBUb6edvVynsGjNIJHp55BMRVwfaGzNdI16wdRMXvOpthBZdCPD7hsloH9Y5VnmU22wskgkt3nhqP8elg3zGAT5yp9VB9QBrshjP0T8sYZFBVX9jAppAxsoTQvErheFr8qlJ4F+DnEYCsDvfcuThGnmzrYDDIhZGCbtRzPV53VfLyw5y7nQ2dUuh/YqsEZuypCyTj9vEzfxTnLP/vtuuNsid1Z/f0h8zGEDEq/K0rpj9L60m+MW6v3Nt0+jnuJT1QYERT+dVlbPoBOpwzaFQunXi7vqj1f06A17t2uKH2hocleAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAICQ/QPAkjm6KjCM/AAAAABJRU5ErkJggg==" },
                    { new Guid("5796dbe8-95b7-4a21-88e5-8892127d6744"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("5800ffbc-ec6e-4031-98b6-d659f5d5e384"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("58e75fac-d100-4b8f-9aa5-e02257702029"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAASkAAACqCAMAAADGFElyAAAAnFBMVEX///8iHh8AAAAgHh8iHR8iHB8hHh4VERIhHyAkHiAgHB3q6upvbm8jHyAbGBr29vYNAwaenZ1QT1DKysrBwcHv7++wsLDk5OS4t7fc3NyioqI4NTYdFxkYFhd4eHjs7OxZWFhhYGAOCw1CQUFqaWmRkZEwLi/GxsaFhYWioaHT09MVDA8yMDGNjY0pJyirqqo9PT2Afn9MSUotJykc/b6UAAAPDElEQVR4nO1dC2OiuhI2D0iIgvisVlCMrXXVqnX//3+7k4BWMKjrtadLN98521peko+ZyWQyGWo1CwsLCwsLCwsLCwsLCwsLCwsLCwsLi0fjrfuJQe90T7Pfev1o3IfF63aw7JV9ZzXB8Qk6p3vqOJSS3YdViDEbNQaT72rWF2AUEE64AuEFpoSgPkIC3QMfEUIY3iyevqthDwcwdYQcnO6pU8+j9C6ekIMQ4S7QLMlr87ua9mCcMoULTDkeReQueEAVIlSdjmfD72rbYzGKXII0H4iGBaaobu8fAyGKKHURUdLFCQvevqtxD8Uo0i1S/86Z8pCr96n/sl+6+dmP46/Tzblf6nQvwj+CKmDqgCJTbsbU/wHFlicE/gkK+MkUQQWm+P/PlDrf8Uiw+QFm/QJT/gOYQhTsOvSqje9q3+NwO1Ou695k0MGUU23UXX2yZqrgqlUSV5n67NAcehM8z9H/4Gya6h9cOp59VwMfhusypYkSOPwD4HAVKbeVZqYKUH2huo2pYL9t/Wrdil/bX4s9Fookcrh6PP2uFj4KtzHFxn984e4m9k8sO8dVDy3cyNQdfVd9FJwwVRgqVRBfx1RtuUIHTx4uIf9cLP8u3MQUuoup2kKCWU+9KpcGo8fc8LfhBn8KhOI+puoBdH8k8z+FqLiffpvneR9TtSRScZvMU6/64O9LmVqsnIwp16F4+ZAb/jbcyNR93tA2dFJTB3YK/RtMxe27Lv4rVBadaIv+b8gUiZO7Lv6xSpnSA6Kqj2e+lKl2lHoJiij+T8gUuo8p8BKcz0G2rPiE1lcy1QqV5+mm2ic2D7nf78MXMtWbC+o5NNO+eP+YG/42aKbcL2FqLInneSSz6PL1MTf8bdhF7nFW6rFM/cIuykYzMHLkuPugO/4u7IRLvkL7nhrYP0irgogrPuyr7S/bKWRkatG+hhmWyD9N/mAv/2WrvgKz6NAe94wpx6NmphoyDq6AE35ClODVn0eefc4h++H2dE8967iUuBVGyGOG6JW5LE4I+oyi+2j+n7bqK7AXSGRRKD9sne6pb6KD9hmYQo4Z9CTn41OmfJx7CJXEC/M/ZarAFKUHqThjqny6T1EEP9AJTwhFVXc7AY34sz0FpnyHHjLNzpki5Tlop5kwhys//6eN+hIsJMr6ctdfvZ/uAaacY891zlQpUSZUfXSs8C6PouCvctMn9c2x7yvO942Z5/5RXmPVIy4KrdBFyKhjzdnBohOC89rTYH+Y/5nX62piG6qIZNoekY9sjlf04GSH+dmCaexkp5Q5CwWmBK26h16rdTHXWSzQHF/kE8KWUqC0M8Mf+ZN2AU21j9ISX6Eoc7j6Jn2JCfK8zHSzvOi0cEQ96hO5L+QUYJRaMJpyZfAVUE6sfCGqPi+qVjIQ5KRJ0b4IC/5hf41XTOJpYanCEGfuA3V02mvAWAzIrXIICgr4A2z6RjGVKovPksLOyeBjPD4bsfUx0X2fTsMmgdxPG9MjGmOF6W7F0LGrgEtXPi2hVmurYLeWKTC84qZY9zQmRzvlsv3SZK17y5cwZ9Or76WD6+kc7BS6KTDZlIRotaOIemJeLzvu9ZQqUvXJ9lqtg/0DUS4V8xvywbaYpo6FCvvKC57SC1NLb7K5mbD/uHv+HjQxOgZXPE8urp+x1tEYN2WKl4oUWH6W9YI/Io6urI6SKTc1O4RdHaFtQy8LhgIF8cVQ5h68DDebcah+oif4nseIHUhAvL/iTfdiQY+jHBJenEcYr+AhHOb7qu9R1fRE70Gmri5HSBhSxkdP46Fgd/HYxepT+4L1A2/5m9AKD4MPNeF7haoPyQlFICn6lKKrWsBiBQ8h077KZy8Cmgem9CCPk7BRroAfIXCpHE41HHTJ/LKqNtghVRT9CO2rvWIf+SlTOh68apf4PsO2FH7mnev0lSvR8V0gFKfapt2ZLvOXYZNfmE1j8W7wq+rvMePZEcQBoYovW6nam1Tj5MzzusX/+PvRxb5/Mt/rIxLOXwsDm06D48/AU7rE+IpHMQsI//TRK+95aoxDH+VnU4QkyXZZ13ZoMux/jCRTc3jkQBQY/ytS0puy9HjyQ0YzGs1NkHV+mQTA/yIKV2LUbrdHaBWygB/DmXrhnifiXc6cPy07p3j72DCeEUVUPYDqT42meMLQk6GTSGVqtz0RAVRXj1RXl4oUge2OQ/Gpem7nscwvXGOCqCWRqRC6SL6XfnfFMMCc8FxM96iM7uFv7W2rLHzP8ZzciqEuPo3cual0fl7NFwhfGB9WDFusSTgnqggC/R4QlXMQ9tHZJIOb/dDb/Z+wEPmIFubeqa/gnqxjdEl+6bbIzyC8YS/PLMncqIx5EKmqr+7LYYs9ZAbRnR2lman3UcHlTCKHlkkhQcL/CQkcOQxw5B8V50znDtN4HgoKqxoHmHqekajMSQirH3Ep4GkjyUF0Ck12HNXfuaoEEyN5p7S5EUiYJ5WBc9+LVtVf2H6G5hgHphaDqdcznkq0cNE4v+jUhtL5dy+8FvKqJt7mOPA/Rergk2v9U0Wl8KY4qdXCiJ/zc7iEILjyGZ5laAkcFJoOCukLzkmAg7NZ8y4+JeaMKfbTjPkpms9z8LBPMn8p8igYKIbnz2d6NJRl5eGgixQr3PhR7sE53l4cvIrEgQTqRGG4eTGk/w7juMRFFZEM/cXPGBZfRLPz2oaxHA5xGMp4nbQ6JrM8TGs2qnEeHIkPJU0wlnKzfzee8jOh4gODt86ydA5+0Dei21kO/x2WLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLP4hDAG6GEYdPpjy4NX29FMPPpmyLp6GKeol6RW9bP/T/ekXveNNNIfHj6Yvmdz9HZfbANhIhvX68AZmZ7mWCglsT1PmWliGpormL3jFVoyxWCTG9BU4b6X2R6h9b3GRFl5l9XI68GXM0JwW1uVMxCa5770qvXkomWQxH72XrJuYi6zwQ4OZ3xYwjblIy6e0MDHWftd1o3S6NGOmx/2M03xOgaLyRWbN2Wy2H5WlkLVCh+Jf6lMHOyIwMRUKlf5JRIzb5qbudrMMO0ONk172wk8RSGnOjLyBKepF+im2JAnKmAowDgk3rzZ+xgShOIgF4SIoS5rq48iJVmVlWnT96lA9r05IKTEy5SMUqFfmErYz5jbGgV7YFAWBNGTTKqbg9vQF0mdSxE1MeTr3G5gqkymx729fN0IQ0yoyJVP+NJmumSgvQ7YPPOqVFscFpigN+KScqV8hiNRsv8HE5+blNDwWwhEKpsqyWqbW+xlmnHNsep5rQa4xhRzh4XGqfYnhCGBKn9nHxNjU5xBFOsu+HZS+DmSICXUoKtNOYMoRiMFz6khKXaNMITGC7V0egGibtHg32o1SrEu0T6ndZCo5N5YgWl+XKcfxIrWMuhXyEqbSM1thmfbRSK9vfJWo7KVhqgwALi93Djx4VFdBA6aImSmimQKhA5n48wJ6vVGU1e1LGJBt+IYbtE+9lxDaMXwORQlTnliPx/AwYm4SW8WUkqn6TjiheeliMxAc9zEvW4QMTCGubqK/BD5N7QCmAs1UbRp5xsLNT58w7AWmvLQ+6JskvmnRLmhfeJGplxj5ASMk2DRYmfYhX0APDRJnNDPAlBf9/j0PAyRKSir3lTzVkpiwD+N+xVQQA0fsA36aLXomU7XxyolMTJ28Sd6wF5hyU6aGgblW2ugGOxUlDUk4YogEieEIJVMx9H2SM2YqyKKY8sCQ+sgvWz61j9V6/i4YOpMHkFqh3QfoFWdclDFFDkx5xlf+bOBEvcrCWN4LmKIZU7GZqR0YSv0ck8BsRKYxiZLaJuBCoFLti6eT+uQdJA9PzvcrphzhA1EyMa9NGGIegN41Q17yQj7F1Lqpnpd2ei7JVBOabGyILyhhOq89MOwFprLqvHAlJA0u2RgkZQ3f8ETAYJkW4CuZmqoSgdDSUi8hVtI44WBsDA0FpkCoIopY2QL/hRRcPegXMKZGm572bM19TC4wldqpd3C9jHT/jjzcr4OVqps806OdetoILkwL4rYYETbtdPYlMqeYUkWeOqpCZ6nnqfV2K11jpQfwPKP9UDhIcLMP3oSb08byTdl00zHAFBn1oBXgAiBiehNdK3TFqNPpTjH01GuDZNc24OaXV2tS2rd6X761SOD7xjqhvYhSyrCqsRnNTDYCtE/rHLRXeFFiOEJVpKHr9Tz0kG/qu+DMYKeMECkpQzXAhKcEgSkxLuzXugWa+wbOq0eRkSkQWzDWK+oT80ItsFPo92gNmJs9T5euwNoe/OxzqG5Hjct8FBr7pQNTtQX2g8gsU2pZsFALPKVpv2Jqptdul7zsMglIpnQfstQH0EzV+iGYG7NM6erpLoX+1VwRbqNqDcBtwnDHYPCBKb3ckLsoHJWMkVshCwQMDJnZP57KWCZpg0JhZOIljGFUB5B4ZvqOXzhmyoS84Dg2+YRDzIJMDJY4iE0K3IJLpGUJFziKzbGEWNdJDcN1iZ9P4uw2Y2liap3VWcWyfEncsrHbbHbjknH8R7vdTiWhmSRtk0yod3ok7SRJPgZm5dq320reJ9Ok3d6ff00LTj9QnBy/LYctXGKaXnwMRxu+pj9Tp7Ybr92yCBPc4uEdIwanraluLmlPF9vLxUcnJhNoYWFhYWFhYWFhYWHxz2C4LQ6b6t23t04uSDFRW3Kjs3ohbNTsPnd7hS294iGF4d2kWqU5FnjOCxOwfbzhm1GvsGWee1/BNj8FMGnjtVznRtJPxShmqxiUGFSqDOMz7jd7z/nA4oBNer2cQPQ3T8Uteaba62GznuTefPRUjFZudjy/oWuK4P+12Ot4yTQ53TaQw3o9x8uWD+tPF5hKWXlaTM62nVwVTwphrK6sEFO9WIfjPnK1qAcqfJeLOPUxO9ty+tfSoEdFpvaL2iIfwq0UU7W9ni9s56LUA9lZ5qsC9eNucUtBppS0DJMLMrXEs5dZPmRfLaYGuFWvv+dbMDgL5fY3Z1vydqrBOpPhLheHLjDVGLVeW7vcE+nKZd04PfV3YhtLzIsW5YwXXoxTF5hqqvTAnEgV+r70r24ud6eLRRD7N71W6q9A7634Oqvm2XM2bCk2sN4tbsnliGbHF7bVzakZFhYWFhYWFhYWFhYWFhYWD8D/APZIHev2YTF4AAAAAElFTkSuQmCC" },
                    { new Guid("6146f98e-346d-4bda-b1b5-a54acea98e0a"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("63c4b689-17f8-4f76-b237-ea8e2c0b8f62"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("6caaa6fd-792a-48d0-b8eb-390668dd8aac"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("7915518a-becf-4c04-9b12-fee1d807727a"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("8e9d0eae-19e7-4067-a32c-6e663a8f2441"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("9707ffca-652f-4766-8cbc-c68574184535"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("a46c6035-4ed7-43cd-a1ad-ecf4d7c2f273"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("a4ee5a76-5a85-48c1-8cfd-7001acaa7714"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAASwAAACoCAMAAABt9SM9AAAAkFBMVEX////4VQb4UgD4RgD3QQD4SwD5ckX4TgD91cz93dX6lnv/+/r4UAD5ajj4RQD7oor8yr78uqn8wrT4XR/6imr+8/D4WRT+6+f7qZT6nIP5fVf4YSj3PQD94Nn+9fP6lHj6hWP7sp/7p5H6jW7+5+L5dk38zcH8xLf92dD8va35gFz5bD33LwD4YSf6hmT5c0l+/nmwAAAKeklEQVR4nO2dDXeiOhCGISRNVcRq/Rbb2lpt7W73//+7BQTMDIEAYoM17zn3nLtUQvKQTJLJJFiWkZGRkZGRkZGRkZGRkZGRkZGRkZFRWXX2E91ZuBqt/zD6qjsT16I5s23GR7qzcR0acNu2idNf687INSiCFeCi4yfdWWm/Yli2zelcd15arxRWYLrIXnduWi4BVmC6vozpKpIIKzRdb8Z05QvCCkyXZ0xXrjCs0HQ96M5UW5WFZRPvbqs7W+2UBJZtu/TZmC6JpLBC07XRnbMWKgdWYLqmO915a51yYRnTlVU+rMh09XTnr1UqghWYLseYLkHFsGxiTJcgBazQdL3PdGeyLVLCCkyXb9riUSVg2bZvmmKkUrDcb93ZbIdKwSJ3urPZDhlYFWRgVZCBVUEGVgUZWBVkYFWQgVVBBlYFGVgVZGBVkIFVQQZWBZ0Pa/fVR/q3fOnO978wxuR8WNQlSK7rcsY8b/n5Y8X4GTUAK/c2l9HFr1rZviQsO1zZ/k2168KwbOKNf6wsF9elYdk2W/5YYS6tAbs0LJu9/VhpLqv18MshF4Zl01+xJ6H3/Gdn7bmycp0Jizi/IGRi43EWhkS+UoXhOhOWzRc/VaRLaTdlxI5gWZMXWtgWq8AKR6WZBOh1D7e2/7ywTCwOtu30i0xXBVjE5ZxTj8HU2DWHQPe6vnssRRqZPCowXRVg0ejabAPZE3LpEl1OQycxUkwI4x5QtwFYsS2fQVpe56IFupzuH0+NRIRlTQ45pqsGLGsEKiq/zg2gs6VIhMENAh8rqemqA8viYkqkf6nyXFC9hQ/aGsO7KT6ZxHTVgtUF4xH/+oZaQ4ZGVBlYloVw1oYF26HzgW6bdTqdJkIKe+tOZ3uBN/HxN9PIJLBQQ60Nq+OABw3Fe3Yvjuc4wX/f99G/7xfdVIs4ck68JoYe3v89DXGf5isaJOTRv/Poub356Z7n46XJ4Lmbq+d5zgBQar5lsMIuAPX8dWBNPPE67wo56XvuMX3i0mVww+wPF+RHFQ5coydaC0r85P83NOmqCPPCkrx5wk1O5BzqM14g71laJvnAQA5LHFzUhgX/4L6n19eemBO+Cl4OqIRONMwA11LUsxVLxnKWNRZfB/H3lvWV7VSmhXMTPpCUaCSz2wWwYE9QDxaoWcROLj8hW8C65WF9Ro0jhjUAdwV9yMS6qwrLyy6rdOQjgiJYwUt895KbGoCVVgfrHc/a/aePcrB6B09Iau2jdIIfVYWVnVkUTZMLYAX5ncYmoR4sOKFO5tL3GS8F+1yXgvWRdOVHWH1cKOJZ7xVhZdwhhQ6YQliREyd6bC1Yj3DCE++aes+aTmQicmAt0lcewepkXUPEg92SGpYDZ2EK154CVjDjDrPYBKw4XxO1+0sGazFZncoRwXpWLh6oYREmFmRd6Hmx1bCCJIKm2Ais44hqiN4dcTMZlMCyuVhpIlgMjwUzCalhia3waVzs07PLwLI2rBFY8ZOWsBUy+/DPQ5mUwYLPCP7cgd0HoXeHKbrjCEviijw96T7N7FDlLbY1wIIFckKnYA+Z6lKwYA0l0/AQsBECGMHa+NRLBd+U0ApHuGuVSQ1r21AzZNHS9AyUxz2mO4NJlIL1BipCPPOEF2NPR2+SqvcNaPHT8D3TtdaCtWjKwB8nhztQIdhIltVSsMAtxD2mA++RuIWgBXd2OX+oByt22DQHawNgJcOJBawmClhOWCFgDY03Yj2BvGRh7SBM5/QX3F1Uh5W6ApuDBbEko3pogIphEX+RwZL6YUGZs7BgM+XCSvm5sAQvRXOwoNFIXu1DeVicR+ZpC2pW6v9ZFcNiea3wXFiDsyfSMlj/RFjp5Fo5kU7lHY7pw9lkYvtkc0NBKEkvF2NFWNBL0Rws+OqTaWxZWIQm0V7yjkIBCw76wY7TM2BhL0VzsKbnwGKr1A/9UAcWlw38zoSV9VI0Bwv6uCrBOlr2WMMasGDTPfmMzoEl8VI0Bwv23VVgxZb9DFhwuck9nA9LuorfAljOAazg1IGFWiE4DbIOrJz4EP2wGDpaogYs1ArhQmZ1WJM8L4V+WA7yldeABcfDLox0rQxrnuulaAEsFFhSA5ZNpLfUgrV3mwk5KvY66IO1RusncHW1Eqxil2pz/ix9sGAMu7CMWQFW9L5VLtVGYO31wppKjEJFWBHhfGOVPLYxH7w2WLgVos8rlIJl87tugbFKHtsErA+tsF6hExUXqBwsm3D17xqBtdUKC9kEfCJYSVhlVA8W7Ku9iU5YW5RLHBmmHZYs1kEXrLlsKaO1sAjXCkvRCvXDopIkNMFStULtsOASYbxGV9efdSYsuKhEHjOF0A0LucmPNR/Ge9eHNaoGawVbYXZzjG5YaH3rGFbw2BCsam5ltOTtZc+M1g1rDFa94okrDPpMVnd2lWEhb5cCFmqF02whdMOC9j02EzCIJlmM2ivXDTGsjqyN44qbwoLhAbKtMZphvcK9O/FiA1wTTn68qQwL9R4LWV5SWCiAThJ0qxnWDkXGxJFQcIqW+D+flbEOGBaKG48XH2DofQoLhSfZVlaaYFlhkM/9GG3ZTCKhPqFhjh0lcGJUChac0cZxALA5p7C+YCuUhb7rgWXTQJ6DfD5pO4G2JrZk0L6XgwWN39Eth2xTAgu1QuzO1wlLqnTIDKNfbL7c9p72KKelYKHDO9io15u9wGsJLBTG6r6NBb1t2waLv6S/hpM023UoxRktBesBOeFYUJ9R0HgC6w5dd0WxVdtgCXOxhTrO9egmVMB6Uj82hlX8yziirT2wxA9hSCOJPInZV8CSRoG6VGL2PwsdwXHX0xpYHKykSByz3gREEB036qhg4YD6QO4YtnIvqtCSLR1i0doFi6/Az18zhSQcTt7IVxlYkucGVRKM2FgY2tdTHFnVKljsC/68l1mgDAc+YHuEVwrWPEM9GBADb0TkXRgVL8e0CZbrZ46hGeEbwjk2mAZFzUcJC3esNlugaZAbbmVdFrbC9sAinL5LvqDVhc75cAcqtEBRZKwaFjpngz/iUofuhZ5i68QPw/KzzwlPlOSMTgfy7fWvQmyv60d931YskxNe+gAvgcpOHJlNT2UkzipyAn2LVdSXbW9EWT3uN8C19Ay5LwWwNhTLdx/vxvOH/IMI1kufhfu8GfMP8a9ehdujjTjWwRcu5RyFt+FetF+ceW48PJmtTrdFJuBLSEamoytsnr+fo6po499MfnqYL7qL+cPZR0V1hoPuYjA8+6ibN+UGunJy/Ws+0Kmsck6Wqabb+czhJz5OpbKYfUPf/pWcLFNB4lEdt6DsyTKlRfzb+165eLhYFVRO/xeeUq7WELt5S4i5N2SsgNIDEcuK01sYLuRp+45PBCgQoeObM1ZQu2nZwEmnf61nPzao+GQZhRj/FedGn63es9J0uf51HpJ5CW2/Ck0XoYeJOpHb0QPJ9bMSZ4XPfLx55W2oYOw3fZyjKUm36rj06g9tv5Aym8AIXZqPtucKbC8kzuO9+pZb1qufmC6ON5QZZTT5jkyXS7vXd0i0BnX6HqPvxliV1P3eTAONjIyMjIyMjIyMjIyMjIyMjIyMjIys/ypxrYsVXb8jAAAAAElFTkSuQmCC" },
                    { new Guid("ae6571e3-fbb1-475a-b223-fe1decde716f"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/jpeg;base64,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" },
                    { new Guid("b4c6e5b5-88d3-4d66-b22d-5e3cc068914d"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("c53b9419-0cf5-4f8d-bc15-91eb888c86cd"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("c7ba492d-8e32-4f92-ae64-3381041bc765"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("cc6cc44d-f395-4c0e-8819-ba62c2d2ee42"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("d08549d3-28c2-4a85-91bb-3be22f04f4a8"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("d59576db-58ad-453e-a04f-a1706e945e5c"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAARMAAAC3CAMAAAAGjUrGAAABEVBMVEX///9PuelOuuhQuOy74O5Etun1/v5EsuIBVJZRuOnk+vuEyudLvOxQr9tPuesAUpMAUZQXZaAAT5AAVZUAUI4jebQ/n9U0jsMSY58Za6UUaanE6PcSbqyR0Or///tPtOfa9/h0xPBhvesjerTw+/wqq98JoOB+yfCM1fYAS5Accqs7lsubu9MAV5RJquAAVZEYhL4Vn9a56/Cn2+7M5/BTtO9ZuuB5xd+Tz+y35PTN8fnS6fiayuFetdxZrN4+pdIAkMIKn9QAj8x6la5Zg6GXqcIAP39hibWq3PYASZWc2vtpi6kuapevyNhxv+Q4dKfu7vQ2gKjZ///E1+MWj9UANX52n8GPw9IApdUFkMZIp84bFDZfAAAK50lEQVR4nO2bDVvbRhKApd3YlkCWhCT8ETtWgw0E+yybAzsEQhJoekkhpb3rXa/c//8hNzMr+UOSgfQBm5B580BAH7b0enZ2dldoGsMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwDMMwf4HDZ0+K4n04WS88Jcpr9+JE14X+NDBNi52kYCdZ2EkWdpKFnWRhJ1nYSRZ2koWdZGEnWZbkxLRt+D6yhBD2aCQLsKUQhoWCSZdgirFegH+mZeu2XNatL2RpTnQh4AA5CsevX6Q5itmybSHlysNtSU6kQHSrtH54wyh8XZjgZHk3v4Bl5RNsNLZ5+kZrtTStuJbwwwzF2Mn3EifgBBLF+JgOPXn7+rT8rlx+D+yfnZ1dAx/Oh2vKifk9OdFPDzFKOgcvX24BuiiVStvb0Q5xtnO+1toV9nfjBPocaYnTY62jtdaOdndJihki28T+zj440XbhSDt5mblXwwQt1A+Yl3Sb+jH10vCN9iWb5t862fgVph/aiWlKuCphjsS4oXV+bGkHu+uxlC3TDDFSyMnOzgdwIjAZSzsDORD0T73LxAm+ug5pGTp128x5f9hlS2mbNnV7j8MJ3ovAW4WG0/n4k/bDi10kbj4YK1EsJXHyvrKISOiR+mEaERJuVla77Z4U+bcs9LDdHob2gt2rcUJ9sH7a0H77+I8T7c0rgKS8TKTEkRI7sbueQ3iE+jkI8KtryXrguF5QtfXkFrGTjwaeV5Mi964hj1UDJ+jJr2g8D59PsDGI8Ym29mlvr1P8fPFiVoo5lRI7MbuukQNsdDaFrLuAV50NCmEPPdhW0fOd6LLmuk4dneTlm5U4EcKSOqTX4sef3X4xdpKKlGjiBIqYBU5cw1VODHAyvUF4T9kHT053QeOxKwHs9iuPyAmmRhOVXO65gy9a8eDi4kJJUU62RBIpZ9jvQBWT68Q3VJw8h9sDJ1TtxMrNXuDC/iDKz/Gy64BRZ/iInJhw1eEhRMkeXPeXYvHtxYuLVxAq0PlcXcWJVi+Fysl6AUK968WZBNz4ACQWV23BfOIYvutUp28FLXMD4sAwgqGdfX8Incgjx/18ZatxAld6VNQuA7gsvw417PHx8UlMA7iAnKLrYViKlBNhV3oJfXTiNCe/V4Ry4s460aMAlRhOLcx5f2G1HQo0r5ejbFVOpA6v/4vnGz450bCUbU1Pe7O1JTHRlqL3sRPqqXB4JDccajHSiks1IbJxost24FLjCnp5bSMcxA1v4+49z8O3HXmlaV98v9/v+19wTNxSYlrq++crVdIqJ5B97IkAWzlpT3vZ2Anmk8nrh75KOH7QzY6osSNWTgyncudAeXAnYnSgnXj9GtD/ouYJWoQ67c2VqvNFmDhJSlcRx0kby61kU8aJXvUww0IjMwbRnA76btcccuJDr/VonECGbbR+wTCJnbTmT1NOtsypEzORgk6gSYATM3mtrBMBGZacYJadf2f89t7zHeXE8PPyzUqc6FbY0P5GYVKr/arajooSFSyNK1Xnj81pnMRnghO4VYyTiV/SNHUCjaoS+Fh+oBPIsuZUFr0KdcSGT2nWq1p0hbebefg6tjTjRNPSgdLYTZy8SzuxNlyfcuzkRlNxgnmm6YMTo4tNBPoWc7bAh+iKAswl/ibGCmbZyRhytU4EOXm+0EkySjbLaSd22kmm7UBHTPlzLxpS6sEKfvYioE+izaM+HhWo8v/xOEEWOVFSyp18J+2FTuD3oYdFal2qgBhEc8NfMxz4WM31pFLWtR9TnNTIyfNcJ8nY57SY58TNjRNVqEOY1LBpQGViU+IIhnODHhgcYvLthzBypkCJZqasHrOTF6/i+ZSrr3SCIdGjTqUmhVXxVC07cxFC1rBu8UAUnYchZ9+lcnsETmhAuPvyM7yGOTtQuyGf4MASuiMbf/WDqoU9EjaeoDrTeKwK1mv+IDKF1fNo0DO600LJwzvBvvh5E3n+66SOnTo5Uk7Wr05aNFcwjf7bciwMjTCFGoMQcycUrNAp12YPbqosgnVwWKMJhyp0TLdrWUbNljhp5jl5oaYOIExa2hY4MRc7SffFdjugA0ZhGI4iFOBC3zJ544iMuT3avYmjbKMvvyEn65+LxVanLKzprOJNTlTxFfUdbDBUIsNoylB9y2Taf6iGOjjSgr3k5G6j42W2nVwnFzjJdPSsCNsPSmJ2dj3TF6fixK56hj+ZcUomnybzJGE81JmdmIJe+w4TS8tx0lzo5PDg88GzBl5Bq7NFx08u+hYnqtBPT8d5Qys+uzeYt6XGRNE34ETTMEK031pFDBOsx+XCmm3OCQ513Mk904CH7noQtw67OzDU/mSfPz96WqETnZxsAs3mP//V6XTW1jrzFDu/X/4IraiUOnFRv2M4VVogaeMQ0fA8D6fycYJSDfV6NA7CoQ7Ov9E8P87re5B7MLuMHomTt+Rks/nv6w8frs+HQLvd7dY3MDcO9vZ+/s+nonZYTncINzuhGTTDHQyrE+p0/AbNQdlDF51sxLvgqKGvRse3Klmqk/P9s7P9nfPr6/Nz0gKR06zXasbeJSg5lXpKyqJ+x8D5WDWDhtUHoqbmKh6ljAot/tUwKryKpabs8PknNfWwcfuzHEty0iYl26BkZx+UkBNQAuPCmuFdFluNUyxL5/PfwprNreLULHS+LnauqqngWrIJPY2LmiBR97BP8mtSTIg3TSuYR+DkHBe2gOvYiZJS3xhcQi4pQ2tIZ7+ba/seDoaMmpqCsylaaJSMfQvWsLTmU03m7Ch0+hg6TvPWnmc5Trrt9j4o+fMMWw8+glONU4pScjw24VNOr0ll5pSSfIL9jll346Us3KvmK3WqXGGjJdSqjh+K5LkEWkN1fd8xnNJty+kPv76DTjZJyT5xfq7iZJPSSf+PotYYq7H/vBMY1lK/sYkhNHFCxWpVV7dPK1mzkwObtObXD62hg+ul7SR3qEiJcE7OdYcy96mM5Tmh+di3TVSyvbM/23ag6dTrtT8oveaNQdCJ6++5WFEki8O4NoqjXwvnS3CROBVaFVw8dINq2AcnkG3nm6O9iU5odHxjpCxlPva/H7b/BM72qd1cUzLpQsvpfnoGuWRs5X1uEBQ1WhFtTyMISlfaVLWjAPCCSupE3B94Xn8IBwVBPbWsbkYBba/eklEe3km50Vr7+4Q3QPK3mb/jGz87tfI/NlolxQdw5jYhvUgv0a7K/LNv0MaieBVVPbqTevzCNNUrVlbsxBblxuKT1g5fj+3RggG1ZU06jck2XT3IBeNnadOK4fwp9Kuluuacx9viqt/O37s0J9LUXx0s4mirVJBwCSI358V1hT7zwskmoeZj0x2I0KfliJphSSWq6c5VOoGPFJ8awGfrw9DUTfgPBRQKBb0gQ8gQ4XjhY8Lz9zezzVzwQcu4WrHxeT9ahs9N3nFluzInM3bmL8O+6apWC/+tShZ2koWdZGEnWdhJFnaShZ1kYSdZ2EkWdpKFnWRhJ1nYSRZ2koWdZGEnWdhJFnaShZ1kYSdZ2EkWdpKFnWRhJ1nuy0lrXSZ/yviNowtLiNN7cbI7mlut/YYxpZT3ESctiBMzlE8BG//y5d1a+tHmv8K6JfGpIHGXL33ydafDl3uaPpIC8sm9OCmHhdITYTz+373kk07xCdHptO4hTlqZvy34VrkPGwzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMAzDMPfN/wHscbiZ38cT4QAAAABJRU5ErkJggg==" },
                    { new Guid("d7bea74e-1675-45a0-a51c-344305d3d23f"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("e8180110-eb59-46df-ab3e-2a55005edca5"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAe1BMVEV8wUL///95wDx2vzd3vzl0vjL9/vxzvS/F4q3z+e74+/SWzWrk8tnt9ubp9OGDxEzL5rfb7cuu146j0n6bznOHxlK+36XN5rmPyV7R6L+p1YaLyFmz2ZfW68bn89zt9uSy2ZPc7dCSy2Wr1oltuyK+3qadz3eaz2+33J5Ay582AAAF3ElEQVR4nO3Z2bKiOhQGYMhAGAVEQMQRt+L7P2EHJUExeC76SO+L/6vqKncnhoQkK4OWBQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAADwS5He3xTBKOV3lLK/Keh/RbkQglp53QRtu2qDdU4EpxPVI11uFud1bjEu2HMS4zy/bi/JLk3TXZUUy4C8Zrh/vXtUnMcW4d2nObC42IWR70h2z3G89BIYns8Eb4tqf88s+d52yMPpMvV1EX1B4S0Ww9eJIFly8vpvO96+rGfoZraxJ/jFaJhxtjyNMy37TqJxMlFMmvdvgfBVOk48jPv4C2g01ULb9oKnCtA8cd6zuI/qs9t0KfaW37+/3hueMEcffqia7TSqBsRyDe3rW0ji06dS7JvMxJemlPT7M5GsP9Yt6mcRDSa6etf1T3z4WIhtB4RvjQnFDC0835/keF50WOylxSLyn6qwunciP790oO97kt/lC2ULeTgkHU7udnnenI/FbjH8bylW5qa33x+lZHWqinO77sL3fSmTq0S+GmZc0r3k5xHm7ZZtncdSXq+DbG1ZYogxZUM4ZYwRxihnre73hdAfnXSbraSrlK2+3r6uibJRbLTIE9GqCqWyj2immxBmMqLqzPfNAdF5/Ya/lMPW6kVFeoymufz+YI4Wmgk18EJhkVpV1Mn4e3QXKkQ68dvyrgZqpCbqfmojMTu+66t04hZTrY1iQ1wgV9U95/dUNTb1TmD1WxpIflTHVJyqEebnpupxtYq/L22k0ZNP5YlnqPx/IXLjSepC1e1CLa//uDFG9lxFXneczJhqvKOK2PMZWjCJyFgqaNxsivQwrA1XvZCFxgays8r5EvgJ4yTTi0io5mP5r1oo6yPiYHNLwsgb7VxiHS3Oxi0kr9QYjvui5NmD1dftzhsKyVQ/H2fYhr6Tp5j1torGx4K+3j/BawvGmAome94dq6zgXFQL338pZKnn478INEw0iWdPOv24aqQJ4/dr1Zi0vZXheATcbcRRvaV65tZ1/bdZGOo0cPVq9xZIHgVM7MYGu5jpkezNPkhZY2qfE+1K9Tkjn6cQM54YhpLcXHa9XlBPcwcalr0OKt9bVMVmzYTQp+I4Vp+uxilEC9vM8Rflsu6vCdQ0MI+D7yHN0EAvTLbXdXc90+06qZp8vtCHq8DYQv5+svcjWVbWlaV6vVZJ5nD8PWxYr66WeL4ZEyeVMGzBG3MLd0PTnGi/KzZBTsTrVl7v6xzzW/qaIUhUdPRuqZp8yXCuMwd63UJn29YWlWev92z0onr3K+2YRnWEG6cQferZULUcTkQarmNSMzkCqXoLkXnB+RqmTjTVOMINO7Ga6DmUGqunZ6y9nYwibD/1oG9THZWMHzwEGvmH3p5kpiYMd5GeNTnJ1INmuJR5peoWsdEAGwINewpHzvXlBN9t1CkdBrQd5nx0vyqzyP8Z7rqyuRd8W9dtFfP79Qrrrlc41+tXSS36dBFareLuIqf7Z+Xr1fJSlvnTLZS/2zS53Hp39zSWFefrZpWdz8OYd+bes7Gn+0EvLIvj8rw8bi9lutcJ3YV2/LyL9vanKkmq0z7qX0L7dIdzb2V0WEiHyPP6rfxaL5n+3NNwcjsy6NbAj/sy2S06JJv5+dPiOnMLLevzplsdmGg5ncOR6SScTpeT3PpRY/4ton0diT/WTW6UH7FvWBHe30HXLezDK7D3TP9ssP0Hx1++/HA0tD310xdvp27tH/GfB9Ovyh32fTPv2R6YCJLD+6nVcfywWg5Xm0S0lf+WyV8chUpfuwvT4dcpn4Lx3KuhqjwVpMmOt+Lium5R3LbHzbWRm2fxevdLOK83t6S6/7pbusUxa+LnX4C7YoLz7eImd657KW7HTWtxeYJxH+Y+WLxUv1sHH7q1bOqunahf6Luf6A2/0T/2ABrrDxik//u33AUDAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJj8AZBjR1ZHXeSrAAAAAElFTkSuQmCC" },
                    { new Guid("f4d7ee74-477d-45fe-80b5-b569c81f99eb"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" },
                    { new Guid("f516859b-cc34-40f7-84d3-9fc03d46cddd"), null, new Guid("00000000-0000-0000-0000-000000000000"), "data:image/png;base64,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" },
                    { new Guid("f71c1802-a472-4b52-ba8e-ca896f418e23"), null, new Guid("00000000-0000-0000-0000-000000000000"), "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "Ratings", "ShopAvatarId" },
                values: new object[,]
                {
                    { new Guid("0133ab03-d17e-42bf-85a2-9181d9d1da61"), "SAMSUNG", 4.0, new Guid("edfa2996-c98e-4610-8616-4ea276731cd0") },
                    { new Guid("0360825f-368b-497d-b590-4b82943dc9e0"), "Amazon Ltd", 4.0, new Guid("9a098291-85c7-4901-9cec-9ce919b82335") },
                    { new Guid("18f6578c-8f58-43d5-80b7-0a5c01d7db6d"), "Apple inc.", 4.0, new Guid("e283fadb-5fb9-43a9-b2fc-a1ec8951918a") },
                    { new Guid("1a0661ac-c406-493a-a747-93b11b5269c4"), "SAMSUNG", 4.0, new Guid("fca2bbfc-aef7-44ff-9127-2e122d1ae554") },
                    { new Guid("1c1438d1-fd47-426c-9a39-7ffa380042d0"), "Apple inc", 4.0, new Guid("6812dab8-36c8-46d6-9eee-02f3f9a75786") },
                    { new Guid("248a4afc-2ebc-4547-98f0-e5b9def6f6a2"), "Energy System", 4.0, new Guid("2e9314db-463f-4871-9013-f3d288ce565d") },
                    { new Guid("312f8ade-2ad6-49b5-835b-300f76d23831"), "Vaseline Inc.", 4.0, new Guid("74bf8a11-0bfc-4baa-9daa-c6ee9760612b") },
                    { new Guid("3a62f09b-9c85-45d4-a807-56b290d765a6"), "Amazon Ltd", 4.0, new Guid("2fdb1bcb-3bc6-435c-b8fe-13093fc87a1a") },
                    { new Guid("3e914d8c-f8fd-47f7-8233-7a03c4a1295d"), "Unik", 4.0, new Guid("d60d8d3a-b300-48b4-86b7-0f1808f08941") },
                    { new Guid("412a1e25-5c86-472a-be20-80b635127fa0"), "Asus Ltd", 4.0, new Guid("eda8054b-142a-4ce5-a266-83af8569ddbc") },
                    { new Guid("4903b8dc-796f-49f6-b0e5-0afffcf1b6a5"), "Alisha Shoes Mart", 4.0, new Guid("df48e470-947b-4e31-9392-4fe7302e2fb4") },
                    { new Guid("53472c47-a418-48d1-969f-ee3ee2862709"), "Dove Inc", 4.0, new Guid("6bc5b792-2633-463b-8868-835d783c6ec9") },
                    { new Guid("5626480e-e493-4665-a49b-33f0df80ea23"), "Amazon Ltd", 4.0, new Guid("76939832-8847-4b22-9564-b43b68ce5146") },
                    { new Guid("569a8312-c0a8-4807-85fd-42293b35fab9"), "Amazon Ltd", 4.0, new Guid("b773d007-2bd8-4ab1-a704-7ac7dbec959a") },
                    { new Guid("7410b8cc-4739-4af1-b7b5-371f245d1307"), "Louis Vuitton", 4.0, new Guid("5f2f2c95-0e40-41e8-9022-5b3cd3ca9573") },
                    { new Guid("8154db0c-ae3f-4a85-8439-0e79f66a51d8"), "Shodagor Ltd", 4.0, new Guid("c4d65fa0-255c-4ca9-bc98-84d826677b6b") },
                    { new Guid("84739c97-6473-4548-9aa0-99aed2e57230"), "Acer Ltd", 4.0, new Guid("44c10cb8-643b-4595-9cb5-09b197213b65") },
                    { new Guid("87600fba-1192-46a3-a02c-6fdbf95bb429"), "Oppo Ltd", 4.0, new Guid("7f7a5c64-8abf-4128-b572-9cf67d5c8528") },
                    { new Guid("9fcdaa7c-a530-4d54-ae5f-f45300f4c4b7"), "3W CLINIC", 4.0, new Guid("dbb9bd99-dee3-403c-8338-1f01f8db3b29") },
                    { new Guid("a36a49e3-48e8-45e6-bf16-6e3306136d25"), "Shahriar Watch House", 4.0, new Guid("ff2c59d4-a590-48bc-b19c-a0ef50b958a4") },
                    { new Guid("ae0f0ad6-b4d7-45ce-9fc3-4b5fb9f6ae06"), "Dove Inc", 4.0, new Guid("d8dcb7b6-97a1-440a-bf75-a945f2907b98") },
                    { new Guid("bab213be-033b-4a59-b843-8eae023399a2"), "Unbranded", 4.0, new Guid("59be1a14-520d-42a7-8e2c-bec3c5c2f196") },
                    { new Guid("bb48ee16-faac-475d-9fde-c2b610a7bb7f"), "Shahriar Watch House", 4.0, new Guid("1824d3bc-35bb-4846-bae8-62c7651b68b9") },
                    { new Guid("cde6e6d7-7fad-47f3-87fd-ecd7b8ec649e"), "Tiaa Ltd", 4.0, new Guid("a0dfac3f-bc72-4151-9ae6-bc5c60296ea2") },
                    { new Guid("dbeb95e3-ffe5-4c04-9d2a-7ab34dc9fd2a"), "Amazon Ltd", 4.0, new Guid("d5d20b14-ddf1-4626-9a07-e46426c49862") },
                    { new Guid("dc5f9ef2-0351-4dc9-98a2-1b96603bc4e3"), "Unik", 4.0, new Guid("50c3003b-b3aa-453c-83af-084689da5cc5") },
                    { new Guid("e143c522-fc6d-43e6-9ec9-e338c8353652"), "Asus Ltd", 4.0, new Guid("34ae4315-f07c-48cf-bd85-e87371a2da38") },
                    { new Guid("fd6b8954-d2d1-482d-9c97-5844a4d08b6c"), "Lenovo Ltd", 4.0, new Guid("d05feba0-59fa-4ef3-9532-abf161421864") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "515775a3-c22c-48eb-8b7b-cd4cf711e2b6", 0, 36, new DateTime(2024, 6, 14, 16, 43, 37, 989, DateTimeKind.Local).AddTicks(3001), "68bec36d-2bd8-43c0-a23f-b08f6af48415", "oleitao@gmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd33c10e-f5d0-40f8-8ed7-9376d7231a35", false, null });
        }
    }
}
