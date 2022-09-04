using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class addtables_PurchaseInvoices_PurchaseInvoiceItems : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_SalesReceipts_UserId",
                table: "SalesReceipts");

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

            migrationBuilder.CreateTable(
                name: "PurchaseInvoices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoices_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PurchaseInvoiceId = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceItems_PurchaseInvoices_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseInvoices",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80afe008-0217-4b68-8d90-299c37e184a9", "878ecf47-9863-48f6-92d6-6808b60b37b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c232515-2123-4c6b-8500-ad9b35a7217a", "633ed3c3-715b-4486-a48c-8b13a48f03ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8717bda9-031b-4355-bb31-961db77e2e84", "ed0bd226-2590-4f59-9979-df73e5b1ce07" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Magni maxime magnam non vel est quod. Eum vero similique voluptas fuga est minima omnis quis. Facere consectetur nostrum. Sapiente fugiat quia et.\n\nNobis neque voluptatum porro unde blanditiis provident. Provident qui earum deleniti molestias quibusdam perferendis exercitationem. Explicabo expedita at suscipit molestiae. Porro dolor exercitationem. Illum rem et modi et perferendis consequuntur et quia. Omnis dolore quasi repellat.\n\nUt et qui. Autem nihil placeat nulla rerum. Nam itaque odit quis eos quibusdam voluptas reprehenderit est. Accusamus sit accusamus error quam ipsa. Doloremque autem et.\n\nSunt velit quasi qui et necessitatibus sequi saepe magni. Aut commodi dicta ea. Molestiae animi ea molestias delectus ipsum ea eaque eius. Soluta at ut molestiae enim.\n\nVoluptatem aut enim id atque. Esse iste alias dignissimos quis exercitationem sit sapiente aut amet. Quia ut non.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Natus assumenda harum excepturi quia iure quia eligendi. Aliquid beatae perferendis iure minus eveniet. Autem voluptates tempore et voluptates accusamus ut. Nemo sit quia nihil quo recusandae aliquid sit neque laudantium. Et qui corporis et rerum sit ullam.\n\nAutem sed accusamus omnis praesentium odit cumque consequatur corrupti. Libero voluptatem quia placeat sit hic pariatur quas sed. Quia quasi aut nostrum eligendi reprehenderit. Quam rerum quo rerum. Ex consequatur adipisci consequatur maiores commodi.\n\nAt ut perspiciatis omnis velit ad ipsam non. Ut rerum officia quaerat quasi. Qui distinctio laborum consequuntur. Ipsa ut quos est fugit.\n\nSapiente autem magnam qui officiis. Amet hic praesentium dolores ut quia pariatur sunt dolorem ipsum. Nisi deleniti nihil quod similique sed quibusdam aliquam iure.\n\nEum culpa nulla similique sunt sint est vel est blanditiis. Sit sapiente voluptate possimus aut fugiat est est iste et. Officia optio nisi aut impedit est ut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Dolores in modi modi officiis dolores. Iure non dolores. Similique ea at illo nesciunt aut. Sed est est et et velit neque quaerat dolores.\n\nExpedita magni iure. Ullam voluptas facilis id magnam ut earum voluptate aliquid. Qui optio nostrum. Illo nesciunt magni. Sequi aut deserunt vel natus doloribus aut distinctio.\n\nMinus et ut nulla velit omnis. Voluptas sed ut repellat sed et tempore. Similique dolorem eos. Numquam aut itaque qui officia odio atque consequatur error. Repellat delectus laudantium exercitationem.\n\nBeatae officiis numquam doloremque voluptatum cum. Qui facilis quas dolore consequatur pariatur facere earum labore incidunt. Et voluptates et labore praesentium.\n\nAut suscipit quisquam corrupti labore voluptatem. Officia in sint. Aspernatur qui dolores accusantium rerum quo dolorum molestiae.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Dolorum asperiores eum tempora cum totam. Saepe voluptas quidem eos velit nulla sed. Nihil similique voluptatem architecto rerum deleniti molestiae.\n\nSunt facere blanditiis. Amet fugiat iste alias vitae rerum impedit veritatis. Rem sequi qui consequatur sunt ut. At corrupti quos ex enim voluptatibus et rem sed.\n\nError maxime provident ipsa doloribus quo rerum. Sunt a odit voluptatum at labore eos sint. Totam qui sit.\n\nVoluptas harum accusamus nesciunt vel et. Non itaque harum rem hic autem laborum molestiae earum nam. Quia saepe corrupti iure minima impedit praesentium. Et in assumenda.\n\nQui sit aperiam omnis nihil aliquam eum. Sunt architecto molestiae. Et laudantium non eveniet. Sed aut voluptate nihil libero veniam. Accusamus quam saepe quas nisi possimus quaerat.");

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceipts_UserId",
                table: "SalesReceipts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceItems_ProductId",
                table: "PurchaseInvoiceItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceItems_PurchaseInvoiceId",
                table: "PurchaseInvoiceItems",
                column: "PurchaseInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoices_UserId",
                table: "PurchaseInvoices",
                column: "UserId");

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

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceItems");

            migrationBuilder.DropTable(
                name: "PurchaseInvoices");

            migrationBuilder.DropIndex(
                name: "IX_SalesReceipts_UserId",
                table: "SalesReceipts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16205507-915f-4dd2-936e-a588f2b00582", "26e6cbc3-dd5e-4a06-8c56-b8a21dedc1e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ea1d679-1eb2-42ca-aeef-62d6f2ca1052", "7ff06153-dd12-4448-802b-b2500b2a2267" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c3fc76a-7d12-4525-a914-ea2c61789e19", "0c4ab19e-ad92-42d8-b46c-fbfa54024dc9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Sit sed tenetur nam et. Facilis corporis aut. Inventore omnis quas nostrum.\n\nNam qui iusto repellat. Error tempore eligendi rem eligendi rerum quae. Neque ipsum vitae quia.\n\nEst nihil voluptate consequatur in a pariatur earum numquam cum. Est excepturi facilis cupiditate ipsum est suscipit rem consequuntur. Velit iusto nesciunt possimus est expedita optio enim quidem. A molestiae quibusdam omnis deleniti.\n\nQuod recusandae quia nostrum. Rerum modi possimus similique facere occaecati facere quos. Non est numquam.\n\nNemo molestias quis iusto commodi. Fugit quia non odio blanditiis. Impedit at cumque occaecati eaque veritatis dolore.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Tenetur qui laudantium nulla quia vel qui. Soluta ex et nam deserunt esse et. Quas illum et laboriosam dignissimos alias quo alias. Eius minus et.\n\nLabore molestias qui autem. Nisi culpa voluptas amet eos consequatur. Quia omnis consequuntur voluptas aut qui aliquam repellendus vel.\n\nAtque quas adipisci nobis et ratione vel. Voluptatibus ipsum quas consequatur minus pariatur maiores. Laboriosam voluptatem id quaerat saepe quia dolores quidem cupiditate voluptates. Quia perferendis expedita aut.\n\nNeque fugit sequi natus occaecati iusto consequatur quas sunt a. Inventore ducimus odio velit eligendi et quia. Rerum molestiae quasi autem impedit eligendi sed est. Voluptatem dicta omnis praesentium sunt voluptas pariatur sunt ipsam.\n\nDoloribus quia dolor consectetur vitae qui. Illo nostrum corrupti harum et. Occaecati dolores in labore ea in ad. Vel non distinctio reiciendis nam accusantium suscipit repellat corporis.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Et placeat iusto iste dolorem inventore ut amet ex consectetur. Et esse aspernatur et. Repudiandae et id nisi est id ipsa.\n\nVoluptas deserunt sint vero odit soluta repellat magnam aspernatur distinctio. Consequatur facilis sunt dolores. Quam harum vero earum alias et voluptatum ullam est culpa. Facere nemo odit id. Dicta sequi soluta. Quia eligendi aut.\n\nSed adipisci rem. Velit est ratione. Inventore quis aliquid alias impedit quo numquam occaecati. Voluptatum corrupti ducimus. Laudantium cumque quaerat nihil quos.\n\nDeserunt et repellendus magni ut nihil sit. Deleniti sequi et. Eum suscipit culpa nisi quasi ut omnis nihil ad et. Qui et aliquam iste.\n\nPerspiciatis corrupti consectetur sed beatae. Nihil ipsa ea rem occaecati. Optio porro quibusdam autem deleniti voluptatem repellat consequatur ducimus atque. Animi error ipsum ut incidunt omnis aliquam nam aut. Magnam repellat hic quia voluptatem quisquam cumque. Soluta odio et quae reprehenderit molestiae aut sint dolorem.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Culpa vel facilis tempore aliquam. Deleniti ut nemo assumenda. Qui quia est laudantium.\n\nDucimus quis alias qui. Quo et sed ut quae dicta animi. Autem et vitae. Reprehenderit totam itaque quaerat dolorum. Saepe qui minus cum maxime quibusdam. Quod aliquid a eum.\n\nCommodi aut praesentium ut assumenda dolorem dolorem animi aut sit. Aut rerum minus ducimus ducimus quia non. Totam libero illum autem repellendus. Est quae fugit expedita quia reprehenderit corporis nulla quia. Dolor cupiditate ut sapiente nulla. Corrupti excepturi voluptatibus delectus dolores quis nisi modi perferendis dolore.\n\nSequi et voluptas est. Nihil consequuntur unde. Molestiae ut eum culpa nostrum. Deleniti eum soluta. Aut nihil iusto labore exercitationem ratione laborum.\n\nDistinctio sequi numquam ut. Possimus tenetur repellendus. Beatae odit debitis cum dolorum possimus est minus. Omnis nam dicta itaque ipsum ipsa. Sequi aspernatur dolorem sequi et.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16595954883150815L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16591011682059852L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16540390525823718L));

            migrationBuilder.CreateIndex(
                name: "IX_SalesReceipts_UserId",
                table: "SalesReceipts",
                column: "UserId",
                unique: true);

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
                name: "FK_SalesReceipts_AspNetUsers_UserId",
                table: "SalesReceipts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
