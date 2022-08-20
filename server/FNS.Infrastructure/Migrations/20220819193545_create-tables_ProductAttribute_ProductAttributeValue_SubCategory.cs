using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class createtables_ProductAttribute_ProductAttributeValue_SubCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.RenameColumn(
                name: "AddedAt",
                table: "SubCategories",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "AddedAt",
                table: "Products",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "SubCategories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<bool>(
                name: "Tumbstone",
                table: "SubCategories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Instant>(
                name: "CreatedAt",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<bool>(
                name: "Tumbstone",
                table: "Products",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ClrType = table.Column<string>(type: "text", nullable: false),
                    Measure = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Tumbstone = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductAttributeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false),
                    Tumbstone = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ProductAttributeValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "Id", "ClrType", "Measure", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "String", null, "Model" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "String", null, "Socket" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Int32", null, "Release year" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Int32", null, "Total number of cores" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "String", null, "Maximum threads" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16609377451241870L), "Et quo blanditiis dolor iste sint quo quo eligendi. Officia voluptatem aut qui ab sed est nihil et quae. Aliquid voluptas reprehenderit. Fugiat sed vel eveniet ullam dolores voluptas qui quia.\n\nFuga dolores iste cumque. Voluptatibus aliquam nisi quia eum perferendis. Alias omnis deserunt. Maiores voluptate quis inventore ratione dolor illo nobis assumenda. Quidem numquam eum occaecati.\n\nIpsa repellat sed quia nemo. Autem sequi et enim ut non. Autem consequuntur officiis cum assumenda ipsum. Nihil autem repellendus nisi non enim repudiandae sit.\n\nAut maxime dolorem rerum nemo reiciendis impedit qui ut. Dolorem qui deleniti iure sapiente sit. Eius sunt facilis. Dolorem libero veniam.\n\nAt aut doloribus ut eum veniam odio perferendis et laborum. At molestias pariatur et possimus esse sed omnis beatae officia. Ut earum quod voluptatibus. Quis quia et totam et asperiores eius placeat. Dolorem eos consequatur atque dolores sunt adipisci a." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16609377451315136L), "In nobis odit aliquam. Cumque a in quo autem nobis eveniet odit qui. Qui eius perspiciatis dolorum minus dolor enim. Nihil repellat eveniet eius consequatur. Dolores est quasi magni aspernatur cum aut aliquid.\n\nVoluptates nihil dicta repellendus quia nostrum asperiores ea odit. Est adipisci ut minus earum. Dolores et numquam molestiae eos consequatur vero unde. Voluptatem esse aspernatur eos.\n\nNostrum quas nobis nihil. Pariatur harum aliquid corporis dolor rerum. Sit dignissimos aut cupiditate nihil velit voluptatem quis. Rerum iste consequuntur esse quos quaerat praesentium voluptas accusantium. Tenetur voluptatibus id qui ut eos sed saepe.\n\nIpsa ratione nesciunt libero molestiae. In velit consectetur quae. Error sint sint et.\n\nError eaque similique. In ut tempora nostrum iusto sint. Unde aut laboriosam veritatis itaque. Voluptatem accusantium aliquid necessitatibus laudantium qui cumque beatae quod laboriosam. Illo velit aliquid. Velit asperiores enim numquam dolores sequi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16609377451326437L), "Voluptatem doloribus et sit. Placeat impedit ut pariatur ut quis quo suscipit. Officia facilis doloribus est earum ullam consequuntur aut sed vitae. Voluptas est pariatur nam rerum eius alias laboriosam eligendi voluptatem. Corporis corporis et modi autem ipsum dolore voluptate. Aut aut perspiciatis.\n\nNemo ut aliquid atque atque a pariatur officia omnis harum. Ex sunt sint. Dolores sit et dolorem sint non illo.\n\nRecusandae eum ullam natus. Sint harum sit delectus dolores veniam sint voluptas. Molestias in dolor voluptatem in amet autem veniam illum aut. Perspiciatis esse soluta id amet iure.\n\nAut est non sit ut veniam et dignissimos nihil cumque. Cupiditate unde nihil ipsum qui nemo dolor. Ullam tenetur quis aut. Consequatur enim fugiat voluptatem est laborum quasi.\n\nExpedita voluptatibus non iusto. Excepturi iure eius eos dicta cupiditate amet deserunt suscipit. Facere molestiae minus iste adipisci." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedAt", "Description", "Name", "Price", "ProductCode" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16609377451337429L), "Et perspiciatis adipisci eveniet consequatur voluptatibus nesciunt. Ea pariatur porro voluptatibus perspiciatis recusandae. Officiis incidunt earum sit quaerat quisquam inventore.\n\nCupiditate ipsum itaque. Quam sunt rem voluptates et. Cum dolorem consectetur nihil sunt nisi harum dignissimos rerum. Iste blanditiis quia earum voluptatem.\n\nFacere quia ipsa consequuntur nam quam in distinctio blanditiis voluptatem. Accusamus error expedita. Assumenda magni illo numquam incidunt eligendi.\n\nEaque omnis ea. Deserunt architecto adipisci voluptas expedita laborum natus voluptatibus itaque at. Dolores voluptatem necessitatibus saepe ut repellat voluptas voluptas.\n\nDelectus perferendis consequatur aliquam ratione voluptatem vel quis aut. Vitae sint ut quam nemo. Voluptatum ipsa aspernatur soluta omnis aut molestiae. Earum veritatis assumenda rerum sed in tenetur consectetur. Pariatur ipsam quasi voluptatibus harum autem reprehenderit maxime. Facilis tenetur et ea.", "AMD Ryzen 5 5600X OEM", 16199m, "4721161" });

            migrationBuilder.InsertData(
                table: "ProductAttributeValues",
                columns: new[] { "Id", "CreatedAt", "ProductAttributeId", "ProductId", "Tumbstone", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AMD Ryzen 5 3600 OEM" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AM4" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "2019" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "6" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000001"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "12" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AMD Ryzen 5 3600 BOX" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AM4" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000002"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "2019" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000002"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "6" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000002"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "12" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000003"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AMD Ryzen 5 4650G OEM" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000003"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AM4" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "2020" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000003"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "6" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "12" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AMD Ryzen 5 5600X OEM" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000004"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "AM4" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "2020" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "6" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), NodaTime.Instant.FromUnixTimeTicks(0L), new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000004"), false, NodaTime.Instant.FromUnixTimeTicks(0L), "12" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductAttributeId",
                table: "ProductAttributeValues",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeValues_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductAttributeValues");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Tumbstone",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Tumbstone",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "SubCategories",
                newName: "AddedAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Products",
                newName: "AddedAt");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "AddedAt", "Description" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16608536934491412L), "Labore iusto quidem non eos tempora impedit qui minima. Quis autem nihil suscipit dolores fugiat in omnis. Ut vero quisquam omnis culpa. Rem explicabo fuga. Perspiciatis esse facere incidunt beatae inventore qui. Enim minima alias doloribus possimus aspernatur dolorum omnis porro officia.\n\nMinima qui eum aut velit voluptatem cum delectus voluptatem. Adipisci sit vel quia aliquid. Ullam voluptas aperiam est sapiente. At consequatur vel. Quia nihil aut. Sed tenetur asperiores quibusdam quia.\n\nCorporis nostrum in nihil. Nostrum non qui in quaerat animi. Qui et omnis nemo fugiat. Et sit porro alias veniam magnam.\n\nPorro eligendi eius quidem quas eos impedit quis. Laudantium rerum eligendi dolorum soluta officiis commodi. Optio dolorum aliquam dolores. Et aliquid est labore. In placeat soluta soluta cum a.\n\nCorporis ipsum sint culpa velit iusto reiciendis. Id occaecati quas in. Aut cum mollitia id quasi magnam adipisci." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "AddedAt", "Description" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16608536934561874L), "Veritatis aut iusto quibusdam. Dolore consequatur debitis. Explicabo et sed. Labore enim non voluptas itaque praesentium facere pariatur. Qui nemo iste omnis. Optio et iusto non.\n\nPariatur nobis vel molestias quod aspernatur molestiae voluptas nesciunt quo. Vitae inventore id sit est. Officiis fugit explicabo quia ea at doloribus. Quae iusto totam.\n\nNobis tempora totam sed. Est qui natus mollitia aut qui voluptas. Et aut ut amet expedita esse magnam aut. Quod corporis adipisci doloremque sed. Veniam eaque qui illum.\n\nConsequatur aut laboriosam magni ut. Maiores quia quia fugit. Qui et voluptatem perferendis dolor qui doloremque cum. Veritatis voluptatem placeat accusantium dolorem error nisi soluta non non. Ex corrupti eaque.\n\nAut delectus aut et aut qui praesentium ut. Accusamus incidunt et qui in quo aliquam ad quod. Aut nihil aut qui quaerat incidunt exercitationem qui." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "AddedAt", "Description" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16608536934573251L), "Consequatur in quidem sequi et excepturi. Nostrum sit deleniti cumque. Et sunt expedita eius dolores occaecati autem perferendis quo non.\n\nReprehenderit nihil quos et qui aut maiores facilis reiciendis consequatur. Quia deserunt itaque ipsam. Illo excepturi eius aut libero officiis impedit explicabo perspiciatis est. Ratione possimus consequuntur cumque.\n\nEveniet vero pariatur nam omnis corporis explicabo culpa. Rem ex quod tempore voluptate porro. Et voluptatibus ratione.\n\nDignissimos aperiam aut. Numquam quaerat nulla. Aut ea voluptatum veritatis omnis vel repellat. Qui et autem nam voluptatem. Voluptatem et maiores omnis in.\n\nAssumenda molestias nihil dolores optio unde illum sequi. Ratione ea sint quia repellat. Similique veritatis esse porro placeat expedita sed magnam pariatur deleniti." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "AddedAt", "Description", "Name", "Price", "ProductCode" },
                values: new object[] { NodaTime.Instant.FromUnixTimeTicks(16608536934584475L), "Dignissimos sed beatae aspernatur enim enim aliquid ut saepe. Deleniti reiciendis nam omnis unde velit voluptas eligendi. Sit harum quae omnis sunt sit. Eveniet at magnam cupiditate consequatur necessitatibus velit.\n\nAliquid voluptates a sint omnis. Sit commodi sapiente quia voluptatibus. Autem natus neque reiciendis vel in ut.\n\nIn qui cum. Labore corporis rerum. Nam odit enim recusandae doloribus nulla eum.\n\nAsperiores modi voluptatem non. Alias qui similique nihil aut ut et. In eaque est quia dicta blanditiis. Perspiciatis voluptatem eligendi consequatur qui. Voluptate aspernatur quia.\n\nTempora consequuntur perspiciatis voluptatibus natus iste. Saepe doloremque recusandae aut iusto. Possimus est rerum aperiam. Natus occaecati veniam repellat dolore quia sed. Eos atque pariatur aut.", "AMD Ryzen 5 5600G OEM", 14899m, "4819672" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedAt", "Description", "Name", "Price", "ProductCode", "SubCategoryId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), NodaTime.Instant.FromUnixTimeTicks(16608536934595627L), "Perspiciatis ea exercitationem soluta sapiente modi quasi soluta omnis. Perferendis itaque ut vitae dignissimos ad rerum nesciunt aut. Ea iure rerum rerum laboriosam perferendis consequuntur modi dicta.\n\nDolore quod consectetur. Et alias mollitia porro necessitatibus. Odit deleniti veniam fugiat.\n\nOfficia laborum aspernatur magni itaque. Eum reiciendis illum voluptate reiciendis iusto. Provident laudantium ut velit quos doloribus veniam harum cum sint. Ullam rerum dolores rerum itaque ipsam amet sit. Qui aspernatur culpa molestiae autem at commodi itaque quia accusamus.\n\nOccaecati asperiores pariatur vitae rem eos dignissimos enim laboriosam. Nisi aut dolores impedit. Pariatur libero quia dolores omnis in. Aliquid et et debitis sunt aut quaerat.\n\nEt magni sed. Optio culpa voluptas sit. Est officia quo reiciendis rerum fugit aut nemo dignissimos eveniet. Laboriosam nihil molestiae fuga. Harum suscipit ab.", "AMD Ryzen 5 5600X OEM", 16199m, "4721161", new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
