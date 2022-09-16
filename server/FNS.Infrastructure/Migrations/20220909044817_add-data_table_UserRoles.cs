using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class adddata_table_UserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoiceItem",
                table: "PurchaseInvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoice",
                table: "PurchaseInvoice");

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "9ea15db5-1566-412e-a381-e09ec51ea16e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "5694a770-ecd9-437b-b119-fd72b56b6921");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "653bc204-3294-467f-ad56-d740890bff6c", "AQAAAAEAACcQAAAAEITdFMOxlYvS1o4wl14MQSeoVyGklUWhOoVqsVjsgDJuH560Mjl1IjMv45BmdUhhpA==", "74596072-d9e0-4e06-934c-5e60a5b0ce68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0236d309-b176-4e11-8c42-b65a85a4c6ef", "AQAAAAEAACcQAAAAEBQI4KA7IuQ/2LZ8RNX/s2JkWh4fcjcXBvAeXORBTR21Xn+o80HLIb6zkzJOiUzhww==", "1fd08640-e864-41ed-adf3-4bf2597cf6db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d5ffa8-9710-480f-aa48-d21e83298f80", "AQAAAAEAACcQAAAAEIdZJWMxRLZy+6u5tzUONrL/2NQfwD6IYMSeA55pBEIlrhDVTmLSedk5OZA3xG4v4A==", "07af4168-432e-4753-a6af-33f487b714ef" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Sint aut et vel. Neque harum ratione quas amet quis eos ullam repellendus ab. Laboriosam et blanditiis.\n\nDucimus consequatur laboriosam molestias et consequatur suscipit. Nihil aut rem et vel eos. Eos aut mollitia ducimus.\n\nUt doloremque eligendi suscipit optio quae neque in ut. Provident velit quos aut quod voluptatum voluptatibus. Nulla blanditiis praesentium. Illum modi velit rerum repellendus optio et.\n\nEx rem quo ut et enim dicta sed. Praesentium provident saepe. Officia autem omnis. Aspernatur illum ut. Voluptatem iste sed molestiae aut autem consequuntur sed est. Ut beatae maiores odio consequuntur natus soluta.\n\nEarum assumenda neque autem voluptatum. Cumque et sit dignissimos optio. Maiores quia molestiae perferendis rerum et molestiae voluptatem. Dolores veritatis recusandae vero adipisci dignissimos eum quia et. Minus beatae accusantium eos mollitia ut ut.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Maiores cupiditate consequatur tenetur ipsum facilis qui. Libero aut velit ipsa nemo necessitatibus harum earum corporis autem. Et ab quo aut fugiat quia quisquam ipsam. Iste qui magnam reiciendis saepe.\n\nUt sint alias quisquam dolor voluptatem exercitationem. Ipsa molestiae voluptatem a odit sapiente. Doloremque commodi porro dolorem expedita. Tenetur sint et voluptatem nulla fugiat sit aut. Incidunt vel officiis qui omnis eligendi rerum totam.\n\nIllum earum dolores animi error qui nostrum. Laborum est autem nisi est. Nisi hic quis molestiae laborum et numquam vero. Numquam impedit veritatis ut qui nostrum voluptatem. Aut odio delectus repellat excepturi.\n\nNihil blanditiis pariatur ex. Necessitatibus optio a et ratione voluptas et. Iure soluta dolores.\n\nIn eos qui harum at vel soluta. Dolores nihil sed inventore qui magnam dolor delectus ut. Vero eius numquam reprehenderit laborum facere quos. Similique quidem omnis.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Occaecati consequatur est quidem consequatur reprehenderit voluptatem. Eos laudantium aut doloribus. Cumque est fugit illum non aut similique dolorem aut. Praesentium eaque ducimus vel qui.\n\nEt vel fugiat et dolores architecto. Nihil labore doloribus neque itaque. Ab expedita harum corporis eveniet neque labore.\n\nRecusandae eius nemo soluta et alias et. Repellendus fugit accusamus voluptates doloremque quo labore dolor eos. Ex voluptatem alias quia impedit ipsa. Fugit ut modi molestiae sed ea nostrum. Consequuntur cumque a maxime veniam ea adipisci quod. Nihil atque saepe consequatur.\n\nQui necessitatibus pariatur amet est mollitia reiciendis nihil aspernatur ipsa. Quis dolorem dolores mollitia voluptatem dolores. Occaecati ab eius laborum earum aut odio. Sit eaque quia odio sit fugit. Quaerat occaecati nisi cumque voluptas debitis at expedita.\n\nEnim nam porro ipsum repellendus consequatur natus eligendi. Rerum hic cupiditate autem quae. Quis earum ab magni.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Sunt nemo fugiat quos eligendi doloremque odit non ut dignissimos. Illo beatae aut. Amet aut eveniet distinctio.\n\nEt aut culpa sit. Incidunt beatae in numquam eos doloremque. Et dolor quis iste nam commodi.\n\nIpsam voluptates et commodi. Numquam quo delectus aut voluptatem. Aut sint voluptates et quo ut. Pariatur perferendis sed vel ut.\n\nEt sint exercitationem beatae. Architecto nesciunt autem quaerat quia. Architecto eum voluptatibus quos vel odit sequi.\n\nEa at placeat tempora eveniet. Labore ipsam dignissimos ea dignissimos eligendi sint. Consequatur excepturi sit non provident corporis sit alias nam. Mollitia consectetur dolores. Numquam incidunt ipsam eius quo et qui quod a aliquid.");

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
                name: "FK_PurchaseInvoiceItems_Products_ProductId",
                table: "PurchaseInvoiceItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceItems_PurchaseInvoices_PurchaseInvoiceId",
                table: "PurchaseInvoiceItems",
                column: "PurchaseInvoiceId",
                principalTable: "PurchaseInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoices_AspNetUsers_UserId",
                table: "PurchaseInvoices",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" });

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItems_Products_ProductId",
                table: "PurchaseInvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceItems_PurchaseInvoices_PurchaseInvoiceId",
                table: "PurchaseInvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoices_AspNetUsers_UserId",
                table: "PurchaseInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoices",
                table: "PurchaseInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseInvoiceItems",
                table: "PurchaseInvoiceItems");

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "492068b0-6e09-4f5c-be6b-9765f7c8a669");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "eef0e6cb-dbfd-4c55-9fe5-bea2d5a81496");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d42216e-8355-4dae-819e-54686b2c4687", "AQAAAAEAACcQAAAAEBr3B5LKeV80tzL2e01DoeUQ/OLGSD6wAmDoQrWnVo4r3SrF+F+U63mhnHMK0uF08Q==", "7461a0b1-8f51-4481-a91e-25dfb20d4495" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eec0470d-a613-4dc5-8da7-10c9f6bc8751", "AQAAAAEAACcQAAAAELZGeomfgpGsi1se4SycfewlZhMWJLz/h8CD8RatlzNpepuSy5t65b2hYkUTaFW48w==", "97108238-7021-475c-969c-70c2e5758279" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac37403-0c22-4974-b62f-8e0f9bb3ac6a", "AQAAAAEAACcQAAAAEOd5KzJklxsR5VOvwHAfjIevqhFp+XdXbHjDqsL7IsHguTA2YUFyphFDEHHpnPEmSA==", "8a1ea8c3-f9d4-41df-915d-01b8cd3ee359" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "Description",
                value: "Odio sed alias ea saepe neque. Qui quam ratione veritatis error ratione vel blanditiis. Tempore voluptatibus saepe hic inventore praesentium et. Velit voluptatem harum accusamus sit nihil omnis qui. Dignissimos minima et sed totam eveniet et similique blanditiis. Et ut excepturi et nam laudantium dignissimos.\n\nIllum doloremque nemo dolores ipsa dolor explicabo. Eveniet non voluptas eum nihil dolorum dolores soluta. Eum officia veniam ipsam.\n\nRecusandae laborum odit similique saepe. Et voluptatem incidunt. Occaecati voluptatem et non assumenda optio eos odio. Qui voluptate dolorum et quam non qui recusandae.\n\nOfficia nemo eaque. Est sit natus libero ex saepe cumque beatae velit. Consequatur voluptatibus itaque enim. Voluptatem repudiandae est.\n\nRepellat debitis a vitae labore magnam est accusamus et. Et voluptatem consequatur vel nostrum. Cumque dolorum dicta ea dolor.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "Description",
                value: "Doloribus et laudantium. At voluptas necessitatibus corrupti rem incidunt ut provident. Placeat aliquam explicabo sapiente accusantium eum accusantium facilis. Voluptas numquam aliquid deleniti cumque adipisci iusto et.\n\nIllo et vel. Quod laudantium eius nesciunt nisi. Maxime incidunt quia facere nulla dolor rerum. Aut ratione ad rem praesentium et. Sed placeat ut recusandae vel officia est eum aut minus.\n\nNon earum iusto quia dolore. Veniam qui ut nesciunt molestiae est exercitationem natus. Natus tenetur officiis minus ullam.\n\nMaxime qui omnis aperiam nostrum at quibusdam. Quam non quia atque suscipit mollitia similique. Minima adipisci sequi rerum. Cum qui voluptatem incidunt accusamus repellendus aliquam et id nam. Repellat minus et. Recusandae ut ab qui nemo est quisquam.\n\nVero totam nihil. Amet nemo molestiae nisi quia qui sit est doloremque. Est modi suscipit perspiciatis aut. Officiis corrupti qui aut placeat dignissimos laudantium qui sequi nemo.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "Description",
                value: "Necessitatibus qui similique ab. Est quod quas quia magni. Et et est repellendus. Eum eum veniam eos. At omnis est dignissimos.\n\nCorporis et molestiae beatae. Sit quisquam sint molestiae. Eos ut ea ut necessitatibus. Id sunt voluptatem deleniti blanditiis.\n\nDicta illum eius sint. Nam omnis sunt. Aut sequi ipsam quam illo similique unde expedita.\n\nPossimus laboriosam sint non veniam odio dolorem nisi. Tenetur consequuntur inventore distinctio. Facilis eum quibusdam eveniet consequatur non similique ut incidunt dolores.\n\nAut distinctio sed voluptatem et. Alias cupiditate in est soluta eum aut officia et magnam. Impedit earum sit ut quas asperiores quo.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "Description",
                value: "Neque non vitae dolorum velit quos perspiciatis tempore et voluptates. Consectetur velit ratione consequatur repudiandae voluptatum. Eos aut aspernatur sunt. Aut atque minima eius rerum.\n\nSimilique fugit aut architecto omnis debitis quae. Eveniet et mollitia laboriosam ab repellat odit nihil quod. Culpa in quasi blanditiis voluptas explicabo eum quae sit. Nostrum praesentium unde nemo facere nihil dolores dolor.\n\nSapiente sint est maiores vel quas. Rem nulla consequatur ea doloribus delectus vel voluptatem sit cumque. Minima architecto aspernatur excepturi eos est quia.\n\nNam et architecto qui nulla eligendi sapiente voluptatem aliquid sit. Tenetur ratione nihil repellat modi et quas eligendi et vero. Sed est enim nihil. Cumque quas natus corporis qui architecto dolorem quibusdam sit provident.\n\nNesciunt ut architecto illum accusantium non officiis ut est eos. Molestiae reiciendis debitis architecto deleniti voluptatum quia praesentium perferendis. Exercitationem quos ab.");

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16559247002192406L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16521251684134143L));

            migrationBuilder.UpdateData(
                table: "SalesReceipts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "CreatedAt",
                value: NodaTime.Instant.FromUnixTimeTicks(16469006891573696L));

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
        }
    }
}
