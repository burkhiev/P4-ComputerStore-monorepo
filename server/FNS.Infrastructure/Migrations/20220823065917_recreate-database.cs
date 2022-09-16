using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class recreatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ClrType = table.Column<string>(type: "text", nullable: false),
                    Measure = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ProductCode = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false, defaultValue: 0m),
                    SubCategoryId = table.Column<string>(type: "text", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeValues",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    ProductAttributeId = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartsWithProducts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    IsPaid = table.Column<bool>(type: "boolean", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartsWithProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartsWithProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartsWithProducts_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "Id", "ClrType", "Measure", "Name" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "String", null, "Model" },
                    { "00000000-0000-0000-0000-000000000002", "String", null, "Socket" },
                    { "00000000-0000-0000-0000-000000000003", "Int32", null, "Release year" },
                    { "00000000-0000-0000-0000-000000000004", "Int32", null, "Total number of cores" },
                    { "00000000-0000-0000-0000-000000000005", "String", null, "Maximum threads" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                column: "Id",
                values: new object[]
                {
                    "00000000-0000-0000-0000-000000000001",
                    "00000000-0000-0000-0000-000000000002",
                    "00000000-0000-0000-0000-000000000003"
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "Процессоры" },
                    { "00000000-0000-0000-0000-000000000002", "Материские платы" },
                    { "00000000-0000-0000-0000-000000000003", "Видеокарты" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 0, "44ddd5aa-8d47-42f8-9d26-2bcf071f242b", "user1@gmail.ru", false, false, null, null, null, null, null, false, "4d0d8161-e997-4104-b031-726b20f5013a", "00000000-0000-0000-0000-000000000001", false, "user1" },
                    { "00000000-0000-0000-0000-000000000002", 0, "77c09761-cf3e-4ec7-a16c-10a46c9b5f00", "user2@gmail.ru", false, false, null, null, null, null, null, false, "1d7be924-a8fa-4824-82e4-fe7364259405", "00000000-0000-0000-0000-000000000002", false, "user2" },
                    { "00000000-0000-0000-0000-000000000003", 0, "5921cd2d-373b-451f-8f0b-2a9e57179008", "admin@yandex.ru", false, false, null, null, null, null, null, false, "0da60b13-92bb-4d38-9244-f4e770d59ad4", "00000000-0000-0000-0000-000000000003", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProductCode", "SubCategoryId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "Perferendis doloribus consectetur quas atque. Aut deleniti ut. Illum blanditiis necessitatibus non rem reiciendis ut. Voluptatem qui vel sunt ut est ipsum commodi optio sed.\n\nIn dolorem odit. In dolores aut. Et hic voluptatem voluptatem optio non mollitia. Exercitationem ratione sed et enim in aut.\n\nQuo quis neque vel et eum odio in adipisci. Aut sit sed doloremque sint. Accusantium voluptatem ea recusandae et vel nulla sed doloremque. Eaque dignissimos aperiam corrupti dolor.\n\nVoluptatem repellendus ut voluptatibus ullam voluptatem necessitatibus non. Autem soluta aperiam quae at nemo accusantium. Non recusandae voluptatum neque ducimus omnis nam quo tempore sit.\n\nUt eos reprehenderit et accusantium voluptate nobis exercitationem illo sint. Qui odio omnis sunt numquam. Est repellendus velit voluptas labore ut.", "AMD Ryzen 5 3600 OEM", 12599m, "1372637", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "Ut ut odio et corporis blanditiis. Quibusdam eum cum fuga. Optio eligendi delectus velit delectus iste aspernatur veritatis inventore minima. Quis et consequatur nostrum dolorem. Ullam dignissimos error iusto neque est saepe ipsa autem. Omnis ratione magnam dolore dicta magnam fugiat velit.\n\nInventore sed sed quia qui. Consectetur quo distinctio et molestiae voluptatibus voluptatem. Dolore magni fuga unde.\n\nIllo earum at et quo dignissimos cumque ut non ut. Quidem autem sequi temporibus voluptatibus aliquid odit cumque optio distinctio. Sed molestias sed est facere.\n\nVelit aspernatur modi tempora nostrum sint velit illo neque. Veritatis odio cupiditate quia eaque. Dicta praesentium omnis qui laudantium repellat at sed quod reiciendis.\n\nAt voluptates qui rerum voluptatum adipisci dolorem ad quo. Dignissimos est sapiente. Suscipit aliquam ullam ipsa. Est inventore sequi suscipit optio iste rerum ipsam. Illo omnis sed maxime expedita nobis et.", "AMD Ryzen 5 3600 BOX", 12899m, "5059834", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", "Enim corrupti odio rerum ducimus. Perspiciatis quo rerum voluptas fugit quaerat necessitatibus iure provident. Harum dicta nam iusto libero. Consequuntur suscipit ea.\n\nOmnis totam sunt aut nam rerum. Dolor odio provident quaerat atque. Esse ea error distinctio modi accusamus ex quam neque.\n\nPerferendis dolores quidem quo qui. Beatae et sequi eum aut et veritatis voluptas. Culpa esse cupiditate ut.\n\nLaudantium non ut reiciendis officia hic est reiciendis deleniti. Deleniti quibusdam qui ullam. Ut libero facilis.\n\nPossimus nemo est quo. Sint voluptatem aperiam vel consequatur. Quis illum officia nihil aliquid quaerat et qui.", "AMD Ryzen 5 PRO 4650G OEM", 12599m, "1689358", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000004", "Vel eligendi natus blanditiis quia voluptatem et. Dolorem quidem dolorem fugiat. Ut ea quia harum.\n\nEst soluta ut libero. Dolor ullam aliquam. Consectetur exercitationem architecto.\n\nNecessitatibus fuga excepturi suscipit id culpa qui soluta. Quam nam voluptatem praesentium aperiam quia. Cupiditate et autem accusamus cupiditate eum.\n\nSint quam ipsa explicabo magnam ratione aut. Dolor rerum sunt non qui culpa nemo. Dolores deleniti blanditiis consequatur voluptates nihil et fuga. Aut facere ut suscipit veritatis commodi ipsam. Ratione eaque facilis dolores qui nostrum possimus neque quis. Minima quod autem cum et.\n\nVoluptatem vel similique minus est asperiores. Quos cupiditate non labore et dolore libero non. Qui in aut quia rerum aspernatur minima. Exercitationem labore est enim consequuntur voluptas dolorum omnis.", "AMD Ryzen 5 5600X OEM", 16199m, "4721161", "00000000-0000-0000-0000-000000000001" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributeValues",
                columns: new[] { "Id", "ProductAttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001", "AMD Ryzen 5 3600 OEM" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001", "AM4" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001", "2019" },
                    { "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001", "6" },
                    { "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000001", "12" },
                    { "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002", "AMD Ryzen 5 3600 BOX" },
                    { "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002", "AM4" },
                    { "00000000-0000-0000-0000-000000000008", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000002", "2019" },
                    { "00000000-0000-0000-0000-000000000009", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002", "6" },
                    { "00000000-0000-0000-0000-000000000010", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000002", "12" },
                    { "00000000-0000-0000-0000-000000000011", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003", "AMD Ryzen 5 4650G OEM" },
                    { "00000000-0000-0000-0000-000000000012", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000003", "AM4" },
                    { "00000000-0000-0000-0000-000000000013", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003", "2020" },
                    { "00000000-0000-0000-0000-000000000014", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000003", "6" },
                    { "00000000-0000-0000-0000-000000000015", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000003", "12" },
                    { "00000000-0000-0000-0000-000000000016", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000004", "AMD Ryzen 5 5600X OEM" },
                    { "00000000-0000-0000-0000-000000000017", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000004", "AM4" },
                    { "00000000-0000-0000-0000-000000000018", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000004", "2020" },
                    { "00000000-0000-0000-0000-000000000019", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000004", "6" },
                    { "00000000-0000-0000-0000-000000000020", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000004", "12" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCartsWithProducts",
                columns: new[] { "Id", "Amount", "IsPaid", "ProductId", "ShoppingCartId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 1, false, "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000002", 2, false, "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", 1, true, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000004", 1, false, "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001" }
                });

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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShoppingCartId",
                table: "AspNetUsers",
                column: "ShoppingCartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductAttributeId",
                table: "ProductAttributeValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartsWithProducts_ProductId",
                table: "ShoppingCartsWithProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartsWithProducts_ShoppingCartId",
                table: "ShoppingCartsWithProducts",
                column: "ShoppingCartId");
        }

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
                name: "ProductAttributeValues");

            migrationBuilder.DropTable(
                name: "ShoppingCartsWithProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
