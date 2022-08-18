using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false),
                    AddedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    ProductCode = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false, defaultValue: 0m),
                    SubCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false),
                    AddedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Процессоры" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Материские платы" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Видеокарты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedAt", "Description", "Name", "Price", "ProductCode", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), NodaTime.Instant.FromUnixTimeTicks(16608526099241543L), "Exercitationem ducimus dolorum aut maxime inventore. Illo occaecati ut molestias sint sunt rerum voluptatibus expedita est. Autem sit consequatur sed. Deleniti qui hic odio odio voluptatem rem doloribus blanditiis. Voluptas a vitae possimus alias provident sed quo.\n\nDoloremque sapiente ipsa ab voluptas. A asperiores magni. Nesciunt et autem. Veritatis omnis vitae excepturi minus vitae dolores explicabo. Est dolorum itaque rem et aut odit.\n\nPorro mollitia quidem maxime magni aut beatae. Qui autem ut. Magni asperiores et ut sit autem quo. Quia debitis unde vitae voluptatem reprehenderit nulla animi. Aliquam aliquid aut excepturi et laborum.", "AMD Ryzen 5 3600 OEM", 12599m, "1372637", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), NodaTime.Instant.FromUnixTimeTicks(16608526099547725L), "Eum vero possimus incidunt eos. Ut iure itaque. Illum animi autem aut ab. Voluptatem voluptatem tempore vitae autem laboriosam. Quia quibusdam et excepturi. Culpa est nisi eveniet et praesentium ut in minima.\n\nCupiditate aliquid est dolor expedita in tenetur est. Placeat est qui earum id impedit sed corporis. Est corporis corporis. Et non ut recusandae ab quibusdam.\n\nMagnam quos et optio. Non et et recusandae dolores aperiam quaerat. Id qui consequatur reprehenderit quisquam est provident qui in. Et recusandae dolore exercitationem omnis praesentium officiis dignissimos deserunt quisquam.", "AMD Ryzen 5 3600 BOX", 12899m, "5059834", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), NodaTime.Instant.FromUnixTimeTicks(16608526099548149L), "Repellat sit et nisi. Et commodi dolor nihil. Doloremque nostrum blanditiis facilis impedit voluptate illo eius enim. Ut ducimus nihil temporibus explicabo reprehenderit quae et laborum.\n\nNihil minima neque illo a. Cumque vero maiores dolores vel. Et totam optio vitae sapiente fugiat dolorum sed. Enim non dolorem esse est voluptas qui sit voluptatem rem.\n\nSapiente ex suscipit et saepe molestiae aliquam dolores. Recusandae quam esse veritatis et est. Pariatur id voluptatem. Numquam perferendis id nemo quasi minus. Quas occaecati explicabo rerum reiciendis et rerum debitis molestiae.", "AMD Ryzen 5 PRO 4650G OEM", 12599m, "1689358", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), NodaTime.Instant.FromUnixTimeTicks(16608526099548540L), "Rerum ab dolorem. Est quaerat nostrum. Rerum et iusto dolorem magnam. Quia qui voluptas nesciunt debitis expedita sequi repellat ut. Dolorem velit placeat est ex rerum qui rem.\n\nDolorum corrupti voluptatum occaecati accusamus enim iure autem aliquid. Cum deleniti similique inventore. Quae illum rem quis fugit quia et voluptas. Dolorem in et facere in maxime et delectus magni dolor.\n\nAut voluptatibus eligendi explicabo. Eius amet qui molestiae sequi et asperiores expedita. Magnam quisquam laboriosam qui at ea facilis nisi. Reprehenderit doloremque impedit laboriosam occaecati expedita et possimus porro aut.", "AMD Ryzen 5 5600G OEM", 14899m, "4819672", new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), NodaTime.Instant.FromUnixTimeTicks(16608526099548877L), "Atque incidunt temporibus est assumenda deleniti sequi dolores. Corrupti expedita iusto et. Vel omnis et itaque. In ad fugiat fugit quisquam. Quo in delectus ducimus.\n\nLaborum maxime rerum et nobis aut. Qui quas sunt. Occaecati illo occaecati nam. Amet occaecati natus.\n\nQui nemo aut est in doloribus odit. Laborum enim ipsum eveniet sit magnam molestiae. Aut et quos. Doloremque mollitia eveniet repellat accusamus harum sapiente rerum ex. Odio ullam odit et est vitae.", "AMD Ryzen 5 5600X OEM", 16199m, "4721161", new Guid("00000000-0000-0000-0000-000000000001") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
