using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class updatexminforalltables : Migration
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
                name: "FK_SalesReceipts_AspNetUsers_UserId",
                table: "SalesReceipts");

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
                values: new object[] { "51fca09c-daab-493f-b056-21f4cc338c36", "bb4aac08-f613-45ee-a404-6749b0b7f168" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dbc426ec-4ee7-48d6-b429-620f9d9090e2", "4536bee9-a919-42a6-81ac-348cc468102a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9b08773-c398-4803-9e92-cfe0d3d593af", "109493d6-3ded-4a39-8777-5205d4270675" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Veritatis modi facere porro accusamus laboriosam ullam. Praesentium quas reprehenderit in asperiores ipsa perferendis fugit quisquam. Modi autem quas illum. Sunt officiis tempore aliquam non aliquid. Placeat sunt illo eos repudiandae sed.\n\nQuis error quis. Placeat rerum exercitationem. Exercitationem dolor pariatur dolores placeat exercitationem ea. Voluptates nihil et deserunt est omnis eius deserunt sint aliquid. Accusantium architecto dolores expedita. Non minima tenetur fuga.\n\nLaudantium et et laudantium. Asperiores inventore ab soluta repellat repudiandae voluptatem aut. Rerum odit explicabo non iste autem.\n\nEnim sit culpa et facilis. Qui similique iure et animi. Quisquam ipsam corporis tempore quis. Est voluptate consequatur quod aut architecto minus.\n\nAliquam veniam repellendus numquam. Voluptatem ea dolorem quia voluptatum mollitia nulla qui perspiciatis. Quo cumque culpa perferendis vel architecto dolorem. Nulla quasi dolorum quibusdam.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Officiis nulla expedita reiciendis quia quos aut delectus. Et accusantium fugit voluptas dolor ab autem in. Fugiat et voluptatibus eum impedit officiis illo nihil.\n\nExpedita ipsa nostrum ex totam expedita quos perferendis magnam aut. Qui itaque et sed tempora praesentium quia illum ex illo. Id omnis non non perferendis vel porro aut assumenda quos. Quo excepturi rerum officia fugiat quo ea.\n\nNostrum nihil occaecati. Rem recusandae eos eos et. Impedit harum repellat et natus culpa aut consequatur aut aliquam. Ut harum voluptatibus et sed labore deleniti. Quia quia aut voluptates voluptas aperiam.\n\nNam quos et vel voluptatibus totam. Et voluptatem autem id. Ut rerum facere. Et sed ut impedit et beatae modi molestiae quia. Velit quas molestias sed dolor quia accusantium.\n\nNam consequuntur praesentium ullam. Natus corporis quisquam. Libero maxime voluptate illo porro quam labore inventore enim. Eum consequuntur quidem molestias sint nobis minus. Eius accusamus facilis eius molestiae.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Fuga ab id explicabo veniam. Doloribus maiores ut optio. Tempore ea nam quibusdam aut. Voluptatibus deleniti laudantium cupiditate labore.\n\nInventore dolor id. Harum in minus velit reiciendis culpa numquam. Iure distinctio reprehenderit inventore. Eligendi velit optio enim voluptatum tempora quia.\n\nEt accusamus veniam distinctio consequatur. Distinctio nam nesciunt perferendis incidunt. Et dolores earum qui iusto velit voluptate. Nesciunt odio corrupti quas vel sit.\n\nDoloremque velit ab esse cumque aut et. Eum veritatis qui quo mollitia. Ea voluptatem asperiores et qui maxime et aut in dolorem. Neque ex dicta harum nisi et rerum.\n\nQuas voluptas adipisci neque harum. Quis non dicta veritatis ea quasi facere distinctio. Beatae ipsa est ut et nemo veniam. Temporibus quo doloremque et maiores ut. Consequatur omnis fugit. Ex eos molestias libero ducimus minus nihil.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Non dicta iste qui corrupti quia. Atque ea temporibus tempora excepturi facere quam aut eum. Tempora recusandae quam voluptatem beatae sed. Minus itaque enim qui fuga vel.\n\nAut fugiat facilis cum similique aliquam. Rerum tempora et aut minus corrupti quo accusantium inventore molestiae. Sed et voluptatem eveniet minima. Est dolores velit sunt sint sunt ut laborum.\n\nTempore rem aut esse delectus voluptatem et itaque et. Omnis voluptatem rerum aut eaque omnis. Soluta expedita ex autem consequatur eos.\n\nEveniet rerum id quis maxime. Sed ab corrupti voluptate veritatis saepe ipsum dignissimos ut fugiat. Pariatur et recusandae exercitationem fuga at voluptatem quia atque accusamus.\n\nPraesentium eum corrupti. Natus modi voluptatem doloribus reiciendis. Enim doloribus sit sit quas est magnam modi.");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAttributeValues_Products_ProductId",
                table: "ProductAttributeValues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBalances_Products_ProductId",
                table: "ProductBalances",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoice_AspNetUsers_UserId",
                table: "PurchaseInvoice",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_Products_ProductId",
                table: "PurchaseInvoiceItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItem_PurchaseInvoice_PurchaseInvoiceId",
                table: "PurchaseInvoiceItem",
                column: "PurchaseInvoiceId",
                principalTable: "PurchaseInvoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesReceipts_AspNetUsers_UserId",
                table: "SalesReceipts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesReceiptsWithProducts_Products_ProductId",
                table: "SalesReceiptsWithProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesReceiptsWithProducts_SalesReceipts_SalesReceiptId",
                table: "SalesReceiptsWithProducts",
                column: "SalesReceiptId",
                principalTable: "SalesReceipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_SalesReceipts_AspNetUsers_UserId",
                table: "SalesReceipts");

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

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16307901439445135L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16434331166209636L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16404357750467261L));

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
                name: "FK_SalesReceipts_AspNetUsers_UserId",
                table: "SalesReceipts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

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
    }
}
