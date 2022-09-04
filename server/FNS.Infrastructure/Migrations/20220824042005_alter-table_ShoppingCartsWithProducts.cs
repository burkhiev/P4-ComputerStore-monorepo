using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class altertable_ShoppingCartsWithProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues");

            migrationBuilder.DropTable(
                name: "ShoppingCartsWithProducts");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ShoppingCartId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ShoppingCarts",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "AspNetUsers",
                type: "xid",
                rowVersion: true,
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "ShoppingCartItems",
                columns: new[] { "Id", "Amount", "ProductId", "ShoppingCartId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 1, "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000002", 2, "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", 1, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000004", 1, "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001" }
                });

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "UserId",
                value: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ShoppingCartId",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ShoppingCartsWithProducts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "text", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "ShoppingCartId" },
                values: new object[] { "44ddd5aa-8d47-42f8-9d26-2bcf071f242b", "4d0d8161-e997-4104-b031-726b20f5013a", "00000000-0000-0000-0000-000000000001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "ShoppingCartId" },
                values: new object[] { "77c09761-cf3e-4ec7-a16c-10a46c9b5f00", "1d7be924-a8fa-4824-82e4-fe7364259405", "00000000-0000-0000-0000-000000000002" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "ShoppingCartId" },
                values: new object[] { "5921cd2d-373b-451f-8f0b-2a9e57179008", "0da60b13-92bb-4d38-9244-f4e770d59ad4", "00000000-0000-0000-0000-000000000003" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Perferendis doloribus consectetur quas atque. Aut deleniti ut. Illum blanditiis necessitatibus non rem reiciendis ut. Voluptatem qui vel sunt ut est ipsum commodi optio sed.\n\nIn dolorem odit. In dolores aut. Et hic voluptatem voluptatem optio non mollitia. Exercitationem ratione sed et enim in aut.\n\nQuo quis neque vel et eum odio in adipisci. Aut sit sed doloremque sint. Accusantium voluptatem ea recusandae et vel nulla sed doloremque. Eaque dignissimos aperiam corrupti dolor.\n\nVoluptatem repellendus ut voluptatibus ullam voluptatem necessitatibus non. Autem soluta aperiam quae at nemo accusantium. Non recusandae voluptatum neque ducimus omnis nam quo tempore sit.\n\nUt eos reprehenderit et accusantium voluptate nobis exercitationem illo sint. Qui odio omnis sunt numquam. Est repellendus velit voluptas labore ut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Ut ut odio et corporis blanditiis. Quibusdam eum cum fuga. Optio eligendi delectus velit delectus iste aspernatur veritatis inventore minima. Quis et consequatur nostrum dolorem. Ullam dignissimos error iusto neque est saepe ipsa autem. Omnis ratione magnam dolore dicta magnam fugiat velit.\n\nInventore sed sed quia qui. Consectetur quo distinctio et molestiae voluptatibus voluptatem. Dolore magni fuga unde.\n\nIllo earum at et quo dignissimos cumque ut non ut. Quidem autem sequi temporibus voluptatibus aliquid odit cumque optio distinctio. Sed molestias sed est facere.\n\nVelit aspernatur modi tempora nostrum sint velit illo neque. Veritatis odio cupiditate quia eaque. Dicta praesentium omnis qui laudantium repellat at sed quod reiciendis.\n\nAt voluptates qui rerum voluptatum adipisci dolorem ad quo. Dignissimos est sapiente. Suscipit aliquam ullam ipsa. Est inventore sequi suscipit optio iste rerum ipsam. Illo omnis sed maxime expedita nobis et.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Enim corrupti odio rerum ducimus. Perspiciatis quo rerum voluptas fugit quaerat necessitatibus iure provident. Harum dicta nam iusto libero. Consequuntur suscipit ea.\n\nOmnis totam sunt aut nam rerum. Dolor odio provident quaerat atque. Esse ea error distinctio modi accusamus ex quam neque.\n\nPerferendis dolores quidem quo qui. Beatae et sequi eum aut et veritatis voluptas. Culpa esse cupiditate ut.\n\nLaudantium non ut reiciendis officia hic est reiciendis deleniti. Deleniti quibusdam qui ullam. Ut libero facilis.\n\nPossimus nemo est quo. Sint voluptatem aperiam vel consequatur. Quis illum officia nihil aliquid quaerat et qui.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Vel eligendi natus blanditiis quia voluptatem et. Dolorem quidem dolorem fugiat. Ut ea quia harum.\n\nEst soluta ut libero. Dolor ullam aliquam. Consectetur exercitationem architecto.\n\nNecessitatibus fuga excepturi suscipit id culpa qui soluta. Quam nam voluptatem praesentium aperiam quia. Cupiditate et autem accusamus cupiditate eum.\n\nSint quam ipsa explicabo magnam ratione aut. Dolor rerum sunt non qui culpa nemo. Dolores deleniti blanditiis consequatur voluptates nihil et fuga. Aut facere ut suscipit veritatis commodi ipsam. Ratione eaque facilis dolores qui nostrum possimus neque quis. Minima quod autem cum et.\n\nVoluptatem vel similique minus est asperiores. Quos cupiditate non labore et dolore libero non. Qui in aut quia rerum aspernatur minima. Exercitationem labore est enim consequuntur voluptas dolorum omnis.");

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
                name: "IX_AspNetUsers_ShoppingCartId",
                table: "AspNetUsers",
                column: "ShoppingCartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartsWithProducts_ProductId",
                table: "ShoppingCartsWithProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartsWithProducts_ShoppingCartId",
                table: "ShoppingCartsWithProducts",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartId",
                table: "AspNetUsers",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
