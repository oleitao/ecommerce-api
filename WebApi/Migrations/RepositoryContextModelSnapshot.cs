﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Repository;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "52597751-662e-4fc3-92f6-4e9438af1b2d",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "bcad7d8c-a0e7-4b78-821d-ef647bb95cbd",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "7b836505-baac-4167-9536-8858245d61cd",
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
                        .HasColumnName("Description");

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
                            Id = new Guid("57fbe976-6cd5-4ea1-8ac3-decfc9ddeeca"),
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
                            Birthday = new DateTime(2024, 7, 2, 11, 48, 9, 861, DateTimeKind.Local).AddTicks(5424),
                            ConcurrencyStamp = "30f7b2da-34d1-4d73-b8be-ddb44992b17d",
                            Email = "oleitao@gmail.com",
                            EmailConfirmed = false,
                            FullName = "oliveira leitao",
                            Gender = "M",
                            Hobby = "netflix",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "def73a2a-1e2d-4808-84c9-5a4a722a6070",
                            TwoFactorEnabled = false
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
