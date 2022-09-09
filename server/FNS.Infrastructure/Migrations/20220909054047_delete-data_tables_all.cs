using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace FNS.Infrastructure.Migrations
{
    public partial class deletedata_tables_all : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019");

            migrationBuilder.DeleteData(
                table: "ProductAttributeValues",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ProductBalances",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoiceItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "SalesReceiptsWithProducts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ShoppingCartItems",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "ProductAttributes",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004");

            migrationBuilder.DeleteData(
                table: "PurchaseInvoices",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

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

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003");

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "c044cd1a-593b-4b10-8e8d-6631bd868c92", "admin", null },
                    { "00000000-0000-0000-0000-000000000002", "6941e7b1-e3d7-45e4-a46b-b627bd5c8f32", "user", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 0, "424edae9-6a48-47fb-bd07-9e756c55db24", NodaTime.Instant.FromUnixTimeTicks(16626570600000000L), "user1@gmail.ru", false, false, null, "USER1@GMAIL.RU", "USER1", "AQAAAAEAACcQAAAAELY0L5+fzu1pf3uRJbMahhbsgAo5qBec33By6XhoPPe9kMxNzSs8GPx1K+0d2gqJ1w==", null, false, "3b03d4db-d12a-43a5-bdfb-bc3be87acfc9", false, "user1" },
                    { "00000000-0000-0000-0000-000000000002", 0, "e1262287-42e7-4292-9376-28ce2322e239", NodaTime.Instant.FromUnixTimeTicks(16626570600000000L), "user2@gmail.ru", false, false, null, "USER2@GMAIL.RU", "USER2", "AQAAAAEAACcQAAAAEJtcf7ypPRKuQENV6YbitvCkVXZQYhJPa2gTg/No7H1xtew+Q7N6j1gns7YP/sY/mA==", null, false, "468a7981-738e-4f2f-af40-8deed788bb22", false, "user2" },
                    { "00000000-0000-0000-0000-000000000003", 0, "ca8ff5ed-213f-4e64-ba6d-48639bfdb7ea", NodaTime.Instant.FromUnixTimeTicks(16626570600000000L), "admin@yandex.ru", false, false, null, "ADMIN@YANDEX.RU", "ADMIN", "AQAAAAEAACcQAAAAEDWY5hnBHyUlTSKPTmen2y/Iex4yf0ckqE5FeP6zB824YJOX+BSCh7bxvCXsDMmpPw==", null, false, "1dddd9b8-3146-4175-acfd-c91211ac5ae2", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "Id", "ClrType", "Measure", "Name" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "String", null, "Model" },
                    { "00000000-0000-0000-0000-000000000002", "String", null, "Socket" },
                    { "00000000-0000-0000-0000-000000000003", "Int32", null, "Release year" },
                    { "00000000-0000-0000-0000-000000000004", "Int32", null, "Total number of cores" },
                    { "00000000-0000-0000-0000-000000000005", "String", null, "Maximum threads" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "Процессоры" },
                    { "00000000-0000-0000-0000-000000000002", "Материские платы" },
                    { "00000000-0000-0000-0000-000000000003", "Видеокарты" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProductCode", "SubCategoryId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "Pariatur culpa ut. Excepturi non rerum laborum mollitia ut et. Voluptas quibusdam ut vitae perferendis architecto rem. Expedita quasi occaecati. Sit doloribus praesentium consequatur explicabo quam esse asperiores hic sint. Ut consequatur assumenda atque repudiandae.\n\nMinus enim in magni earum voluptatem possimus magni accusantium aspernatur. Tenetur facere commodi labore. Vel et magni minus recusandae perferendis commodi.\n\nLaborum aut qui quod. Sunt culpa qui eaque pariatur non in. Et pariatur pariatur voluptatibus.\n\nLabore animi expedita illum reprehenderit ut. Est id libero natus. Nihil ea repellendus consequatur velit qui omnis dicta illum. Et excepturi velit enim expedita velit quisquam.\n\nArchitecto velit blanditiis omnis et officiis architecto et. Nihil ea impedit quia consequatur est ut. Quod hic tempore. Velit rem voluptate a distinctio excepturi. Quis amet corrupti dolor maxime eum.", "AMD Ryzen 5 3600 OEM", 12599m, "1372637", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "Ut facilis omnis molestiae sint. Et laboriosam consectetur fugit nisi consequuntur facere sed. Nisi ab rerum vel provident dolor laborum sit voluptates.\n\nOmnis et iure quo nisi et. Inventore illum incidunt quidem ut in est. Doloremque magni id dolorem earum quia ut.\n\nQuas magni ut culpa ullam aspernatur ut quia molestiae architecto. At dolor voluptatum minus asperiores fugiat et voluptatibus facere itaque. Corrupti unde quo.\n\nQui quo dignissimos quibusdam id. Voluptatibus sunt voluptatem rerum voluptatem porro culpa. Qui alias velit voluptates est iure iure vitae ex adipisci.\n\nDeleniti neque quo sit qui fugiat minima qui quia. Dolore officia exercitationem sed sit quisquam officia voluptatibus. Placeat voluptate necessitatibus aut ut natus.", "AMD Ryzen 5 3600 BOX", 12899m, "5059834", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", "Accusamus aut provident laudantium et. Quaerat magnam totam sit dolorem dolorem. Cupiditate quas neque natus rerum assumenda maxime.\n\nAlias sit dolorem quis et quia dignissimos quia. Est similique exercitationem veritatis quaerat ipsa nostrum nesciunt quas aut. Aperiam placeat provident non. Totam accusantium suscipit. Facere aliquam amet molestiae perspiciatis.\n\nId ipsa aliquid. Quo fugit amet quas sapiente. Qui sunt qui quae. Et accusantium quae optio eos qui quisquam qui et.\n\nEt cupiditate ut qui amet quas quia. Earum velit reprehenderit ratione eius perferendis. Vero voluptas quo. Quaerat qui inventore qui odio sapiente hic sed sed. Eum consectetur autem similique velit voluptatibus aliquam soluta quasi qui.\n\nReiciendis illum consequatur cupiditate in beatae iure hic qui. Sunt omnis veritatis quia. Quia est dolore sunt soluta sed quod.", "AMD Ryzen 5 PRO 4650G OEM", 12599m, "1689358", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000004", "Doloremque maiores eos doloribus mollitia eveniet iure qui consequatur. Molestias rerum eos et repellat possimus. Est occaecati et ad nesciunt ipsam sint. Ipsa architecto minus a esse dolor quaerat voluptas. Ad distinctio quos quas fugiat pariatur. Libero corrupti nobis esse.\n\nEa quia odit corporis a debitis corporis. Unde a officiis ducimus reiciendis natus quia velit dolores deleniti. Itaque in ut rerum perspiciatis hic beatae.\n\nDeserunt sed qui qui est et iusto. Odit porro officiis temporibus debitis tenetur explicabo harum. Tempora ullam non.\n\nAliquam itaque quisquam eum omnis et. Sed nisi pariatur consequuntur. Tempora dolor pariatur alias. Voluptas omnis qui earum minus. Ut quam magnam rerum voluptatem. Aspernatur harum nulla consequatur molestiae aspernatur asperiores consequatur ipsa.\n\nAccusantium est saepe reiciendis. Est ipsam et necessitatibus atque quia. Quis qui voluptatibus architecto tempore maxime. In at voluptates doloribus autem itaque beatae dignissimos sed.", "AMD Ryzen 5 5600X OEM", 16199m, "4721161", "00000000-0000-0000-0000-000000000001" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseInvoices",
                columns: new[] { "Id", "CreatedAt", "UserId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000003" });

            migrationBuilder.InsertData(
                table: "SalesReceipts",
                columns: new[] { "Id", "CreatedAt", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", NodaTime.Instant.FromUnixTimeTicks(16402685711858923L), "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", NodaTime.Instant.FromUnixTimeTicks(16496306756646427L), "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", NodaTime.Instant.FromUnixTimeTicks(16325864813755007L), "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributeValues",
                columns: new[] { "Id", "ProductAttributeId", "ProductId", "Value" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001", "AMD Ryzen 5 3600 OEM" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001", "AM4" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001", "2019" },
                    { "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001", "6" },
                    { "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000001", "12" },
                    { "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002", "AMD Ryzen 5 3600 BOX" },
                    { "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002", "AM4" },
                    { "00000000-0000-0000-0000-000000000008", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000002", "2019" },
                    { "00000000-0000-0000-0000-000000000009", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002", "6" },
                    { "00000000-0000-0000-0000-000000000010", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000002", "12" },
                    { "00000000-0000-0000-0000-000000000011", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000003", "AMD Ryzen 5 4650G OEM" },
                    { "00000000-0000-0000-0000-000000000012", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000003", "AM4" },
                    { "00000000-0000-0000-0000-000000000013", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000003", "2020" },
                    { "00000000-0000-0000-0000-000000000014", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000003", "6" },
                    { "00000000-0000-0000-0000-000000000015", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000003", "12" },
                    { "00000000-0000-0000-0000-000000000016", "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000004", "AMD Ryzen 5 5600X OEM" },
                    { "00000000-0000-0000-0000-000000000017", "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000004", "AM4" },
                    { "00000000-0000-0000-0000-000000000018", "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000004", "2020" },
                    { "00000000-0000-0000-0000-000000000019", "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000004", "6" },
                    { "00000000-0000-0000-0000-000000000020", "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000004", "12" }
                });

            migrationBuilder.InsertData(
                table: "ProductBalances",
                columns: new[] { "Id", "Amount", "ProductId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 4, "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", 10, "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", 3, "00000000-0000-0000-0000-000000000003" },
                    { "00000000-0000-0000-0000-000000000004", 5, "00000000-0000-0000-0000-000000000004" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseInvoiceItems",
                columns: new[] { "Id", "Amount", "ProductId", "PurchaseInvoiceId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 2, "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000002", 3, "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", 7, "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000004", 5, "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000001" }
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

            migrationBuilder.InsertData(
                table: "ShoppingCartItems",
                columns: new[] { "Id", "Amount", "CreatedAt", "ProductId", "ShoppingCartId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000001", 1, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000002", 2, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", 1, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000004", 1, NodaTime.Instant.FromUnixTimeTicks(0L), "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000001" }
                });
        }
    }
}
