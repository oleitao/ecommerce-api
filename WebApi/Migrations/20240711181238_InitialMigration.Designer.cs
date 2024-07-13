﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Repository;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240711181238_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c538e741-669e-4e9a-9c49-42f12883603c",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "c7e4b83a-4e72-45bd-a89c-3d87f2067fbc",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "68f4b448-d1a0-4a93-a8c0-ef72d7de073e",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Model.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<string>("Image_Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Image_Url");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("SubTitle");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"),
                            ImageUrl = "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838",
                            SubTitle = "",
                            Title = "Computers and Laptops"
                        },
                        new
                        {
                            Id = new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"),
                            ImageUrl = "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png",
                            SubTitle = "",
                            Title = "cosmetics and body care"
                        });
                });

            modelBuilder.Entity("Model.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsBodyHtml")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Emails", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab93ad1d-fb5a-4fb2-bd71-8c4b1baec9ae"),
                            Body = "<body style=\"font-family: 'Poppins', Arial, sans-serif\">\r\n    <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n        <tr>\r\n            <td align=\"center\" style=\"padding: 20px;\">\r\n                <table class=\"content\" width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse: collapse; border: 1px solid #cccccc;\">\r\n                    <!-- Header -->\r\n                    <tr>\r\n                        <td class=\"header\" style=\"background-color: #345C72; padding: 40px; text-align: center; color: white; font-size: 24px;\">\r\n                        [TITLE]\r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Body -->\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                        Hello, All! <br>\r\n                        [CONTENT]\r\n                        <br><br>\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit. Incidunt, officia facilis  atque? Ipsam voluptas fugiat distinctio blanditiis veritatis.            \r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Call to action Button -->\r\n                    <tr>\r\n                        <td style=\"padding: 0px 40px 0px 40px; text-align: center;\">\r\n                            <!-- CTA Button -->\r\n                            <table cellspacing=\"0\" cellpadding=\"0\" style=\"margin: auto;\">\r\n                                <tr>\r\n                                    <td align=\"center\" style=\"background-color: #345C72; padding: 10px 20px; border-radius: 5px;\">\r\n                                        <a href=\"https://www.yourwebsite.com\" target=\"_blank\" style=\"color: #ffffff; text-decoration: none; font-weight: bold;\">Book a Free Consulatation</a>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit.             \r\n                        </td>\r\n                    </tr>\r\n                    <!-- Footer -->\r\n                    <tr>\r\n                        <td class=\"footer\" style=\"background-color: #333333; padding: 40px; text-align: center; color: white; font-size: 14px;\">\r\n                        Copyright &copy; 2024 | Your brand name\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>",
                            Content = "https://localhost:8080/api/v1.1/email/accountvalidation",
                            IsBodyHtml = true,
                            Priority = 0,
                            Subject = "Email account validation"
                        },
                        new
                        {
                            Id = new Guid("3a18dd76-edf5-4541-b54c-943fd6e1f176"),
                            Body = "<body style=\"font-family: 'Poppins', Arial, sans-serif\">\r\n    <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n        <tr>\r\n            <td align=\"center\" style=\"padding: 20px;\">\r\n                <table class=\"content\" width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse: collapse; border: 1px solid #cccccc;\">\r\n                    <!-- Header -->\r\n                    <tr>\r\n                        <td class=\"header\" style=\"background-color: #345C72; padding: 40px; text-align: center; color: white; font-size: 24px;\">\r\n                        [TITLE]\r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Body -->\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                        Hello, All! <br>\r\n                        [CONTENT]\r\n                        <br><br>\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit. Incidunt, officia facilis  atque? Ipsam voluptas fugiat distinctio blanditiis veritatis.            \r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Call to action Button -->\r\n                    <tr>\r\n                        <td style=\"padding: 0px 40px 0px 40px; text-align: center;\">\r\n                            <!-- CTA Button -->\r\n                            <table cellspacing=\"0\" cellpadding=\"0\" style=\"margin: auto;\">\r\n                                <tr>\r\n                                    <td align=\"center\" style=\"background-color: #345C72; padding: 10px 20px; border-radius: 5px;\">\r\n                                        <a href=\"https://www.yourwebsite.com\" target=\"_blank\" style=\"color: #ffffff; text-decoration: none; font-weight: bold;\">Book a Free Consulatation</a>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit.             \r\n                        </td>\r\n                    </tr>\r\n                    <!-- Footer -->\r\n                    <tr>\r\n                        <td class=\"footer\" style=\"background-color: #333333; padding: 40px; text-align: center; color: white; font-size: 14px;\">\r\n                        Copyright &copy; 2024 | Your brand name\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>",
                            Content = "email de pagamento",
                            IsBodyHtml = true,
                            Priority = 0,
                            Subject = "Email payment"
                        },
                        new
                        {
                            Id = new Guid("06d36b5b-d52e-4328-9a8a-2db972b119a1"),
                            Body = "<body style=\"font-family: 'Poppins', Arial, sans-serif\">\r\n    <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n        <tr>\r\n            <td align=\"center\" style=\"padding: 20px;\">\r\n                <table class=\"content\" width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse: collapse; border: 1px solid #cccccc;\">\r\n                    <!-- Header -->\r\n                    <tr>\r\n                        <td class=\"header\" style=\"background-color: #345C72; padding: 40px; text-align: center; color: white; font-size: 24px;\">\r\n                        [TITLE]\r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Body -->\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                        Hello, All! <br>\r\n                        [CONTENT]\r\n                        <br><br>\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit. Incidunt, officia facilis  atque? Ipsam voluptas fugiat distinctio blanditiis veritatis.            \r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Call to action Button -->\r\n                    <tr>\r\n                        <td style=\"padding: 0px 40px 0px 40px; text-align: center;\">\r\n                            <!-- CTA Button -->\r\n                            <table cellspacing=\"0\" cellpadding=\"0\" style=\"margin: auto;\">\r\n                                <tr>\r\n                                    <td align=\"center\" style=\"background-color: #345C72; padding: 10px 20px; border-radius: 5px;\">\r\n                                        <a href=\"https://www.yourwebsite.com\" target=\"_blank\" style=\"color: #ffffff; text-decoration: none; font-weight: bold;\">Book a Free Consulatation</a>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit.             \r\n                        </td>\r\n                    </tr>\r\n                    <!-- Footer -->\r\n                    <tr>\r\n                        <td class=\"footer\" style=\"background-color: #333333; padding: 40px; text-align: center; color: white; font-size: 14px;\">\r\n                        Copyright &copy; 2024 | Your brand name\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>",
                            Content = "newsletter email 1",
                            IsBodyHtml = true,
                            Priority = 0,
                            Subject = "Newslatter email 1"
                        });
                });

            modelBuilder.Entity("Model.ImageUrl", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ProductId");

                    b.Property<string>("Public_id")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Public_id");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ImageUrls", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1b129a29-08a4-4597-8708-092f202bd123"),
                            ProductId = new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"),
                            Publicid = "test1",
                            Url = "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png"
                        },
                        new
                        {
                            Id = new Guid("48366c80-fd5f-421e-8a43-9f2fa65c0ba2"),
                            ProductId = new Guid("398e76bb-70f0-4712-af76-10726bb6dd93"),
                            Publicid = "test2",
                            Url = "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499"
                        });
                });

            modelBuilder.Entity("Model.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Subject");

                    b.Property<int>("Discount_price")
                        .HasColumnType("int")
                        .HasColumnName("Discount_price");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Name");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("Price");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("Rating");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ShopId");

                    b.Property<Guid?>("ShopId1")
                        .HasColumnType("char(36)");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("Stock");

                    b.Property<int>("Total_sell")
                        .HasColumnType("int")
                        .HasColumnName("Total_sell");

                    b.HasKey("Id");

                    b.HasIndex("ShopId1");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"),
                            CategoryId = new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"),
                            Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                            Discountprice = 0,
                            Name = "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty",
                            Price = 0,
                            Rating = 0,
                            ShopId = new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"),
                            Stock = 0,
                            Totalsell = 0
                        },
                        new
                        {
                            Id = new Guid("398e76bb-70f0-4712-af76-10726bb6dd93"),
                            CategoryId = new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"),
                            Description = "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.",
                            Discountprice = 0,
                            Name = "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour",
                            Price = 0,
                            Rating = 0,
                            ShopId = new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"),
                            Stock = 0,
                            Totalsell = 0
                        });
                });

            modelBuilder.Entity("Model.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Comment");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ProductId");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("Rating");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)")
                        .HasColumnName("UserId");

                    b.Property<string>("UserId1")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId1");

                    b.ToTable("Reviews", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1c922f3-95a9-45aa-a45c-d573166852ce"),
                            Comment = "comment",
                            ProductId = new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"),
                            Rating = 5,
                            UserId = new Guid("efbcf454-0125-41ff-ac91-75d1564af044")
                        });
                });

            modelBuilder.Entity("Model.Shop", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Name");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Ratings")
                        .HasColumnType("double")
                        .HasColumnName("Ratings");

                    b.Property<Guid>("ShopAvatarId")
                        .HasColumnType("char(36)")
                        .HasColumnName("ShopAvatarId");

                    b.HasKey("Id");

                    b.HasIndex("ShopAvatarId");

                    b.ToTable("Shops", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"),
                            Name = "Apple inc",
                            ProductId = new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"),
                            Ratings = 4.0,
                            ShopAvatarId = new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc")
                        });
                });

            modelBuilder.Entity("Model.ShopAvatar", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<string>("Public_id")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Public_id");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Url");

                    b.HasKey("Id");

                    b.ToTable("ShopAvatars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"),
                            Publicid = "test",
                            Url = "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png"
                        });
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("Age");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Birthday");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FullName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Gender");

                    b.Property<string>("Hobby")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Hobby");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "efbcf454-0125-41ff-ac91-75d1564af044",
                            AccessFailedCount = 0,
                            Age = 36,
                            Birthday = new DateTime(2024, 7, 11, 19, 12, 38, 416, DateTimeKind.Local).AddTicks(2569),
                            ConcurrencyStamp = "90657188-d507-4708-a7c2-26ce7d780325",
                            Email = "cp5469@protonmail.com",
                            EmailConfirmed = false,
                            FullName = "oliveira leitao",
                            Gender = "M",
                            Hobby = "netflix",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "e31ec530-bace-4ce6-989e-776bbeef479b",
                            TwoFactorEnabled = false,
                            UserName = "oleitao"
                        },
                        new
                        {
                            Id = "efbcf454-0125-41ff-ac91-75d1564af045",
                            AccessFailedCount = 0,
                            Age = 51,
                            Birthday = new DateTime(2024, 7, 11, 19, 12, 38, 416, DateTimeKind.Local).AddTicks(2640),
                            ConcurrencyStamp = "b475672b-985a-4d03-9f6d-f873b66452e4",
                            Email = "olivleitao@gmail.com",
                            EmailConfirmed = false,
                            FullName = "luis figo",
                            Gender = "M",
                            Hobby = "cinema",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "a0847929-4d9d-4997-9502-94be2f84833b",
                            TwoFactorEnabled = false,
                            UserName = "figolu"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.ImageUrl", b =>
                {
                    b.HasOne("Model.Product", null)
                        .WithMany("Image_Url")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Product", b =>
                {
                    b.HasOne("Model.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId1");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("Model.Review", b =>
                {
                    b.HasOne("Model.Product", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Shop", b =>
                {
                    b.HasOne("Model.ShopAvatar", "Shop_avatar")
                        .WithMany()
                        .HasForeignKey("ShopAvatarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shop_avatar");
                });

            modelBuilder.Entity("Model.Product", b =>
                {
                    b.Navigation("Image_Url");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
