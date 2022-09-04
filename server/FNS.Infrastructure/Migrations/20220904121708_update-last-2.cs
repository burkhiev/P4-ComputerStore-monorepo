using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class updatelast2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributeValues_ProductAttributes_ProductAttributeId",
                table: "ProductAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductBalances_Products_ProductId",
                table: "ProductBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoice_AspNetUsers_UserId",
                table: "PurchaseInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItem_Products_ProductId",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceId",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesReceiptsWithProducts_Products_ProductId",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesReceiptsWithProducts_SalesReceipts_SalesReceiptId",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a52e8ea1-0fab-47de-a882-467129b3a363", "bbafab93-7aab-4c3e-9eb1-abd7ff14f001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1c58f00-dd85-4944-9f32-ca068a3ca2e9", "46efbb9c-a2eb-40e3-9051-e1ed8f095fc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41a35d11-48a3-4f20-85d8-2b5077d46f30", "fca965cb-9ed9-471f-808e-a8583892d0a2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Rerum nihil asperiores blanditiis hic eos officiis suscipit officia provident. Nesciunt totam vero autem saepe harum voluptatem ut in. Sint incidunt et saepe est et nobis. Eius cupiditate eum at. Sit beatae velit dolorum soluta architecto.\n\nAut laudantium ut quia harum molestiae sapiente dolor. Ea nostrum et tempora velit sit in aperiam fuga. A numquam ea hic tempora nihil aut eaque culpa.\n\nQui vitae fuga enim vitae sunt. Ut minus eos voluptatibus eum. Quibusdam provident et. Ea nisi consequatur molestiae culpa alias.\n\nExpedita ut perspiciatis quo cum perspiciatis tempora quisquam quis. Hic qui commodi ad et autem. Dicta vero occaecati eos. Temporibus et corrupti nihil ipsam nisi. Et earum itaque eveniet et. Perferendis eveniet facere.\n\nAnimi molestias architecto illum modi cumque est. Consectetur hic voluptatem ipsa pariatur temporibus error odio sint adipisci. Hic vel voluptatem. Sit quia dignissimos et. Ducimus ea velit possimus ut rem earum.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Similique exercitationem voluptas. Ut ut suscipit suscipit non. Facilis quo eveniet et tenetur earum aspernatur. Repellendus quis rerum.\n\nDeserunt culpa nulla libero harum error impedit accusantium id dolor. Dolorem placeat saepe corrupti eum ab. Ipsam mollitia repudiandae minus provident animi et voluptas sed.\n\nEt voluptatem voluptatem quia aut. Dolorem quas adipisci. Modi perspiciatis eos ut voluptatem nesciunt fugiat atque.\n\nEsse sit autem quis recusandae commodi ut porro. Aperiam earum numquam id qui inventore sed ad at. Vel enim nesciunt qui aut aliquid eum.\n\nTotam ut aspernatur voluptatum. Ut incidunt architecto consequatur aperiam. Non ducimus officia sapiente aut. Quia sit odit aut et autem. Repellat in odio enim qui est necessitatibus.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Perspiciatis nisi nihil assumenda quo. Esse voluptatum aut. Sed magni architecto. Itaque perspiciatis voluptatem fugiat.\n\nPerferendis voluptatum animi est atque. Et aut officia quod. Libero et consequuntur facere quo deserunt. Dolores id repellat sunt provident delectus libero et ipsa est. Fugiat odit cumque qui unde consequatur aliquid optio repellat.\n\nNisi porro est atque sunt dicta. Quia et quis nemo fugiat vel laudantium ex neque. Facilis laboriosam numquam ea. Corporis molestiae cum neque aut omnis accusamus corporis laboriosam voluptas. Sunt culpa dolores atque earum. Eius sit natus sapiente qui.\n\nSimilique doloremque velit molestiae aut quo. Et consequatur autem sint ipsa suscipit incidunt porro. Id et veniam. Repudiandae voluptates et dolorum perspiciatis vel tempora id non.\n\nAsperiores quas numquam reiciendis quis. Doloremque tenetur amet nemo vel quo voluptatem sit voluptatem praesentium. Consectetur illo earum pariatur est ab aut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Est earum autem error cumque voluptas. Qui quam quia nam non autem dolores. Placeat quod voluptate porro placeat cumque suscipit aliquam sit eius. Porro cupiditate odio commodi ratione culpa provident.\n\nRem vel est sapiente. Consequatur quia sed atque enim. Cupiditate amet molestias.\n\nUt impedit et vero est alias libero ipsum fugiat id. Vel quo autem amet facere voluptates porro possimus. Qui cupiditate laudantium labore et ipsa quis nostrum cum explicabo. Cumque autem nihil natus vel sunt nesciunt qui. Quasi nam facere quidem rerum qui.\n\nDolorem aut est assumenda. Velit rerum rerum sit consequatur odio. Cupiditate tenetur at et expedita cupiditate quod voluptatem repellendus doloribus.\n\nVoluptatem inventore et atque et nam. Dolores magnam ut. Consequatur alias voluptates libero beatae adipisci. Incidunt voluptas id.");

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValues_ProductAttributes_ProductAttributeId",
                table: "ProductAttributeValues",
                column: "ProductAttributeId",
                principalTable: "ProductAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBalances_Products_ProductId",
                table: "ProductBalances",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoice_AspNetUsers_UserId",
                table: "PurchaseInvoice",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_Products_ProductId",
                table: "PurchaseInvoiceItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceId",
                table: "PurchaseInvoiceItem",
                column: "PurchaseInvoiceId",
                principalTable: "PurchaseInvoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesReceiptsWithProducts_Products_ProductId",
                table: "SalesReceiptsWithProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesReceiptsWithProducts_SalesReceipts_SalesReceiptId",
                table: "SalesReceiptsWithProducts",
                column: "SalesReceiptId",
                principalTable: "SalesReceipts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
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
                name: "FK_ProductAttributeValues_ProductAttributes_ProductAttributeId",
                table: "ProductAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductBalances_Products_ProductId",
                table: "ProductBalances");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoice_AspNetUsers_UserId",
                table: "PurchaseInvoice");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItem_Products_ProductId",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceId",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesReceiptsWithProducts_Products_ProductId",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesReceiptsWithProducts_SalesReceipts_SalesReceiptId",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6178a560-8948-4735-9840-a671c80e333e", "95c0c32b-30f1-43cd-96b1-554525eeaaf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e34c7a8e-686f-4ffa-a650-78857b3c47bd", "ca61b05e-49fb-4654-9b78-c0557aa9cad9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34c09b8c-3652-4cfd-9933-55ec8d0b0bb0", "5ac779df-ec41-474c-b38d-fe64a96d2431" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Atque iusto dolorem corrupti magni doloremque ab. Aliquam accusantium reprehenderit. Sed amet maiores eos et ullam eum saepe.\n\nLabore sed quas molestiae exercitationem laboriosam hic voluptates excepturi. Consequatur ut impedit sed. Quas qui sequi cumque molestias sed magnam. Dolores et perspiciatis ut cupiditate.\n\nId quos rem consectetur autem distinctio. Incidunt ut qui quidem. Debitis occaecati nihil incidunt quia voluptas cupiditate libero consequatur voluptatem. Accusamus itaque autem provident omnis. Facilis nobis ut. Corporis nihil iste est vel.\n\nTemporibus occaecati numquam. Officiis recusandae cupiditate amet qui vel et dolor dolorum. Aliquam culpa laboriosam expedita libero provident.\n\nExplicabo natus repellat dolorum quasi earum et neque. Voluptatem ullam quod amet ea quidem. Qui rerum ex. Quia soluta nostrum aut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Assumenda voluptatum et atque et iure sapiente facilis ipsam. Quia aperiam in delectus quia et. Doloribus voluptatibus voluptatem quisquam deserunt dolore est. A enim eos quo quod et eos quis et tempora.\n\nSit esse minus expedita animi adipisci explicabo expedita vel. Dolores expedita nihil aut voluptas et ipsum repellat facilis. Maiores esse est praesentium atque molestiae.\n\nNon omnis voluptas eaque aliquam at distinctio velit quas et. Alias voluptas sequi et eos animi voluptatem modi temporibus ut. Sapiente sed ullam dolorem ipsam. Reprehenderit labore id est.\n\nAdipisci odio impedit sed. Amet aut eaque facilis. Nesciunt porro et. Dolorum modi voluptate et. Minima id quod molestias sit. Laudantium placeat quidem saepe vero ullam et magnam eius sed.\n\nLibero facilis necessitatibus. Aut quia voluptatum. Iste nihil ut voluptatibus non nulla qui. Eveniet rem et neque reprehenderit rerum provident qui sed.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Consectetur molestiae quo. Perferendis recusandae quaerat cum est repellat suscipit pariatur vero quo. Quas molestiae iusto dolor delectus nesciunt provident.\n\nNulla occaecati quo vitae nisi qui nihil at. Tempora natus quo ut sunt eius ad. Occaecati consequatur accusantium repudiandae sint quisquam suscipit consequatur id ut.\n\nIn eos molestias accusantium debitis et consequuntur rerum eius. Quia non eum distinctio earum eos ducimus labore adipisci. Et at omnis ducimus quo possimus ipsum ab facilis reprehenderit. Maxime id quasi saepe voluptatum quaerat omnis veniam voluptates ducimus.\n\nEveniet reprehenderit vero. Necessitatibus sint consequatur eius sit omnis et exercitationem autem. Commodi porro cupiditate temporibus. Consequatur aperiam nesciunt cupiditate porro labore.\n\nPossimus nostrum tempore voluptas eligendi. Repellat cum in. Enim consequatur ullam.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Quidem alias voluptas molestiae accusantium hic quam aut ad similique. Molestias nam nisi eligendi molestiae expedita corrupti dolorem repellat. Dignissimos mollitia tenetur repellendus sit mollitia deserunt fuga.\n\nUnde animi tempora sit. Accusantium officia nihil sequi officiis accusamus deserunt repudiandae odio aut. A aut fuga excepturi rem nihil pariatur quas. Et iusto porro voluptatem maxime incidunt molestiae voluptas eos. Dolore explicabo enim omnis ad.\n\nNam labore cumque ad consectetur ipsam nobis dolorem temporibus tenetur. Dolor et nam iure deserunt nesciunt maxime error nam repellat. Consequatur et ut eveniet et at omnis accusantium qui. Nihil occaecati atque aut.\n\nRerum quibusdam beatae hic saepe. Necessitatibus id totam iusto aut itaque. Voluptatem suscipit qui sunt.\n\nQuia expedita dignissimos quia corrupti velit labore. Perferendis est minima et molestiae. Aut sed quo quia atque fugit totam ut quasi autem. Ut neque harum maiores nesciunt natus esse eum.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16349534740751605L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16506185663914687L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16483171167891557L));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValues_ProductAttributes_ProductAttributeId",
                table: "ProductAttributeValues",
                column: "ProductAttributeId",
                principalTable: "ProductAttributes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBalances_Products_ProductId",
                table: "ProductBalances",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoice_AspNetUsers_UserId",
                table: "PurchaseInvoice",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_Products_ProductId",
                table: "PurchaseInvoiceItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceId",
                table: "PurchaseInvoiceItem",
                column: "PurchaseInvoiceId",
                principalTable: "PurchaseInvoice",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesReceiptsWithProducts_Products_ProductId",
                table: "SalesReceiptsWithProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesReceiptsWithProducts_SalesReceipts_SalesReceiptId",
                table: "SalesReceiptsWithProducts",
                column: "SalesReceiptId",
                principalTable: "SalesReceipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
