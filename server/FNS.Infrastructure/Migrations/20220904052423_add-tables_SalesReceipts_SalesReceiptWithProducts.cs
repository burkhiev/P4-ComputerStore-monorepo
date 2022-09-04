using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class addtables_SalesReceipts_SalesReceiptWithProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesReceipts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReceipts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesReceiptsWithProducts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    SalesReceiptId = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceiptsWithProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReceiptsWithProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReceiptsWithProducts_SalesReceipts_SalesReceiptId",
                        column: x => x.SalesReceiptId,
                        principalTable: "SalesReceipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01573a66-6f9e-4bfd-b1ab-d713ddd04768", "ae2730d7-569a-49d3-9890-4e615ac7e4df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "694efe14-534a-4586-aa47-636369b73407", "7374f215-f985-44e1-849b-abcae3dd3737" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3fa80ad-7a20-488a-bb45-9bd25ee9212c", "512b72a5-767f-41f4-88bb-d65a8deb06eb" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Eos temporibus et temporibus. Sit et et sunt in minima. Ratione a pariatur qui ex. Debitis voluptatem soluta porro dolor et iusto eveniet.\n\nTemporibus quidem vel aliquid ea dolorem vero corporis eum ut. Illo ut non rem ad ut corporis eius sunt. Nihil cumque eaque aut sed tempore.\n\nNatus minus quibusdam et esse odio tenetur nostrum veritatis. Dignissimos distinctio facere facere molestias quo voluptas voluptatem aspernatur et. Omnis ea ea consectetur nesciunt laborum iste.\n\nQuibusdam quia reiciendis quia voluptas blanditiis facere optio. Quia ea autem dolor quaerat. Facere quam quis aut et deleniti qui aut cum rerum. Veritatis sed nulla ipsa est vitae natus sint qui. Recusandae nisi officia laudantium excepturi commodi rerum consequatur voluptatem.\n\nIpsum eligendi est perferendis incidunt aut tempore. Unde consectetur perferendis aperiam. Aut soluta aut tenetur qui aspernatur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Qui aut quia omnis maxime voluptas qui dolores et sunt. Laborum aliquid eius dolore labore nulla magni. Natus aut quo repudiandae nam recusandae ut magnam. Suscipit natus accusamus consequatur eveniet blanditiis ipsa dolorem provident dicta. Doloribus beatae sit officiis.\n\nVoluptas facere excepturi ab veritatis et sint fugit nam ut. Quisquam nesciunt laudantium aspernatur iure. Minus mollitia laborum ut. Et officia architecto repellendus nemo qui alias non.\n\nEt labore voluptatem mollitia quasi culpa. Facere unde est. Ut eaque pariatur laudantium dicta perferendis. Ipsum odit fuga blanditiis.\n\nEt voluptate et consequatur sed sequi repudiandae saepe. Nam voluptatem minima sed sed et ipsa veniam dolores. Sint dicta veritatis illo molestiae possimus enim dolorem.\n\nNatus ipsam adipisci dolores voluptatem asperiores. Unde consequatur quis laudantium aut. Fuga aspernatur enim dicta libero.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Illum omnis ducimus sunt officiis repudiandae. Est aspernatur officiis minima odit earum aspernatur earum est eius. Praesentium eveniet numquam et reprehenderit sed harum.\n\nAtque earum fugit placeat quaerat exercitationem enim voluptates fuga. Sed recusandae quos nihil ut omnis repellat. Velit cum facere cupiditate veniam asperiores iusto ipsum.\n\nRepellat laudantium animi neque et quia. Numquam quia veniam deleniti quis et. Est at et autem minima. Ea reiciendis sequi rerum beatae qui earum omnis explicabo.\n\nCum deleniti saepe sint facere laudantium vero. Corrupti voluptatem ab fugiat ut et magnam iure. Et consequatur ex atque nisi fugit possimus error impedit.\n\nIusto sed id consequatur qui. Numquam laudantium aperiam quidem corporis magni voluptas accusantium facilis quo. Ab consequuntur omnis perspiciatis blanditiis omnis.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Laborum tenetur labore. Sint cum temporibus rerum quidem. Nesciunt omnis rerum illum. Dolorum ipsa magni adipisci voluptatem enim qui cupiditate.\n\nSoluta animi odio maiores repellat voluptatem eligendi. Libero aliquam harum ex et cum qui officia sed dolore. Optio ut autem sed incidunt est. Nobis sunt sed quia repellat temporibus qui.\n\nQuo magni aliquam. Exercitationem tempore ducimus consectetur sed natus est. Illo nisi officiis.\n\nTenetur eum blanditiis tempora doloremque asperiores in laboriosam natus. Est delectus reiciendis sit. Labore quae quas praesentium sapiente quas aperiam et culpa eos. Est voluptas nam numquam consequatur hic.\n\nAtque rerum odio repellat ducimus aut perferendis quaerat commodi recusandae. Officia officia quas aut perspiciatis ratione sunt porro non. Aut nihil asperiores nihil adipisci tempore fugit.");

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "SalesReceiptsWithProducts",
                columns: new[] { "Id", "Amount", "ProductId", "SalesReceiptId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 1, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", 1, "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", 1, "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" },
                    { "00000000-0000-0000-0000-000000000004", 1, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceipts_UserId",
                table: "SalesReceipts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptsWithProducts_ProductId",
                table: "SalesReceiptsWithProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceiptsWithProducts_SalesReceiptId",
                table: "SalesReceiptsWithProducts",
                column: "SalesReceiptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesReceiptsWithProducts");

            migrationBuilder.DropTable(
                name: "SalesReceipts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6ac16e7-b4e0-4ae8-9a38-2a1bfa8be723", "973bcd53-443b-43ea-a72d-bf638aae9214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5088a58-e273-491e-a199-0df54c929b9a", "576c82db-f1ad-4e71-948c-9f9e947cd2e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58afb2cc-59b0-41c3-a794-3a1fce2bae5c", "fbdf8731-d164-4bf0-96f0-0e0fdffa8b8d" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Consequuntur maxime animi optio vel quo saepe aut molestias numquam. Distinctio temporibus provident dolorum ab autem non ut accusantium ut. Id perspiciatis enim commodi maiores animi ipsum aut iste. Officia praesentium natus animi nemo aut delectus vero. Amet modi sed.\n\nMaxime aut inventore. Quisquam non a. Ullam enim quia iure in illo maiores.\n\nQuia et dicta labore. At odio modi magnam. Quis magnam hic. Dolores sunt assumenda ut ad et laborum. Optio aut vitae aliquam impedit.\n\nFacere tenetur sed aperiam ea labore necessitatibus et. Voluptas beatae error sed similique. Fugit excepturi omnis. Aut aut autem.\n\nId unde voluptas nemo omnis atque molestiae voluptatem cupiditate. Aut earum et aspernatur et placeat laudantium animi. Est asperiores autem et rerum inventore asperiores dolorum quasi aliquam. Quas ut iure eaque cum id dolore magni. Impedit quasi qui quam eos et facilis beatae.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Possimus incidunt voluptas vitae culpa sunt adipisci accusamus facere. Omnis quidem quis libero. Sit nihil expedita tempore sunt rerum a quas doloribus at. Alias molestiae itaque non.\n\nFuga qui distinctio omnis facilis eos dolore occaecati impedit et. At voluptatem laboriosam officiis aut aut laborum officiis velit. Tenetur consequatur provident ab impedit vel voluptatibus quo voluptatem. Maiores iste incidunt error id qui est ut. Magnam consectetur earum quas commodi aut laborum sint.\n\nQui sunt adipisci. Debitis enim magni dolores autem et sed. Nulla eius et officia sed eos.\n\nAmet exercitationem et et. Voluptatem nisi quod. Fugiat aliquid ut unde. Laborum voluptas est ut eum. Quia iste sapiente qui. Ab dicta ut in vel qui quo.\n\nLaborum placeat est quo pariatur provident perspiciatis. Dolorem accusamus sapiente enim quia neque totam. Saepe quia recusandae sunt libero est earum non. Sint qui perspiciatis sequi aut unde est aperiam. Accusamus nostrum corrupti odio quod vero.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Quam eum atque. Nihil voluptatem excepturi voluptatem. Officiis et nemo sint earum dolores laborum in.\n\nDolorem et minima. Culpa veritatis et non. Corporis molestias eos.\n\nLabore quidem veritatis expedita enim ullam quia consequatur ea. Officiis et minus. Voluptatem similique ut eveniet. Sint nihil deserunt odio dignissimos.\n\nRecusandae quos tempore omnis repellendus reprehenderit. Quia autem cum ratione enim debitis quo. Possimus qui similique.\n\nEos nisi ratione facere consectetur libero. Quia molestiae reprehenderit natus voluptas aspernatur quia. Iure sunt quia et pariatur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Nostrum qui consequatur. Illum molestiae cum facere molestias distinctio sed ea molestiae nulla. Velit eos ab fugit enim iure. Dolores ut tempora.\n\nQuos nihil pariatur. Excepturi iste ducimus ea quis error voluptate ullam. Inventore aut iusto sit sit perferendis nulla dolores ad.\n\nQuibusdam voluptatem autem quibusdam. Harum culpa nemo ipsa et libero. Nihil quisquam et suscipit assumenda. Perferendis quos sunt accusantium vel. Cupiditate voluptatem voluptatem dolores ab.\n\nNostrum qui unde impedit et quo et sint. Earum ex tenetur. Ipsum consectetur autem omnis dignissimos blanditiis nihil non labore dolorem. Sed dolorem aut esse enim voluptas voluptatibus laudantium.\n\nEnim qui dolor velit et distinctio. Aliquam quia id maiores. Repellendus officiis accusantium quos. Consequatur molestiae voluptas velit assumenda commodi quas.");
        }
    }
}
