using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altertable__tablesall__addcolumnsCreatedAt_UpdatedAt__createtable__tableProductAttributeGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "SubCategories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "ShoppingCarts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "ShoppingCarts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<Instant>(
                name: "CreatedAt",
                table: "ShoppingCartItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(Instant),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "ShoppingCartItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "SalesReceiptsWithProducts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "SalesReceiptsWithProducts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "SalesReceipts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "PurchaseInvoices",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "PurchaseInvoiceItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "PurchaseInvoiceItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "ProductBalances",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "ProductBalances",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "ProductAttributeValues",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<string>(
                name: "GroupId",
                table: "ProductAttributes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "ProductAttributes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "AspNetRoles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<Instant>(
                name: "UpdatedAt",
                table: "AspNetRoles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "AspNetRoles",
                type: "xid",
                rowVersion: true,
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.CreateTable(
                name: "ProductAttributeGroup",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeGroup", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "eaf44339-7526-461d-909a-d909f6ebfdf6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "3328c008-8b8c-40c3-be86-4787b3f8d3f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6891078-0eb8-4586-89a3-4dd4fbf18913", "AQAAAAEAACcQAAAAEJ9WTlKMiX0Gf73CCUD0+8nTgWrGA/thnXVHJUD4XW4dWi7I2ULXm67oBQewMTkkQA==", "e0d81d84-c467-433e-bfa8-9a181a464e1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a64999b-3fa3-4db8-84b8-47b3cde4d962", "AQAAAAEAACcQAAAAECF5MYhD7goDfuvfDOoXqt1RPnyW08b4Y6lvq9y//dfxe0Rg41U1gWi0fEJPl7znGQ==", "872a4f85-1984-452c-aadd-ae1a519f66c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e4c0cc-7d94-479b-abe1-2f53f3e9db0d", "AQAAAAEAACcQAAAAEHoy2SekRNEvVWx5Rpf+8Ftr9i9MIeq6TH8naEl8X3Ev6oq/EFJ64uBuCGH4MIkUGQ==", "d7ecb5c5-765e-4b5b-be4b-943fb12cfed3" });

            migrationBuilder.InsertData(
                table: "ProductAttributeGroup",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "Общие параметры" },
                    { "00000000-0000-0000-0000-000000000002", "Параметры процессора" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Facere reprehenderit consequatur quia vel recusandae quos. Exercitationem sint commodi ad ut et. Nam non voluptate et et sint et hic qui. Quia natus inventore adipisci dolorem dolorem ut quod deleniti.\n\nCorporis in beatae sed ea non non quae maiores. Et officiis molestias quis dignissimos. Blanditiis dolores officia et amet quidem odit est illo.\n\nOmnis illum voluptatem. Repudiandae dignissimos eligendi harum minima ducimus exercitationem enim. Voluptatem quos id voluptatibus.\n\nNon ut ut. Molestiae porro eum. Dolor consequatur dolorum blanditiis.\n\nDistinctio odit fugiat maiores rerum. Sunt ea aspernatur dolores minima consequatur dignissimos dolorem et velit. Incidunt ad vero id enim. Est sunt molestiae qui hic. Sit asperiores numquam saepe quia dolores neque et. Qui ut sunt blanditiis quae quo qui dolore sed.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Nostrum quod dolor porro quas sit porro consequuntur veritatis voluptatem. Voluptas dolore architecto enim qui. Doloremque accusantium debitis soluta explicabo architecto ad natus. Aliquid ea corrupti quia et.\n\nHic blanditiis molestias tenetur dolores laudantium numquam odio dolorem ut. Numquam earum ea. Voluptatum odit magni minus qui corrupti ducimus.\n\nVoluptatem quam possimus accusamus maiores. Quibusdam dolorem dolorum distinctio. Ipsum aliquid quam quisquam. Iure doloremque labore rerum qui quae. Incidunt quos sequi modi.\n\nRerum omnis laboriosam omnis maxime quisquam. Dolorum beatae possimus. Ducimus modi aut quia sunt non. Cum ut iure aut ut sit et. Voluptas tenetur impedit. Velit numquam officiis et harum.\n\nInventore dolorem consequuntur ut et debitis quasi. Repudiandae assumenda a. Doloremque et reiciendis reiciendis sed id asperiores impedit voluptatem voluptatem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Id doloribus ea. Facilis expedita eligendi et sint sit voluptas corrupti autem placeat. Suscipit similique non. Quia aspernatur voluptatum.\n\nPlaceat eaque aliquam distinctio assumenda. Rerum voluptates voluptatem architecto voluptatem atque. Quos non quis. Sit impedit magnam amet facere sit ut dolore aut.\n\nEligendi architecto non repellat eum. Voluptas delectus nemo quidem provident voluptatem. Suscipit repellendus consequatur magni quia maiores voluptatem.\n\nQuia in fuga officia. Rem itaque aliquam. Eos totam aut laudantium voluptatem ut numquam molestiae ut. Adipisci aperiam qui voluptatum quam eos enim consectetur.\n\nOccaecati ut perferendis. Incidunt excepturi id ipsam doloribus cupiditate. Quis autem laboriosam dolores sequi aut quis in. Qui consequuntur hic.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Est eius recusandae autem deserunt laboriosam sapiente. Nostrum adipisci sequi sed et illum. Enim corporis aut laboriosam voluptas. Itaque aut dolorem temporibus assumenda quasi eaque et. Omnis reprehenderit perspiciatis.\n\nItaque et sint. Dolorem dolorem nostrum. Aut perferendis iure.\n\nA eligendi et. Dolorem et aspernatur accusamus occaecati fugit nisi. Harum a totam sapiente. Voluptatem facilis consectetur distinctio eaque labore et quis.\n\nSed vel quia facere. Cum beatae autem at adipisci cupiditate asperiores. Nisi aliquid autem sequi earum itaque eligendi velit consequatur nisi. Necessitatibus quaerat illo pariatur.\n\nSaepe officia velit et. Qui ut delectus et ad. Aut est quos rerum et quibusdam consequatur officia. Et aut eos magnam et impedit porro. Delectus cupiditate voluptatum. Sunt ut et molestiae saepe ut et recusandae.");

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "GroupId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "GroupId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "GroupId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "GroupId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                column: "GroupId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_GroupId",
                table: "ProductAttributes",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeGroup_Name",
                table: "ProductAttributeGroup",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributes_ProductAttributeGroup_GroupId",
                table: "ProductAttributes",
                column: "GroupId",
                principalTable: "ProductAttributeGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributes_ProductAttributeGroup_GroupId",
                table: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "ProductAttributeGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductAttributes_GroupId",
                table: "ProductAttributes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SalesReceipts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PurchaseInvoices");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PurchaseInvoiceItems");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PurchaseInvoiceItems");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductBalances");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductBalances");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductAttributeValues");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "ProductAttributes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductAttributes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<Instant>(
                name: "CreatedAt",
                table: "ShoppingCartItems",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(Instant),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "6a269003-f65b-4d07-93a9-5c4776667d94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "81c81d73-ccab-4d49-9641-98a773269782");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6409408-1654-4ed3-a5cd-dfedf7c5ac2c", "AQAAAAEAACcQAAAAEOyyWzhhNRVI6IuxKScFJ3KfcLWfNCeDGDlExBXQWqd/ijc5AvSSS7iAa7pYarp9dg==", "9891bccb-4f97-4c22-9477-bb52030682af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ba23ed-2468-4191-a3fe-778be918ef99", "AQAAAAEAACcQAAAAEFqTMtl2Buab9OeyZ/R82Md4gGn5yZSwTom9+a3cQiKSB0NsAoO2gmN7YX5HAEvqzg==", "d7ea9a1e-0134-498b-8180-72ba02a2a7f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45e7fc40-21bf-4b04-8282-171aa0661fe1", "AQAAAAEAACcQAAAAEABq8ljRBUeoOn5ltNVqs7hO/JZSEzQxBSKnPcRGZeFWo7dLr196YFANdFlEeDhjUw==", "bb9d18a5-ebed-4464-8ef9-cc95194b3bab" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Aliquam voluptas eaque molestias modi debitis. Ut eaque autem dolorem odit autem quam. Saepe reprehenderit et. Repellat ipsa facilis voluptatem cum ex quis minus.\n\nMagni culpa suscipit. Nisi pariatur dolores error neque qui. In hic culpa. Voluptatem corrupti ad ex deserunt rerum ullam neque ea. Ipsam atque esse sit placeat velit. Voluptates excepturi at dolorum.\n\nRatione quis similique facere nobis quod ipsum eum nihil tempora. Consequuntur beatae voluptates rerum expedita aperiam aperiam. Suscipit nulla eius voluptatem deserunt omnis magni quia sit.\n\nVoluptas nam et et non. Placeat accusamus consequuntur et eveniet a repellendus. Iure voluptatem quod veniam possimus non.\n\nEt quia voluptatem fuga. Eveniet at optio at omnis labore quas ad rem aut. Aut debitis corporis dolorum quia sunt. Accusantium autem reprehenderit fugit. Numquam asperiores quaerat unde optio tempore saepe excepturi aliquam aut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Minima magni numquam non odit in. Consectetur qui inventore doloribus quia cumque aut ipsa. Praesentium minima et quia. Sed recusandae quos vel voluptates. Laudantium delectus illum expedita quas corporis.\n\nMagni dolor ullam sequi. Non ut suscipit rem maxime voluptate ea ut vel maiores. Illum cumque delectus perferendis non ut aut.\n\nDoloribus accusantium quasi architecto. Veniam est ipsum optio expedita necessitatibus maxime pariatur numquam. Alias nisi quis corrupti et adipisci rerum cum expedita. Accusantium hic delectus optio tenetur nihil incidunt reiciendis quasi qui.\n\nCumque cupiditate molestiae omnis ut ut iure magnam. Similique non eius. Eum doloribus laudantium. Qui placeat voluptas incidunt aut inventore dolor omnis.\n\nNobis incidunt natus et dolores debitis odit quae et. Ea magni praesentium modi labore sit ad possimus. Molestiae repudiandae harum sit qui quo. Quo sequi asperiores ea ullam. Consectetur sunt accusantium dolorum aliquid et at illo qui.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Autem eveniet blanditiis rerum. Eum voluptatibus qui temporibus. Iure iusto in. Sunt provident magnam.\n\nVoluptates odit quia. Voluptate vel nesciunt magnam excepturi. Porro sit totam et autem ut itaque sint aspernatur.\n\nImpedit tenetur qui praesentium nostrum cupiditate qui est et ratione. Debitis quibusdam molestiae at voluptatem velit qui omnis. Id perspiciatis est repellat. Magnam vel qui possimus consequatur nemo dolores.\n\nArchitecto quaerat tenetur. Iste hic ab et eaque et. Dolor blanditiis modi voluptatibus.\n\nAut modi nam. Nisi earum provident eaque minima enim accusantium non fuga ab. Pariatur unde laborum necessitatibus qui aut. Est molestiae sint vitae nisi ut est qui. Quia eius perferendis deleniti. Ipsum laboriosam est neque.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Esse quia rerum necessitatibus optio rerum. Vel beatae aut eum et est nobis. Dolores ea reiciendis ut repudiandae.\n\nNihil earum consequatur aut rerum corporis nisi deleniti. Et ab est quia quisquam atque harum. Iure natus quo. Officia quod deleniti perferendis et commodi eum.\n\nEt optio officiis quia possimus. Dolores hic voluptatem excepturi sunt. Corporis in est corporis consectetur molestias et earum voluptate.\n\nDistinctio aliquam libero iste ut sequi excepturi perferendis aliquam ipsum. Consequatur voluptatem veniam corporis aut quo ullam enim. Et incidunt maxime et. Eaque omnis ab rerum exercitationem voluptatem voluptate dolores.\n\nRerum aut minima illum sequi corrupti quo fugiat. Tempora quia vel dolor ut sint voluptatem. Consequuntur aliquid autem. Dicta rerum ex. Voluptatibus sunt modi doloremque voluptatem odio non magni omnis.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16377733999179049L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16503567552544784L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16569135710474366L));
        }
    }
}
