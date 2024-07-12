using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(name: "Image_Url", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Body = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsBodyHtml = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subject = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShopAvatars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Publicid = table.Column<string>(name: "Public_id", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopAvatars", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birthday = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Hobby = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    RefreshToken = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ratings = table.Column<double>(type: "double", nullable: false),
                    ShopAvatarId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProductId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_ShopAvatars_ShopAvatarId",
                        column: x => x.ShopAvatarId,
                        principalTable: "ShopAvatars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subject = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discountprice = table.Column<int>(name: "Discount_price", type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Totalsell = table.Column<int>(name: "Total_sell", type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ShopId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ShopId1 = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Shops_ShopId1",
                        column: x => x.ShopId1,
                        principalTable: "Shops",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ImageUrls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Publicid = table.Column<string>(name: "Public_id", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUrls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUrls_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Comment = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId1 = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "68f4b448-d1a0-4a93-a8c0-ef72d7de073e", null, "Administrator", "ADMINISTRATOR" },
                    { "c538e741-669e-4e9a-9c49-42f12883603c", null, "User", "USER" },
                    { "c7e4b83a-4e72-45bd-a89c-3d87f2067fbc", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image_Url", "SubTitle", "Title" },
                values: new object[,]
                {
                    { new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "https://cdn.shopify.com/s/files/1/1706/9177/products/NEWAppleMacbookProwithM1ProChip14InchLaptop2021ModelMKGQ3LL_A_16GB_1TBSSD_custommacbd.jpg?v=1659592838", "", "Computers and Laptops" },
                    { new Guid("6e27b4b8-e66c-450a-bf41-58344b208513"), "https://indian-retailer.s3.ap-south-1.amazonaws.com/s3fs-public/2021-07/kosme1.png", "", "cosmetics and body care" }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "Body", "Content", "IsBodyHtml", "Priority", "Subject" },
                values: new object[,]
                {
                    { new Guid("06d36b5b-d52e-4328-9a8a-2db972b119a1"), "<body style=\"font-family: 'Poppins', Arial, sans-serif\">\r\n    <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n        <tr>\r\n            <td align=\"center\" style=\"padding: 20px;\">\r\n                <table class=\"content\" width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse: collapse; border: 1px solid #cccccc;\">\r\n                    <!-- Header -->\r\n                    <tr>\r\n                        <td class=\"header\" style=\"background-color: #345C72; padding: 40px; text-align: center; color: white; font-size: 24px;\">\r\n                        [TITLE]\r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Body -->\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                        Hello, All! <br>\r\n                        [CONTENT]\r\n                        <br><br>\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit. Incidunt, officia facilis  atque? Ipsam voluptas fugiat distinctio blanditiis veritatis.            \r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Call to action Button -->\r\n                    <tr>\r\n                        <td style=\"padding: 0px 40px 0px 40px; text-align: center;\">\r\n                            <!-- CTA Button -->\r\n                            <table cellspacing=\"0\" cellpadding=\"0\" style=\"margin: auto;\">\r\n                                <tr>\r\n                                    <td align=\"center\" style=\"background-color: #345C72; padding: 10px 20px; border-radius: 5px;\">\r\n                                        <a href=\"https://www.yourwebsite.com\" target=\"_blank\" style=\"color: #ffffff; text-decoration: none; font-weight: bold;\">Book a Free Consulatation</a>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit.             \r\n                        </td>\r\n                    </tr>\r\n                    <!-- Footer -->\r\n                    <tr>\r\n                        <td class=\"footer\" style=\"background-color: #333333; padding: 40px; text-align: center; color: white; font-size: 14px;\">\r\n                        Copyright &copy; 2024 | Your brand name\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>", "newsletter email 1", true, 0, "Newslatter email 1" },
                    { new Guid("3a18dd76-edf5-4541-b54c-943fd6e1f176"), "<body style=\"font-family: 'Poppins', Arial, sans-serif\">\r\n    <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n        <tr>\r\n            <td align=\"center\" style=\"padding: 20px;\">\r\n                <table class=\"content\" width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse: collapse; border: 1px solid #cccccc;\">\r\n                    <!-- Header -->\r\n                    <tr>\r\n                        <td class=\"header\" style=\"background-color: #345C72; padding: 40px; text-align: center; color: white; font-size: 24px;\">\r\n                        [TITLE]\r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Body -->\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                        Hello, All! <br>\r\n                        [CONTENT]\r\n                        <br><br>\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit. Incidunt, officia facilis  atque? Ipsam voluptas fugiat distinctio blanditiis veritatis.            \r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Call to action Button -->\r\n                    <tr>\r\n                        <td style=\"padding: 0px 40px 0px 40px; text-align: center;\">\r\n                            <!-- CTA Button -->\r\n                            <table cellspacing=\"0\" cellpadding=\"0\" style=\"margin: auto;\">\r\n                                <tr>\r\n                                    <td align=\"center\" style=\"background-color: #345C72; padding: 10px 20px; border-radius: 5px;\">\r\n                                        <a href=\"https://www.yourwebsite.com\" target=\"_blank\" style=\"color: #ffffff; text-decoration: none; font-weight: bold;\">Book a Free Consulatation</a>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit.             \r\n                        </td>\r\n                    </tr>\r\n                    <!-- Footer -->\r\n                    <tr>\r\n                        <td class=\"footer\" style=\"background-color: #333333; padding: 40px; text-align: center; color: white; font-size: 14px;\">\r\n                        Copyright &copy; 2024 | Your brand name\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>", "email de pagamento", true, 0, "Email payment" },
                    { new Guid("ab93ad1d-fb5a-4fb2-bd71-8c4b1baec9ae"), "<body style=\"font-family: 'Poppins', Arial, sans-serif\">\r\n    <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\r\n        <tr>\r\n            <td align=\"center\" style=\"padding: 20px;\">\r\n                <table class=\"content\" width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"border-collapse: collapse; border: 1px solid #cccccc;\">\r\n                    <!-- Header -->\r\n                    <tr>\r\n                        <td class=\"header\" style=\"background-color: #345C72; padding: 40px; text-align: center; color: white; font-size: 24px;\">\r\n                        [TITLE]\r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Body -->\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                        Hello, All! <br>\r\n                        [CONTENT]\r\n                        <br><br>\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit. Incidunt, officia facilis  atque? Ipsam voluptas fugiat distinctio blanditiis veritatis.            \r\n                        </td>\r\n                    </tr>\r\n\r\n                    <!-- Call to action Button -->\r\n                    <tr>\r\n                        <td style=\"padding: 0px 40px 0px 40px; text-align: center;\">\r\n                            <!-- CTA Button -->\r\n                            <table cellspacing=\"0\" cellpadding=\"0\" style=\"margin: auto;\">\r\n                                <tr>\r\n                                    <td align=\"center\" style=\"background-color: #345C72; padding: 10px 20px; border-radius: 5px;\">\r\n                                        <a href=\"https://www.yourwebsite.com\" target=\"_blank\" style=\"color: #ffffff; text-decoration: none; font-weight: bold;\">Book a Free Consulatation</a>\r\n                                    </td>\r\n                                </tr>\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"body\" style=\"padding: 40px; text-align: left; font-size: 16px; line-height: 1.6;\">\r\n                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam corporis sint eum nemo animi velit exercitationem impedit.             \r\n                        </td>\r\n                    </tr>\r\n                    <!-- Footer -->\r\n                    <tr>\r\n                        <td class=\"footer\" style=\"background-color: #333333; padding: 40px; text-align: center; color: white; font-size: 14px;\">\r\n                        Copyright &copy; 2024 | Your brand name\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>", "https://localhost:5000/api/v1.1/email/accountvalidation", true, 0, "Email account validation" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Subject", "Discount_price", "Name", "Price", "Rating", "ShopId", "ShopId1", "Stock", "Total_sell" },
                values: new object[,]
                {
                    { new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "MacBook pro M2 chipset 256gb ssd 8gb ram space-gray color with apple 1 year warranty", 0, 0, new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), null, 0, 0 },
                    { new Guid("398e76bb-70f0-4712-af76-10726bb6dd93"), new Guid("6e27b4b8-e66c-450a-bf41-58344b208512"), "Product details are a crucial part of any eCommerce website or online marketplace. These details help the potential customers to make an informed decision about the product they are interested in buying. A well-written product description can also be a powerful marketing tool that can help to increase sales.Product details typically include information about the products features, specifications, dimensions, weight, materials, and other relevant information that can help customers to understand the product better. The product details section should also include high-quality images and videos of the product, as well as customer reviews and ratings.", 0, "Iphone 14 pro max 256 gb ssd and 8 gb ram silver colour", 0, 0, new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "ShopAvatars",
                columns: new[] { "Id", "Public_id", "Url" },
                values: new object[] { new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc"), "test", "https://www.hatchwise.com/wp-content/uploads/2022/05/amazon-logo-1024x683.png" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "Gender", "Hobby", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "efbcf454-0125-41ff-ac91-75d1564af044", 0, 36, new DateTime(2024, 7, 11, 19, 12, 38, 416, DateTimeKind.Local).AddTicks(2569), "90657188-d507-4708-a7c2-26ce7d780325", "cp5469@protonmail.com", false, "oliveira leitao", "M", "netflix", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e31ec530-bace-4ce6-989e-776bbeef479b", false, "oleitao" },
                    { "efbcf454-0125-41ff-ac91-75d1564af045", 0, 51, new DateTime(2024, 7, 11, 19, 12, 38, 416, DateTimeKind.Local).AddTicks(2640), "b475672b-985a-4d03-9f6d-f873b66452e4", "olivleitao@gmail.com", false, "luis figo", "M", "cinema", false, null, null, null, null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a0847929-4d9d-4997-9502-94be2f84833b", false, "figolu" }
                });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "ProductId", "Public_id", "Url" },
                values: new object[,]
                {
                    { new Guid("1b129a29-08a4-4597-8708-092f202bd123"), new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), "test1", "https://www.istorebangladesh.com/images/thumbs/0000286_macbook-pro-m1_550.png" },
                    { new Guid("48366c80-fd5f-421e-8a43-9f2fa65c0ba2"), new Guid("398e76bb-70f0-4712-af76-10726bb6dd93"), "test2", "https://www.custommacbd.com/cdn/shop/products/AppleMacBookProwithM2chip2022model_8GB_256GB_CustomMacBD_540x.jpg?v=1659438499" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "UserId", "UserId1" },
                values: new object[] { new Guid("a1c922f3-95a9-45aa-a45c-d573166852ce"), "comment", new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), 5, new Guid("efbcf454-0125-41ff-ac91-75d1564af044"), null });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Name", "ProductId", "Ratings", "ShopAvatarId" },
                values: new object[] { new Guid("c2264d48-6f36-4b1a-bf95-3c62f67f2ac0"), "Apple inc", new Guid("398e76bb-70f0-4712-af76-10726bb6dd92"), 4.0, new Guid("41635d09-6c09-40cd-89c5-17f81ab497fc") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageUrls_ProductId",
                table: "ImageUrls",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopId1",
                table: "Products",
                column: "ShopId1");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId1",
                table: "Reviews",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ShopAvatarId",
                table: "Shops",
                column: "ShopAvatarId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "ImageUrls");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "ShopAvatars");
        }
    }
}
