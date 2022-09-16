using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class updatelast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItems_Products_ProductId",
                table: "PurchaseInvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItems_PurchaseInvoices_PurchaseInvoiceId",
                table: "PurchaseInvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoices_AspNetUsers_UserId",
                table: "PurchaseInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesReceiptsWithProducts_Products_ProductId",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesReceiptsWithProducts_SalesReceipts_SalesReceiptId",
                table: "SalesReceiptsWithProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoices",
                table: "PurchaseInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoiceItems",
                table: "PurchaseInvoiceItems");

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

            migrationBuilder.RenameTable(
                name: "PurchaseInvoices",
                newName: "PurchaseInvoice");

            migrationBuilder.RenameTable(
                name: "PurchaseInvoiceItems",
                newName: "PurchaseInvoiceItem");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoices_UserId",
                table: "PurchaseInvoice",
                newName: "IX_PurchaseInvoice_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoiceItems_PurchaseInvoiceId",
                table: "PurchaseInvoiceItem",
                newName: "IX_PurchaseInvoiceItem_PurchaseInvoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoiceItems_ProductId",
                table: "PurchaseInvoiceItem",
                newName: "IX_PurchaseInvoiceItem_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoice",
                table: "PurchaseInvoice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoiceItem",
                table: "PurchaseInvoiceItem",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "PurchaseInvoice",
                columns: new[] { "Id", "UserId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" });

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
                table: "PurchaseInvoiceItem",
                columns: new[] { "Id", "Amount", "ProductId", "PurchaseInvoiceId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 2, "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", 3, "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", 7, "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000004", 5, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001" }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoiceItem",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoice",
                table: "PurchaseInvoice");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItem",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItem",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItem",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItem",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoice",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.RenameTable(
                name: "PurchaseInvoiceItem",
                newName: "PurchaseInvoiceItems");

            migrationBuilder.RenameTable(
                name: "PurchaseInvoice",
                newName: "PurchaseInvoices");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoiceItem_PurchaseInvoiceId",
                table: "PurchaseInvoiceItems",
                newName: "IX_PurchaseInvoiceItems_PurchaseInvoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoiceItem_ProductId",
                table: "PurchaseInvoiceItems",
                newName: "IX_PurchaseInvoiceItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseInvoice_UserId",
                table: "PurchaseInvoices",
                newName: "IX_PurchaseInvoices_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoiceItems",
                table: "PurchaseInvoiceItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseInvoices",
                table: "PurchaseInvoices",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16555359798529035L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16539736006708536L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16616559348166370L));

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItems_Products_ProductId",
                table: "PurchaseInvoiceItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItems_PurchaseInvoices_PurchaseInvoiceId",
                table: "PurchaseInvoiceItems",
                column: "PurchaseInvoiceId",
                principalTable: "PurchaseInvoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoices_AspNetUsers_UserId",
                table: "PurchaseInvoices",
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
        }
    }
}
